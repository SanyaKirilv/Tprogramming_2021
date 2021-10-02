namespace CourseApp
{
    using System;
    using CourseApp.Class;

    public class ConsoleInputOutput
    {
        public void StartProgram()
        {
            Console.Clear();
            Console.WriteLine("Hello!");
            Console.WriteLine("This program can create files with default or your params");
            Console.WriteLine("File with default params - 1 | File with your params - 2");
            Console.WriteLine("What you want?");
            Class();
        }

        private void Class()
        {
            string[] name = { "isuct", "Funny", "Test", "Car", "Page", "IDE", "Game", "Video", "Music", "Work" };
            string[] extension = { ".txt", ".pdf", ".jpg", ".cs", ".html", ".png", ".abb", ".mp3", ".mp4" };
            string[] weightModificator = { "B", "KB", "MB", "GB", "TB", "PB" };
            switch (IntValue())
            {
                case 1:
                {
                    Console.Clear();
                    var task = new ClassTask();
                    break;
                }

                case 2:
                {
                    Console.Clear();
                    var value = new FileValues();
                    var task = new ClassTask(value.FileParam(name), value.FileParam(extension), value.Weight(), value.FileParam(weightModificator));
                    break;
                }
            }
        }

        private int IntValue()
        {
            bool isNumber = false;
            var input = string.Empty;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out int inputValue);
                if (!isNumber)
                {
                    Console.WriteLine("Please enter correct value");
                }
            }

            return Convert.ToInt32(input);
        }

        private double DoubleValue()
        {
            bool isNumber = false;
            var input = string.Empty;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = double.TryParse(input, out double inputValue);
                if (!isNumber)
                {
                    Console.WriteLine("Please enter correct value");
                }
            }

            return Convert.ToDouble(input);
        }
    }
}