namespace CourseApp
{
    using System.Collections.Generic;

    public class GameList
    {
        public List<Player> GetList(int size)
        {
            var list = new List<Player>();
            var factory = new PlayerFactory();
            for (var count = 0; count < size; count++)
            {
                list.Add(factory.FactoryMethod());
            }

            return list;
        }
    }
}