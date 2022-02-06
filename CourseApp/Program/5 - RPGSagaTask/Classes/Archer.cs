namespace CourseApp
{
    public class Archer : Player
    {
        public Archer(string name, double health, double damage)
        {
            Class = "Archer";
            Name = name;
            HP = health;
            Health = HP;
            Damage = damage;
        }
    }
}
