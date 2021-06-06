namespace SuperDoc
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.mainPlayer3 = new System.Windows.Forms.PictureBox();
            this.Cloud3 = new System.Windows.Forms.Timer(this.components);
            this.LeftMove3 = new System.Windows.Forms.Timer(this.components);
            this.RightMove3 = new System.Windows.Forms.Timer(this.components);
            this.UpMove3 = new System.Windows.Forms.Timer(this.components);
            this.DownMove3 = new System.Windows.Forms.Timer(this.components);
            this.Shot3 = new System.Windows.Forms.Timer(this.components);
            this.enemyMove3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BossShot = new System.Windows.Forms.Timer(this.components);
            this.BossShoot = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPlayer3
            // 
            this.mainPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPlayer3.Image = global::SuperDoc.Properties.Resources.fly;
            this.mainPlayer3.Location = new System.Drawing.Point(40, 440);
            this.mainPlayer3.Name = "mainPlayer3";
            this.mainPlayer3.Size = new System.Drawing.Size(210, 230);
            this.mainPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPlayer3.TabIndex = 0;
            this.mainPlayer3.TabStop = false;
            // 
            // Cloud3
            // 
            this.Cloud3.Enabled = true;
            this.Cloud3.Interval = 10;
            this.Cloud3.Tick += new System.EventHandler(this.Cloud3_Tick);
            // 
            // LeftMove3
            // 
            this.LeftMove3.Interval = 10;
            this.LeftMove3.Tick += new System.EventHandler(this.LeftMove3_Tick);
            // 
            // RightMove3
            // 
            this.RightMove3.Interval = 10;
            this.RightMove3.Tick += new System.EventHandler(this.RightMove3_Tick);
            // 
            // UpMove3
            // 
            this.UpMove3.Interval = 10;
            this.UpMove3.Tick += new System.EventHandler(this.UpMove3_Tick);
            // 
            // DownMove3
            // 
            this.DownMove3.Interval = 10;
            this.DownMove3.Tick += new System.EventHandler(this.DownMove3_Tick);
            // 
            // Shot3
            // 
            this.Shot3.Enabled = true;
            this.Shot3.Interval = 20;
            this.Shot3.Tick += new System.EventHandler(this.Shot3_Tick);
            // 
            // enemyMove3
            // 
            this.enemyMove3.Enabled = true;
            this.enemyMove3.Interval = 10;
            this.enemyMove3.Tick += new System.EventHandler(this.enemyMove3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pixel Cyr", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(736, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 135);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // BossShot
            // 
            this.BossShot.Enabled = true;
            this.BossShot.Interval = 20;
            this.BossShot.Tick += new System.EventHandler(this.BossShot_Tick);
            // 
            // BossShoot
            // 
            this.BossShoot.Enabled = true;
            this.BossShoot.Interval = 1300;
            this.BossShoot.Tick += new System.EventHandler(this.BossShoot_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SuperDoc.Properties.Resources.LocThird;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPlayer3);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox mainPlayer3;
        private System.Windows.Forms.Timer Cloud3;
        private System.Windows.Forms.Timer LeftMove3;
        private System.Windows.Forms.Timer RightMove3;
        private System.Windows.Forms.Timer UpMove3;
        private System.Windows.Forms.Timer DownMove3;
        private System.Windows.Forms.Timer Shot3;
        private System.Windows.Forms.Timer enemyMove3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer BossShot;
        private System.Windows.Forms.Timer BossShoot;
    }
}