using System;
using System.Collections.Generic;
using System.Linq;
using Zenject;

namespace Confrontation
{
	public class RegionsNeighboringCalculator : IInitializable
	{
		[Inject] private readonly IField _field;

		public void Initialize()
		{
			_field.Neighbouring.Neighbouring = _field.Regions.ToDictionary((r) => r, GroupByNeighbouring);
		}

		private IEnumerable<Region> GroupByNeighbouring(Region region)
		{
			var set = new HashSet<Region>();
			var neighborsForCell = region.CellsInRegion.SelectMany(CollectNeighboursFor);

			set.AddRange(neighborsForCell);
			return set;
		}

		private IEnumerable<Region> CollectNeighboursFor(Cell cell)
			=> CollectNeighbors(cell, cell.Coordinates.Row.IsEven() ? IsDiagonallyNext : IsDiagonallyPrevious);

		private IEnumerable<Region> CollectNeighbors(Cell cell, Func<Coordinates, Coordinates, bool> isTooFar)
		{
			var centerRow = cell.Coordinates.Row;
			var centerColumn = cell.Coordinates.Column;

			for (var row = centerRow - 1; row < centerRow + 1; row++)
			{
				for (var column = centerColumn - 1; column < centerColumn + 1; column++)
				{
					var currentCoordinates = new Coordinates(row, column);

					if (_field.Cells.Sizes.IsInBounds(currentCoordinates)
					    && isTooFar(cell.Coordinates, currentCoordinates) == false)
					{
						yield return cell.RelatedRegion;
					}
				}
			}
		}

		private static bool IsDiagonallyNext(Coordinates center, Coordinates other)
			=> center.Column + 1 == other.Column
			   && center.Row != other.Row;

		private static bool IsDiagonallyPrevious(Coordinates center, Coordinates other)
			=> center.Column - 1 == other.Column
			   && center.Row != other.Row;
	}
}