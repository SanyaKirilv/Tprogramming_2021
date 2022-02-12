namespace CourseApp
{
    public class Pudge : Player
    {
        public Pudge(string nickname, Ability damage, Ability activeSkill, Ability ultimate)
        {
            Character = "Pudge";
            Class = "Strength";
            Nickname = nickname;
            Armor = 11.43;
            Damage = damage;
            ActiveSkill = activeSkill;
            Ultimate = ultimate;
            Regenerate();
        }

        public override void Regenerate()
        {
            Health = 3040;
            Damage.Regenerate();
            ActiveSkill.Regenerate();
            Ultimate.Regenerate();
            IsStanned = false;
        }
    }
}
