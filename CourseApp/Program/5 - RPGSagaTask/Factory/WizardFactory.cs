namespace CourseApp
{
    public class WizardFactory : Factory
    {
        public override Player FactoryMethod(string name, double health, double damage)
        {
            return new Wizard(name, health, damage);
        }
    }
}
