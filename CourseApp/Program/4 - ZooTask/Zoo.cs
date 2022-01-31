namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Zoo : IDrawable
    {
        public Zoo(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Draw()
        {
            var zooUserInterface = new ZooUserInterface();
            Console.WriteLine($"Zoo: {Name}");
            Console.WriteLine($"Animals:");
            zooUserInterface.Draw(Animals());
            Console.WriteLine($"Peoples:");
            zooUserInterface.Draw(Peoples());
            Console.WriteLine($"Objects:");
            zooUserInterface.Draw(Objects());
        }

        public List<IDrawable> Animals()
        {
            var list = new List<IDrawable>();
            list.Add(new Bird("Hummingbird", "Very small", 1, null));
            list.Add(new Bird("Eagle", "Small", 2, "Fly"));
            list.Add(new FourLegged("Lion", "Medium", 5, null));
            list.Add(new FourLegged("Wolf", "Medium", 2, "Howl"));
            list.Add(new Fish("Shark", "Big", 2, "Swim"));
            list.Add(new Fish("Swordfish", "Medium", 3, "Swim"));
            return list;
        }

        public List<IDrawable> Peoples()
        {
            var list = new List<IDrawable>();
            list.Add(new Employee("Mike", "Director", 35, 0));
            list.Add(new Employee("Leo", "Сleaner", 56, 1300));
            list.Add(new Employee("Mark", "Worker", 0, 1300));
            list.Add(new Visitor("Stepa", 19));
            list.Add(new Visitor("Daniil", 11));
            list.Add(new Visitor("Gleb", 34));
            return list;
        }

        public List<IDrawable> Objects()
        {
            var list = new List<IDrawable>();
            list.Add(new Building("Administration", "Big", null));
            list.Add(new Building("Toilet", "Small", "Wood"));
            list.Add(new Building("Shop", "Medium", "Concrete"));
            list.Add(new InteriorObject("Table", "Medium", "Wood"));
            list.Add(new InteriorObject("Laptop", "Medium", null));
            list.Add(new InteriorObject("Char", null, null));
            return list;
        }
    }
}