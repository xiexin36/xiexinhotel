using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotels.Windows
{
    public partial class 拆分账单 : Form
    {
        public 拆分账单()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.Red;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            登记新资料 dj = new 登记新资料();
            dj.Show();
        }
    }
}
