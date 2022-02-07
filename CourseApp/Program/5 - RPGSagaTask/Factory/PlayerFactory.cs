namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class PlayerFactory : CFactory
    {
        public override Player FactoryMethod()
        {
            return ClassSelect();
        }

        private Player ClassSelect()
        {
            Player player = null;
            var random = new Random();
            var ability = new List<Ability>();
            ability.Add(new BasicDamage());
            switch (random.Next(0, 7))
            {
                case 0:
                    ability.Add(new FireArrow());
                    player = new Archer(Name(), random.Next(60, 80), ability);
                    break;
                case 1:
                    ability.Add(new RevengeStrike());
                    player = new Knight(Name(), random.Next(70, 100), ability);
                    break;
                case 2:
                    ability.Add(new SkipTurn());
                    player = new Wizard(Name(), random.Next(30, 40), ability);
                    break;
                case 3:
                    ability.Add(new Rot());
                    player = new Ogre(Name(), random.Next(60, 90), ability);
                    break;
                case 4:
                    ability.Add(new Healing());
                    player = new Druid(Name(), random.Next(30, 40), ability);
                    break;
                case 5:
                    ability.Add(new Fear());
                    player = new QueenOfPain(Name(), random.Next(40, 60), ability);
                    break;
                case 6:
                    ability.Add(new BazoookaShoot());
                    player = new Sniper(Name(), random.Next(50, 70), ability);
                    break;
            }

            return player;
        }

        private string Name()
        {
            var name = Names.Name;
            var random = new Random();
            return name[random.Next(0, name.Length)];
        }
    }
}