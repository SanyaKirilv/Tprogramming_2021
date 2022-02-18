namespace CourseApp
{
    public class LightningBold : Ability
    {
        private readonly double _damage = 350;
        private readonly double _damagePerStep = 0;
        private readonly double _damageMultiplier = 1;
        private readonly bool _stan = true;
        private readonly int _duration = 2;
        private readonly int _countOfUse = 2;

        public LightningBold()
        {
            AbilityName = "Lightning Bold";
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
