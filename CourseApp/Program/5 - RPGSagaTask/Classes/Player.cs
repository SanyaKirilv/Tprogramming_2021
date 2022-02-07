namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public abstract class Player : IPlayer
    {
        public string ClassName { get; set; }

        public string Name { get; set; }

        public string DamageType { get; set; }

        public double Health { get; set; }

        public double StartHealth { get; set; }

        public bool IsFrozen { get; set; }

        public bool IsDead { get; set; }

        public List<Ability> Ability { get; set; }

        public double FullDamage(Player player, Player target)
        {
            var random = new Random();
            var damage = 0d;
            if (!player.Ability[1].IsUsed && !player.Ability[1].InUse)
            {
                switch (random.Next(0, 2))
                {
                    case 0:
                        player.DamageType = "Basic";
                        break;
                    case 1:
                        player.DamageType = "Ability";
                        break;
                }
            }
            else if (player.Ability[1].IsUsed)
            {
                player.DamageType = "Basic";
                damage = player.Ability[0].BasicDamage;
            }

            if (player.DamageType == "Ability")
            {
                switch (player.Ability[1].Class)
                {
                    case "Effect":
                        switch (player.Ability[1].Type)
                        {
                            case "OneUse":

                                break;
                            case "Periodic":
                                player.Ability[1].InUse = true;
                                damage = (player.Ability[0].BasicDamage * player.Ability[1].DamageMultiplier) + player.Ability[1].BasicDamage;
                                target.IsFrozen = true;
                                player.Ability[1].Duration -= 1;
                                if (player.Ability[1].Duration == 0)
                                {
                                    player.Ability[1].IsUsed = true;
                                    player.Ability[1].InUse = false;
                                    target.IsFrozen = false;
                                }

                                break;
                        }

                        break;
                    case "Damage":
                        switch (player.Ability[1].Type)
                        {
                            case "OneUse":
                                damage = (player.Ability[0].BasicDamage * player.Ability[1].DamageMultiplier) + player.Ability[1].BasicDamage;
                                player.Ability[1].IsUsed = true;
                                player.Ability[1].InUse = false;
                                break;
                            case "Periodic":
                                player.Ability[1].InUse = true;
                                damage = (player.Ability[0].BasicDamage * player.Ability[1].DamageMultiplier) + player.Ability[1].BasicDamage;
                                player.Ability[1].Duration -= 1;
                                if (player.Ability[1].Duration == 0)
                                {
                                    player.Ability[1].IsUsed = true;
                                    player.Ability[1].InUse = false;
                                }

                                break;
                        }

                        break;
                    case "Boost":
                        switch (player.Ability[1].Type)
                        {
                            case "OneUse":
                                damage = (player.Ability[0].BasicDamage * player.Ability[1].DamageMultiplier) + player.Ability[1].BasicDamage;
                                player.Health += damage;
                                player.Ability[1].IsUsed = true;
                                player.Ability[1].InUse = false;
                                break;
                        }

                        break;
                }
            }

            return damage;
        }

        public void ApplyDamage(Player player, Player target)
        {
            Health -= player.FullDamage(player, target);
            if (Health <= 0)
            {
                IsDead = true;
            }
        }

        public void Regenerate()
        {
            Health = StartHealth;
            Ability[1].InUse = false;
            Ability[1].IsUsed = false;
            Ability[1].Duration = Ability[1].StartDuration;
        }

        public string Display()
        {
            return $"({ClassName}) {Name}";
        }
    }
}
