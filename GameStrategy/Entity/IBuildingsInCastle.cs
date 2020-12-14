namespace GameStrategy.Entity
{
    public interface IBuildingsInCastle
    {
         bool Interaction { get; set; }
         int Level { get; set; }
         bool CanLevelUp { get; set; }
         string Description { get; set; }
         int CostLevelUp { get; set; }

        
    }
}