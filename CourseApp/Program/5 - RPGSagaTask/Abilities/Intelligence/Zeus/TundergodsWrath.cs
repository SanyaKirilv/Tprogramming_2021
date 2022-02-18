namespace CourseApp
{
    public class TundergodsWrath : Ability
    {
        private readonly double _damage = 650;
        private readonly double _damagePerStep = 0;
        private readonly double _damageMultiplier = 1;
        private readonly bool _stan = false;
        private readonly int _duration = 0;
        private readonly int _countOfUse = 1;

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
