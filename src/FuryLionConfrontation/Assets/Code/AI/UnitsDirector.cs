using System.Collections.Generic;
using System.Linq;
using Zenject;

namespace Confrontation
{
	public class UnitsDirector
	{
		[Inject] private readonly IField _field;
		[Inject] private readonly Player _player;

		private UnitsSquad[] OurUnits => _field.LocatedUnits.Where(IsOurUnit).AsArray();

		public void DirectUnits()
		{
			if (OurUnits.TryPickRandom(out var randomSquad)
			    && CollectNeighboursFor(randomSquad).TryPickRandom(out var randomVillage))
			{
				randomSquad.MoveTo(randomVillage.RelatedCell);
			}
		}

		private bool IsOurUnit(UnitsSquad unit) => unit is not null && unit.OwnerPlayerId == _player.Id;

		private IEnumerable<Village> CollectNeighboursFor(UnitsSquad randomSquad)
			=> _field.Buildings
			         .OfType<Village>()
			         .Where((v) => IsOnNeighbourRegions(randomSquad, v));

		private bool IsOnNeighbourRegions(UnitsSquad squad, Building village)
			=> IsNeighbours(squad.LocationCell.RelatedRegion, village.RelatedCell.RelatedRegion);

		private bool IsNeighbours(Region currentRegion, Region targetRegion)
			=> _field.Neighboring.IsNeighbours(targetRegion, currentRegion)
			   && targetRegion != currentRegion;

		public class Factory : PlaceholderFactory<Player, UnitsDirector> { }
	}
}