using UnityEngine;

namespace Confrontation
{
	public class MaterialByRegion : MonoBehaviour
	{
		[SerializeField] private Renderer _renderer;
		[SerializeField] private PlayersColorsSheet _playersColorsSheet;

		public void ChangeMaterialTo(int playerId)
			=> _renderer.material.color = _playersColorsSheet.GetColorFor(playerId);
	}
}