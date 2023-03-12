using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Serialization;
using Zenject;

namespace Confrontation
{
	public class MainMenuInstaller : MonoInstaller
	{
		[SerializeField] private PlayLevelButton _playLevelButtonPrefab;
		[SerializeField] private List<LevelScriptableObject> _levels;
		[SerializeField] private Transform _levelsGridRoot;
		[SerializeField] private LevelEditorUI _levelEditorUIPrefab;
		[SerializeField] private RectTransform _uiRoot;

		public override void InstallBindings()
		{
			Container.BindInstance(_playLevelButtonPrefab).AsSingle();

			InstallForLevelButtonsSpawner();

			Container.Bind<ToGameplay>().AsSingle();
			Container.BindInterfacesTo<LevelButtonsSpawner>().AsSingle();

			Container.BindFactory<ILevel, PlayLevelButton, LevelSelectionButtonBase.Factory>()
			         .FromComponentInNewPrefab(_playLevelButtonPrefab);

			InstallLevelEditor();
		}

		private void InstallLevelEditor()
		{
#if UNITY_EDITOR
			Container.BindInterfacesAndSelfTo<LevelEditorUI>()
			         .FromComponentInNewPrefab(_levelEditorUIPrefab)
			         .UnderTransform(_uiRoot)
			         .AsSingle();

			Container.BindInstance(_levels).WhenInjectedInto<LevelEditorUI>();
#endif
		}

		private void InstallForLevelButtonsSpawner()
		{
			Container.BindInstance(_levelsGridRoot).WhenInjectedInto<LevelButtonsSpawner>();
			Container.BindInstance(_levels).WhenInjectedInto<LevelButtonsSpawner>();
		}
	}
}