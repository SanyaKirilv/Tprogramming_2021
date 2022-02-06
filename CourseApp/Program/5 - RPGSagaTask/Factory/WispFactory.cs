namespace CourseApp
{
    public class WispFactory : Factory
    {
        public override Player FactoryMethod(string name, double health, double damage)
        {
            return new Wisp(name, health, damage);
        }
    }
}
