using FluentAssertions;
using NUnit.Framework;
using Zenject;

namespace Confrontation.Editor.Tests
{
	[TestFixture]
	public class FieldGeneratorTests : ZenjectUnitTestFixture
	{
		[SetUp]
		public void SetUp()
		{
			Container.Bind<ILevelSelector>().To<TestLevelCreator>().AsSingle();
			Container.Bind<IField>().To<Field>().AsSingle();
			Container.BindFieldGenerator();
		}

		[TearDown]
		public void TearDown()
		{
			Container.UnbindAll();
		}

		[Test]
		public void _1_WhenInitialized_AndFieldWasEmpty_ThenFieldShouldNotContainEmptyElements()
		{
			// Arrange.
			var field = Container.Resolve<IField>();
			var generator = Container.Resolve<FieldGenerator>();

			// Act.
			generator.Initialize();

			// Assert.
			var cells = field.Cells;
			cells.Should().AllBeOfType<Cell>();
		}
	}
}