namespace io.github.asdproject.theHatter.tests
{
    using Xunit;
    using interfaces;

    public class BlueprintTests
    {
        private readonly IBlueprint<ITestInterface> _bluePrint;

        public BlueprintTests()
        {
            // Arrange
            _bluePrint = new Blueprint<ITestInterface>();
        }

        [Fact]
        public void BlueprintIsNotNull()
        {
            // Assert
            Assert.NotNull(_bluePrint);
        }

        [Fact]
        public void BlueprintObjectType()
        {
            // Assert
            Assert.True(_bluePrint.Object.GetType() == typeof(ITestInterface));
        }
    }
}