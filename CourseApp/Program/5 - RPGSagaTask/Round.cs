namespace CourseApp
{
    public class Round
    {
        private Player winner;
        private Player louser;
        private Player playerOne;
        private Player playerTwo;
        private string gameLog;

        public Round(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        public Player StartRound(int fight)
        {
            gameLog += $"   Битва №{fight} : {playerOne.Draw()} vs {playerTwo.Draw()} \n\r";
            while (!playerOne.IsDead && !playerTwo.IsDead)
            {
                if (!playerOne.IsDead && !playerTwo.IsDead)
                {
                    playerTwo.ApplyDamage(playerOne.Damage);
                    gameLog += $"    - ({playerOne.Class}) {playerOne.Name} наносит урон {playerOne.Damage}HP, {(playerTwo.IsDead ? $"({playerTwo.Class}) {playerTwo.Name} погибает" : $"у ({playerTwo.Class}) {playerTwo.Name} осталось {playerTwo.HP}HP")}\n\r";
                }

                if (!playerOne.IsDead && !playerTwo.IsDead)
                {
                    playerOne.ApplyDamage(playerTwo.Damage);
                    gameLog += $"    - ({playerTwo.Class}) {playerTwo.Name} наносит урон {playerTwo.Damage}HP,{(playerOne.IsDead ? $"({playerOne.Class}) {playerOne.Name} погибает" : $"у ({playerOne.Class}) {playerOne.Name} осталось {playerOne.HP}HP")}\n\r";
                }
            }

            winner = playerOne;
            louser = playerTwo;
            if (playerOne.IsDead)
            {
                winner = playerTwo;
                louser = playerOne;
            }

            gameLog += $"   Победитель : ({winner.Class}) {winner.Name}\n\r";
            gameLog += "   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\r";

            return winner;
        }

        public string GetLog()
        {
            return gameLog;
        }
    }
}
