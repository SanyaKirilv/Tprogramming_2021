namespace CourseApp
{
    using System;

    public class BasicDamage : Ability
    {
        public BasicDamage()
        {
            var random = new Random();
            AbilityName = "Удар";
            Class = "Damage";
            Type = "Basic";
            BasicDamage = random.Next(5, 10);
            DamageMultiplier = 1;
            Duration = 0;
            StartDuration = 0;
        }
    }
}
