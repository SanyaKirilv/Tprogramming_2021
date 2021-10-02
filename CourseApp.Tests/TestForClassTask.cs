namespace CourseApp.Tests
{
    using CourseApp.Class;
    using Xunit;

    public class TestForTask
    {
        [Theory]
        [InlineData("VSCode", ".exe", 1.56, "GB")]
        [InlineData("ISUCT", ".HTML", 0.79, "KB")]
        [InlineData("Program", ".cs", 0.47, "B")]
        [InlineData("Music", ".mp3", 1.56, "KB")]
        [InlineData("Cat", ".exe", 1.56, "MB")]
        [InlineData("Video", ".mov", 0.63, "TB")]
        public void TestClass(string name, string extension, double weight, string weightModificator)
        {
            var expected = $"{name}{extension} {weight}{weightModificator}";
            Document file = new FileCreator(name, extension, weight, weightModificator);
            var actual = file.Display();
            Assert.Equal(expected, actual);
        }
    }
}
