namespace CourseApp
{
    public class Dismember : Ability
    {
        private double _damage = 640;
        private double _damagePerStep = 0;
        private double _damageMultiplier = 1;
        private bool _stan = false;
        private int _duration = 0;
        private int _countOfUse = 1;

        public Dismember()
        {
            AbilityName = "Dismember";
            Damage = _damage;
            DamagePerStep = _damagePerStep;
            DamageMultiplier = _damageMultiplier;
            IsAbleToUse = true;
            Stan = _stan;
            Regenerate();
        }

        public override void Regenerate()
        {
            BaseDuration = _duration;
            Duration = _duration;
            CountOfUse = _countOfUse;
        }
    }
}