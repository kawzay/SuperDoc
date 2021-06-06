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
    public partial class GameMenu : Form
    {

        public GameMenu()
        {
            InitializeComponent();
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Continue_MouseHover(object sender, EventArgs e)
        {
            Continue.Image = Properties.Resources.continueY;
        }

        private void MainMenu_MouseHover(object sender, EventArgs e)
        {
            MainMenu.Image = Properties.Resources.main_menuY;
        }

        private void exitGame_MouseHover(object sender, EventArgs e)
        {
            exitGame.Image = Properties.Resources.ExitY;
        }

        private void Continue_MouseLeave(object sender, EventArgs e)
        {
            Continue.Image = Properties.Resources._continue;
        }

        private void MainMenu_MouseLeave(object sender, EventArgs e)
        {
            MainMenu.Image = Properties.Resources.main_menu;
        }

        private void exitGame_MouseLeave(object sender, EventArgs e)
        {
            exitGame.Image = Properties.Resources.Exit2;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form1.GameSong.controls.stop();
            this.Hide();
            Owner.Hide();
            Menu menuF = new Menu();
            menuF.Show();
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
