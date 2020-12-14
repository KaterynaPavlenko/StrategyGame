namespace GameStrategy.Models.ArmyUnit
{
    public class Recruit
    {
        public static int Speed = 1;
        public static int Cost = 2;

        public static string Description =
            " Защита=2\n Атака=2\n Скорость на карте,инициатива в бою=1\n Время подготовки = 1 день\n";

        public Recruit()
        {
            Shield = 2;
            Attack = 2;
            Speed = 1;
            TimeTraining = 1;
            Cost = 2;
        }

        public static int Shield { get; set; }
        public static int Attack { get; set; }
        public int TimeTraining { get; set; }
        public int RecruitmentLevel { get; set; }
    }
}