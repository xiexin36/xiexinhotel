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
    public partial class 挂账查询 : Form
    {
        public 挂账查询()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            协议单位 xydw = new 协议单位();
            using (xydw)
            {
                xydw.StartPosition = FormStartPosition.CenterParent;
                xydw.ShowDialog(this);
            }
        }
    }
}
