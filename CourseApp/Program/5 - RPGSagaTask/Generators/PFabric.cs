namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class PFabric : Fabric
    {
        private List<string> _name = new List<string>() { "Артемий", "Ева", "Кира", "Платон", "Максим", "Владимир", "Алиса", "Василий", "София", "Ника", "Марьям", "Тимофей", "Ангелина", "Мирон", "Антон", "Ярослав", "Иван", "Аделина", "Валерия", "Диана", "Дмитрий", "Амина", "Алексей", "Кирилл", "Александр", "Даниил", "Агата", "Виктория", "Михаил", "Злата", "Илья", "Дарья", "Ксения", "Александра", "Элина", "Артём", "Юрий", "Никита", "Павел", "Эмилия", "Мария", "Лев", "Андрей", "Маргарита", "Степан", "Григорий", "Василиса", "Фёдор", "Вероника", "Егор", "Елизавета", "Евгений", "Арина", "Марат", "Тимур", "Сафия", "Денис", "Ольга", "Дамир", "Софья", "Богдан", "Семён", "Зоя", "Нина", "Лилия", "Милана", "Николай", "Яна", "Екатерина", "Леонид", "Ирина", "Людмила", "Данияр", "Давид", "Анастасия", "Марк", "Вячеслав", "Константин", "Филипп", "Агния", "Эрик", "Надежда", "Любовь", "Анна", "Игорь", "Полина", "Антонина", "Стефания", "Назар", "Алина", "Медина", "Варвара", "Вера", "Мелания", "Сергей", "Ульяна", "Валентина", "Георгий", "Матвей", "Эмиль" };

        private List<string> _allCharacters = new List<string>() { "Zeus", "Lina", "Axe", "Pudge" };

        public override Player FabricMethod()
        {
            return NewPlayer();
        }

        public Player NewPlayer()
        {
            Player player = null;
            switch (_allCharacters[Random.Shared.Next(0, _allCharacters.Count)])
            {
                case "Zeus":
                    _allCharacters.Remove("Zeus");
                    player = new Zeus(Nickname(), new Damage(Random.Shared.Next(164, 172)), new LightningBold(), new TundergodsWrath());
                    break;
                case "Lina":
                    _allCharacters.Remove("Lina");
                    player = new Lina(Nickname(), new Damage(Random.Shared.Next(172, 180)), new DragonSlave(), new LagunaBlade());
                    break;
                case "Axe":
                    _allCharacters.Remove("Axe");
                    player = new Axe(Nickname(), new Damage(Random.Shared.Next(164, 168)), new CounterHelix(), new CullingBlade());
                    break;
                case "Pudge":
                    _allCharacters.Remove("Pudge");
                    player = new Pudge(Nickname(), new Damage(Random.Shared.Next(168, 174)), new Rot(), new Dismember());
                    break;
            }

            return player;
        }

        private string Nickname()
        {
            var name = _name[Random.Shared.Next(0, _name.Count)];
            _name.Remove(name);
            return name;
        }
    }
}