using UnityEngine;
using Zenject;

namespace Confrontation
{
	public class GameplayInstaller : MonoInstaller
	{
		[SerializeField] private ResourcesService _resources;

		// ReSharper disable Unity.PerformanceAnalysis - Method call only on initialization
		public override void InstallBindings()
		{
			Container.Bind<IAssetsService>().To<AssetsService>().AsSingle();
			Container.Bind<IResourcesService>().FromInstance(_resources).AsSingle();
			Container.BindInterfacesAndSelfTo<Field>().AsSingle();

			// new Field(_level, _cellPrefab, _villagePrefab, new AssetsService())
		}
	}
}