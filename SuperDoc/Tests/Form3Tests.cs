using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperDoc.Tests
{
    [TestClass]
    public class Form3Tests
    {
        [TestMethod]
        public void BossShoot_Tick_WhenDefault_Return()
        {
            var form = new Form3();
            form.bossBullet = new PictureBox[] { new PictureBox() };
            form.bossGif = new PictureBox[] { new PictureBox() };
            form.BossShoot_Tick(null, null);
        }
        [TestMethod]
        public void BossShoot_Tick_WhenBossGifNotVisible_Return()
        {
            var form = new Form3();
            form.bossBullet = new PictureBox[] { new PictureBox() };
            var pb = new PictureBox();
            pb.Visible = false;
            form.bossGif = new PictureBox[] { pb };
            form.BossShoot_Tick(null, null);
        }
        [TestMethod]
        public void BossShot_Tick_Default_Return()
        {
            var form = new Form3();
            form.bossBulSpeed = 40;
            var pb = new PictureBox();
            pb.Left = 0;
            form.bossBullet = new PictureBox[] { pb };
            form.BossShot_Tick(null, null);

            Assert.AreEqual(form.bossBullet[0].Left, -40);
        }
        [TestMethod]
        public void Teleport_Default_Return()
        {
            var form = new Form3();
            form.portals = new PictureBox[] { new PictureBox() };
            form.mainPlayer3 = new PictureBox
            {
                Bounds = new System.Drawing.Rectangle()
            };

            form.Teleport();
        }
        [TestMethod]
        public void Deth_Default_Return()
        {
            var form = new Form3();
            var b = new PictureBox();
            b.Bounds = new System.Drawing.Rectangle();
            form.bullet = new PictureBox[] { b };
            form.bossBullet = new PictureBox[] { new PictureBox() };
            var pb = new PictureBox();
            pb.Visible = false;
            pb.Bounds = b.Bounds;
            form.bossGif = new PictureBox[] { pb };

            form.Deth();
        }
        [TestMethod]
        public void MoveEnemis_Default_Return()
        {
            var form = new Form3();
            var b = new PictureBox();
            b.Bounds = new System.Drawing.Rectangle();
            form.bullet = new PictureBox[] { b };
            form.bossBullet = new PictureBox[] { new PictureBox() };
            var pb = new PictureBox();
            pb.Visible = false;
            pb.Bounds = b.Bounds;
            form.bossGif = new PictureBox[] { pb };

            form.MoveEnemis(form.bossGif, 5);
        }
        [TestMethod]
        public void Cloud3_Tick_WhenBoundsLeftEqual1280_Return()
        {
            var form = new Form3();

            var b = new PictureBox();
            b.Bounds = new System.Drawing.Rectangle();
            b.Left = 1280;
            form.cloud = new PictureBox[] { b };

            form.Cloud3_Tick(null, null);
        }
        [TestMethod]
        public void Cloud3_Tick_WhenBoundsLeftLess1280_Return()
        {
            var form = new Form3();

            var b = new PictureBox();
            b.Bounds = new System.Drawing.Rectangle();
            b.Left = 1280;
            form.cloud = new PictureBox[] { b };

            form.Cloud3_Tick(null, null);
        }
    }
}
