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
    public partial class MenuScreen : UserControl
    {

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void gameButton1_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Stage());
        }

        private void gameButton2_Click(object sender, EventArgs e)
        {

        }

        private void gameButton3_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
