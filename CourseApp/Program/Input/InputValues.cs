namespace CourseApp
{
    using System;

    public class InputValues
    {
        public string InputString()
        {
            var item = string.Empty;
            var isCorrect = false;
            var check = new CheckValues();
            while (!isCorrect)
            {
                item = Console.ReadLine();
                isCorrect = check.IsValidString(item);
            }

            return item;
        }

        public int InputInt(int maxValue)
        {
            return InputInt(0, maxValue);
        }

        public int InputInt(int minValue, int maxValue)
        {
            var isCorrect = false;
            var number = 0;
            while (true)
            {
                var item = Console.ReadLine();
                (number, isCorrect) = InputInt(minValue, maxValue, item);
                if (isCorrect)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Please enter correct value!");
                }
            }

            return number;
        }

        public (int, bool) InputInt(int minValue, int maxValue, string item)
        {
            var intInput = 0;
            var isCorrect = false;
            var check = new CheckValues();
            if (int.TryParse(item, out intInput))
            {
                isCorrect = check.IsValidInt(intInput, minValue, maxValue);
            }

            return (intInput, isCorrect);
        }

        public double InputDouble(double maxValue)
        {
            return InputDouble(0, maxValue);
        }

        public double InputDouble(double minValue, double maxValue)
        {
            var isCorrect = false;
            var number = 0d;
            while (true)
            {
                var item = Console.ReadLine();
                (number, isCorrect) = InputDouble(minValue, maxValue, item);
                if (isCorrect)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"Please enter correct value!");
                }
            }
        }

        public (double, bool) InputDouble(double minValue, double maxValue, string item)
        {
            var doubleInput = 0d;
            var isCorrect = false;
            var check = new CheckValues();
            if (double.TryParse(item, out doubleInput))
            {
                isCorrect = check.IsValidDouble(doubleInput, minValue, maxValue);
            }

            return (doubleInput, isCorrect);
        }
    }
}
