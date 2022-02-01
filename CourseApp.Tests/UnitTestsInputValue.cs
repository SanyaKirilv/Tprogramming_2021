namespace CourseApp.Tests
{
    using Xunit;

    public class UnitTestsInputValue
    {
        [Theory]
        [InlineData(0, -1, 2, true)]
        [InlineData(0, 1, 2, false)]
        [InlineData(1, 0, 2, true)]
        [InlineData(1, 1, 2, true)]
        public void TestCheckValuesInputInt(int input, int min, int max, bool expected)
        {
            var check = new CheckValues();
            var actual = check.IsValidInt(input, min, max);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0.1, -1, 2, true)]
        [InlineData(0.5, 1, 2, false)]
        [InlineData(1, 0, 2, true)]
        [InlineData(1.2, 1, 2, true)]
        public void TestCheckValuesInputDouble(double input, double min, double max, bool expected)
        {
            var check = new CheckValues();
            var actual = check.IsValidDouble(input, min, max);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2", 0, 3, true)]
        [InlineData("-1", 0, 3, false)]
        [InlineData("r", 0, 3, false)]
        [InlineData("-1.2", -2, -1, false)]
        [InlineData("4.1", 4, 5, false)]
        [InlineData(" ", 4, 4, false)]
        public void TestInputInt(string item, int minValue, int maxValue, bool expected)
        {
            var input = new InputValues();
            var (_, actual) = input.InputInt(minValue, maxValue, item);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0", 0, 3, true)]
        [InlineData("-1.5", 0, 3, false)]
        [InlineData("r", 0, 3, false)]
        [InlineData("-1", -2, -1, true)]
        [InlineData("4", 4, 5, true)]
        [InlineData(" ", 4, 4, false)]
        public void TestInputDouble(string item, int minValue, int maxValue, bool expected)
        {
            var input = new InputValues();
            var (_, actual) = input.InputDouble(minValue, maxValue, item);
            Assert.Equal(expected, actual);
        }
    }
}
