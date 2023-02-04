using FluentAssertions;
using NUnit.Framework;

namespace Confrontation.Editor.Tests
{
	public class StringFormatterTests
	{
		[Test]
		public void WhenFormat_AndLowerFirst_ThenUpperFirst()
		{
			// Arrange.
			var name = "width";

			// Act.
			name = name.Pretty();

			// Assert.
			name.Should().Be("Width");
		}

		[Test]
		public void WhenFormat_AndUnderScoreLowerFirst_ThenUpperFirst()
		{
			// Arrange.
			var name = "_width";

			// Act.
			name = name.Pretty();

			// Assert.
			name.Should().Be("Width");
		}

		[Test]
		public void WhenFormat_AndCamelCase_ThenAddSpaces()
		{
			// Arrange.
			var name = "someText";

			// Act.
			name = name.Pretty();

			// Assert.
			name.Should().Be("Some Text");
		}

		[Test]
		public void WhenFormat_AndCamelCaseWithUnderScore_ThenAddSpacesAndFirstToUpper()
		{
			// Arrange.
			var name = "_someAnotherText";

			// Act.
			name = name.Pretty();

			// Assert.
			name.Should().Be("Some Another Text");
		}
	}
}