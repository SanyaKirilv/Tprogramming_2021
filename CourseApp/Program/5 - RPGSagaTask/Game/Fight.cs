namespace CourseApp
{
    using System;

    public class Fight
    {
        private Player _winner;
        private Player _losser;
        private Player _p1;
        private Player _p2;

        public Fight(Player p1, Player p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public (Player, Player) RunFight(int fight)
        {
            Logger.WriteLogLine($" | # Fight №{fight}: {_p1.Draw()} vs {_p2.Draw()}");
            while (!_p1.IsDead && !_p2.IsDead)
            {
                GetDamage(_p1, _p2);
                GetDamage(_p2, _p1);
            }

            _winner = _p1;
            _losser = _p2;
            if (_p1.IsDead)
            {
                _winner = _p2;
                _losser = _p1;
            }

            Logger.WriteLogLine($" | | Winner of this fight: {_winner.Draw()}");
            Logger.WriteLogLine($" | #~~~~~~~~~~~~~~~~~~");
            return (_winner, _losser);
        }

        public void GetDamage(Player enemy, Player target)
        {
            var damage = 0d;
            if (!enemy.IsDead && !enemy.IsStanned)
            {
                if (!enemy.ActiveSkill.InUse && !enemy.Ultimate.InUse)
                {
                    var random = Random.Shared.Next(0, 3);
                    switch (random)
                    {
                        case 0:
                            Skill.SelectSkill(enemy.Damage);
                            break;
                        case 1:
                            Skill.SelectSkill(enemy.ActiveSkill);
                            if (!enemy.ActiveSkill.IsAbleToUse)
                            {
                                Skill.SelectSkill(enemy.Damage);
                            }

                            break;
                        case 2:
                            Skill.SelectSkill(enemy.Ultimate);
                            if (!enemy.Ultimate.IsAbleToUse)
                            {
                                Skill.SelectSkill(enemy.Damage);
                            }

                            break;
                    }
                }

                damage += Skill.UseSkill(enemy, target, enemy.Damage);
                damage += Skill.UseSkill(enemy, target, enemy.ActiveSkill);
                damage += Skill.UseSkill(enemy, target, enemy.Ultimate);
            }

            target.Health -= damage - target.Armor;
            if (target.Health <= 0)
            {
                target.IsDead = true;
            }

            if (!enemy.IsStanned && !enemy.IsDead)
            {
                Logger.WriteLogLine($"{target.Draw()} {(target.IsDead ? "die" : $"have {target.Health:f0}hp")}");
            }
        }
    }
}
