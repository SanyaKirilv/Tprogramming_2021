namespace CourseApp
{
    public class Damage : Ability
    {
        private readonly double _damagePerStep = 0;
        private readonly double _damageMultiplier = 1;
        private readonly bool _stan = false;
        private readonly int _countOfUse = 1000000;

        public Damage(double damage)
        {
            AbilityName = "Damage";
            Damage = damage;
            DamagePerStep = _damagePerStep;
            DamageMultiplier = _damageMultiplier;
            IsAbleToUse = true;
            Stan = _stan;
            Regenerate();
        }

        public override void Regenerate()
        {
            CountOfUse = _countOfUse;
            InUse = false;
        }
    }
}
