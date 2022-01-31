namespace CourseApp
{
    using System;

    public class Employee : People, IDrawable
    {
        public Employee(string name, string post, int age, int salary)
            : base(name, age)
        {
            Name = name;
            Post = post;
            Age = age;
            Salary = salary;
        }

        public int Salary { get; set; }

        public string Post { get; set; }

        public void Draw()
        {
            var information = @$"  Class: Employee
    Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)}
    Post: {(string.IsNullOrEmpty(Post) ? "none" : Post)}
    Age: {(Age <= 0 ? "none" : Age)}y
    Salary: {(string.IsNullOrEmpty(Salary.ToString()) ? "none" : Salary)}$
    ";
            Console.WriteLine(information);
        }
    }
}