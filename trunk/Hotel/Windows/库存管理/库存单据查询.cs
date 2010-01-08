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
    public partial class 库存单据查询 : Form
    {
        private StringBuilder path = new StringBuilder("Hotels.Windows.");
        public 库存单据查询()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(path + this.comboBoxWindow.SelectedText.ToString());
            Form f = (Form)Activator.CreateInstance(t);//创建所需的实例对象
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }
    }
}
