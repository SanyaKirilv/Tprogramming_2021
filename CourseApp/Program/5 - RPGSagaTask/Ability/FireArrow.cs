namespace CourseApp
{
    public class FireArrow : Ability
    {
        public FireArrow()
        {
            AbilityName = "Огненные стрелы";
            Class = "Damage";
            Type = "Periodic";
            BasicDamage = 10;
            DamageMultiplier = 1;
            Duration = 5;
            StartDuration = 5;
        }
    }
}
