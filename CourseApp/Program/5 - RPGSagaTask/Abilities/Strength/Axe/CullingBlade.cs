namespace CourseApp
{
    public class CullingBlade : Ability
    {
        private readonly double _damage = 600;
        private readonly double _damagePerStep = 0;
        private readonly double _damageMultiplier = 1;
        private readonly bool _stan = false;
        private readonly int _duration = 0;
        private readonly int _countOfUse = 1;

        public CullingBlade()
        {
            AbilityName = "Culling Blade";
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
