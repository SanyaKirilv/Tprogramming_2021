namespace CourseApp
{
    public static class GameManager
    {
        public static void RunGame(int size)
        {
            var generator = new Generator(size);
            var list = generator.GenerateStartList();
            var round = new Round();
            round.RunRound(list);
            Logger.ReagLog();
        }
    }
}