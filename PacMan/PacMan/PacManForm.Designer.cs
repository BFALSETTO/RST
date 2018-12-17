namespace PacMan
{
    partial class PacManForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            this.SuspendLayout();
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.MidnightBlue;
            this.picWall1.Location = new System.Drawing.Point(171, 58);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(33, 162);
            this.picWall1.TabIndex = 0;
            this.picWall1.TabStop = false;
            this.picWall1.Tag = "wall";
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.MidnightBlue;
            this.picWall3.Location = new System.Drawing.Point(69, 323);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(33, 162);
            this.picWall3.TabIndex = 1;
            this.picWall3.TabStop = false;
            this.picWall3.Tag = "wall";
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.MidnightBlue;
            this.picWall4.Location = new System.Drawing.Point(387, 323);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(33, 162);
            this.picWall4.TabIndex = 2;
            this.picWall4.TabStop = false;
            this.picWall4.Tag = "wall";
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.MidnightBlue;
            this.picWall2.Location = new System.Drawing.Point(477, 58);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(33, 162);
            this.picWall2.TabIndex = 3;
            this.picWall2.TabStop = false;
            this.picWall2.Tag = "wall";
            // 
            // redGhost
            // 
            this.redGhost.Location = new System.Drawing.Point(210, 116);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(36, 38);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 4;
            this.redGhost.TabStop = false;
            // 
            // yellowGhost
            // 
            this.yellowGhost.Location = new System.Drawing.Point(108, 383);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(36, 38);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 5;
            this.yellowGhost.TabStop = false;
            // 
            // pinkGhost
            // 
            this.pinkGhost.Location = new System.Drawing.Point(426, 383);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(36, 38);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 6;
            this.pinkGhost.TabStop = false;
            // 
            // pacman
            // 
            this.pacman.Image = global::PacMan.Properties.Resources.Left;
            this.pacman.Location = new System.Drawing.Point(136, 262);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(40, 40);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 7;
            this.pacman.TabStop = false;
            // 
            // PacManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 531);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall1);
            this.Name = "PacManForm";
            this.Text = "PACMAN";
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox redGhost;
        private System.Windows.Forms.PictureBox yellowGhost;
        private System.Windows.Forms.PictureBox pinkGhost;
        private System.Windows.Forms.PictureBox pacman;
    }
}

