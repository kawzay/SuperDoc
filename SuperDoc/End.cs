using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperDoc
{
    public partial class End : Form
    {
        public static int i = 9;
        public End()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        public void End_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (i <= 11)
                {
                    ManualEnd("click enter...");
                    i++;

                    if (i >= 11)
                    {
                        i = 11;
                        button2.Visible = true;
                        ManualEnd("click MOUSE...");
                    }
                }
                this.BackgroundImage = Image.FromFile(i + ".png");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mMenu = new Menu();
            mMenu.Show();
            Form1.GameSong.controls.stop();
        }
        private void ManualEnd(string str)
        {
            lable2.Text = str;
            lable2.Location = new Point(20, 120);
            lable2.Visible = true;

            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("Pixel Cyr_1.ttf");

            lable2.Font = new Font(f.Families[0], 32);
        }

        private void End_Load(object sender, EventArgs e)
        {
            ManualEnd("click enter...");
        }
    }
}
