namespace CourseApp
{
    using System;

    public class Fight
    {
        private Player _firstPlayer;
        private Player _secondPlayer;
        private Logger _battleLogger;

        public Fight(Logger battleLogger, Player firstPlayer, Player secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
            _battleLogger = battleLogger;
        }

        public Player GetWinner()
        {
            var isEnd = false;
            _battleLogger.WriteLogLine($" | | {_firstPlayer.Display()} {_firstPlayer.Health:f1}hp vs {_secondPlayer.Display()} {_secondPlayer.Health:f1}hp");
            while (!isEnd)
            {
                if (!_firstPlayer.IsDead && !_secondPlayer.IsDead)
                {
                    if (!_firstPlayer.IsFrozen)
                    {
                        _secondPlayer.ApplyDamage(_firstPlayer, _secondPlayer);
                        DamageLogWrite(_firstPlayer, _secondPlayer);
                        if (_secondPlayer.IsDead)
                        {
                            isEnd = true;
                        }
                    }
                }

                if (!_firstPlayer.IsDead && !_secondPlayer.IsDead)
                {
                    if (!_secondPlayer.IsFrozen)
                    {
                        _firstPlayer.ApplyDamage(_secondPlayer, _firstPlayer);
                        DamageLogWrite(_secondPlayer, _firstPlayer);
                        if (_firstPlayer.IsDead)
                        {
                            isEnd = true;
                        }
                    }
                }
            }

            var winner = _firstPlayer;
            if (_firstPlayer.IsDead)
            {
                winner = _secondPlayer;
            }

            _battleLogger.WriteLogLine($" | | Победитель: {winner.Display()}");
            return winner;
        }

        public void DamageLogWrite(Player playerOne, Player playerTwo)
        {
            switch (playerOne.DamageType)
            {
                case "Basic":
                    _battleLogger.WriteLogLine($" | | {playerOne.Display()} наносит удар, {(playerTwo.IsDead ? $"{playerTwo.Display()} погибает" : $"у {playerTwo.Display()} осталось {playerTwo.Health:f1}hp")}");
                    break;
                case "Ability":
                    switch (playerOne.Ability[1].Class)
                    {
                        case "Effect":
                            switch (playerOne.Ability[1].Type)
                            {
                                case "OneUse":
                                    break;
                                case "Periodic":
                                    _battleLogger.WriteLogLine($" | | {playerOne.Display()} наносит удар и применяет {playerOne.Ability[1].AbilityName} {playerOne.Ability[1].Duration} хода, {(playerTwo.IsDead ? $"{playerTwo.Display()} погибает" : $"у {playerTwo.Display()} осталось {playerTwo.Health:f1}hp")}");
                                    break;
                            }

                            break;
                        case "Damage":
                            switch (playerOne.Ability[1].Type)
                            {
                                case "OneUse":
                                    _battleLogger.WriteLogLine($" | | {playerOne.Display()} наносит {playerOne.Ability[1].AbilityName}, {(playerTwo.IsDead ? $"{playerTwo.Display()} погибает" : $"у {playerTwo.Display()} осталось {playerTwo.Health:f1}hp")}");
                                    break;
                                case "Periodic":
                                    _battleLogger.WriteLogLine($" | | {playerOne.Display()} наносит удар и применяет {playerOne.Ability[1].AbilityName} еще {playerOne.Ability[1].Duration} хода, {(playerTwo.IsDead ? $"{playerTwo.Display()} погибает" : $"у {playerTwo.Display()} осталось {playerTwo.Health:f1}hp")}");
                                    break;
                            }

                            break;
                        case "Boost":
                            switch (playerOne.Ability[1].Type)
                            {
                                case "OneUse":
                                    _battleLogger.WriteLogLine($" | | {playerOne.Display()} наносит удар и применяет {playerOne.Ability[1].AbilityName}, {(playerTwo.IsDead ? $"{playerTwo.Display()} погибает" : $"у {playerTwo.Display()} осталось {playerTwo.Health:f1}hp")}");
                                    break;
                                case "Periodic":
                                    break;
                            }

                            break;
                    }

                    break;
            }
        }
    }
}