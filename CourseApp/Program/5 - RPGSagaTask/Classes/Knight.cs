namespace CourseApp
{
    public class Knight : Player
    {
        private double startHealth;

        public Knight(string name, double health, double damage)
        {
            Class = "Knight";
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
