using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SuperDoc
{
    public partial class Menu : Form
    {
        WindowsMediaPlayer MenuSound;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            MenuSound = new WindowsMediaPlayer();
            MenuSound.URL = "MENU.mp3";
            MenuSound.settings.setMode("loop", true);
            MenuSound.settings.volume = 20;

        }

        private void gamestart_MouseHover(object sender, EventArgs e)
        {
            gamestart.Image = Properties.Resources.Start_game1;
        }



        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.Exit3;
        }

        private void gamestart_MouseLeave(object sender, EventArgs e)
        {
            gamestart.Image = Properties.Resources.Start_game;
        }


        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.Exit;
        }

        private void gamestart_Click(object sender, EventArgs e)
        {
            MenuSound.controls.stop();
            this.Hide();
            History history = new History();
            history.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
