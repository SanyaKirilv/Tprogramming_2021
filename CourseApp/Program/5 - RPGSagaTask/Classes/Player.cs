namespace CourseApp
{
    public abstract class Player : IPlayer
    {
        public string Class { get; set; }

        public string Name { get; set; }

        public double Health { get; set; }

        public double HP { get; set; }

        public double Damage { get; set; }

        public bool IsDead { get; set; }

        public void ApplyDamage(double damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                IsDead = true;
            }
        }

        public void Regenerate()
        {
            IsDead = false;
            HP = Health;
        }

        public string Draw()
        {
            return $"({Class}) {Name} {Health}HP";
        }
    }
}
