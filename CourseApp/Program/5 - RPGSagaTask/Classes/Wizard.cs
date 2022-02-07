namespace CourseApp
{
    using System.Collections.Generic;

    public class Wizard : Player
    {
        public Wizard(string name, double health, List<Ability> ability)
        {
            ClassName = "Wizard";
            Name = name;
            Health = health;
            StartHealth = health;
            Ability = ability;
        }
    }
}
