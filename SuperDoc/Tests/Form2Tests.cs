using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SuperDoc.Tests
{
    [TestClass]
    public class Form2Tests
    {
        [TestMethod]
        public void Cloud2_Tick_WhenBoundsLeftEqual1280_Return()
        {
            var form = new Form2();

            var b = new PictureBox();
            b.Bounds = new System.Drawing.Rectangle();
            b.Left = 1280;
            form.cloud = new PictureBox[] { b };

            form.Cloud2_Tick(null, null);
        }
        [TestMethod]
        public void Cloud2_Tick_WhenBoundsLeftLess1280_Return()
        {
            var form = new Form2();

            var b = new PictureBox();
            b.Bounds = new System.Drawing.Rectangle();
            b.Left = 1280;
            form.cloud = new PictureBox[] { b };

            form.Cloud2_Tick(null, null);
        }
        [TestMethod]
        public void Teleport_Default_Return()
        {
            var form = new Form2();
            form.portals = new PictureBox[]
            {
                new PictureBox
                {
                    Bounds = new System.Drawing.Rectangle()
                }
            };
            form.mainPlayer2 = new PictureBox
            {
                Bounds = new System.Drawing.Rectangle()
            };

            form.Teleport();
        }
        [TestMethod]
        public void Deth_Default_Return()
        {
            var form = new Form2();
            form.rnd = new Random();
            var windowsMediaPlayer = Substitute.For<WindowsMediaPlayer>();
            form.Rip = windowsMediaPlayer;
            var b = new PictureBox();
            b.Bounds = new System.Drawing.Rectangle(new Point(1, 1), new Size(10, 10));
            form.bullet = new PictureBox[] { b };
            var pb = new PictureBox();
            pb.Visible = false;
            b.Bounds = new System.Drawing.Rectangle(new Point(1, 1), new Size(10, 10));

            form.enemies = new PictureBox[] { pb };

            form.Deth();
        }
        [TestMethod]
        public void MoveEnemis_Default_Return()
        {
            var testLeft = 100;
            var form = new Form2();
            form.rnd = new Random();
            var b = new PictureBox();
            b.Bounds = new System.Drawing.Rectangle();
            form.bullet = new PictureBox[] { b };
            var pb = new PictureBox();
            pb.Visible = false;
            pb.Bounds = b.Bounds;
            pb.Left = testLeft;
            form.enemies = new PictureBox[] { pb };

            form.MoveEnemis(form.enemies, 5);

            Assert.AreEqual(form.enemies[0].Left < testLeft, true);
        }
    }
}
