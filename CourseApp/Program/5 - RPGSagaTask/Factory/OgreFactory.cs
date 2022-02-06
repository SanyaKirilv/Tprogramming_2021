namespace CourseApp
{
    public class OgreFactory : Factory
    {
        public override Player FactoryMethod(string name, double health, double damage)
        {
            return new Ogre(name, health, damage);
        }
    }
}
