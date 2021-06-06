using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SuperDoc.Properties
{
     public class CloudsF
    {
        public PictureBox[] cloud;
        public int bgSpeed;
        public Random rndcl;

        public void CloudsForm()
        {
            bgSpeed = 10;
            cloud = new PictureBox[20];
            rndcl = new Random();

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
     }
}
