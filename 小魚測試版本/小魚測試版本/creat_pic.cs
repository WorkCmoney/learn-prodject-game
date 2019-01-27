using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace 小魚測試版本
{
    class creat_pic
    {
        public PictureBox picbox(int a, int b, string name)
        {

            PictureBox picture = new PictureBox();
            picture.Location = new System.Drawing.Point(a, b);
            picture.Size = new System.Drawing.Size(70, 50);
            picture.Image = new Bitmap(name + ".png");
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            return picture;

        }
    }
}
