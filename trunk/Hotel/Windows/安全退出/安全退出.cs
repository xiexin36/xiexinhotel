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
    public partial class 安全退出 : Form
    {
        
        public 安全退出()
        {
            InitializeComponent();
        }

        private void 安全退出_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            清园旅社管理系统 f = new 清园旅社管理系统();
            //Form a = this.ParentForm;           
            //this.Hide();
            f.ShowDialog(); 
        }
    }
}
