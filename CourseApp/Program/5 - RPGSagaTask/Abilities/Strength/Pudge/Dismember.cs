namespace CourseApp
{
    public class Dismember : Ability
    {
        private readonly double _damage = 640;
        private readonly double _damagePerStep = 0;
        private readonly double _damageMultiplier = 1;
        private readonly bool _stan = false;
        private readonly int _duration = 0;
        private readonly int _countOfUse = 1;

        public Dismember()
        {
            AbilityName = "Dismember";
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
