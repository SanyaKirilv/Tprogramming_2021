namespace CourseApp
{
    using System;

    public class MainFile
    {
        public static void Main(string[] args)
        {
            var game = new Game(16);
            game.Draw();
            Console.ReadLine();
        }
    }
}
