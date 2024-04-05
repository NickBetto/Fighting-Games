using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fighting_Games
{
    internal class Player
    {
        public int x, y;
        public int width = 30;
        public int height = 30;
        public int speed = 6;
        public string facing;

        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(string direction)
        {
            if (direction == "up")
            {
                if (y > 20)
                {
                    y -= speed;
                }
            }
            if (direction == "down")
            {
                if (y < Stage.height - 50)
                {
                    y += speed;
                }
            }
            if (direction == "left")
            {
                if (x > 10)
                {
                    x -= speed;
                }
            }
            if (direction == "right")
            {
                if (x < Stage.width - 40)
                {
                    x += speed;
                }
            }
            facing = direction;
        }

        public bool Collision(Player p)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle player2Rec = new Rectangle(p.x, p.y, p.width, p.height);

            if (playerRec.IntersectsWith(player2Rec))
            {
                return true;
            }
            return false;
        }

        public bool collidesWith(Bullet b)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle bulletRec = new Rectangle(b.x, b.y, b.width, b.height);

            if (playerRec.IntersectsWith(bulletRec))
            {
                return true;
            }
            return false;
        }

    }
}
