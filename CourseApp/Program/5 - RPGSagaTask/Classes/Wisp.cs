namespace CourseApp
{
    public class Wisp : Player
    {
        private double startHealth;

        public Wisp(string name, double health, double damage)
        {
            Class = "Wisp";
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
