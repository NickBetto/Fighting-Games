using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_Games
{
    internal class Bullet
    {
        public int x, y;
        public int width = 10;
        public int height = 10;
        public int xSpeed, ySpeed;


        public Bullet(int x, int y, int width, int height, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public void bulletMove()
        {
            x += xSpeed;
            y += ySpeed;
        }
    }
}
