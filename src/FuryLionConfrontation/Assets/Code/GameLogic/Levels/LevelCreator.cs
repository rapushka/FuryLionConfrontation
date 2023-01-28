using System.Collections.Generic;
using UnityEngine;

namespace Confrontation
{
	public class LevelCreator : ILevelSelector
	{
		public LevelCreator() => SelectedLevel = Create();

		public Level SelectedLevel { get; }

		private static Level Create()
			=> new()
			{
				PlayersCount = 2,
				Sizes = new Sizes(5, 5),
				Regions = new List<Region>
				{
					new()
					{
						OwnerPlayerId = 1,
						VillageCoordinates = new Coordinates(1, 1),
						CellsCoordinates = new List<Coordinates>
						{
							new(row: 2, column: 1),
							new(row: 1, column: 1),
							new(row: 0, column: 1),
							new(row: 2, column: 2),
							new(row: 1, column: 2),
							new(row: 0, column: 2),
							new(row: 1, column: 0),
						},
					},
					new()
					{
						OwnerPlayerId = 2,
						VillageCoordinates = new Coordinates(3, 3),
						CellsCoordinates = new List<Coordinates>
						{
							new(row: 4, column: 3),
							new(row: 3, column: 3),
							new(row: 2, column: 3),
							new(row: 4, column: 4),
							new(row: 3, column: 4),
							new(row: 2, column: 4),
							new(row: 3, column: 2),
						},
					},
				},
				Buildings = new List<BuildingData>
				{
					new()
					{
						Prefab = Resources.Load<Building>("Prefabs/Golden Mine"),
						Coordinates = new Coordinates(0, 1),
					},
				},
			};
	}
}