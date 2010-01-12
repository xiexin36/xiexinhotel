using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotels.DataModels;
using System.Data.Linq;

namespace Hotels.Windows
{
    public partial class 其他基础资料 : Form
    {
        private DataClassesDataContext db = new DataClassesDataContext();
        private bool isSave;
        public 其他基础资料()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                DialogResult rusult = MessageBox.Show("您还没有保存,是否现在保存?", "小心", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (rusult == DialogResult.Yes)
                {
                    this.db.SubmitChanges();
                    this.Dispose();
                }
                else if (rusult == DialogResult.No)
                    this.Dispose();
            }
            else
                this.Dispose();
        }

        private void 其他基础资料_Load(object sender, EventArgs e)
        {
            this.goodUnitsBindingSource.DataSource = db.goodUnits;
            this.passengerSoursesBindingSource.DataSource = db.passengerSourses;
            this.payWaysBindingSource.DataSource = db.payWays;
            this.dataGridView.DataSource = this.passengerSoursesBindingSource;
            this.listBox.SelectedIndex = 0;
            dataGridView.Columns[0].Visible = false;         
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text == "")
            {
                MessageBox.Show("名称不能为空,请重新!");
                return;
            }
            if (isSave)
                isSave = false;
            switch (this.listBox.SelectedIndex)
            {
                case 0: this.passengerSoursesAdd(); break;
                case 1: this.payWaysAdd(); break;
                case 2: this.goodUnitsAdd(); break;
            }
        }

        private void goodUnitsAdd()
        {
            goodUnits gU = ((IList<goodUnits>)this.goodUnitsBindingSource.List).FirstOrDefault(r => (r.名称).Equals(this.textBoxName.Text));
            if (gU != null)
            {
                MessageBox.Show("商品单位[" + gU.名称 + "]已经存在,请输入其他的房间类型");
                return;
            }
            gU = new goodUnits();
            if (goodUnitsBindingSource.Count == 0)
                gU.goodUnitsId = 1;
            else
                gU.goodUnitsId = ((IList<goodUnits>)this.goodUnitsBindingSource.List).Max(p => p.goodUnitsId)+1;
            gU.名称 = this.textBoxName.Text;
            this.goodUnitsBindingSource.Add(gU);
            this.goodUnitsBindingSource.MoveLast();
        }

        private void passengerSoursesAdd()
        {
            passengerSourses gU = ((IList<passengerSourses>)this.passengerSoursesBindingSource.List).FirstOrDefault(r => (r.名称).Equals(this.textBoxName.Text));          
            if (gU != null)
            {
                MessageBox.Show("客人来源[" + gU.名称 + "]已经存在,请输入其他的房间类型");
                return;
            }
            gU = new passengerSourses();
            if (passengerSoursesBindingSource.Count == 0)
                gU.passengerSourseId = 1;
            else
                gU.passengerSourseId = ((IList<passengerSourses>)this.passengerSoursesBindingSource.List).Max(p => p.passengerSourseId) + 1;
            gU.名称 = this.textBoxName.Text;
            this.passengerSoursesBindingSource.Add(gU);
            this.passengerSoursesBindingSource.MoveLast();
        }

        private void payWaysAdd()
        {

            payWays gU = ((IList<payWays>)this.payWaysBindingSource.List).FirstOrDefault(r => (r.名称).Equals(this.textBoxName.Text));            
            if (gU != null)
            {
                MessageBox.Show("支付方式[" + gU.名称 + "]已经存在,请输入其他的房间类型");
                return;
            }
            gU = new payWays();
            if (payWaysBindingSource.Count == 0)
                gU.payWayId = 1;
            else
                gU.payWayId = ((IList<payWays>)this.payWaysBindingSource.List).Max(p => p.payWayId)+1;
            gU.名称 = this.textBoxName.Text;
            this.payWaysBindingSource.Add(gU);
            this.payWaysBindingSource.MoveLast();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.RowCount==0)
            {
                MessageBox.Show("没有可以删除的行!");
                return;
            }
            if (this.dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的行!");
                return;
            }
            if (MessageBox.Show("确定删除选择的行?", "小心", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (isSave)
                isSave = false;
            switch (this.listBox.SelectedIndex)
            {
                case 0: this.passengerSoursesDelete(); break;
                case 1: this.payWaysDelete(); break;
                case 2: this.goodUnitsDelete(); break;
            }
        }

        private void goodUnitsDelete()
        {
                goodUnits rt = (goodUnits)this.goodUnitsBindingSource.List[this.dataGridView.SelectedRows[0].Index];
                roomgoods rm = db.roomgoods.FirstOrDefault(r => r.RoomGoodUnitId == rt.goodUnitsId);               
                if (rm != null)
                    MessageBox.Show("房间表中具有该楼层的房间,无法删除该房间类型");
                else
                    this.goodUnitsBindingSource.RemoveAt(this.dataGridView.SelectedRows[0].Index);                          
        }

        private void passengerSoursesDelete()
        {  
                passengerSourses rt = (passengerSourses)this.passengerSoursesBindingSource.List[this.dataGridView.SelectedRows[0].Index];
                passenger rm = db.passenger.FirstOrDefault(r =>r.Psourse  == rt.passengerSourseId);
                if (rm != null)
                {
                    MessageBox.Show("房间表中具有该楼层的房间,无法删除该房间类型");
                }
                else
                    this.passengerSoursesBindingSource.RemoveAt(this.dataGridView.SelectedRows[0].Index);         
        }

        private void payWaysDelete()
        {          
                payWays rt = (payWays)this.payWaysBindingSource.List[this.dataGridView.SelectedRows[0].Index];
                passenger rm = db.passenger.FirstOrDefault(r => r.PpayWay == rt.payWayId);
                if (rm != null)
                {
                    MessageBox.Show("房间表中具有该楼层的房间,无法删除该房间类型");
                }
                else
                    this.payWaysBindingSource.RemoveAt(this.dataGridView.SelectedRows[0].Index);            
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (isSave)
                isSave = false;
            switch(this.listBox.SelectedIndex)
            {
                case 0: this.passengerSoursesUpdate(); break;
                case 1: this.payWaysUpdate(); break;
                case 2: this.goodUnitsUdDate(); break;
            }
        }

        private void goodUnitsUdDate()
        {
            if (this.goodUnitsBindingSource.Count == 0)
                return;
            int index = dataGridView.SelectedRows[0].Index;
            goodUnits rt = (goodUnits)this.goodUnitsBindingSource.List[index];
            if (rt.名称.Equals(this.textBoxName.Text))
            return;
            else
            {
                goodUnits rtt = ((IList<goodUnits>)this.goodUnitsBindingSource.List).FirstOrDefault(r => (r.名称).Equals(this.textBoxName.Text));
                if (rtt != null)
                {
                    MessageBox.Show("已经存在相同的用品单位,无法修改");
                    return;
                }
                rt.名称=this.textBoxName.Text;
            }
        }

        private void payWaysUpdate()
        {
            if (this.payWaysBindingSource.Count == 0)
                return;
            int index = dataGridView.SelectedRows[0].Index;
            payWays rt = (payWays)this.payWaysBindingSource.List[index];
            if (rt.名称.Equals(this.textBoxName.Text))
                return;
            else
            {
                payWays rtt = ((IList<payWays>)this.payWaysBindingSource.List).FirstOrDefault(r => (r.名称).Equals(this.textBoxName.Text));
                if (rtt != null)
                {
                    MessageBox.Show("已经存在相同的支付方式,无法修改");
                    return;
                }
                rt.名称 = this.textBoxName.Text;
            }
        }

        private void passengerSoursesUpdate()
        {
            if (this.passengerSoursesBindingSource.Count == 0)
                return;
            int index = dataGridView.SelectedRows[0].Index;
            passengerSourses rt = (passengerSourses)this.passengerSoursesBindingSource.List[index];
            if (rt.名称.Equals(this.textBoxName.Text))
                return;
            else
            {
                passengerSourses rtt = ((IList<passengerSourses>)this.passengerSoursesBindingSource.List).FirstOrDefault(r => (r.名称).Equals(this.textBoxName.Text));
                if (rtt != null)
                {
                    MessageBox.Show("已经存在相同的客人来源,无法修改");
                    return;
                }
                rt.名称 = this.textBoxName.Text;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                db.SubmitChanges();
                if (!isSave)
                    isSave = true;
                MessageBox.Show("保存成功");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("保存失败" + ex.ToString());
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.listBox.SelectedIndex)
            {
                case 0: dataGridView.DataSource  = this.passengerSoursesBindingSource; dataGridView.Columns[0].Visible = false; this.labelTableName.Text = "客人来源"; break;
                case 1: dataGridView.DataSource  = this.payWaysBindingSource; dataGridView.Columns[0].Visible = false; this.labelTableName.Text = "支付方式"; break;
                case 2: dataGridView.DataSource  = this.goodUnitsBindingSource; dataGridView.Columns[0].Visible = false; this.labelTableName.Text = "商品单位"; break;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count > 0)
                this.textBoxName.Text = this.dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            else
                this.textBoxName.Text = "";
        }
    }
}
