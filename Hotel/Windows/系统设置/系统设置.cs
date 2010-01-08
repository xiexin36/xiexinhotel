using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

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

        private void labelColor_Click(object sender, EventArgs e)
        {
            DialogResult result=this.colorDialog.ShowDialog();
            if (result== DialogResult.OK)
            {
                Label labelNow = sender as Label;
                labelNow.BackColor = colorDialog.Color;             
            }
        }

        private void 系统设置_Load(object sender, EventArgs e)
        {            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radioButtonRoomStyleFull_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.roomTableStyleFull = !Properties.Settings.Default.roomTableStyleFull;
        }
       
    }
}
