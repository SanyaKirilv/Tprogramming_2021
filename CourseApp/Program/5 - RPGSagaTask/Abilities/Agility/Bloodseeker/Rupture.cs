namespace CourseApp
{
    public class Rupture : Ability
    {
        private double _damage = 200;
        private double _damagePerStep = 400;
        private double _damageMultiplier = 1;
        private bool _stan = false;
        private int _duration = 2;
        private int _countOfUse = 2;

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
