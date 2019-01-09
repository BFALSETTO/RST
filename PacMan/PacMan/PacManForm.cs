using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//need threading for Thread.Sleep for my splash screen
using System.Threading;
//need media for SoundPlayer
using System.Media;

namespace PacMan
{
    public partial class PacManForm : Form
    {
        List<PictureBox> listOfPictureBoxes = new List<PictureBox>();

        //create the sound player
        private SoundPlayer BackgroundMusic;

        //delcare and initialize variables
        bool goUp = false, goDown = false, goLeft = false, goRight = false;

        int speed = 8;

        //ghost 1 and 2 variables 
        int ghost1 = 8;
        int ghost2 = 8;

        //ghost3 variables
        int ghost3x = 8;
        int ghost3y = 8;

        //score variable
        int score = 0;

        public PacManForm()
        {
            InitializeComponent();
            
            //load sounds and make certain objects invisible
            lblGameOver.Visible = false;
            BackgroundMusic = new SoundPlayer("Background Theme.wav");
            Console.WriteLine("***Sound Loaded");
            picUnmute.Hide();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("***keyisdown called");

            //if the left arrow key is pressed:
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                //set goLeft = true
                goLeft = true;
                //change the image to the pacman moving left
                picPacman.Image = Properties.Resources.zachleft;
            }

            //if the right arrow key is pressed:
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
<<<<<<< HEAD
                Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
=======
                Console.WriteLine("***Keys.Right is pressed");

>>>>>>> 12c05efc610ebffc45446753a746aed3c7710c67
                goRight = true;
                picPacman.Image = Properties.Resources.zachright;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                goUp = true;
                picPacman.Image = Properties.Resources.zachup;
            }

