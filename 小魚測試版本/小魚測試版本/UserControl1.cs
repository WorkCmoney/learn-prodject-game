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
    public partial class Introduction : UserControl
    {
        
        public Introduction()
        {
            InitializeComponent();
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }
    }
}
