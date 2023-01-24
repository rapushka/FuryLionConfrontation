using UnityEngine;
using UnityEngine.UI;

namespace Confrontation
{
	public abstract class ButtonBase : MonoBehaviour
	{
		[SerializeField] private Button _button;

		private void OnEnable()  => _button.onClick.AddListener(OnButtonClick);
		private void OnDisable() => _button.onClick.AddListener(OnButtonClick);

		protected abstract void OnButtonClick();
	}
}