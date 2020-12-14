using System.Drawing;
using System.IO;
using GameStrategy.Entity;

namespace GameStrategy.Models.Buildings
{
    public class Villages : Building
    {
        public Image sprite;
        public int spriteHeight;
        public int spriteWith;

        public Villages(int posY, int posX) : base(posY, posX)
        {
            spriteHeight = 379;
            spriteWith =  492;
            sprite = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                "Sprites\\village.png"));
        }


        public void DrawVillage(Graphics g)
        {
            g.DrawImage(sprite, new Rectangle(new Point(posX, posY), new Size(spriteWith, spriteHeight)), 0, 0,
                spriteWith, spriteHeight, GraphicsUnit.Pixel);
        }
    }
}