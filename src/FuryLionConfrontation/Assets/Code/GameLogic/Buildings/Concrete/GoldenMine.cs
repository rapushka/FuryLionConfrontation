using Zenject;

namespace Confrontation
{
	public class GoldenMine : Building, IActorWithCoolDown
	{
		[Inject] private readonly GameSession _gameSession;
		[Inject] private readonly GameplayUiMediator _ui;

		public float PassedDuration { get; set; }

		public float CoolDownDuration => Balance.ProduceCollDownDuration;

		public override string Name => nameof(GoldenMine);

		private int GoldProducingRate => Balance.ProduceAmount;

		private Player OwnerPlayer => _gameSession.GetPlayerById(Field.Regions[Coordinates].OwnerPlayerId);

		private GoldenMineData Balance => BalanceTable.GoldenMines[Level];

		public void Action() => ProduceGold();

		private void ProduceGold()
		{
			OwnerPlayer.Stats.GoldCount += GoldProducingRate;
			_ui.UpdateHud();
		}
	}
}