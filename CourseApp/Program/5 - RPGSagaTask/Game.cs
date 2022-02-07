namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Game
    {
        private int _size;
        private int _round;
        private int _battle;

        public Game(int size)
        {
            _size = size;
        }

        public void StartGame()
        {
            var logger = new Logger();
            var startListGenerator = new GameList();
            var gameList = new List<List<Player>>();
            gameList.Add(startListGenerator.GetList(_size));
            logger.WriteLogLine(" Стaртовая сетка:");
            for (var number = 0; number < gameList[0].Count; number++)
            {
                logger.WriteLogLine($" | {number + 1} - {gameList[0][number].Display()} : Здоровье {gameList[0][number].Health:f1}hp; Способности {gameList[0][number].Ability[0].AbilityName} и {gameList[0][number].Ability[1].AbilityName}");
            }

            logger.WriteLogLine(" #~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Round(_size, gameList, logger);
            logger.WriteLogLine(" Статистика игры:");
            logger.WriteLogLine($" | Победитель: {gameList[gameList.Count - 1][0].Display()}");
            logger.WriteLogLine($" | Всего участников: {_size}");
            logger.WriteLogLine($" | Всего раундов: {_round}");
            logger.WriteLogLine($" | Всего боев: {_battle}");
            logger.WriteLogLine($" #~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(logger.ReadLog());
        }

        public void Round(int size, List<List<Player>> gameList, Logger logger)
        {
            var roundLogger = new Logger();
            for (int round = 0; round < Math.Log(size, 2); round++)
            {
                roundLogger.CleanLog();
                roundLogger.WriteLogLine($" Раунд №{round + 1}");
                foreach (var player in gameList[round])
                {
                    player.Regenerate();
                }

                gameList.Add(Battle(gameList[round], roundLogger));
                roundLogger.WriteLogLine($" #~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                _round++;
                logger.WriteLog(roundLogger.ReadLog());
            }
        }

        public List<Player> Battle(List<Player> gameList, Logger roundLogger)
        {
            var newList = new List<Player>();
            var battleLogger = new Logger();
            for (int battle = 1; battle < gameList.Count; battle += 2)
            {
                battleLogger.CleanLog();
                battleLogger.WriteLogLine($" |-Битва №{newList.Count + 1}");
                var fight = new Fight(battleLogger, gameList[battle - 1], gameList[battle]);
                newList.Add(fight.GetWinner());
                battleLogger.WriteLogLine($" | #~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                _battle++;
                roundLogger.WriteLog(battleLogger.ReadLog());
            }

            return newList;
        }
    }
}
