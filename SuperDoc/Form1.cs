using SuperDoc.Properties;
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
    public partial class Form1 : Form
    {
        public PictureBox[] cloud;
        int bgSpeed;
        public Random rnd;
        int playerSpeed;
        public PictureBox[] bullet;
        int bulSpeed;
        Point delta;
        
        public PictureBox[] enemies;
        int sizeEnemy;
        int enemySpeed;

        int score;
        int lvl;
        public PictureBox[] portals;
        int portSize;
        bool portalIsOpen;

        public static WindowsMediaPlayer GameSong;
        public WindowsMediaPlayer Rip;
        WindowsMediaPlayer Shoot;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgSpeed = 10;
            cloud = new PictureBox[20];
            rnd = new Random();
            playerSpeed = 10;
            delta = new Point(0, 0);

            bullet = new PictureBox[1];
            bulSpeed = 100;

            enemies = new PictureBox[4];
            sizeEnemy = rnd.Next(60,80);
            enemySpeed = 4;

            score = 0;
            lvl = 1;
            portals = new PictureBox[1];
            portalIsOpen = false;
            portSize = 180;      

            Image enemyIm = Image.FromFile("enemy.gif");
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = enemyIm;
                enemies[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 2000, rnd.Next(550, 750));

                this.Controls.Add(enemies[i]); 
            }

            GameSong = new WindowsMediaPlayer();
            GameSong.URL = "GameSong.mp3";
            GameSong.settings.setMode("loop", true);
            GameSong.settings.volume = 20;

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

            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(rnd.Next(-1000, 1280), rnd.Next(10, 100));
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

        public void Cloud_Tick(object sender, EventArgs e)
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

        private void LeftMove_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left > 10)
            {
                mainPlayer.Left -= playerSpeed;
            }
        }

        private void RightMove_Tick(object sender, EventArgs e)
        {
            mainPlayer.Left += playerSpeed;
        }

        private void UpMove_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Top > 540)
            {
                mainPlayer.Top -= playerSpeed;
            }
        }

        private void DownMove_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Top < 750)
            {
                mainPlayer.Top += playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (portalIsOpen)
                Teleport();
            mainPlayer.Image = Properties.Resources.fly;
            switch (e.KeyCode)
            {
                case Keys.A:
                    LeftMove.Start();
                    break;
                case Keys.D:
                    RightMove.Start();
                    break;
                case Keys.W:
                    UpMove.Start();
                    break;
                case Keys.S:
                    DownMove.Start();
                    break;
                case Keys.Escape:
                    int tEnemySpeed = enemySpeed;
                    enemySpeed = 0;
                    GameMenu gMenu = new GameMenu();
                    this.Hide();
                    gMenu.ShowDialog(this);
                    enemySpeed = tEnemySpeed;
                    break;
                default:
                    mainPlayer.Image = Properties.Resources.stay;
                    break;
            }

            if (e.KeyCode == Keys.Space)
            {
                mainPlayer.Image = Properties.Resources.fly;
                Deth();
                for (int i = 0; i < bullet.Length; i++)
                {
                    if (bullet[i].Left > 1280)
                    {
                        Shoot.controls.play();
                        bullet[i].Location = new Point(mainPlayer.Location.X + 5 + i * 5, mainPlayer.Location.Y + 30);
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (portalIsOpen)
                Teleport();
            mainPlayer.Image = Properties.Resources.stay;

            LeftMove.Stop();
            RightMove.Stop();
            UpMove.Stop();
            DownMove.Stop();
        }

        private void Shot_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullet.Length; i++)
            {
                bullet[i].Left += bulSpeed;
            }


        }

        private void enemyMove_Tick(object sender, EventArgs e)
        {
            MoveEnemis(enemies, enemySpeed);
        }
        
        public void MoveEnemis(PictureBox[] enemies, int speed)
        {
            Deth();

            for (int i = 0; i < enemies.Length;i++)
            {
                enemies[i].Left -= speed + (int)(Math.Cos(enemies[i].Left * Math.PI / 180) + Math.Sin(enemies[i].Left * Math.PI / 180));

                if(enemies[i].Left < this.Left)
                {
                    int sizeEnemy = rnd.Next(70, 90);
                    enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                    enemies[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 1400, rnd.Next(550, 750));
                }
            }
        }

        public void Deth()
        {
            for (int i = 0; i < enemies.Length;i++)
            {
                if (bullet[0].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    Rip.controls.play();
                    enemies[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 1400, rnd.Next(550, 750));
                    bullet[0].Location = new Point(2000, mainPlayer.Location.Y + 50);

                    score += 1;

                    if (score % 9 == 0)
                    {
                        lvl += 1;
                        
                       if(enemySpeed <= 15)
                       {
                        enemySpeed += 2;
                       }
                         if (lvl == 5)
                        {
                            enemySpeed = 0;
                            GameOver("move on");
                            enemies[1].Visible = false;
                            enemies[2].Visible = false;
                            enemies[3].Visible = false;
                            enemies[0].Visible = false;  

                            Image portal = Image.FromFile("portal.gif");
                            for (int a = 0; a < portals.Length; a++)
                            {
                                portals[a] = new PictureBox();
                                portals[a].Size = new Size(portSize, portSize);
                                portals[a].SizeMode = PictureBoxSizeMode.Zoom;
                                portals[a].BackColor = Color.Transparent;
                                portals[a].Image = portal;
                                portals[a].Location = new Point(1350, 610);

                                this.Controls.Add(portals[a]);
                                Teleport();

                            }
                            portalIsOpen = true;
                        }

                    }
                   
                }
                
                if(mainPlayer.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    mainPlayer.Image = Properties.Resources.die;
                    mainPlayer.Enabled = false;
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
            enemyMove.Stop();

            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("Pixel Cyr_1.ttf");

            label1.Font = new Font(f.Families[0], 80);
        }    

        public void Teleport()
        {
            for (int a = 0; a < portals.Length; a++)
            {
                if (mainPlayer.Bounds.IntersectsWith(portals[a].Bounds))
                {
                    this.Close();
                    Form2 secForm = new Form2();
                    secForm.Show();
                }
            }
        }
    }
}
