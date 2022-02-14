namespace CourseApp
{
    using System.Collections.Generic;

    public class Generator
    {
        private int _gameSize;

        public Generator(int gameSize)
        {
            _gameSize = gameSize;
        }

        public List<Player> GenerateStartList()
        {
            var list = new List<Player>();
            var fabric = new PFabric();
            for (int size = 0; size < _gameSize; size++)
            {
                list.Add(fabric.GetRandomPlayer());
            }

            return list;
        }
    }
}
