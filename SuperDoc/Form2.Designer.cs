namespace SuperDoc
{
    partial class Form2
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
            this.Cloud2 = new System.Windows.Forms.Timer(this.components);
            this.mainPlayer2 = new System.Windows.Forms.PictureBox();
            this.LeftMove2 = new System.Windows.Forms.Timer(this.components);
            this.RightMove2 = new System.Windows.Forms.Timer(this.components);
            this.UpMove2 = new System.Windows.Forms.Timer(this.components);
            this.DownMove2 = new System.Windows.Forms.Timer(this.components);
            this.Shot2 = new System.Windows.Forms.Timer(this.components);
            this.enemyMove2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // Cloud2
            // 
            this.Cloud2.Enabled = true;
            this.Cloud2.Interval = 10;
            this.Cloud2.Tick += new System.EventHandler(this.Cloud2_Tick);
            // 
            // mainPlayer2
            // 
            this.mainPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPlayer2.Image = global::SuperDoc.Properties.Resources.stay;
            this.mainPlayer2.Location = new System.Drawing.Point(118, 766);
            this.mainPlayer2.Name = "mainPlayer2";
            this.mainPlayer2.Size = new System.Drawing.Size(210, 230);
            this.mainPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPlayer2.TabIndex = 0;
            this.mainPlayer2.TabStop = false;
            // 
            // LeftMove2
            // 
            this.LeftMove2.Interval = 5;
            this.LeftMove2.Tick += new System.EventHandler(this.LeftMove2_Tick);
            // 
            // RightMove2
            // 
            this.RightMove2.Interval = 5;
            this.RightMove2.Tick += new System.EventHandler(this.RightMove2_Tick);
            // 
            // UpMove2
            // 
            this.UpMove2.Interval = 5;
            this.UpMove2.Tick += new System.EventHandler(this.UpMove2_Tick);
            // 
            // DownMove2
            // 
            this.DownMove2.Interval = 5;
            this.DownMove2.Tick += new System.EventHandler(this.DownMove2_Tick);
            // 
            // Shot2
            // 
            this.Shot2.Enabled = true;
            this.Shot2.Interval = 5;
            this.Shot2.Tick += new System.EventHandler(this.Shot2_Tick);
            // 
            // enemyMove2
            // 
            this.enemyMove2.Enabled = true;
            this.enemyMove2.Interval = 10;
            this.enemyMove2.Tick += new System.EventHandler(this.enemyMove2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pixel Cyr", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(612, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 135);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::SuperDoc.Properties.Resources.LocSec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPlayer2);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Cloud2;
        public System.Windows.Forms.PictureBox mainPlayer2;
        private System.Windows.Forms.Timer LeftMove2;
        private System.Windows.Forms.Timer RightMove2;
        private System.Windows.Forms.Timer UpMove2;
        private System.Windows.Forms.Timer DownMove2;
        private System.Windows.Forms.Timer Shot2;
        private System.Windows.Forms.Timer enemyMove2;
        private System.Windows.Forms.Label label1;
    }
}