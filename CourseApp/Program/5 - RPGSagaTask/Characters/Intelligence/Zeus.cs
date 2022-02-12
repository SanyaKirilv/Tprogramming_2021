namespace CourseApp
{
    public class Zeus : Player
    {
        public Zeus(string nickname, Ability damage, Ability activeSkill, Ability ultimate)
        {
            Character = "Zeus";
            Class = "Intelligence";
            Nickname = nickname;
            Armor = 11.97;
            Damage = damage;
            ActiveSkill = activeSkill;
            Ultimate = ultimate;
            Regenerate();
        }

        public override void Regenerate()
        {
            Health = 2060;
            Damage.Regenerate();
            ActiveSkill.Regenerate();
            Ultimate.Regenerate();
            IsStanned = false;
        }
    }
}
