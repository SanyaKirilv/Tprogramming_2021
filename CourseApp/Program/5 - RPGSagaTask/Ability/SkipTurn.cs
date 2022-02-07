namespace CourseApp
{
    public class SkipTurn : Ability
    {
        public SkipTurn()
        {
            AbilityName = "Пропуск хода";
            Class = "Effect";
            Type = "Periodic";
            BasicDamage = 2;
            DamageMultiplier = 1;
            Duration = 2;
            StartDuration = 2;
        }
    }
}