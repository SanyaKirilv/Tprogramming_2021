namespace CourseApp
{
    using System.Collections.Generic;

    public class Round
    {
        public void RunRound(List<Player> list)
        {
            while (list.Count != 1)
            {
                foreach (var player in list)
                {
                    player.Regenerate();
                }

                for (int i = 1; i < list.Count; i += 2)
                {
                    Logger.WriteLogLine($" # Round");
                    list.Remove(GetLouser(list[i - 1], list[i]));
                    Logger.WriteLogLine($" #~~~~~~~~~~~~~~~~~~");
                }
            }

            Logger.WriteLogLine($"Winner of Tournir: {list[0].Draw()}");
        }

        public Player GetLouser(Player p1, Player p2)
        {
            var fight = new Fight(p1, p2);
            return fight.RunFight().Item2;
        }
    }
}