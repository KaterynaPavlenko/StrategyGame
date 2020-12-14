using System.Collections.Generic;
using System.Drawing;
using System.IO;
using GameStrategy.Controller;
using GameStrategy.Entity;
using GameStrategy.Models.ArmyUnit;
using GameStrategy.Models.Buildings;

namespace GameStrategy.Models
{
    public class Castle : Building
    {
        public Barracks Barracks;
        private Image castleSprite;
        public Houses Houses;
        public Temple Temple;
        public TownHall TownHall;
        public Walls Walls;
        public Army ArmyInCastle;

        public IList<Task> tasks = new List<Task>
        {
            new Task(50, "Отнести свиток в деревню", 10), new Task(100, "Добыть дерева", 30),
            new Task(100, "Отнести древний камень владельцу", 15)
        };


        public Castle(int posY, int posX) : base(posY, posX)
        {
            Coins = 500;
            People = 100;
            Level = 1;
            LimitPeopleCount = 300;
            CastleHeight = MapController.cellSize;
            CastleWith = MapController.cellSize;
            castleSprite =
                new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "Sprites\\castle.png"));
            TownHall = new TownHall();
            Temple = new Temple();
            Barracks = new Barracks();
            Houses = new Houses();
            Walls = new Walls();
            ArmyInCastle=new Army();
        }

        public int CastleHeight { get; }
        public int CastleWith { get; }

        public Image CastleSprite
        {
            get => castleSprite;
            set
            {
                castleSprite = value;
                if (Interaction)
                    castleSprite =
                        new Bitmap(Path.Combine(
                            new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                            "Sprites\\castle_interaction.png"));
            }
        }

        public int Coins { get; set; }
        public int People { get; set; }
        public int LimitPeopleCount { get; set; }
        public int Level { get; set; }

        public void Draw(Graphics g)
        {
            g.DrawImage(castleSprite,
                new Rectangle(new Point(MapController.cellSize * posX, MapController.cellSize * posY),
                    new Size(CastleWith, CastleHeight)), 0,
                512, 512, 512, GraphicsUnit.Pixel);
        }

        public void GenerateResources()
        {
            if (People < LimitPeopleCount) People += 10;
        }

    }
}