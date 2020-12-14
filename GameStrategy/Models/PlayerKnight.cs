using System.Drawing;
using System.IO;
using GameStrategy.Controller;
using GameStrategy.Entity;

namespace GameStrategy.Models
{
    public class PlayerKnight : Player
    {
        public Army Army;
        public Castle Castle;
        private Image playerSprite;

        public PlayerKnight(int posY, int posX, Castle castle) : base(posY, posX)
        {
            PlayerHeight = MapController.cellSize / 2;
            PlayerWith = MapController.cellSize / 2;
            playerSprite =
                new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "Sprites\\warrior spritesheet calciumtrice.png"));
            Castle = castle;
            Army = new Army();
        }

        public int PlayerHeight { get; }
        public int PlayerWith { get; }

        public Image PlayerSprite
        {
            get
            {
                if (Interaction)
                    playerSprite =
                        new Bitmap(Path.Combine(
                            new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                            "Sprites\\warrior spritesheet calciumtrice_interaction.png"));
                if (!Interaction)
                    playerSprite =
                        new Bitmap(Path.Combine(
                            new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                            "Sprites\\warrior spritesheet calciumtrice.png"));

                return playerSprite;
            }
            set => playerSprite = value;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(PlayerSprite,
                new Rectangle(new Point(MapController.cellSize * posX, MapController.cellSize * posY),
                    new Size(PlayerWith, PlayerHeight)), 0,
                0, 30, 30, GraphicsUnit.Pixel);
        }

        public void Move(int x, int y)
        {
            while (!stopMove(x, y))
            {
                Find(x, y);
                MapController.map[posX, posY] = 5;
                if (posX != lastPosX && posY != lastPosY)
                    MapController.map[lastPosX, lastPosY] = 1;
            }
        }
    }
}