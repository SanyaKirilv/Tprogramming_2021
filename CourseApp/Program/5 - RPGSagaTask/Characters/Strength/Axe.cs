namespace CourseApp
{
    public class Axe : Player
    {
        public Axe(string nickname, Ability damage, Ability activeSkill, Ability ultimate)
        {
            Character = "Axe";
            Class = "Strength";
            Nickname = nickname;
            Armor = 15.3;
            Damage = damage;
            ActiveSkill = activeSkill;
            Ultimate = ultimate;
            Regenerate();
        }

        public override void Regenerate()
        {
            Health = 2940;
            Damage.Regenerate();
            ActiveSkill.Regenerate();
            Ultimate.Regenerate();
            IsStanned = false;
        }
    }
}
