namespace CourseApp
{
    using System.Collections.Generic;

    public class Sniper : Player
    {
        public Sniper(string name, double health, List<Ability> ability)
        {
            ClassName = "Sniper";
            Name = name;
            Health = health;
            StartHealth = health;
            Ability = ability;
        }
    }
}
