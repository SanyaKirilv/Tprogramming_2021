namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Game
    {
        private int size = 0;
        private string gameLog;

        public Game(int size)
        {
            this.size = size;
        }

        public string GameLog()
        {
            var startList = new RandomListCreator();
            var gameList = new List<List<Player>>();
            var rounds = 0;
            gameList.Add(Fight(1, startList.GetList(size)));
            for (int i = 0; i < Math.Log(size, 2); i++)
            {
                rounds += gameList[i].Count;
                gameList.Add(Fight(2 + i, gameList[i]));
            }

            gameLog += $"Игра окончена!\n\rКолличество игроков : {size}\n\rКолличество битв : {Math.Log(size, 2)}\n\rКолличество раундов : {rounds}";
            return gameLog;
        }

        public List<Player> Fight(int roundNumber, List<Player> list)
        {
            var newList = new List<Player>();
            var fightLog = string.Empty;
            var fightNumber = 1;
            foreach (Player player in list)
            {
                player.Regenerate();
            }

            if (list.Count > 1)
            {
                gameLog += $"Раунд №{roundNumber}\n\r";
            }

            for (int i = 1; i < list.Count; i += 2)
            {
                var round = new Round(list[i - 1], list[i]);
                newList.Add(round.StartRound(fightNumber));
                gameLog += round.GetLog();
                fightNumber++;
            }

            return newList;
        }

        public void Draw()
        {
            Console.WriteLine(GameLog());
        }
    }
}
