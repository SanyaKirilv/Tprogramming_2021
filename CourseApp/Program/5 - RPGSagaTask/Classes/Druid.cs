namespace CourseApp
{
    using System.Collections.Generic;

    public class Druid : Player
    {
        public Druid(string name, double health, List<Ability> ability)
        {
            ClassName = "Druid";
            Name = name;
            Health = health;
            StartHealth = health;
            Ability = ability;
        }
    }
}
