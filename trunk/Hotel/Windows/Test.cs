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
    public partial class Test : Form
    {
        private DataClassesDataContext db=new DataClassesDataContext();
        public Test()
        {           
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
           
        }

        private void roomManageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            db.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//             //int i = this.roomManageDataGridView.SelectedRows[0].Index;
//             this.roomManageBindingSource.RemoveAt(i);
//             Console.WriteLine("hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
