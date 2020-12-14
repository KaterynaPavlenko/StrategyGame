namespace GameStrategy.Models.ArmyUnit
{
    public class Shooter
    {
        public static int Speed = 3;
        public static int Cost = 8;

        public static string Description =
            " Защита=3\n Атака=4\n Скорость на карте,инициатива в бою=3\n Время подготовки = 3 дня\n";

        public Shooter()
        {
            Shield = 3;
            Attack = 4;
            TimeTraining = 3;
            RecruitmentLevel = 1;
        }

        public static int Shield { get; set; }
        public static int Attack { get; set; }
        public int TimeTraining { get; set; }
        public int RecruitmentLevel { get; set; }
    }
}