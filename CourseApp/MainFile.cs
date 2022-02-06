namespace CourseApp
{
    using System;
    public class MainFile
    {
        public static void Main(string[] args)
        {
            var game = new Game(2);
            game.Draw();
            Console.ReadLine();
        }
    }
}
