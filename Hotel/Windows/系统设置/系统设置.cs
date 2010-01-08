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
    public partial class 系统设置 : Form
    {
        public 系统设置()
        {
            InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            this.panel结账后.Enabled = !this.panel结账后.Enabled;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
        }
    }
}
