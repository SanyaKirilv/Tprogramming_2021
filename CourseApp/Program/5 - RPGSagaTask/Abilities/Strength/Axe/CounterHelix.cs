namespace CourseApp
{
    public class CounterHelix : Ability
    {
        private readonly double _damage = 180;
        private readonly double _damagePerStep = 0;
        private readonly double _damageMultiplier = 1;
        private readonly bool _stan = false;
        private readonly int _duration = 0;
        private readonly int _countOfUse = 2;

        public CounterHelix()
        {
            AbilityName = "Counter Helix";
            Damage = _damage;
            DamagePerStep = _damagePerStep;
            DamageMultiplier = _damageMultiplier;
            Stan = _stan;
            Regenerate();
        }

        public override void Regenerate()
        {
            BaseDuration = _duration;
            Duration = _duration;
            CountOfUse = _countOfUse;
            InUse = false;
            IsAbleToUse = true;
        }
    }
}
