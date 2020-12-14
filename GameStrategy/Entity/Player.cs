using System;
using GameStrategy.Controller;

namespace GameStrategy.Entity
{
    public class Player
    {
        public Player(int posY, int posX)
        {
            this.posX = posX;
            this.posY = posY;
            lastPosX = posX;
            lastPosY = posY;
            CountPositionToTarget = 0;
            Day = 1;
        }

        public int Day { get; set; }
        public int posY { get; set; }
        public int posX { get; set; }
        public int lastPosY { get; set; }
        public int lastPosX { get; set; }
        public bool Interaction { get; set; }
        public int CountPositionToTarget { get; set; }


        public void Move(int[,] map)
        {
            var coefficient = new int[8];
            coefficient[0] = map[posX + 1, posY + 1];
            coefficient[1] = map[posX, posY + 1];
            coefficient[2] = map[posX - 1, posY + 1];
            coefficient[3] = map[posX - 1, posY];
            coefficient[4] = map[posX - 1, posY - 1];
            coefficient[5] = map[posX, posY - 1];
            coefficient[6] = map[posX + 1, posY - 1];
            coefficient[7] = map[posX + 1, posY];
            var moveToX = -1;
            var moveToY = 0;
            for (var i = 0; i < 8; i++)
                if (coefficient[i] == -2)

                    coefficient[i] = 999;
            Array.Sort(coefficient);
            for (var x = posX - 1; x <= posY + 1; x++)
            for (var y = posX + 1; y >= posY - 1; y--)
                if (map[x, y] == coefficient[0])
                {
                    moveToX = x;
                    moveToY = y;
                    CountPositionToTarget++;
                }

            if (moveToX == -1 && moveToY == 0)
            {
                moveToY = posY;
                moveToX = posX;
            }

            lastPosX = posX;
            lastPosY = posY;
            posX = moveToX;
            posY = moveToY;
        }

        public void Find(int findX, int findY)
        {
            var map = new int[MapController.MapHeight, MapController.MapWith];
            int x, y, step = 0;
            for (x = 0; x < MapController.MapHeight; x++)
            for (y = 0; y < MapController.MapWith; y++)
                if (MapController.map[x, y] == 2 || MapController.map[x, y] == 5)
                    map[x, y] = -2;
                else map[x, y] = -1;
            var add = true;
            map[findX, findY] = 0;
            while (add)
            {
                add = false;
                for (x = 0; x < MapController.MapHeight; x++)
                for (y = 0; y < MapController.MapWith; y++)
                    if (map[x, y] == step)
                    {
                        if (y - 1 >= 0 && map[x, y - 1] != -2 && map[x, y - 1] == -1)
                            map[x, y - 1] = step + 1;
                        if (x - 1 >= 0 && map[x - 1, y] != -2 && map[x - 1, y] == -1)
                            map[x - 1, y] = step + 1;
                        if (y + 1 >= 0 && map[x, y + 1] != -2 && map[x, y + 1] == -1)
                            map[x, y + 1] = step + 1;
                        if (x + 1 >= 0 && map[x + 1, y] != -2 && map[x + 1, y] == -1)
                            map[x + 1, y] = step + 1;
                    }

                step++;
                add = true;
                if (map[posX, posY] > 0)
                    add = false;
                if (step > MapController.MapHeight * MapController.MapWith)
                    add = false;
            }

            Move(map);
        }

        public bool stopMove(int targetX, int targetY)
        {
            var move = false;
            for (var x = posX - 1; x <= posX + 1; x++)
            for (var y = posY + 1; y >= posY - 1; y--)
                if (x == targetX && y == targetY)
                    move = true;
            return move;
        }
    }
}