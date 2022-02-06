namespace CourseApp
{
    public interface IPlayer
    {
        string Class { get; set; }

        string Name { get; set; }

        double Health { get; set; }

        double Damage { get; set; }

        bool IsDead { get; set; }

        public string Draw();
    }
}
