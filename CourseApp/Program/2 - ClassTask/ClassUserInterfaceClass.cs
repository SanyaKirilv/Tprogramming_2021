namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class ClassUserInterfaceClass
    {
        public void StartPage()
        {
            var isEnabled = true;
            while (isEnabled)
            {
                var input = new InputValues();
                Console.WriteLine(@"
    In this program you can:
    1 - Get default file
    2 - Get custom file
    3 - Exit program
    What you want? Enter integer values.");
                switch (input.InputInt(1, 3))
                {
                    case 1:
                        DefaultFile();
                        break;

                    case 2:
                        CustomFile();
                        break;
                    case 3:
                        isEnabled = false;
                        break;
                }
            }
        }

        private void DefaultFile()
        {
            Console.Clear();
            var input = new InputValues();
            var file = new FileCreator("Program", "Cs", "0.34", "MB");
            Console.WriteLine($@"Default file:
{file.Display()}");
        }

        private void CustomFile()
        {
            Console.Clear();
            List<string> customValues = InputCustomValues();
            while (customValues.Count != 4)
            {
                customValues = InputCustomValues();
            }

            var file = new FileCreator(customValues);
            Console.WriteLine($"Custom file{file.Display()}");
        }

        private List<string> InputCustomValues()
        {
            Console.Clear();
            var customValues = new List<string>();
            customValues.Add(EnumValueName());
            customValues.Add(EnumValueExtension());
            customValues.Add(EnterValue());
            customValues.Add(EnumValueWeightModificator());
            Console.Clear();
            return customValues;
        }

        private string EnumValueName()
        {
            Console.Clear();
            var name = string.Empty;
            var input = new InputValues();
            var enumLength = Enum.GetNames(typeof(EnumName)).Length;
            Console.WriteLine($"Choose avaible name. Enter integer values.");
            for (int i = 0; i < enumLength; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumName), i)}");
            }

            Console.WriteLine("Your variant:");
            var id = input.InputInt(1, enumLength) - 1;
            name = Enum.GetName(typeof(EnumName), id);
            return name;
        }

        private string EnumValueExtension()
        {
            Console.Clear();
            var input = new InputValues();
            var enumLength = Enum.GetNames(typeof(EnumExtension)).Length;
            Console.WriteLine($"Choose avaible extension. Enter integer values.");
            for (var i = 0; i < enumLength; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumExtension), i)}");
            }

            Console.WriteLine("Your variant:");
            var id = input.InputInt(1, enumLength) - 1;
            return Enum.GetName(typeof(EnumExtension), id);
        }

        private string EnumValueWeightModificator()
        {
            Console.Clear();
            var input = new InputValues();
            var enumLength = Enum.GetNames(typeof(EnumWeightModificator)).Length;
            Console.WriteLine($"Choose avaible weightModificator. Enter integer values.");
            for (var i = 0; i < enumLength; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumWeightModificator), i)}");
            }

            Console.WriteLine("Your variant:");
            var id = input.InputInt(1, Enum.GetNames(typeof(EnumWeightModificator)).Length) - 1;
            return Enum.GetName(typeof(EnumWeightModificator), id);
        }

        private string EnterValue()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine(@"Enter weight. Weight must be positive. Value range is (0.001 to 1023).
Your value:");
            return input.InputDouble(0.001, 1023).ToString();
        }
    }
}
