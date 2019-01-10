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
    //PacMan PacManForm = new Form();
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
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
        }

        public void SplashStart()
        {
            Application.Run(new frmSplashScreen());
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            Form frmPacMan = new frmPacMan();
            this.Hide();
            frmPacMan.ShowDialog();
            this.Close();
        }
    }
}
