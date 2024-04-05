using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighting_Games
{
    public partial class Stage : UserControl
    {
        Player Hero;
        Player Hero2;
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        public static int width, height;
        bool upArrowDown, downArrowDown, leftArrowDown, rightArrowDown, kArrowDown;
        bool wArrowDown, sArrowDown, aArrowDown, dArrowDown, fArrowDown;
        List<Bullet> bullets = new List<Bullet>();
        int heroLives = 3;
        int heroLives2 = 3;

        public Stage()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            width = this.Width;
            height = this.Height;

            Hero = new Player(200, 300);
            Hero2 = new Player(596, 300);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //player1 Move
            int temp2x = Hero2.x;
            int temp2y = Hero2.y;

            if (upArrowDown)
            {
                Hero2.Move("up");
            }
            if (downArrowDown)
            {
                Hero2.Move("down");
            }
            if (leftArrowDown)
            {
                Hero2.Move("left");
            }
            if (rightArrowDown)
            {
                Hero2.Move("right");
            }
            if (kArrowDown)
            {
                Bullet b = new Bullet(0, 0, 0, 0, 0, 0);

                if (Hero2.facing == "up")
                {
                    b = new Bullet(Hero2.x, Hero2.y - 10, width, height, 0, -8);
                }
                else if (Hero2.facing == "down")
                {
                    b = new Bullet(Hero2.x, Hero2.y + 40, width, height, 0, 8);
                }
                else if (Hero2.facing == "right")
                {
                    b = new Bullet(Hero2.x + 40, Hero2.y, width, height, 8, 0);
                }
                else if (Hero2.facing == "left")
                {
                    b = new Bullet(Hero2.x - 10, Hero2.y, width, height, -8, 0);
                }

                bullets.Add(b);
            }

            if (Hero2.Collision(Hero))
            {
                Hero2.x = temp2x;
                Hero2.y = temp2y;
            }

            //player2 Move
            int tempx = Hero.x;
            int tempy = Hero.y;

            if (wArrowDown)
            {
                Hero.Move("up");
            }
            if (sArrowDown)
            {
                Hero.Move("down");
            }
            if (aArrowDown)
            {
                Hero.Move("left");
            }
            if (dArrowDown)
            {
                Hero.Move("right");
            }

            if (Hero.Collision(Hero2))
            {
                Hero.x = tempx;
                Hero.y = tempy;
            }

            if (fArrowDown)
            {
                Bullet b= new Bullet(0,0,0,0,0,0);

                if (Hero.facing == "up")
                {
                    b = new Bullet(Hero.x, Hero.y - 10, width, height, 0, -8);
                }
                else if (Hero.facing == "down")
                {
                    b = new Bullet(Hero.x, Hero.y + 40, width, height, 0, 8);
                }
                else if (Hero.facing == "right")
                {
                    b = new Bullet(Hero.x + 40, Hero.y, width, height, 8, 0);
                }
                else if (Hero.facing == "left")
                {
                    b = new Bullet(Hero.x - 10, Hero.y, width, height, -8, 0);
                }
                
                bullets.Add(b);
            }

            foreach (Bullet b in bullets)
            {
                b.bulletMove();
            }

            foreach (Bullet b in bullets)
            {
                if (Hero.collidesWith(b))
                {
                    heroLives--;
                }
                if (Hero2.collidesWith(b))
                {
                    heroLives2--;
                }
            }
            if (heroLives <= 0)
            {
                Application.Exit();
            }
            if (heroLives2 <= 0)
            {
                Application.Exit();
            }

            Refresh();
        }

        private void Stage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.K:
                    kArrowDown = true;
                    break;
                case Keys.W:
                    wArrowDown = true;
                    break;
                case Keys.S:
                    sArrowDown = true;
                    break;
                case Keys.A:
                    aArrowDown = true;
                    break;
                case Keys.D:
                    dArrowDown = true;
                    break;
                case Keys.F:
                    fArrowDown = true;
                    break;
            }
        }

        private void Stage_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.K:
                    kArrowDown= false;
                    break;
                case Keys.W:
                    wArrowDown = false;
                    break;
                case Keys.S:
                    sArrowDown = false;
                    break;
                case Keys.A:
                    aArrowDown = false;
                    break;
                case Keys.D:
                    dArrowDown = false;
                    break;
                case Keys.F:
                    fArrowDown= false;
                    break;
            }
        }
        private void Stage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, Hero.x, Hero.y, Hero.width, Hero.height);
            e.Graphics.FillRectangle(greenBrush, Hero2.x, Hero2.y, Hero.width, Hero.height);

            foreach (Bullet b in bullets)
            {
                e.Graphics.FillRectangle (redBrush, b.x, b.y, b.width, b.height);
            }
        }
    }
}
