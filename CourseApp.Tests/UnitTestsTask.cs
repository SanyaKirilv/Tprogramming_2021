namespace CourseApp.Tests
{
    using System.Collections.Generic;
    using Xunit;
    using static System.Math;

    public class UnitTestsTask
    {
        [Theory]
        [InlineData(3, 2, 0.11, 1.56)]
        [InlineData(3, 2, 0.36, 1.488)]
        [InlineData(3, 2, 0.08, 1.565)]
        [InlineData(3, 2, 0.026, 1.57)]
        [InlineData(3, 2, 0.35, 1.491)]
        [InlineData(3, 2, 0.41, 1.471)]
        [InlineData(3, 2, 0.51, 1.441)]
        public void TestCalculate(double a, double b, double x, double expected)
        {
            var task = new CalculateTasks(a, b);
            var (_, actual) = task.CalculateValue(x);
            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [InlineData(0.1, 0.5, 0.1, 5)]
        [InlineData(0, 5, 1, 6)]
        [InlineData(0.25, 0.5, 0.05, 6)]
        [InlineData(1.2, 2.4, 1.2, 2)]
        public void TestListCount(double start, double end, double delta, int expected)
        {
            var task = new CalculateTasks(start, end, delta);
            var actual = task.ListValue().Count;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 0.1, 0.5, 0.1, new double[] { 1.58, 1.603, 1.634, 1.667, 1.698 })]
        [InlineData(2, 3, 3, 9, 3, new double[] { double.NaN, double.NaN, double.NaN })]
        [InlineData(2, 3, 0.5, 2.5, 0.5, new double[] { 1.698, 1.571, double.NaN, double.NaN, double.NaN })]
        public void TestTaskOne(double a, double b, double start, double end, double delta, double[] expected)
        {
            var task = new CalculateTasks(a, b, start, end, delta);
            var list = task.ListValue();
            var actual = new List<double>();
            foreach (var item in list)
            {
                actual.Add(Round(task.CalculateValue(item).Item2, 3));
            }

            Assert.Equal(expected, actual.ToArray());
        }

        [Theory]
        [InlineData(2, 3, new double[] { 1, 2, 3, 4 }, new double[] { 1.571, double.NaN, double.NaN, double.NaN })]
        [InlineData(2, 3, new double[] { 0.1, 0.2, 0.3, 0.4 }, new double[] { 1.58, 1.603, 1.634, 1.667 })]
        [InlineData(2, 3, new double[] { 0.5, 0.75, 0.8, 0.9 }, new double[] { 1.698, 1.733, 1.728, 1.698 })]
        public void TestTaskTwo(double a, double b, double[] list, double[] expected)
        {
            var task = new CalculateTasks(a, b);
            var actual = new List<double>();
            foreach (var item in list)
            {
                actual.Add(Round(task.CalculateValue(item).Item2, 3));
            }

            Assert.Equal(expected, actual.ToArray());
        }
    }
}
