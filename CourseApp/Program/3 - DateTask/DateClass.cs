namespace CourseApp
{
    using System;
    using static System.Math;

    public class DateClass
    {
        public (int, int, int) CalculateAge(DateTime birthDay, DateTime dateToday)
        {
            var months = dateToday.Month - birthDay.Month;
            var years = dateToday.Year - birthDay.Year;
            if (dateToday.Day < birthDay.Day)
            {
                months--;
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            var days = (dateToday - birthDay.AddMonths((years * 12) + months)).Days;
            return (years, months, days);
        }

        public (string, string, string) CreateOutput((int, int, int) age)
        {
            var years = $"{age.Item1} year{(age.Item1 % 10 == 1 ? " " : "`s")}";
            var months = $"{age.Item2} month{(age.Item2 % 10 == 1 ? " " : "`s")}";
            var days = $"{age.Item3} day{(age.Item3 % 10 == 1 ? " " : "`s")}";
            return (years, months, days);
        }

        public (string, string, string) CreateOutput((int, int) age)
        {
            var months = string.Empty;
            var days = string.Empty;
            var mod = "Happy birthDay!";
            if (age.Item1 + age.Item2 != 0)
            {
                months = string.Empty;
                days = string.Empty;
                if (age.Item1 != 0)
                {
                    months = $"{age.Item1} {(age.Item1 % 10 == 1 ? "month" : "month`s")}";
                    mod = "to your birthDay";
                    if (age.Item1 < 0)
                    {
                        months = $"{Abs(age.Item1)} {(Abs(age.Item1) % 10 == 1 ? "month" : "month`s")}";
                        mod = "from your birthDay";
                    }
                }

                if (age.Item2 != 0)
                {
                    days = $"{age.Item2} {(age.Item2 % 10 == 1 ? "day" : "day`s")}";
                    mod = "to your birthDay";
                    if (age.Item2 < 0)
                    {
                        days = $"{Abs(age.Item2)} {(Abs(age.Item2) % 10 == 1 ? "day" : "day`s")}";
                        mod = "from your birthDay";
                    }
                }
            }

            return (months, days, mod);
        }

        public (int, int) CalculateDaysToBirthDay(DateTime birthDay, DateTime dateToday)
        {
            var months = birthDay.Month - dateToday.Month;
            var years = birthDay.Year - dateToday.Year;
            if (birthDay.Year < dateToday.Day)
            {
                months--;
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            var days = (birthDay - dateToday.AddMonths((years * 12) + months)).Days;
            return (months, days);
        }
    }
}
