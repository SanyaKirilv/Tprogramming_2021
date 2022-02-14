namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class PFabric : Fabric
    {
        private List<string> _name = new List<string>() { "Артемий", "Ева", "Кира", "Платон", "Максим", "Владимир", "Алиса", "Василий", "София", "Ника", "Марьям", "Тимофей", "Ангелина", "Мирон", "Антон", "Ярослав", "Иван", "Аделина", "Валерия", "Диана", "Дмитрий", "Амина", "Алексей", "Кирилл", "Александр", "Даниил", "Агата", "Виктория", "Михаил", "Злата", "Илья", "Дарья", "Ксения", "Александра", "Элина", "Артём", "Юрий", "Никита", "Павел", "Эмилия", "Мария", "Лев", "Андрей", "Маргарита", "Степан", "Григорий", "Василиса", "Фёдор", "Вероника", "Егор", "Елизавета", "Евгений", "Арина", "Марат", "Тимур", "Сафия", "Денис", "Ольга", "Дамир", "Софья", "Богдан", "Семён", "Зоя", "Нина", "Лилия", "Милана", "Николай", "Яна", "Екатерина", "Леонид", "Ирина", "Людмила", "Данияр", "Давид", "Анастасия", "Марк", "Вячеслав", "Константин", "Филипп", "Агния", "Эрик", "Надежда", "Любовь", "Анна", "Игорь", "Полина", "Антонина", "Стефания", "Назар", "Алина", "Медина", "Варвара", "Вера", "Мелания", "Сергей", "Ульяна", "Валентина", "Георгий", "Матвей", "Эмиль" };

        private List<string> _allCharacters = new List<string>() { "Zeus", "Lina", "Axe", "Pudge", "Sniper", "Bloodseeker" };

        public override Player GetRandomPlayer()
        {
            Player player = null;
            var name = _name[Random.Shared.Next(0, _name.Count)];
            switch (_allCharacters[Random.Shared.Next(0, _allCharacters.Count)])
            {
                case "Zeus":
                    player = new Zeus(name, new Damage(Random.Shared.Next(164, 172)), new LightningBold(), new TundergodsWrath());
                    break;
                case "Lina":
                    player = new Lina(name, new Damage(Random.Shared.Next(172, 180)), new DragonSlave(), new LagunaBlade());
                    break;
                case "Axe":
                    player = new Axe(name, new Damage(Random.Shared.Next(164, 168)), new CounterHelix(), new CullingBlade());
                    break;
                case "Pudge":
                    player = new Pudge(name, new Damage(Random.Shared.Next(168, 174)), new Rot(), new Dismember());
                    break;
                case "Sniper":
                    player = new Sniper(name, new Damage(Random.Shared.Next(146, 152)), new HeadShot(), new TakeAim());
                    break;
                case "Bloodseeker":
                    player = new Bloodseeker(name, new Damage(Random.Shared.Next(160, 166)), new BloodRite(), new Rupture());
                    break;
            }

            return player;
        }
    }
}
