namespace SuperDoc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Cloud = new System.Windows.Forms.Timer(this.components);
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.LeftMove = new System.Windows.Forms.Timer(this.components);
            this.RightMove = new System.Windows.Forms.Timer(this.components);
            this.UpMove = new System.Windows.Forms.Timer(this.components);
            this.DownMove = new System.Windows.Forms.Timer(this.components);
            this.Shot = new System.Windows.Forms.Timer(this.components);
            this.enemyMove = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DethT = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Cloud
            // 
            this.Cloud.Enabled = true;
            this.Cloud.Interval = 10;
            this.Cloud.Tick += new System.EventHandler(this.Cloud_Tick);
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = global::SuperDoc.Properties.Resources.stay;
            this.mainPlayer.Location = new System.Drawing.Point(175, 800);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(210, 230);
            this.mainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            // 
            // LeftMove
            // 
            this.LeftMove.Interval = 10;
            this.LeftMove.Tick += new System.EventHandler(this.LeftMove_Tick);
            // 
            // RightMove
            // 
            this.RightMove.Interval = 10;
            this.RightMove.Tick += new System.EventHandler(this.RightMove_Tick);
            // 
            // UpMove
            // 
            this.UpMove.Interval = 10;
            this.UpMove.Tick += new System.EventHandler(this.UpMove_Tick);
            // 
            // DownMove
            // 
            this.DownMove.Interval = 10;
            this.DownMove.Tick += new System.EventHandler(this.DownMove_Tick);
            // 
            // Shot
            // 
            this.Shot.Enabled = true;
            this.Shot.Interval = 20;
            this.Shot.Tick += new System.EventHandler(this.Shot_Tick);
            // 
            // enemyMove
            // 
            this.enemyMove.Enabled = true;
            this.enemyMove.Interval = 10;
            this.enemyMove.Tick += new System.EventHandler(this.enemyMove_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pixel Cyr", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(561, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 135);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::SuperDoc.Properties.Resources.cyberpunk_street1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPlayer);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SuperDoc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Cloud;
        public System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer RightMove;
        private System.Windows.Forms.Timer DownMove;
        private System.Windows.Forms.Timer Shot;
        private System.Windows.Forms.Timer enemyMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer LeftMove;
        private System.Windows.Forms.Timer UpMove;
        private System.Windows.Forms.Timer DethT;
    }
}

