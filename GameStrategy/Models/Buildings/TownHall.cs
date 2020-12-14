using GameStrategy.Entity;

namespace GameStrategy.Models.Buildings
{
    public class TownHall : IBuildingsInCastle
    {
        private readonly int MaxLevel = 10;
        private readonly int MaxTaxPercentage = 28;

        public TownHall()
        {
            CostLevelUp = 200;
            Level = 1;
            TaxPercentage = 10;
            CanLevelUp = true;
            Description =
                "— приносит доход в виде 10% налога от количества людей в замке;\n— за каждый уровень(после первого) налог повышается на 2 %;\n— максимальное количество уровней – 10, максимальный налог – 28 %;\n— позволяет нанимать в армию войска – Рекрутов ";
        }

        public bool Interaction { get; set; }
        public int Level { get; set; }
        public bool CanLevelUp { get; set; }
        public string Description { get; set; }
        public int CostLevelUp { get; set; }

        public double TaxPercentage { get; set; }


        public void LevelUp()
        {
            Level++;
            CostLevelUp = 200 * Level;
            if (Level >= MaxLevel)
                CanLevelUp = false;
        }

        public int GetNewPeople(int countPeople)
        {
            if (TaxPercentage < MaxTaxPercentage)
                TaxPercentage += 2;
            return (int) (countPeople * (TaxPercentage / 100));
        }
    }
}