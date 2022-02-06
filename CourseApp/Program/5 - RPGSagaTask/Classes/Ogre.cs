namespace CourseApp
{
    public class Ogre : Player
    {
        private double startHealth;

        public Ogre(string name, double health, double damage)
        {
            Class = "Ogre";
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
