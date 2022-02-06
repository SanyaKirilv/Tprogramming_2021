namespace CourseApp
{
    public class Wisp : Player
    {
        public Wisp(string name, double health, double damage)
        {
            Class = "Wisp";
            Name = name;
            HP = health;
            Health = HP;
            Damage = damage;
        }
    }
}
