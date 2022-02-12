namespace CourseApp
{
    public class Bloodseeker : Player
    {
        public Bloodseeker(string nickname, Ability damage, Ability activeSkill, Ability ultimate)
        {
            Character = "Bloodseeker";
            Class = "Agility";
            Nickname = nickname;
            Armor = 22.98;
            Damage = damage;
            ActiveSkill = activeSkill;
            Ultimate = ultimate;
            Regenerate();
        }

        public override void Regenerate()
        {
            Health = 2520;
            Damage.Regenerate();
            ActiveSkill.Regenerate();
            Ultimate.Regenerate();
            IsStanned = false;
        }
    }
}
