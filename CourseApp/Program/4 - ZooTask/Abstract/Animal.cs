namespace CourseApp
{
    public abstract class Animal
    {
        public Animal(string type, string size, int age, string ability)
        {
            Type = type;
            Size = size;
            Age = age;
            Ability = ability;
        }

        public string Type { get; set; }

        public string Size { get; set; }

        public int Age { get; set; }

        public string Ability { get; set; }
    }
}
