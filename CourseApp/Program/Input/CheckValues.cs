namespace CourseApp
{
    using System;

    public class CheckValues
    {
        public bool IsValidString(string item)
        {
            var isValidValue = true;
            if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
            {
                isValidValue = false;
                Console.WriteLine("Value is null or empty or contains invalid characters or whitespace. Please enter correct value!");
            }

            return isValidValue;
        }

        public bool IsValidInt(int item, int minValue, int maxValue)
        {
            var isValidValue = true;
            if (item < minValue || item > maxValue)
            {
                Console.WriteLine($"Value ({item}) is out of range. Please enter correct value!");
                isValidValue = false;
            }

            return isValidValue;
        }

        public bool IsValidDouble(double item, double minValue, double maxValue)
        {
            var isValidValue = true;
            if (item < minValue || item > maxValue)
            {
                Console.WriteLine($"Value ({item}) is out of range. Please enter correct value!");
                isValidValue = false;
            }

            return isValidValue;
        }
    }
}
