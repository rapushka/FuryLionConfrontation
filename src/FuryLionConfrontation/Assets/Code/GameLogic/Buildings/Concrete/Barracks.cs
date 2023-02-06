using UnityEngine;
using Zenject;

namespace Confrontation
{
	public class Barracks : Building, IActorWithCoolDown
	{
		[Inject] private readonly UnitsSquad.Factory _unitsFactory;

		[field: SerializeField] public float CoolDownDuration { get; private set; } = 10f;

		public float PassedDuration { get; set; }

		private bool HaveSquad => LocatedUnits is not null;

		private UnitsSquad LocatedUnits => Field.LocatedUnits[Coordinates];

		private Vector3 InitialUnitPosition => transform.position + Constants.VerticalOffsetAboveCell;

		public void Action() => CreateUnit();

		private void CreateUnit()
		{
			if (HaveSquad)
			{
				LocatedUnits.QuantityOfUnits++;
			}
			else
			{
				_unitsFactory.Create(InitialUnitPosition, RelatedCell, RelatedCell.RelatedRegion.OwnerPlayerId);
			}
		}
	}
}