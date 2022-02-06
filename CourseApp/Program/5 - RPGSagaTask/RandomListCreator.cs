namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class RandomListCreator
    {
        public List<Player> GetList(int size)
        {
            var list = new List<Player>();
            for (int i = 0; i < size; i++)
            {
                list.Add(GetRandomClass());
            }

            return list;
        }

        public Player GetRandomClass()
        {
            Random random = new Random();
            List<Factory> factories = new List<Factory>();
            factories.Add(new ArcherFactory());
            factories.Add(new KnightFactory());
            factories.Add(new WizardFactory());
            factories.Add(new WispFactory());
            factories.Add(new OgreFactory());
            return factories[random.Next(0, factories.Count)].FactoryMethod(RandomName(), random.Next(10, 100), random.Next(10, 20));
        }

        public string RandomName()
        {
            Random random = new Random();
            var name = Enum.GetName(typeof(EnumClassName), random.Next(0, Enum.GetNames(typeof(EnumClassName)).Length));
            return name;
        }
    }
}
