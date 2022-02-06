namespace CourseApp
{
    public class Knight : Player
    {
        public Knight(string name, double health, double damage)
        {
            Class = "Knight";
            Name = name;
            HP = health;
            Health = HP;
            Damage = damage;
        }
    }
}
