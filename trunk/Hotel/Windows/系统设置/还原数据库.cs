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
    public partial class 还原数据库 : Form
    {
        public 还原数据库()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
            this.textBoxPath.Text = this.openFileDialog.FileName;
        }

        private void 还原数据库_Load(object sender, EventArgs e)
        {

        }
    }
}
