namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class TaskUserInterface
    {
        public TaskUserInterface()
        {
            Console.WriteLine("Hello!");
        }

        public void StartPage()
        {
            var isEnabled = true;
            while (isEnabled)
            {
                var input = new InputValues();
                var listValues = new List<double>() { 0.08, 0.026, 0.35, 0.41, 0.51 };
                Console.WriteLine(@"
    In this program you can:
    1 - Get calculating with default values
    2 - Get calculating with custom values
    3 - Exit program
    What you want? Enter integer values.");
                switch (input.InputInt(1, 3))
                {
                    case 1:
                        DefaultCalculations(listValues);
                        break;

                    case 2:
                        CustomCalculations(listValues, InputCustomValues());
                        break;

                    case 3:
                        isEnabled = false;
                        break;
                }
            }
        }

        private void DefaultCalculations(List<double> listValues)
        {
            Console.Clear();
            var input = new InputValues();
            var task = new CalculateTasks(2.0, 3.0, 0.11, 0.36, 0.05);
            Console.WriteLine($"Calculated with default values:");
            Output(task.StartCalculate(task.ListValue()));
            Output(task.StartCalculate(listValues));
        }

        private void CustomCalculations(List<double> listValues, List<double> listCustomValues)
        {
            Console.Clear();
            var task = new CalculateTasks(listCustomValues);
            Console.WriteLine($"Calculated with custom values:");
            Output(task.StartCalculate(task.ListValue()));
            Output(task.StartCalculate(listValues));
        }

        private void Output(List<(double, double)> lst)
        {
            Console.WriteLine("Task:");
            foreach (var (x, y) in lst)
            {
                Console.WriteLine($"  x = {x:f2} y = {y:f2}");
            }
        }

        private List<double> InputCustomValues()
        {
            Console.Clear();
            var input = new InputValues();
            var listCustomValues = new List<double>();
            Console.WriteLine("Enter your values:");
            Console.Write("a = ");
            listCustomValues.Add(input.InputDouble(double.MinValue, double.MaxValue));
            Console.Write("b = ");
            listCustomValues.Add(input.InputDouble(double.MinValue, double.MaxValue));
            Console.Write("start = ");
            listCustomValues.Add(input.InputDouble(double.MinValue, double.MaxValue));
            Console.Write("end = ");
            listCustomValues.Add(input.InputDouble(double.MinValue, double.MaxValue));
            Console.Write("delta = ");
            listCustomValues.Add(input.InputDouble(double.MinValue, double.MaxValue));
            Console.Clear();
            return listCustomValues;
        }
    }
}
