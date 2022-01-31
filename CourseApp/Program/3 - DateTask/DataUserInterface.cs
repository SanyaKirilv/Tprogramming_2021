namespace CourseApp
{
    using System;

    public class DataUserInterface
    {
        public DataUserInterface()
        {
            Console.WriteLine("Hello!");
            IsValuesEnter = false;
        }

        public bool IsValuesEnter { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public void StartPage()
        {
            var isEnabled = true;
            while (isEnabled)
            {
                var input = new InputValues();
                Console.WriteLine(@"
Avaible actions:
1 - Set your birthDay
2 - Get your age
3 - Get date to your birthDay
4 - Exit program
What you want? Enter integer values.");
                switch (input.InputInt(1, 4))
                {
                    case 1:
                        SetYourBirthDate();
                        break;

                    case 2:
                        GetAge();
                        break;

                    case 3:
                        GetDateToYourBirth();
                        break;

                    case 4:
                        isEnabled = false;
                        break;
                }
            }
        }

        public void Output(string message)
        {
            switch (message)
            {
                case "days":
                    var days = Date();
                    var line = string.Empty;
                    if (string.IsNullOrEmpty(days.Item1) && string.IsNullOrEmpty(days.Item2))
                    {
                        line = $"{days.Item3}";
                    }

                    if (!string.IsNullOrEmpty(days.Item1) && !string.IsNullOrEmpty(days.Item2))
                    {
                        line = $"{days.Item1}, {days.Item2} {days.Item3}";
                    }

                    if (string.IsNullOrEmpty(days.Item1) || string.IsNullOrEmpty(days.Item2))
                    {
                        if (string.IsNullOrEmpty(days.Item1))
                        {
                            line = $"{days.Item2} {days.Item3}";
                        }

                        if (string.IsNullOrEmpty(days.Item2))
                        {
                            line = $"{days.Item1} {days.Item3}";
                        }
                    }

                    Console.WriteLine(line);
                    break;

                case "age":
                    var age = Age();
                    Console.WriteLine($"Your age: {age.Item1}, {age.Item2} and {age.Item3}");
                    break;
            }
        }

        private void SetYourBirthDate()
        {
            Console.Clear();
            var input = new InputValues();
            var today = DateTime.Now;
            Console.WriteLine("Enter your birthday");
            Console.WriteLine("Year:");
            Year = input.InputInt(0001, today.Year);
            Console.WriteLine("Month:");
            if (Year == today.Year)
            {
                Month = input.InputInt(1, today.Month);
            }
            else
            {
                Month = input.InputInt(1, 12);
            }

            Console.WriteLine("Day:");
            if (Month == today.Month)
            {
                Day = input.InputInt(1, today.Day);
            }
            else
            {
                Day = input.InputInt(1, 31);
            }

            IsValuesEnter = true;
            Console.Clear();
        }

        private void GetAge()
        {
            Console.Clear();
            var input = new InputValues();
            if (IsValuesEnter)
            {
                Output("age");
            }
            else
            {
                Console.WriteLine("You dont enter your birthDay!");
            }
        }

        private void GetDateToYourBirth()
        {
            Console.Clear();
            var input = new InputValues();
            if (IsValuesEnter)
            {
                Output("days");
            }
            else
            {
                Console.WriteLine("You dont enter your birthDay!");
            }
        }

        private (string, string, string) Age()
        {
            var dateClass = new DateClass();
            var birthDay = new DateTime(Year, Month, Day);
            var dateToday = DateTime.Today;
            var date = dateClass.CreateOutput(dateClass.CalculateAge(birthDay, dateToday));
            return (date.Item1, date.Item2, date.Item3);
        }

        private (string, string, string) Date()
        {
            var dateClass = new DateClass();
            var birthDay = new DateTime(Year, Month, Day);
            var dateToday = DateTime.Today;
            var date = dateClass.CreateOutput(dateClass.CalculateDaysToBirthDay(birthDay, dateToday));
            return (date.Item1, date.Item2, date.Item3);
        }
    }
}
