namespace CourseApp
{
    public abstract class Player : IPlayer
    {
        public string Class { get; set; }

        public string Name { get; set; }

        public double Health { get; set; }

        public double Damage { get; set; }

        public bool IsDead { get; set; }

        public void ApplyDamage(double damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                IsDead = true;
            }
        }

        public abstract void Regenerate();

        public string Draw()
        {
            return $"({Class}) {Name} {Health}HP";
        }
    }
}
