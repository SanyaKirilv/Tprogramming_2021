namespace CourseApp
{
    using System.Collections.Generic;

    public class Ogre : Player
    {
        public Ogre(string name, double health, List<Ability> ability)
        {
            ClassName = "Ogre";
            Name = name;
            Health = health;
            StartHealth = health;
            Ability = ability;
        }
    }
}
