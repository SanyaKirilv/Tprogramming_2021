namespace CourseApp
{
    public class Sniper : Player
    {
        public Sniper(string nickname, Ability damage, Ability activeSkill, Ability ultimate)
        {
            Character = "Sniper";
            Class = "Agility";
            Nickname = nickname;
            Armor = 21.3;
            Damage = damage;
            ActiveSkill = activeSkill;
            Ultimate = ultimate;
            Regenerate();
        }

        public override void Regenerate()
        {
            Health = 2020;
            Damage.Regenerate();
            ActiveSkill.Regenerate();
            Ultimate.Regenerate();
            IsStanned = false;
        }
    }
}
