using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace Confrontation
{
	public class UnitOrderPerformer : MonoBehaviour
	{
		[Inject] private readonly UnitsSquad.Factory _unitsFactory;
		[Inject] private readonly IAssetsService _assets;
		[Inject] private readonly IField _field;

		[SerializeField] public UnitsSquad _unitsSquad;

		private UnitFighter _unitFighter;
		[CanBeNull] private Cell _targetCell;


		private void Start() => _unitFighter = new UnitFighter(_unitsSquad, _assets, _field);

		public void LocateInTargetCell()
		{
			Locate(_targetCell);
			_targetCell = null;
		}

		private void Locate(Cell cell)
		{
			if (IsAlreadyPlaced(cell) == false)
			{
				_unitFighter.CaptureRegion(cell);
				return;
			}

			if (IsHaveSameOwner(cell))
			{
				MergeWith(cell.LocatedUnits);
				return;
			}

			_unitFighter.FightWithSquadOn(cell);
		}

		public void MoveTo(Cell targetCell, int quantityToMove)
		{
			_field.LocatedUnits.Remove(_unitsSquad);

			if (quantityToMove < _unitsSquad.QuantityOfUnits
			    && quantityToMove > 0)
			{
				FormNewSquad(quantityToMove);
			}

			_targetCell = targetCell;
		}

		private void FormNewSquad(int quantity)
		{
			_unitsFactory.Create(_unitsSquad.LocationCell, _unitsSquad.OwnerPlayerId, quantity);
			_unitsSquad.QuantityOfUnits -= quantity;
		}

		private bool IsAlreadyPlaced(Cell cell) => cell.LocatedUnits == true && cell.LocatedUnits != _unitsSquad;

		private bool IsHaveSameOwner(Cell cell) => cell.OwnerPlayerId == _unitsSquad.OwnerPlayerId;

		private void MergeWith(Garrison units)
		{
			units.QuantityOfUnits += _unitsSquad.QuantityOfUnits;
			_assets.Destroy(_unitsSquad.gameObject);
		}
	}
}