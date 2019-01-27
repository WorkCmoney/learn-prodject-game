using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace boombgame
{
    
    public partial class Form1 : Form
    {
        int change = 0;
        Bitmap img;
        public static int score = 0;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            score1.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (change == 0)
            {
                img = new Bitmap("pic\\Bee\\costume1.png");
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                bee.Image = img;
                change += 1;return;
            }
            if (change == 1)
            {
                img = new Bitmap("pic\\Bee\\costume2.png");
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                bee.Image = img;

                change -= 1;return;
            }
           
        }
      

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 game = new Form2();
            score1.Visible = true;
            game.ShowDialog();
        } 
    }
}
