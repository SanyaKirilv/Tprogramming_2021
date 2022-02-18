namespace CourseApp
{
    public abstract class Player
    {
        public string Character { get; set; }

        public string Class { get; set; }

        public string Nickname { get; set; }

        public double Health { get; set; }

        public double Armor { get; set; }

        public bool IsDead { get; set; }

        public bool IsStanned { get; set; }

        public Ability Damage { get; set; }

        public Ability ActiveSkill { get; set; }

        public Ability Ultimate { get; set; }

        public abstract void Regenerate();

        public string Draw()
        {
            return $"{Character} {Nickname}";
        }
    }
}
