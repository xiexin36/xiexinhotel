using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotels.DataModels;

namespace Hotels.Windows
{
    public partial class 暂时离开 : Form
    {
        private user u;
        public 暂时离开()
        {
            InitializeComponent();
        }

        private void 暂时离开_Load(object sender, EventArgs e)
        {
            this.u=MainWindow.u;
            this.labelUserName.Text = this.u.Name;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals(this.u.PassWord))
                this.Close();
            else
                MessageBox.Show("操作员密码错误,请重新输入!");
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {          
            if (MessageBox.Show("是否现在备份数据库?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                Application.Exit();             
            else
            {   
                this.Hide();        
                Form f = new 备份数据库();
                using(f)
                {
                    f.ShowDialog(MainWindow.mWindow);
                    Application.Exit();
                }
            }
        }

 
    }
}
