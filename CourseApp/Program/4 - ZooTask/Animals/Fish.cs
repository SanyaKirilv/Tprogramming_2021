namespace CourseApp
{
    using System;

    public class Fish : Animal, IDrawable
    {
        public Fish(string type, string size, int age, string ability)
            : base(type, size, age, ability)
        {
            Type = type;
            Size = size;
            Age = age;
            Ability = ability;
        }

        public void Draw()
        {
            var information = @$"  Class: Fish
    Type: {(string.IsNullOrEmpty(Type) ? "none" : Type)}
    Size: {(string.IsNullOrEmpty(Size) ? "none" : Size)}
    Age: {(Age <= 0 ? "none" : Age)}y
    Ability: {(string.IsNullOrEmpty(Ability) ? "none" : Ability)}
    ";
            Console.WriteLine(information);
        }
    }
}
