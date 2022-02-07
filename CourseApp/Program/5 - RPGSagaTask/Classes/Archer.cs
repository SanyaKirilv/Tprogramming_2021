namespace CourseApp
{
    using System.Collections.Generic;

    public class Archer : Player
    {
        public Archer(string name, double health, List<Ability> ability)
        {
            ClassName = "Archer";
            Name = name;
            Health = health;
            StartHealth = health;
            Ability = ability;
        }
    }
}
