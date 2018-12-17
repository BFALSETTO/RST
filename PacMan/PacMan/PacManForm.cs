using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class PacManForm : Form
    {
        //delcare and initialize variables
        bool goUp, goDown, goLeft, goRight;

        int speed = 5;

        //ghost 1 and 2 variables 
        int ghost1 = 8;
        int ghost2 = 8;

        //ghost3 variables
        int ghost3x = 8;
        int ghost3y = 8;

        int score = 0;

        public PacManForm()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                pacman.Image = Properties.Resources.Left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                pacman.Image = Properties.Resources.Right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                pacman.Image = Properties.Resources.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                pacman.Image = Properties.Resources.down;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //show the score on the board
            label1.Text = "Score: " + score;

            //player movement code start
            if (goLeft)
            {
                //move the player to the left
                pacman.Left -= speed;
            }
            
            if (goRight)
            {
                pacman.Left += speed;
            }
            
            if (goUp)
            {
                pacman.Top -= speed;
            }

            if (goDown)
            {
                pacman.Top += speed;
            }
            //player movements code end
        }

        private void PacManForm_Load(object sender, EventArgs e)
        {

        }
    }
}
