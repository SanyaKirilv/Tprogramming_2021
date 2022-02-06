namespace CourseApp
{
    public class Wizard : Player
    {
        public Wizard(string name, double health, double damage)
        {
            Class = "Wizard";
            Name = name;
            HP = health;
            Health = HP;
            Damage = damage;
        }
    }
}
