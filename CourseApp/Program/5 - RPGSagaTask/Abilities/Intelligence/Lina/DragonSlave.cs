namespace CourseApp
{
    public class DragonSlave : Ability
    {
        private readonly double _damage = 310;
        private readonly double _damagePerStep = 30;
        private readonly double _damageMultiplier = 1;
        private readonly bool _stan = false;
        private readonly int _duration = 2;
        private readonly int _countOfUse = 2;

        public DragonSlave()
        {
            AbilityName = "Dragon Slave";
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
