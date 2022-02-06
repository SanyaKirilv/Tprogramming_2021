namespace CourseApp
{
    public class Archer : Player
    {
        private double startHealth;

        public Archer(string name, double health, double damage)
        {
            Class = "Archer";
            Name = name;
            startHealth = health;
            Health = health;
            Damage = damage;
        }

        public override void Regenerate()
        {
            if (IsDead)
            {
                Health = startHealth;
            }
        }
    }
}
