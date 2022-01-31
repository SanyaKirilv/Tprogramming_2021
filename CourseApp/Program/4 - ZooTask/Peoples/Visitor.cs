namespace CourseApp
{
    using System;

    public class Visitor : People, IDrawable
    {
        public Visitor(string name, int age)
            : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public void Draw()
        {
            var information = @$"  Class: Employee
    Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)}
    Age: {(string.IsNullOrEmpty(Age.ToString()) ? "none" : Age)}y
    ";
            Console.WriteLine(information);
        }
    }
}