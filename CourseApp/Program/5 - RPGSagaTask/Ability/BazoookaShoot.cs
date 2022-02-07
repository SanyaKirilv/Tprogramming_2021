namespace CourseApp
{
    public class BazoookaShoot : Ability
    {
        public BazoookaShoot()
        {
            AbilityName = "Выстрел из РПГ";
            Class = "Damage";
            Type = "OneUse";
            BasicDamage = 20;
            DamageMultiplier = 1.75;
            Duration = 0;
            StartDuration = 0;
        }
    }
}
