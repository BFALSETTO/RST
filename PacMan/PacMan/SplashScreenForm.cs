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
using System.Media;

namespace PacMan
{
    public partial class frmSplashScreen : Form
    {
        private SoundPlayer Sound = new SoundPlayer("pacman_beginning.wav");

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Loaded");
            Sound.Play();
        }
    }
}
