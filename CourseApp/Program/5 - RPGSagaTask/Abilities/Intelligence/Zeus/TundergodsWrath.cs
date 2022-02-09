namespace CourseApp
{
    public class TundergodsWrath : Ability
    {
        private double _damage = 650;
        private double _damagePerStep = 0;
        private double _damageMultiplier = 1;
        private bool _stan = false;
        private int _duration = 0;
        private int _countOfUse = 1;

        public TundergodsWrath()
        {
            AbilityName = "Tundergod`s Wrath";
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