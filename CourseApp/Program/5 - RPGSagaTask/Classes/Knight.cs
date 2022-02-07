namespace CourseApp
{
    using System.Collections.Generic;

    public class Knight : Player
    {
        public Knight(string name, double health, List<Ability> ability)
        {
            ClassName = "Knight";
            Name = name;
            Health = health;
            StartHealth = health;
            Ability = ability;
        }
    }
}
