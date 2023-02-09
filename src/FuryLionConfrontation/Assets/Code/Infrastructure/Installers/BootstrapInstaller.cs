using Zenject;

namespace Confrontation
{
	public class BootstrapInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesTo<ToMainMenuOnInitialize>().AsSingle();
		}
	}
}