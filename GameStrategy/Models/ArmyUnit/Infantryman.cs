namespace GameStrategy.Models.ArmyUnit
{
    public class Infantryman
    {
        public static int Speed = 1;
        public static int Cost = 20;

        public static string Description =
            " Защита=6\n Атака=8\n Скорость на карте,инициатива в бою=1\n Время подготовки = 3 дня\n";

        public Infantryman()
        {
            Shield = 6;
            Attack = 8;
            TimeTraining = 3;
            RecruitmentLevel = 4;
        }

        public static int Shield { get; set; }
        public static int Attack { get; set; }
        public int TimeTraining { get; set; }
        public int RecruitmentLevel { get; set; }
    }
}