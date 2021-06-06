namespace SuperDoc
{
    partial class DethForm
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
            this.Rest = new System.Windows.Forms.PictureBox();
            this.mMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Rest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Rest
            // 
            this.Rest.BackColor = System.Drawing.Color.Transparent;
            this.Rest.Image = global::SuperDoc.Properties.Resources.Restart;
            this.Rest.Location = new System.Drawing.Point(583, 518);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(255, 64);
            this.Rest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rest.TabIndex = 0;
            this.Rest.TabStop = false;
            this.Rest.Click += new System.EventHandler(this.Rest_Click);
            this.Rest.MouseLeave += new System.EventHandler(this.Rest_MouseLeave);
            this.Rest.MouseHover += new System.EventHandler(this.Rest_MouseHover);
            // 
            // mMenu
            // 
            this.mMenu.BackColor = System.Drawing.Color.Transparent;
            this.mMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mMenu.Image = global::SuperDoc.Properties.Resources.main_menu;
            this.mMenu.Location = new System.Drawing.Point(1020, 775);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(311, 58);
            this.mMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mMenu.TabIndex = 1;
            this.mMenu.TabStop = false;
            this.mMenu.Click += new System.EventHandler(this.mMenu_Click);
            this.mMenu.MouseLeave += new System.EventHandler(this.mMenu_MouseLeave);
            this.mMenu.MouseHover += new System.EventHandler(this.mMenu_MouseHover);
            // 
            // DethForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SuperDoc.Properties.Resources.DethMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.mMenu);
            this.Controls.Add(this.Rest);
            this.Name = "DethForm";
            this.Text = "DethForm";
            this.Load += new System.EventHandler(this.DethForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Rest;
        private System.Windows.Forms.PictureBox mMenu;
    }
}