using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小魚測試版本
{
    public partial class sorce : UserControl
    {
        int fish_eat;
        
        
        public sorce()
        {
            InitializeComponent();
            
        }

        private void sorce_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            fish_eat = Form1.eat_fish;
            yscore3.Text = "" + fish_eat;
        }
    }
}
