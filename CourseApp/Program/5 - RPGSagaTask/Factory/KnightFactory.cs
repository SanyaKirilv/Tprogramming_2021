namespace CourseApp
{
    public class KnightFactory : Factory
    {
        public override Player FactoryMethod(string name, double health, double damage)
        {
            return new Knight(name, health, damage);
        }
    }
}
