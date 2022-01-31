namespace CourseApp.Program
{
    using System.Collections.Generic;
    using static System.Math;

    public class CalculateTasks
    {
        public CalculateTasks(double aValue, double bValue, double startValue, double endValue, double deltaValue)
        {
            AValue = aValue;
            BValue = bValue;
            StartValue = startValue;
            EndValue = endValue;
            DeltaValue = deltaValue;
        }

        public CalculateTasks(List<double> listValues)
        {
            AValue = listValues[0];
            BValue = listValues[1];
            StartValue = listValues[2];
            EndValue = listValues[3];
            DeltaValue = listValues[4];
        }

        public CalculateTasks(double aValue, double bValue)
        {
            AValue = aValue;
            BValue = bValue;
        }

        public CalculateTasks(double startValue, double endValue, double deltaValue)
        {
            StartValue = startValue;
            EndValue = endValue;
            DeltaValue = deltaValue;
        }

        public double StartValue { get; set; }

        public double EndValue { get; set; }

        public double DeltaValue { get; set; }

        public double AValue { get; set; }

        public double BValue { get; set; }

        public List<(double, double)> StartCalculate(List<double> listValue)
        {
            var list = new List<(double, double)>();
            foreach (var x in listValue)
            {
                var value = CalculateValue(x);
                list.Add(value);
            }

            return list;
        }

        public List<double> ListValue()
        {
            var listValue = new List<double>();
            for (var x = StartValue; x <= EndValue; x += DeltaValue)
            {
                listValue.Add(x);
            }

            return listValue;
        }

        public (double, double) CalculateValue(double x)
        {
            var sin = Asin(Pow(x, AValue));
            var cos = Acos(Pow(x, BValue));
            return (x, sin + cos);
        }
    }
}
