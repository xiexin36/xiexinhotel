using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Hotels.Properties;

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
            Settings.Default.Save();
            this.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();//刷新配置为上一次的配置数据,不进行修改
            this.Dispose();
        }

        private void radioButtonRoomStyleFull_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.roomTableStyleFull = !Settings.Default.roomTableStyleFull;
        }

        private void myComboBoxNoEditRoomButtonSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = this.myComboBoxNoEditRoomButtonSize.Text;
            Settings.Default.roomButtonSizeComboxSelcet = a;
            int Sizewidth = Convert.ToInt32(a.Substring(0, 4));
            int Sizeheight = Convert.ToInt32(a.Substring(5, 4));
            Settings.Default.roomButtonSize = new Size(Sizewidth, Sizeheight);     
        }
    }
}
