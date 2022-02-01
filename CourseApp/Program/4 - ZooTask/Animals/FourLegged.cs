namespace CourseApp
{
    using System;

    public class FourLegged : Animal, IDrawable
    {
        public FourLegged(string type, string size, int age, string ability)
            : base(type, size, age, ability)
        {
            Type = type;
            Size = size;
            Age = age;
            Ability = ability;
        }

        public void Draw()
        {
            var information = @$"  Class: FourLegged
    Type: {(string.IsNullOrEmpty(Type) ? "none" : Type)}
    Size: {(string.IsNullOrEmpty(Size) ? "none" : Size)}
    Age: {(Age <= 0 ? "none" : Age)}y
    Ability: {(string.IsNullOrEmpty(Ability) ? "none" : Ability)}
    ";
            Console.WriteLine(information);
        }
    }
}
