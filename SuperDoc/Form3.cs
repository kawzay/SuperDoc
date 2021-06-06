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
    public partial class Form3 : Form
    {
        public PictureBox[] cloud;
        int bgSpeed;
        Random rnd;
        int playerSpeed;
        public PictureBox[] bullet;
        int bulSpeed;
        Point delta;

        public PictureBox[] bossGif;
        int bossSize;
        int bossSpeed;
        public PictureBox[] bossBullet;
        public int bossBulSpeed;

        int score;
        int lvl;
        public PictureBox[] portals;
        int portSize;
        bool portalIsOpen;
        bool isRunDown = false;

        WindowsMediaPlayer Rip;
        WindowsMediaPlayer Shoot;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bgSpeed = 10;
            cloud = new PictureBox[20];
            rnd = new Random();
            playerSpeed = 12;
            delta = new Point(0, 0);

            bullet = new PictureBox[2];
            bulSpeed = 100;

            bossGif = new PictureBox[1];
            bossSize = 300;
            bossSpeed = 2; //
            bossBullet = new PictureBox[2];
            bossBulSpeed = 50;

            score = 0;
            lvl = 1;
            portals = new PictureBox[1];
            portalIsOpen = false;
            portSize = 250;

            Image enemyIm = Image.FromFile("GifBoss.gif");
            for (int i = 0; i < bossGif.Length; i++)
            {
                bossGif[i] = new PictureBox();
                bossGif[i].Size = new Size(bossSize, bossSize);
                bossGif[i].SizeMode = PictureBoxSizeMode.Zoom;
                bossGif[i].BackColor = Color.Transparent;
                bossGif[i].Image = enemyIm;
                bossGif[i].Location = new Point(1200, 350);

                this.Controls.Add(bossGif[i]);
            }
            Rip = new WindowsMediaPlayer();
            Rip.URL = "Rip.mp3";
            Rip.settings.volume = 15;

            Shoot = new WindowsMediaPlayer();
            Shoot.URL = "Shoot.mp3";
            Shoot.settings.volume = 15;

            for (int i = 0; i < bullet.Length; i++)
            {
                bullet[i] = new PictureBox();
                bullet[i].BorderStyle = BorderStyle.None;
                bullet[i].Size = new Size(20, 5);
                bullet[i].BackColor = Color.White;

                this.Controls.Add(bullet[i]);
            }

            for (int i = 0; i < bossBullet.Length; i++)
            {
                bossBullet[i] = new PictureBox();
                bossBullet[i].BorderStyle = BorderStyle.None;
                bossBullet[i].Size = new Size(30, 10);
                bossBullet[i].BackColor = Color.White;

                this.Controls.Add(bossBullet[i]);
            }

            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(rnd.Next(-1000, 1280), rnd.Next(10, 300));
                if (i % 2 == 1)
                {
                    cloud[i].Size = new Size(rnd.Next(100, 225), rnd.Next(30, 70));
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200);
                }
                else
                {
                    cloud[i].Size = new Size(150, 25);
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 250, 200, 200);
                }
                this.Controls.Add(cloud[i]);
            }

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        public void Cloud3_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i].Left += bgSpeed;

                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Height;
                }
            }

            for (int i = cloud.Length; i < cloud.Length; i++)
            {
                cloud[i].Left += bgSpeed - 2;

                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Left;
                }
            }
        }

        private void LeftMove3_Tick(object sender, EventArgs e)
        {
            if (mainPlayer3.Left > 10)
            {
                mainPlayer3.Left -= playerSpeed;
            }
        }

        private void RightMove3_Tick(object sender, EventArgs e)
        {
            mainPlayer3.Left += playerSpeed;

        }

        private void UpMove3_Tick(object sender, EventArgs e)
        {
            if (mainPlayer3.Top > 100)
            {
                mainPlayer3.Top -= playerSpeed;
            }
        }

        private void DownMove3_Tick(object sender, EventArgs e)
        {
            if (mainPlayer3.Top < 700)
            {
                mainPlayer3.Top += playerSpeed;
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (portalIsOpen)
                Teleport();
            mainPlayer3.Image = Properties.Resources.fly;
            switch (e.KeyCode)
            {
                case Keys.A:
                    LeftMove3.Start();
                    break;
                case Keys.D:
                    RightMove3.Start();
                    break;
                case Keys.W:
                    UpMove3.Start();
                    break;
                case Keys.S:
                    DownMove3.Start();
                    break;
                case Keys.Escape:
                    int tBossSpeed = bossSpeed;
                    bossSpeed = 0;
                    GameMenu gMenu = new GameMenu();
                    this.Hide();
                    gMenu.ShowDialog(this);
                    bossSpeed = tBossSpeed;
                    break;
                default:
                    mainPlayer3.Image = Properties.Resources.stay;
                    break;
            }

            if (e.KeyCode == Keys.Space)
            {
                mainPlayer3.Image = Properties.Resources.fly;
                Deth();
                for (int i = 0; i < bullet.Length; i++)
                {
                    if (bullet[i].Left > 1280)
                    {
                        Shoot.controls.play();
                        bullet[i].Location = new Point(mainPlayer3.Location.X + 5 + i * 5, mainPlayer3.Location.Y + 30);
                    }
                }
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (portalIsOpen)
                Teleport();
            mainPlayer3.Image = Properties.Resources.stay;

            LeftMove3.Stop();
            RightMove3.Stop();
            UpMove3.Stop();
            DownMove3.Stop();
        }

        private void Shot3_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullet.Length; i++)
            {
                bullet[i].Left += bulSpeed;
            }
        }

        private void enemyMove3_Tick(object sender, EventArgs e)
        {
            MoveEnemis(bossGif, bossSpeed);
        }
        public void MoveEnemis(PictureBox[] bossGif, int bossSpeed)
        {
            Deth();

            for(int i = 0; i < bossGif.Length; i++)
            {
                if(bossGif[i].Top > this.Top && !isRunDown)                
                    bossGif[i].Top -= bossSpeed+3;                
                else if(bossGif[i].Top < 600)
                {
                    bossGif[i].Top += bossSpeed+3;
                    isRunDown = true;
                }
                else if (bossGif[i].Top == 600)
                {
                    bossGif[i].Top -= bossSpeed+3;
                    isRunDown = false;
                }              
            }
        }
        public void Deth()
        {
            for (int i = 0; i < bossGif.Length; i++)
            {
                if (bullet[0].Bounds.IntersectsWith(bossGif[i].Bounds))
                {
                    score += 1;
                    if (score % 13 == 0)
                    {
                        lvl += 1;     
                        if (lvl == 7)
                        {
                            bossSpeed = 0;
                            GameOver("move on");

                            bossGif[0].Visible = false;

                            Image portal = Image.FromFile("portal.gif");
                            for (int a = 0; a < portals.Length; a++)
                            {
                                portals[a] = new PictureBox();
                                portals[a].Size = new Size(portSize, portSize);
                                portals[a].SizeMode = PictureBoxSizeMode.Zoom;
                                portals[a].BackColor = Color.Transparent;
                                portals[a].Image = portal;
                                portals[a].Location = new Point(1350, 350);

                                this.Controls.Add(portals[a]);
                                Teleport();

                            }
                            portalIsOpen = true;
                        }

                    }

                }

                if (mainPlayer3.Bounds.IntersectsWith(bossGif[i].Bounds) || mainPlayer3.Bounds.IntersectsWith(bossBullet[i].Bounds))
                {
                    mainPlayer3.Image = Properties.Resources.die;
                    mainPlayer3.Enabled = false;
                    GameOver("Game Over");
                    DethForm DethF = new DethForm();
                    DethF.Show();
                    this.Close();

                }
            }
        }

        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(500, 90);
            label1.Visible = true;
            enemyMove3.Stop();

            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("Pixel Cyr_1.ttf");

            label1.Font = new Font(f.Families[0], 80);
        }

        public void Teleport()
        {
            for (int a = 0; a < portals.Length; a++)
            {
                if (mainPlayer3.Bounds.IntersectsWith(portals[a].Bounds))
                {
                    this.Close();
                    End endForm = new End();
                    endForm.Show();
                }
            }
        }

        public void BossShot_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bossBullet.Length; i++)
            {
                bossBullet[i].Left -= bossBulSpeed;
            }
        }

        public void BossShoot_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bossBullet.Length; i++)
            {
                if (bossBullet[i].Left < 1200)
                {
                    bossBullet[i].Location = new Point(bossGif[0].Location.X + 5 + i * 5, bossGif[0].Location.Y + 140);
                }
            }
            if(bossGif[0].Visible == false)
            {
                BossShoot.Stop();
            }
        }
    }
}
