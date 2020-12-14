using GameStrategy.Entity;

namespace GameStrategy.Models.Buildings
{
    public class Walls : IBuildingsInCastle
    {
        private readonly int MaxLevel = 10;

        public Walls()
        {
            CostLevelUp = 200;
            Level = 1;
            CanLevelUp = true;
            Description =
                "— повышают защиту армии в обороне на +1 за каждые два уровня;\n— максимальное количество уровней – 10;\n— максимальный бонус к защите обороняющихся войск = +5; ";
        }

        public bool Interaction { get; set; }
        public int Level { get; set; }
        public bool CanLevelUp { get; set; }
        public string Description { get; set; }
        public int CostLevelUp { get; set; }

        public void LevelUp()
        {
            Level++;
            CostLevelUp = 200 * Level;
            if (Level >= MaxLevel)
                CanLevelUp = false;
        }
    }
}