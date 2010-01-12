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
    public partial class 房价方案 : Form
    {
        private DataClassesDataContext db;
        public 房价方案()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 房价方案_Load(object sender, EventArgs e)
        {
            this.db = MainWindow.db;
            this.roomPricePlansBindingSource.DataSource = this.db.RoomPricePlans;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form f = new 房价方案明细();
            using(f)
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            }
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            Form f = new 房价方案明细((RoomPricePlans)this.roomPricePlansBindingSource.List[this.dataGridViewManageTable.SelectedRows[0].Index]);
            using (f)
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RoomPricePlans plan = (RoomPricePlans)this.roomPricePlansBindingSource.List[this.dataGridViewManageTable.SelectedRows[0].Index];
            room r = db.room.FirstOrDefault(r1 => r1.rPricePlan == plan.roomPricePlanId);
            if (r != null)
            {
                MessageBox.Show("目前在店客人中有使用该房间方案的房间,无法删除");
                return;
            }
            if (MessageBox.Show("确定删除选择的行?", "小心", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (this.db.RoomPricePlans.Count() > 0)
            {
                this.roomPricePlansBindingSource.RemoveAt(this.dataGridViewManageTable.SelectedRows[0].Index);
                db.SubmitChanges();
            }
            else
            {
                MessageBox.Show("没有可以删除的行");
            }
        }
    }
}
