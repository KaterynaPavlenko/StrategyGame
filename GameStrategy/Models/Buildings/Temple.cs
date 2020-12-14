using GameStrategy.Entity;

namespace GameStrategy.Models.Buildings
{
    public class Temple : IBuildingsInCastle
    {
        private readonly int MaxLevel = 10;

        public Temple()
        {
            CostLevelUp = 750;
            Level = 1;
            CanLevelUp = true;
            Description =
                "— повышает атаку армии в походе на +1 за каждые три уровня;\n— максимальный бонус к атаке для армии в походе – 3(условие только для девятого уровня);\n— повышает атаку армии в обороне на +1 за каждые два уровня;\n— максимальный бонус к атаке для армии в обороне – 5(условие только для девятого уровня); ";
        }

        public bool Interaction { get; set; }
        public int Level { get; set; }
        public bool CanLevelUp { get; set; }
        public string Description { get; set; }
        public int CostLevelUp { get; set; }


        public void LevelUp()
        {
            Level++;
            CostLevelUp = 750 * Level;
            if (Level >= MaxLevel)
                CanLevelUp = false;
        }
    }
}