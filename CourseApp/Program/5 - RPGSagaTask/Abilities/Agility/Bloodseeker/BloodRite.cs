namespace CourseApp
{
    public class BloodRite : Ability
    {
        private double _damage = 300;
        private double _damagePerStep = 0;
        private double _damageMultiplier = 1;
        private bool _stan = false;
        private int _duration = 2;
        private int _countOfUse = 2;

        public BloodRite()
        {
            AbilityName = "Blood Rite";
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