            if (e.KeyCode == Keys.Down|| e.KeyCode == Keys.S)
            {
                Console.WriteLine("***Keys." + e.KeyCode + " is pressed");
                goDown = true;
                picPacman.Image = Properties.Resources.zachdown;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }
        }

        private void picMute_Click(object sender, EventArgs e)
        {
            BackgroundMusic.Stop();
            picMute.Hide();
            picUnmute.Show();
        }

        private void picUnmute_Click(object sender, EventArgs e)
        {
            BackgroundMusic.Play();
            picUnmute.Hide();
            picMute.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("***timer1_Tick called");
            //show the score on the board
            lblScore.Text = "Score: " + score;

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
            if (picRedGhost.Bounds.IntersectsWith(picWall3.Bounds))
            {
                ghost1 = -ghost1;
            }
            if (picRedGhost.Bounds.IntersectsWith(picWall4.Bounds))
            {
                ghost1 = -ghost1;
            }
            //if the yellow ghost hits the wall then reverse speed
            if (picYellowGhost.Bounds.IntersectsWith(picWall1.Bounds))
            {
               ghost2 = -ghost2;
            }
            if (picYellowGhost.Bounds.IntersectsWith(picWall2.Bounds))
            {
                ghost2 = -ghost2;
            }
            //if the yellow ghost hits the wall then reverse speed
            if (picYellowGhost.Bounds.IntersectsWith(picWall3.Bounds))
            {
                ghost2 = -ghost2;
            }
            if (picYellowGhost.Bounds.IntersectsWith(picWall4.Bounds))
            {
                ghost2 = -ghost2;
            }

            //for loop to check walls ghosts and points
            foreach (Control atag in this.Controls)
            {
                if (atag is PictureBox && atag.Tag == "ghost")
                {
                    //checking if the player hits the wall or the ghost, them game over
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        int indexToRemove;
                        Random rndNumGen = new Random();

                        picPacman.Left = 0;
                        picPacman.Top = 25;
                        lblGameOver.Text = "GAME OVER";
                        lblGameOver.Show();
                        tmrTimer.Stop();
                        picPacman.Hide();
                        picMute.Hide();
                        picUnmute.Hide();
                        BackgroundMusic.Stop();

                        //for (int counter = 0)
                        while (listOfPictureBoxes.Count() > 0)
                        {
                            string tmpPicString;
                            PictureBox tmpPicBox;
                            indexToRemove = rndNumGen.Next(0, listOfPictureBoxes.Count());
                            tmpPicBox = listOfPictureBoxes.ElementAt(indexToRemove);
                            tmpPicString = tmpPicBox.Name;
                            Console.WriteLine("Name of picture to be removed: " + tmpPicString);
                            tmpPicBox.Hide();
                            listOfPictureBoxes.RemoveAt(indexToRemove);
                            Thread.Sleep(200);
                        }
                        Thread.Sleep(200);
                        picCoin13.Hide();
                    }
                    if (score == 30)
                    {
                        picPacman.Left = 0;
                        picPacman.Top = 25;
                        lblGameOver.Text = "YOU WIN!";
                        lblGameOver.Show();
                        tmrTimer.Stop();
                        picPacman.Hide();
                        picMute.Hide();
                        picUnmute.Hide();
                        BackgroundMusic.Stop();
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
                        Console.WriteLine("***Score is " + score);
                        Console.WriteLine(atag.Name);
                        listOfPictureBoxes.Remove((PictureBox)atag);
                        Console.WriteLine("***listOfPictureBoxes.Count is " + listOfPictureBoxes.Count());                        

                    }
                }
                if (atag is PictureBox && atag.Tag == "noMansLandTop")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Top += speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "noMansLandRight")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Left -= speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "noMansLandBottom")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Top -= speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "noMansLandLeft")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Left += speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "wallLeft")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Left -= speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "wallTop")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Top -= speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "wallRight")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Left += speed;
                    }
                }
                if (atag is PictureBox && atag.Tag == "wallBottom")
                {
                    if (((PictureBox)atag).Bounds.IntersectsWith(picPacman.Bounds))
                    {
                        picPacman.Top += speed;
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
            Console.WriteLine("Waiting for 5 seconds");
            Thread.Sleep(1000);
            Console.WriteLine("Waiting for 4 seconds");
            Thread.Sleep(1000);
            Console.WriteLine("Waiting for 3 seconds");
            Thread.Sleep(1000);
            Console.WriteLine("Waiting for 2 seconds");
            Thread.Sleep(1000);
            Console.WriteLine("Waiting for 1 second");
            Thread.Sleep(1000);
            Console.WriteLine("Loading main menu");
            Console.WriteLine("Populating listOfPictureBoxes with each picturebox");
            //populating the list with all the coins
            t.Abort();
            PopulateList();
            BackgroundMusic.Play();
        }

        public void SplashStart()
        {
            Application.Run(new frmSplashScreen());
        }

        public void PopulateList()
        {
            listOfPictureBoxes.Add(picCoin1);
            listOfPictureBoxes.Add(picCoin2);
            listOfPictureBoxes.Add(picCoin3);
            listOfPictureBoxes.Add(picCoin4);
            listOfPictureBoxes.Add(picCoin5);
            listOfPictureBoxes.Add(picCoin6);
            listOfPictureBoxes.Add(picCoin7);
            listOfPictureBoxes.Add(picCoin8);
            listOfPictureBoxes.Add(picCoin9);
            listOfPictureBoxes.Add(picCoin10);
            listOfPictureBoxes.Add(picCoin11);
            listOfPictureBoxes.Add(picCoin12);
            listOfPictureBoxes.Add(picCoin12);
            listOfPictureBoxes.Add(picCoin14);
            listOfPictureBoxes.Add(picCoin15);
            listOfPictureBoxes.Add(picCoin16);
            listOfPictureBoxes.Add(picCoin17);
            listOfPictureBoxes.Add(picCoin18);
            listOfPictureBoxes.Add(picCoin19);
            listOfPictureBoxes.Add(picCoin20);
            listOfPictureBoxes.Add(picCoin21);
            listOfPictureBoxes.Add(picCoin22);
            listOfPictureBoxes.Add(picCoin23);
            listOfPictureBoxes.Add(picCoin24);
            listOfPictureBoxes.Add(picCoin25);
            listOfPictureBoxes.Add(picCoin26);
            listOfPictureBoxes.Add(picCoin27);
            listOfPictureBoxes.Add(picCoin28);
            listOfPictureBoxes.Add(picCoin29);
            listOfPictureBoxes.Add(picCoin30);
        }
    }
}
