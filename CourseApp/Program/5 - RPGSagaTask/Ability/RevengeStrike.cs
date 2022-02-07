namespace CourseApp
{
    public class RevengeStrike : Ability
    {
        public RevengeStrike()
        {
            AbilityName = "Удар возмездия";
            Class = "Damage";
            Type = "OneUse";
            BasicDamage = 4;
            DamageMultiplier = 1.3;
            Duration = 1;
            StartDuration = 1;
        }
    }
}