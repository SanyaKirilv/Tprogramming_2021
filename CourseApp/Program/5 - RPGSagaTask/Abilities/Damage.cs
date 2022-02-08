namespace CourseApp
{
    public class Damage : Ability
    {
        private double _damagePerStep = 0;
        private double _damageMultiplier = 1;
        private bool _stan = false;
        private int _countOfUse = 1000000;

        public Damage(double damage)
        {
            AbilityName = "Damage";
            Damage = damage;
            DamagePerStep = _damagePerStep;
            DamageMultiplier = _damageMultiplier;
            IsAbleToUse = true;
            Stan = _stan;
            Regenerate();
        }

        public override void Regenerate()
        {
            CountOfUse = _countOfUse;
        }
    }
}