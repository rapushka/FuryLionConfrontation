using UnityEngine;

namespace Confrontation
{
	public class RegionColor : MonoBehaviour
	{
		[SerializeField] private Renderer _renderer;
		[SerializeField] private PlayersColorsSheet _playersColorsSheet;

		public void ChangeColorTo(int playerId)
			=> _renderer.material.color = _playersColorsSheet.GetColorFor(playerId);
	}
}