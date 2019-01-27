using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小魚測試版本
{
    public partial class Form1 : Form
    {
        public static int eat_fish = 0;
        int x = -350;

        
        

        public static int GetEat
        {
            get { return eat_fish; }
            set { eat_fish = value; }
        }


        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tail.Location = new Point(x, 59);
            introduction1.Visible = false;
            userControl21.Visible = false;
            sorce1.Visible = false;
            timer1.Enabled = true;
            
        }

        private void play(object sender, EventArgs e)
        {
            Form2 newgame = new Form2();
            newgame.ShowDialog();
            sorce1.Visible = true;
        }

        private void how_play(object sender, EventArgs e)
        {

            
            introduction1.Visible = true;
            userControl21.Visible = true;


        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sorce1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tail.Location = new Point(x+5,59);
            x += 5;
            if (x >= 105)
            {
                timer1.Enabled = false;
            }
        }
    }
    }

