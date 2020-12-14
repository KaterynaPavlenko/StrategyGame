using System.Drawing;
using System.IO;
using GameStrategy.Controller;
using GameStrategy.Entity;
using GameStrategy.Models.ArmyUnit;

namespace GameStrategy.Models
{
    public class Bot : Player
    {
        private Image botSprite;
        public Castle Castle;
        public Army Army { get; set; }
        public int BotHeight { get; }
        public int BotWith { get; }
        public string Type { get; set; }
        public Bot(int posY, int posX, string type, Castle castle, Army army) : base(posY, posX)
        {
            BotHeight = MapController.cellSize / 2;
            BotWith = MapController.cellSize / 2;
            BotSprite =
                new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "Sprites\\PyromaniacOrc.png"));
            Interaction = false;
            Type = type;
            Castle = castle;
            Army = army;
        }

        public Image BotSprite
        {
            get
            {
                if (Interaction)
                    botSprite =
                        new Bitmap(Path.Combine(
                            new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                            "Sprites\\PyromaniacOrcInteraction.png"));
                if (!Interaction)
                    botSprite =
                        new Bitmap(Path.Combine(
                            new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                            "Sprites\\PyromaniacOrc.png"));

                return botSprite;
            }
            set => botSprite = value;
        }

        public void HireArmy()
        {
            var percent = (int) (Castle.Coins * (60.0f / 100.0f));
            while (Castle.Coins >= percent && Castle.Coins > 0)
            {
                AddCavalry(1);
                AddRecruit(1);
                AddInfantryman(1);
                AddShooter(1);
            }
        }

        public void LevelUpCastle()
        {
            if (Castle.Coins >= Castle.TownHall.CostLevelUp && Castle.TownHall.CanLevelUp)
            {
                Castle.TownHall.LevelUp();
                Castle.Coins -= Castle.TownHall.CostLevelUp;
            }

            if (Castle.Coins >= Castle.Houses.CostLevelUp && Castle.Houses.CanLevelUp)
            {
                Castle.Houses.LevelUp();
                Castle.Coins -= Castle.Houses.CostLevelUp;
            }

            if (Castle.Coins >= Castle.Temple.CostLevelUp && Castle.Temple.CanLevelUp)
            {
                Castle.Temple.LevelUp();
                Castle.Coins -= Castle.Temple.CostLevelUp;
            }

            if (Castle.Coins >= Castle.Walls.CostLevelUp && Castle.Walls.CanLevelUp)
            {
                Castle.Walls.LevelUp();
                Castle.Coins -= Castle.Walls.CostLevelUp;
            }

            if (Castle.Coins >= Castle.Barracks.CostLevelUp && Castle.Barracks.CanLevelUp)
            {
                Castle.Barracks.LevelUp();
                Castle.Coins -= Castle.Barracks.CostLevelUp;
            }
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(BotSprite,
                new Rectangle(new Point(MapController.cellSize * posX, MapController.cellSize * posY),
                    new Size(BotWith, BotHeight)), 0,
                0, 30, 30, GraphicsUnit.Pixel);
        }

        public void MoveDraw(Graphics g)
        {
            g.DrawImage(BotSprite,
                new Rectangle(new Point(MapController.cellSize * posX, MapController.cellSize * posY),
                    new Size(BotWith, BotHeight)), 0,
                0, 30, 30, GraphicsUnit.Pixel);
            MapController.map[posX, posY] = 5;
            if (posX != lastPosX && posY != lastPosY)
                MapController.map[lastPosX, lastPosY] = 1;
        }

        public void AddCavalry(int count)
        {
            if (Castle.Barracks.Level >= Cavalry.RecruitmentLevel)
                for (var i = 0; i < count; i++)
                {
                    Army.Cavalries.Add(new Cavalry());
                    Castle.Coins -= Cavalry.Cost;
                }
        }

        public void AddRecruit(int count)
        {
            for (var i = 0; i < count; i++)
            {
                Army.Recruits.Add(new Recruit());
                Castle.Coins -= Recruit.Cost;
            }
        }

        public void AddShooter(int count)
        {
            for (var i = 0; i < count; i++)
            {
                Army.Shooters.Add(new Shooter());
                Castle.Coins -= Shooter.Cost;
            }
        }

        public void AddInfantryman(int count)
        {
            if (Castle.Barracks.Level >= 4)
                for (var i = 0; i < count; i++)
                {
                    Army.Infantrymen.Add(new Infantryman());
                    Castle.Coins -= Infantryman.Cost;
                }
        }
    }
}