using GameStrategy.Entity;

namespace GameStrategy.Models.Buildings
{
    public class Houses : IBuildingsInCastle
    {
        private readonly int MaxLevel = 25;
        private int MaxCountPeople = 5000;
        private int MaxNewPeople = 250;

        public Houses()
        {
            CostLevelUp = 200;
            Level = 1;
            LimitPeopleCount = 200;
            NewPeopleCount = 10;
            CanLevelUp = true;
            Description =
                "— повышают лимит населения базы на 200 человек за каждый уровень, начиная с первого;\n— на 10 повышают количество людей, которые каждый уровень приходят в замок;\n— максимальное количество уровней – 25, максимальный лимит населения – 5000;\n— на каждом ходе максимальное значение приходящих в замок людей – 250; ";
        }

        public bool Interaction { get; set; }
        public int Level { get; set; }
        public bool CanLevelUp { get; set; }
        public string Description { get; set; }
        public int CostLevelUp { get; set; }

        public int LimitPeopleCount { get; set; }
        public int NewPeopleCount { get; set; }


        public void LevelUp()
        {
            Level++;
            NewPeopleCount += 10;
            CostLevelUp = 150 * Level;
            if (Level >= MaxLevel)
                CanLevelUp = false;
            LimitPeopleCount += 200;
        }
    }
}