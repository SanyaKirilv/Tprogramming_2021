namespace CourseApp
{
    using System;

    public abstract class Ability
    {
        public string AbilityName { get; set; }

        public double BasicDamage { get; set; }

        public double DamageMultiplier { get; set; }

        public int Duration { get; set; }

        public int StartDuration { get; set; }

        public bool IsUsed { get; set; }

        public bool InUse { get; set; }

        public string Type { get; set; }

        public string Class { get; set; }
    }
}