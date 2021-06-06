namespace SuperDoc
{
    partial class Menu
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
            this.gamestart = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PigMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gamestart
            // 
            this.gamestart.BackColor = System.Drawing.Color.Transparent;
            this.gamestart.BackgroundImage = global::SuperDoc.Properties.Resources.Start_game;
            this.gamestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamestart.Location = new System.Drawing.Point(372, 422);
            this.gamestart.Name = "gamestart";
            this.gamestart.Size = new System.Drawing.Size(577, 121);
            this.gamestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gamestart.TabIndex = 1;
            this.gamestart.TabStop = false;
            this.gamestart.Click += new System.EventHandler(this.gamestart_Click);
            this.gamestart.MouseLeave += new System.EventHandler(this.gamestart_MouseLeave);
            this.gamestart.MouseHover += new System.EventHandler(this.gamestart_MouseHover);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::SuperDoc.Properties.Resources.Exit;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Location = new System.Drawing.Point(1099, 775);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(234, 96);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SuperDoc.Properties.Resources.Ted;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1353, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 413);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PigMenu
            // 
            this.PigMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PigMenu.BackColor = System.Drawing.Color.Transparent;
            this.PigMenu.BackgroundImage = global::SuperDoc.Properties.Resources.PigMenu;
            this.PigMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PigMenu.Location = new System.Drawing.Point(33, 606);
            this.PigMenu.Name = "PigMenu";
            this.PigMenu.Size = new System.Drawing.Size(533, 382);
            this.PigMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PigMenu.TabIndex = 4;
            this.PigMenu.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SuperDoc.Properties.Resources.Слой_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2282, 1239);
            this.Controls.Add(this.PigMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.gamestart);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PigMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox gamestart;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PigMenu;
    }
}