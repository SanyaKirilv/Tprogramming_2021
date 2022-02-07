namespace CourseApp
{
    public class Fear : Ability
    {
        public Fear()
        {
            AbilityName = "Страх";
            Class = "Damage";
            Type = "OneUse";
            BasicDamage = 35;
            DamageMultiplier = 1.2;
            Duration = 0;
            StartDuration = 0;
        }
    }
}
