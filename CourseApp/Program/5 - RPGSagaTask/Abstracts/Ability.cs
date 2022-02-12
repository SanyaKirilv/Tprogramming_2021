namespace CourseApp
{
    public abstract class Ability
    {
        public string AbilityName { get; set; }

        public string AbilityType { get; set; }

        public double Damage { get; set; }

        public double DamagePerStep { get; set; }

        public double DamageMultiplier { get; set; }

        public double HealthRegeneration { get; set; }

        public bool Stan { get; set; }

        public bool InUse { get; set; }

        public bool IsAbleToUse { get; set; }

        public int BaseDuration { get; set; }

        public int Duration { get; set; }

        public int CountOfUse { get; set; }

        public abstract void Regenerate();
    }
}
