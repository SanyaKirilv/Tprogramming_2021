namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public static class GameManager
    {
        public static void RunGame(int size)
        {
            var list = new List<List<Player>>();
            var generator = new Generator(size);
            var listSize = (int)Math.Log2(size);
            list.Add(generator.GenerateStartList());
            for (int i = 0; i < listSize; i++)
            {
                Logger.WriteLogLine($" # Round №{i + 1}");
                var round = new Round();
                list.Add(round.GetWinnerList(list[i]));
                Logger.WriteLogLine($" #~~~~~~~~~~~~~~~~~~");
            }

            Logger.WriteLogLine($" Winner of this tournir: {list[listSize - 1][0].Draw()}");
            Logger.WriteLogLine($" Total rounds: {listSize}");
            Logger.WriteLogLine($" Total fights: {Math.Pow(2, listSize) + 1}");

            Logger.ReagLog();
        }
    }
}
