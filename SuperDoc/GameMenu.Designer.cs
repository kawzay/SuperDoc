namespace SuperDoc
{
    partial class GameMenu
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
            this.Continue = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.PictureBox();
            this.exitGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitGame)).BeginInit();
            this.SuspendLayout();
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.Image = global::SuperDoc.Properties.Resources._continue;
            this.Continue.Location = new System.Drawing.Point(1294, 461);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(377, 56);
            this.Continue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Continue.TabIndex = 0;
            this.Continue.TabStop = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            this.Continue.MouseLeave += new System.EventHandler(this.Continue_MouseLeave);
            this.Continue.MouseHover += new System.EventHandler(this.Continue_MouseHover);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Image = global::SuperDoc.Properties.Resources.main_menu;
            this.MainMenu.Location = new System.Drawing.Point(673, 741);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(381, 52);
            this.MainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainMenu.TabIndex = 1;
            this.MainMenu.TabStop = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            this.MainMenu.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            this.MainMenu.MouseHover += new System.EventHandler(this.MainMenu_MouseHover);
            // 
            // exitGame
            // 
            this.exitGame.BackColor = System.Drawing.Color.Transparent;
            this.exitGame.Image = global::SuperDoc.Properties.Resources.Exit2;
            this.exitGame.Location = new System.Drawing.Point(1644, 897);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(161, 63);
            this.exitGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitGame.TabIndex = 2;
            this.exitGame.TabStop = false;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            this.exitGame.MouseLeave += new System.EventHandler(this.exitGame_MouseLeave);
            this.exitGame.MouseHover += new System.EventHandler(this.exitGame_MouseHover);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SuperDoc.Properties.Resources.GameMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Continue);
            this.DoubleBuffered = true;
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Continue;
        private System.Windows.Forms.PictureBox MainMenu;
        private System.Windows.Forms.PictureBox exitGame;
    }
}