using GameStrategy.Models.ArmyUnit;

namespace GameStrategy.Models
{
    internal class Battlefield
    {
        public Army Army;
        public Bot Bot;

        public Battlefield(Army army, Bot bot)
        {
            Army = army;
            Bot = bot;
        }

        public int A { get; set; }
        public int D { get; set; }
        public int F { get; set; }

        public void Attack(int countUnit, int attacUnit, int defenseUnit)
        {
            A = countUnit * attacUnit;
            D = countUnit * defenseUnit;
            F = (int) (countUnit * attacUnit * 0.75);
        }

        public void Battle()
        {
            var battle = true;
            while (battle)
            {
                if (Army.Shooters.Count != 0)
                    while (Army.Shooters.Count != 0 && Bot.Army.Shooters.Count != 0)
                    {
                        Attack(Army.Shooters.Count, Shooter.Attack, Shooter.Shield);
                        Bot.Army.RemoveShooter((D - A) / Shooter.Shield);
                        Attack(Bot.Army.Shooters.Count, Shooter.Attack, Shooter.Shield);
                        Army.RemoveShooter((D - F) / Shooter.Shield);
                    }

                if (Army.Cavalries.Count != 0)
                    while (Army.Cavalries.Count != 0 && Bot.Army.Cavalries.Count != 0)
                    {
                        Attack(Army.Cavalries.Count, Cavalry.Attack, Cavalry.Shield);
                        Bot.Army.RemoveCavalry((D - A) / Cavalry.Shield);
                        Attack(Bot.Army.Cavalries.Count, Cavalry.Attack, Cavalry.Shield);
                        Army.RemoveCavalry((D - F) / Cavalry.Shield);
                    }

                if (Army.Recruits.Count != 0)
                    while (Army.Recruits.Count != 0 && Bot.Army.Recruits.Count != 0)
                    {
                        Attack(Army.Recruits.Count, Recruit.Attack, Recruit.Shield);
                        Bot.Army.RemoveRecruit((D - A) / Recruit.Shield);
                        Attack(Bot.Army.Recruits.Count, Recruit.Attack, Recruit.Shield);
                        Army.RemoveRecruit((D - F) / Recruit.Shield);
                    }

                if (Army.Infantrymen.Count != 0)
                    while (Army.Infantrymen.Count != 0 && Bot.Army.Infantrymen.Count != 0)
                    {
                        Attack(Army.Infantrymen.Count, Infantryman.Attack, Infantryman.Shield);
                        Bot.Army.RemoveInfantryman((D - A) / Infantryman.Shield);
                        Attack(Bot.Army.Infantrymen.Count, Infantryman.Attack, Infantryman.Shield);
                        Army.RemoveInfantryman((D - F) / Infantryman.Shield);
                    }

                if (Army.Infantrymen.Count == 0 && Army.Shooters.Count == 0 && Army.Cavalries.Count == 0 &&
                    Army.Recruits.Count == 0)
                {
                    Army.ResultBattle = "Failed";
                }
                else
                {
                    Army.ResultBattle = "Victory";
                    Army.Earned = Bot.Castle.Coins / 2;
                }

                battle = false;
            }
        }
    }
}