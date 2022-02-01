namespace CourseApp.Tests
{
    using Xunit;

    public class UnitTestsClass
    {
        [Theory]
        [InlineData("VSCode", "Exe", "1.56", "GB")]
        [InlineData("ISUCT", "HTML", "0.79", "KB")]
        [InlineData("Program", "Cs", "0.47", "B")]
        [InlineData("Music", "Mp3", "1.56", "KB")]
        [InlineData("Cat", "Exe", "1.56", "MB")]
        [InlineData("Video", "Mov", "0.63", "TB")]
        public void TestClass(string name, string extension, string weight, string weightModificator)
        {
            var expected = $"{name}.{extension} {weight}{weightModificator}";
            var file = new FileCreator(name, extension, weight, weightModificator);
            var actual = file.Display();
            Assert.Equal(expected, actual);
        }
    }
}
