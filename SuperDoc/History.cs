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
using WMPLib;
using System.IO;

namespace SuperDoc
{
    public partial class History : Form
    {
        WindowsMediaPlayer Komiks;
        public History()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        public static int i = 1;

        private void History_Load(object sender, EventArgs e)
        {
            Komiks = new WindowsMediaPlayer();
            Komiks.URL = "Komiks.mp3";
            Komiks.settings.setMode("loop", true);
            Komiks.settings.volume = 20;
            Manual("click enter...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 GameForm = new Form1();
            GameForm.Show();
            Komiks.controls.stop();

        }
        public void History_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (i <= 8)
                {
                    i++;
                    Manual("click enter...");

                    if (i >= 8)
                    {
                        i = 8;
                        button2.Visible = true;
                        Manual("click MOUSE...");
                    }
                }
                if (File.Exists(i + ".png"))
                    this.BackgroundImage = Image.FromFile(i + ".png");
            }
        }
        private void Manual(string str)
        {
            lable1.Text = str;
            lable1.Location = new Point(20, 120);
            lable1.Visible = true;

            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("Pixel Cyr_1.ttf");

            lable1.Font = new Font(f.Families[0], 32);
        }
    }
}