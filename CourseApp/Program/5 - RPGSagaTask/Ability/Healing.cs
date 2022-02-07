namespace CourseApp
{
    public class Healing : Ability
    {
        public Healing()
        {
            AbilityName = "Воровство здоровья";
            Class = "Boost";
            Type = "OneUse";
            BasicDamage = 10;
            DamageMultiplier = 1;
            Duration = 0;
            StartDuration = 0;
        }
    }
}
