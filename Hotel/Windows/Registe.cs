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
    public partial class Registe : Form
    {
        private user user = new user();
        internal Registe(user u)
        {
            this.user=u;
            InitializeComponent();
        }

        private void Registe_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelsDataSet.user”中。您可以根据需要移动或移除它。

        }
        private void buttonCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.comboBoxName.SelectedValue.ToString() == this.textBoxPassword.Text)
            {
                this.user.Name = this.comboBoxName.Text;
                this.user.PassWord = this.comboBoxName.SelectedValue.ToString();
                this.user.Rights = Convert.ToInt32(this.comboBoxName.Tag.ToString());
                this.Dispose();
            }
            else
            {
                MessageBox.Show("用户名或密码错误","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
