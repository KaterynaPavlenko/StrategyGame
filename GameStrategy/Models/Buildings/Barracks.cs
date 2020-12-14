using GameStrategy.Entity;

namespace GameStrategy.Models.Buildings
{
    public class Barracks : IBuildingsInCastle
    {
        private readonly int MaxLevel = 10;

        public Barracks()
        {
            CostLevelUp = 300;
            Level = 1;
            CanLevelUp = true;
            Description =
                "— позволяют тренировать войска, максимальный уровень – 10;\n— на первом уровне позволяют нанимать в армию войска – Стрелков;\n— на втором и третье уровнях ускоряет наём Стрелков на 1 ход за каждый уровень;\n— на четвертом уровне позволяет нанимать в армию войска – Пехоту;\n— на пятом и шестом уровнях ускоряет наём Пехоты на 1 ход за каждый уровень;\n— на седьмом уровне позволяет нанимать в армию войска – Кавалерию; ";
        }

        public bool Interaction { get; set; }
        public int Level { get; set; }
        public bool CanLevelUp { get; set; }
        public string Description { get; set; }
        public int CostLevelUp { get; set; }


        public void LevelUp()
        {
            Level++;
            CostLevelUp = 300 * Level;
            if (Level >= MaxLevel)
                CanLevelUp = false;
        }
    }
}