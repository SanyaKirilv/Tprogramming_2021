namespace CourseApp
{
    public class LightningBold : Ability
    {
        private double _damage = 350;
        private double _damagePerStep = 0;
        private double _damageMultiplier = 1;
        private bool _stan = true;
        private int _duration = 2;
        private int _countOfUse = 2;

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
