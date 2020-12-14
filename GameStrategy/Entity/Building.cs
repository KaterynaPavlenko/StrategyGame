namespace GameStrategy.Entity
{
    public class Building
    {
        public Building(int posY, int posX)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public int posY { get; set; }
        public int posX { get; set; }
        public bool Interaction { get; set; }
    }
}