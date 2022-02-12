namespace CourseApp
{
    public class Lina : Player
    {
        public Lina(string nickname, Ability damage, Ability activeSkill, Ability ultimate)
        {
            Character = "Lina";
            Class = "Intelligence";
            Nickname = nickname;
            Health = 2260;
            Armor = 16.32;
            Damage = damage;
            ActiveSkill = activeSkill;
            Ultimate = ultimate;
        }

        public override void Regenerate()
        {
            Health = 2260;
            Damage.Regenerate();
            ActiveSkill.Regenerate();
            Ultimate.Regenerate();
            IsStanned = false;
        }
    }
}
