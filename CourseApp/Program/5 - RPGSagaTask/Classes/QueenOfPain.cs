namespace CourseApp
{
    using System.Collections.Generic;

    public class QueenOfPain : Player
    {
        public QueenOfPain(string name, double health, List<Ability> ability)
        {
            ClassName = "QueenOfPain";
            Name = name;
            Health = health;
            StartHealth = health;
            Ability = ability;
        }
    }
}
