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
    public partial class DethForm : Form
    {
        public DethForm()
        {
            InitializeComponent();
        }

        private void DethForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Rest_MouseHover(object sender, EventArgs e)
        {
            Rest.Image = Properties.Resources.RestartY;
        }

        private void mMenu_MouseHover(object sender, EventArgs e)
        {
            mMenu.Image = Properties.Resources.main_menuY;
        }

        private void mMenu_MouseLeave(object sender, EventArgs e)
        {
            Rest.Image = Properties.Resources.Restart;
        }

        private void Rest_MouseLeave(object sender, EventArgs e)
        {
            mMenu.Image = Properties.Resources.main_menu;
        }

        private void Rest_Click(object sender, EventArgs e)
        {
            Form1.GameSong.controls.stop();
            this.Close();
            Form1 DethF = new Form1();
            DethF.Show();
        }

        private void mMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menuD = new Menu();
            menuD.Show();
            Form1.GameSong.controls.stop();
        }
    }
}
