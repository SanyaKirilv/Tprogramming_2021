namespace CourseApp
{
    public class Wizard : Player
    {
        private double startHealth;

        public Wizard(string name, double health, double damage)
        {
            Class = "Wizard";
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
