namespace CourseApp
{
    using System.Collections.Generic;

    public class Round
    {
        public List<Player> GetWinnerList(List<Player> list)
        {
            var fightNumber = 0;
            var winnerList = new List<Player>();
            foreach (var player in list)
            {
                player.Regenerate();
            }

            for (var i = 1;  i < list.Count;  i += 2)
            {
                var fight = new Fight(list[i - 1], list[i]);
                winnerList.Add(fight.RunFight(fightNumber + 1).Item1);
                fightNumber++;
            }

            return winnerList;
        }
    }
}
