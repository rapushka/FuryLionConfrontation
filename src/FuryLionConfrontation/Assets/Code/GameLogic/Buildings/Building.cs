using System;
using UnityEngine;
using Zenject;

namespace Confrontation
{
	public abstract class Building : MonoBehaviour, ICoordinated
	{
		[Inject] private readonly IField _field;

		private Coordinates _coordinates;

		public Cell RelatedCell => _field.Cells[Coordinates];

		public Coordinates Coordinates
		{
			get => _coordinates;
			set
			{
				_coordinates = value;
				_field.Buildings.Add(this);
			}
		}

		protected IField Field => _field;

		[Serializable]
		public class Data
		{
			[SerializeField] private Building _prefab;
			[SerializeField] private Coordinates _coordinates;

			[SerializeField] private int _selectionIndex;

			public Building Prefab
			{
				get => _prefab;
				set => _prefab = value;
			}

			public Coordinates Coordinates
			{
				get => _coordinates;
				set => _coordinates = value;
			}
		}

		public class Factory : PlaceholderFactory<Building, Building>
		{
			public T Create<T>(T prefab, Cell cell)
				where T : Building
			{
				var building = base.Create(prefab);
				building.transform.SetParent(cell.transform, worldPositionStays: false);
				building.Coordinates = cell.Coordinates;
				return (T)building;
			}
		}
	}
}