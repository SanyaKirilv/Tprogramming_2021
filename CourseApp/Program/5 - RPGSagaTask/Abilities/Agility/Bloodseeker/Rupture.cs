namespace CourseApp
{
    public class Rupture : Ability
    {
        private readonly double _damage = 200;
        private readonly double _damagePerStep = 400;
        private readonly double _damageMultiplier = 1;
        private readonly bool _stan = false;
        private readonly int _duration = 2;
        private readonly int _countOfUse = 2;

        public Rupture()
        {
            AbilityName = "Rupture";
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
