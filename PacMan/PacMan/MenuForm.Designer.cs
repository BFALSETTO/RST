namespace PacMan
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblMenu.ForeColor = System.Drawing.Color.Yellow;
            this.lblMenu.Location = new System.Drawing.Point(124, 25);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(139, 31);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "PAC-MAN";
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.Black;
            this.btnLevel1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLevel1.FlatAppearance.BorderSize = 0;
            this.btnLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel1.ForeColor = System.Drawing.Color.Yellow;
            this.btnLevel1.Location = new System.Drawing.Point(154, 85);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(78, 30);
            this.btnLevel1.TabIndex = 1;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = false;
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.Black;
            this.btnLevel2.FlatAppearance.BorderSize = 0;
            this.btnLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.ForeColor = System.Drawing.Color.Yellow;
            this.btnLevel2.Location = new System.Drawing.Point(154, 135);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(78, 30);
            this.btnLevel2.TabIndex = 2;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = false;
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackColor = System.Drawing.Color.Black;
            this.btnLevel3.FlatAppearance.BorderSize = 0;
            this.btnLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLevel3.ForeColor = System.Drawing.Color.Yellow;
            this.btnLevel3.Location = new System.Drawing.Point(154, 185);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(78, 30);
            this.btnLevel3.TabIndex = 3;
            this.btnLevel3.Text = "Level 3";
            this.btnLevel3.UseVisualStyleBackColor = false;
            // 
            // btnCredits
            // 
            this.btnCredits.BackColor = System.Drawing.Color.Black;
            this.btnCredits.FlatAppearance.BorderSize = 0;
            this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCredits.ForeColor = System.Drawing.Color.Yellow;
            this.btnCredits.Location = new System.Drawing.Point(154, 235);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(78, 30);
            this.btnCredits.TabIndex = 4;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(387, 305);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.lblMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnCredits;
    }
}