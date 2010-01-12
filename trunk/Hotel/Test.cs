using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotels.DataModels;
namespace Hotels
{
    public partial class Test : Form
    {
        private DataClassesDataContext db = new DataClassesDataContext();
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            this.roomFloorsBindingSource.DataSource = db.roomFloors;
            //this.myMaskBoxDigit1.NumLength = 8;           
        }

        private void roomFloorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int a = (int)this.roomFloorsComboBox.SelectedValue;
        }
    }
}
