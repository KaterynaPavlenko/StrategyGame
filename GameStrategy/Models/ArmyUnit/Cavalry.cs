namespace GameStrategy.Models.ArmyUnit
{
    public class Cavalry
    {
        public static int Speed = 3;
        public static int Cost = 48;

        public static string Description =
            " Защита=7\n Атака=20\n Скорость на карте,инициатива в бою=3\n Время подготовки = 4 день\n";

        public Cavalry()
        {
            Shield = 7;
            Attack = 20;
            TimeTraining = 4;
            RecruitmentLevel = 7;
        }

        public static int Shield { get; set; }
        public static int Attack { get; set; }
        public int TimeTraining { get; set; }
        public static int RecruitmentLevel { get; set; }
    }
}