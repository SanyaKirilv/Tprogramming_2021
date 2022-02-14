namespace CourseApp
{
    public static class Skill
    {
        public static double UseSkill(Player enemy, Player target, Ability ability)
        {
            var damage = 0d;
            if (ability.InUse)
            {
                if (ability.BaseDuration > 0)
                {
                    if (ability.Stan)
                    {
                        target.IsStanned = true;
                    }

                    if (ability.Duration != ability.BaseDuration)
                    {
                        damage += ability.Damage;
                    }
                    else
                    {
                        damage = (enemy.Damage.Damage + ability.DamagePerStep) * ability.DamageMultiplier;
                    }

                    Logger.WriteLog($" | | {enemy.Draw()} use {ability.AbilityName} duration: {ability.Duration} step, ");

                    ability.Duration--;
                    if (ability.Duration == 0)
                    {
                        target.IsStanned = false;
                        ability.InUse = false;
                        ability.Duration = ability.BaseDuration;
                    }
                }

                if (ability.BaseDuration == 0)
                {
                    damage = (enemy.Damage.Damage + ability.Damage) * ability.DamageMultiplier;
                    Logger.WriteLog($" | | {enemy.Draw()} use {ability.AbilityName}, ");
                    ability.InUse = false;
                }

                ability.CountOfUse--;
            }

            return damage;
        }

        public static void SelectSkill(Ability ability)
        {
            if (ability.CountOfUse > 0)
            {
                ability.InUse = true;
            }
            else
            {
                ability.IsAbleToUse = false;
            }
        }
    }
}
