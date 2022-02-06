namespace CourseApp
{
    public class ArcherFactory : Factory
    {
        public override Player FactoryMethod(string name, double health, double damage)
        {
            return new Archer(name, health, damage);
        }
    }
}
