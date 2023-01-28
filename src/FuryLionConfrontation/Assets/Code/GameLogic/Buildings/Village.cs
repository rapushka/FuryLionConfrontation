using System.Collections.Generic;
using UnityEngine;

namespace Confrontation
{
	public class Village : Building
	{
		[field: SerializeField] public List<Cell> CellsInRegion { get; private set; } = new();

		public void AddToRegion(Cell cell)
		{
			CellsInRegion.Add(cell);
			cell.RelatedRegion = this;
		}
	}
}