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
    public partial class 备份数据库 : Form
    {
        public 备份数据库()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 备份数据库_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveFileDialog_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
            this.textBoxPath.Text = this.saveFileDialog.FileName;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
