namespace CourseApp
{
    using System;
    using CourseApp.Program;

    public class MainFile
    {
        public static void Main(string[] args)
        {
            var userInterface = new UserInterface();
            userInterface.StartPage();
            Console.ReadLine();
        }
    }
}
