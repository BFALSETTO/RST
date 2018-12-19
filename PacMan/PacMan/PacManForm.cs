using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
                picPacman.Image = Properties.Resources.Left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                picPacman.Image = Properties.Resources.Right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                picPacman.Image = Properties.Resources.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                picPacman.Image = Properties.Resources.down;
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
                picPacman.Left -= speed;
            }
            
            if (goRight)
            {
                picPacman.Left += speed;
            }
            
            if (goUp)
            {
                picPacman.Top -= speed;
            }

            if (goDown)
            {
                picPacman.Top += speed;
            }
            //player movements code end

            //moving the ghosts and bumping with the walls
            picRedGhost.Left += ghost1;
            picYellowGhost.Left += ghost2;

            //if the red ghost hits the wall then reverse speed
            if (picRedGhost.Bounds.IntersectsWith(picWall1.Bounds))
            {
                ghost1 = -ghost1;
            }
            //if the red ghost hits the wall then reverse speed
            if (picRedGhost.Bounds.IntersectsWith(picWall2.Bounds))
            {
                ghost1 = -ghost1;
            }
            //if the yellow ghost hits the wall then reverse speed
            if (picYellowGhost.Bounds.IntersectsWith(picWall1.Bounds))
            {
               ghost2 = -ghost2;
            }
            //if the yellow ghost hits the wall then reverse speed
            if (picYellowGhost.Bounds.IntersectsWith(picWall2.Bounds))
            {
                ghost2 = -ghost2;
            }

            //for loop to check walls ghosts and points
            foreach (Control atag in this.Controls)
            {
                if (atag is PictureBox && atag.Tag == "wall" || atag.Tag == "ghost")
                {
                    //checking if the player hits the wall or the ghost, them game over
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds) || score == 30)
                    {
                        picPacman.Left = 0;
                        picPacman.Top = 25;
                        label2.Text = "GAME OVER";
                        label2.Show();
                        tmrTimer.Stop();
                    }
                }
                if (atag is PictureBox && atag.Tag == "coin")
                {
                    //checking to see if the player hits the picturebox then add score
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        //remove the point
                        this.Controls.Remove(atag);
                        //add to the score
                        score++;
                    }
                }
            }//end the for loop for checking walls, points and ghosts

            //ghost 3 going crazy here
            picPinkGhost.Left += ghost3x;
            picPinkGhost.Top += ghost3y;

            if (picPinkGhost.Left < 1 ||
                picPinkGhost.Left + picPinkGhost.Width > ClientSize.Width - 2 ||
                (picPinkGhost.Bounds.IntersectsWith(picWall1.Bounds)) ||
                (picPinkGhost.Bounds.IntersectsWith(picWall2.Bounds)) ||
                (picPinkGhost.Bounds.IntersectsWith(picWall3.Bounds)) ||
                (picPinkGhost.Bounds.IntersectsWith(picWall4.Bounds))
                )
            {
                ghost3x = -ghost3x;
            }
            if (picPinkGhost.Top < 1 || picPinkGhost.Top + picPinkGhost.Height > ClientSize.Height - 2)
            {
                ghost3y = -ghost3y;
            }
            //end crazy ghost movements
        }

        private void PacManForm_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new frmSplashScreen());
        }
    }
}
