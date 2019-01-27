using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boombgame
{
    public partial class score : UserControl
    {

        public score()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int a = Form1.score;
            label2.Text = "" + a;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
