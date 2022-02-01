namespace CourseApp
{
    using System;

    public class MainFile
    {
        public static void Main(string[] args)
        {
            var taskUserInterface = new TaskUserInterface();
            taskUserInterface.StartPage();
            var classUserInterface = new ClassUserInterfaceClass();
            classUserInterface.StartPage();
            var dataUserInterface = new DataUserInterface();
            dataUserInterface.StartPage();
            var zooUserInterface = new ZooUserInterface();
            var zoo = new Zoo("Moscow zoo");
            zooUserInterface.Draw(zoo);
            Console.ReadLine();
        }
    }
}
