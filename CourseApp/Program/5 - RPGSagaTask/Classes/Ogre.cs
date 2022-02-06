namespace CourseApp
{
    public class Ogre : Player
    {
        public Ogre(string name, double health, double damage)
        {
            Class = "Ogre";
            Name = name;
            HP = health;
            Health = HP;
            Damage = damage;
        }
    }
}
