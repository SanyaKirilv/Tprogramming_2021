namespace CourseApp
{
    public class Rot : Ability
    {
        public Rot()
        {
            AbilityName = "Вонялка";
            Class = "Damage";
            Type = "Periodic";
            BasicDamage = 5;
            DamageMultiplier = 1.5;
            Duration = 5;
            StartDuration = 5;
        }
    }
}
