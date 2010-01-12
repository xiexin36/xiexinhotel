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
    public partial class 客房管理 : Form
    {
        private DataClassesDataContext db = new DataClassesDataContext();
        private int tabIndex;
       
        private bool isSave;
        public 客房管理()
        {          
            InitializeComponent();
        }

        private void 客房管理_Load(object sender, EventArgs e)
        {
            this.roomFloorsBindingSource.DataSource = this.db.roomFloorsView;
            this.roomManageBindingSource.DataSource = this.db.roomManage;
            this.roomtypeBindingSource.DataSource = this.db.roomTypeView;
            isSave = true;
            this.roomIdMyMaskBoxDigit.NumLength = 4;
            this.phoneMyMaskBoxDigit.NumLength = 15;
        }

        private void buttonBack_Click(object sender, EventArgs e)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (isSave) //标识没有保存
                isSave = false;
            tabIndex = this.tabControl.SelectedIndex;
            switch (tabIndex)
            {
                case 0: roomAdd(); break;
                case 1: roomTypeAdd(); break;
                case 2: roomFloorAdd(); break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除选择的行?", "小心", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (isSave) //标识没有保存
                isSave = false;
            tabIndex = this.tabControl.SelectedIndex;
            switch (tabIndex)
            {
                case 0: roomDelete(); break;
                case 1: roomTypeDelete(); break;
                case 2: roomFloorDelete(); break;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (isSave) //标识没有保存
                isSave = false;
            tabIndex = this.tabControl.SelectedIndex;
            switch (tabIndex)
            {
                case 0: roomUpdate(); break;
                case 1: roomTypeUpdate(); break;
                case 2: roomFloorUpdate(); break;
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
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.roomManage);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("保存失败" + ex.ToString());
            }
        }


        private void roomDelete()
        {
            if (this.dataGridViewManageTableRoomManage.SelectedRows.Count > 0)
            {
                this.roomManageBindingSource.RemoveAt(this.dataGridViewManageTableRoomManage.SelectedRows[0].Index);
                this.roomManageBindingSource.MovePrevious();
            }
            else
                MessageBox.Show("没有可以删除的行");
        }

        private void roomFloorDelete()
        {
            if (this.dataGridViewManageTableRoomFloor.SelectedRows.Count > 0)
            {
                roomFloorsView rt = (roomFloorsView)this.roomFloorsBindingSource.List[this.dataGridViewManageTableRoomFloor.SelectedRows[0].Index];
                roomManage rm = ((IList<roomManage>)this.roomManageBindingSource.List).FirstOrDefault(r => r.rFloor == rt.floorId);
                if (rm != null)
                    MessageBox.Show("房间表中具有该楼层的房间,无法删除该房间类型");
                else
                {
                    this.roomFloorsBindingSource.RemoveAt(this.dataGridViewManageTableRoomFloor.SelectedRows[0].Index);
                    this.roomFloorsBindingSource.MovePrevious();
                }
            }
            else
                MessageBox.Show("没有可以删除的行");
        }

        private void roomTypeDelete()
        {
            if (this.dataGridViewManageTableRoomType.SelectedRows.Count > 0)
            {
                roomTypeView rt = (roomTypeView)this.roomtypeBindingSource.List[this.dataGridViewManageTableRoomType.SelectedRows[0].Index];
                roomManage rm = ((IList<roomManage>)this.roomManageBindingSource.List).FirstOrDefault(r => r.rType == rt.type);
                if (rm != null)
                {
                    MessageBox.Show("房间表中具有该类型的房间,无法删除该房间类型");
                }
                else
                {
                    this.roomtypeBindingSource.RemoveAt(this.dataGridViewManageTableRoomType.SelectedRows[0].Index);
                    this.roomtypeBindingSource.MovePrevious();
                }
            }
            else
                MessageBox.Show("没有可以删除的行");
        }


        private void roomAdd()
        {
            if (this.roomIdMyMaskBoxDigit.Text == "")
            {
                MessageBox.Show("房间号不能为空,请输入房间号!");
                return;
            }
            int num = Convert.ToInt32(this.roomIdMyMaskBoxDigit.Text);
            roomManage rm = ((IList<roomManage>)this.roomManageBindingSource.List).FirstOrDefault(r => r.roomId == num);
            if (rm != null)
            {
                MessageBox.Show("房间号[" + rm.roomId + "]已经存在,请输入其他的房间号");
                return;
            }
            rm = new roomManage();
            rm.roomId = num;
            rm.rType = (int)this.roomTypeMyComboBoxNoEdit.SelectedValue;
            rm.rFloor = (int)this.roomFloorsMyComboBoxNoEdit.SelectedValue;
            rm.floorName = this.roomFloorsMyComboBoxNoEdit.Text;
            rm.typeName = this.roomTypeMyComboBoxNoEdit.Text;
            rm.statusName = "空房";
            rm.rStatue = 1;
            rm.phone = Convert.ToInt32(this.phoneMyMaskBoxDigit.Text);
            rm.description = this.descriptionTextBox.Text;
            if (this.isHourRoomCheckBox.CheckState == CheckState.Checked)
            {
                rm.isHourRoom = true;
            }
            this.roomManageBindingSource.Add(rm);
            this.roomManageBindingSource.MoveNext();
        }

        private void roomFloorAdd()
        {
            if (this.textBoxFloorName.Text == "")
            {
                MessageBox.Show("房间楼层名不能为空,请重新!");
                return;
            }
            roomFloorsView rf = ((IList<roomFloorsView>)this.roomFloorsBindingSource.List).FirstOrDefault(r => (r.floorName).Equals(this.textBoxFloorName.Text));
            if (rf != null)
            {
                MessageBox.Show("楼层[" + rf.floorName + "]已经存在,请输入其他的房间类型");
                return;
            }
            rf = new roomFloorsView();
            if (roomFloorsBindingSource.Count == 0)
                rf.floorId = 1;
            else
                rf.floorId = ((IList<roomFloorsView>)this.roomFloorsBindingSource.List).Max(p => p.floorId) + 1;
            rf.floorName = this.textBoxFloorName.Text;          
            this.roomFloorsBindingSource.Add(rf);
            this.roomFloorsBindingSource.MoveLast();
        }

        private void roomTypeAdd()
        {
            if (this.typeNameTextBox.Text == "" || this.myMaskBoxMoneyOnePrice.Text == "")
            {
                MessageBox.Show("房间类型与单价不能为空,请重新!");
                return;
            }
            roomTypeView rt = ((IList<roomTypeView>)this.roomtypeBindingSource.List).FirstOrDefault(r => (r.typeName).Equals(this.typeNameTextBox.Text));
            if (rt != null)
            {
                MessageBox.Show("房间类型[" + rt.typeName + "]已经存在,请输入其他的房间类型");
                return;
            }
            rt = new roomTypeView();
            if (roomtypeBindingSource.Count == 0)
                rt.type = 1;
            else
                rt.type = ((IList<roomTypeView>)this.roomtypeBindingSource.List).Max(p => p.type) + 1;          
            rt.typeName = this.typeNameTextBox.Text;
            rt.onePrice = Convert.ToDecimal(this.myMaskBoxMoneyOnePrice.Text);
            if (this.myMaskBoxMoneyHourStartPrice.Text != "")
                rt.hourStartPrice = Convert.ToDecimal(this.myMaskBoxMoneyHourStartPrice.Text);
            if (this.myMaskBoxMoneyHourAddPrice.Text != "")
                rt.hourAddPrice = Convert.ToDecimal(this.myMaskBoxMoneyHourAddPrice.Text);
            this.roomtypeBindingSource.Add(rt);
            this.roomtypeBindingSource.MoveNext();
        }


        private void roomUpdate()
        {
            if (this.roomManageBindingSource.Count == 0)
                return;
            int index = dataGridViewManageTableRoomManage.SelectedRows[0].Index;
            roomManage rm = (roomManage)this.roomManageBindingSource.List[index];
            if (rm.roomId != Convert.ToInt32(this.roomIdMyMaskBoxDigit.Text))//修改房间号
            {
                MessageBox.Show("不能修改房间号,请先删除该房间,再重新添加");
                return;
            }
            rm.rType = (int)this.roomTypeMyComboBoxNoEdit.SelectedValue;
            rm.rFloor = (int)this.roomFloorsMyComboBoxNoEdit.SelectedValue;
            rm.floorName = this.roomFloorsMyComboBoxNoEdit.Text;
            rm.typeName = this.roomTypeMyComboBoxNoEdit.Text;
            if (this.phoneMyMaskBoxDigit.Text!="")
                rm.phone = Convert.ToInt32(this.phoneMyMaskBoxDigit.Text);
            rm.description = this.descriptionTextBox.Text;
            if (this.isHourRoomCheckBox.CheckState == CheckState.Checked)
                rm.isHourRoom = true;
            else
                rm.isHourRoom = false;
        }

        private void roomTypeUpdate()
        {
            if (this.roomtypeBindingSource.Count == 0)
                return;
            int index = dataGridViewManageTableRoomType.SelectedRows[0].Index;
            roomTypeView rt = (roomTypeView)this.roomtypeBindingSource.List[index];
            if (rt.typeName.Equals(this.typeNameTextBox.Text))
            {
                rt.onePrice = Convert.ToDecimal(this.myMaskBoxMoneyOnePrice.Text);
                if (this.myMaskBoxMoneyHourStartPrice.Text != "")
                    rt.hourStartPrice = Convert.ToDecimal(this.myMaskBoxMoneyHourStartPrice.Text);
                if (this.myMaskBoxMoneyHourAddPrice.Text != "")
                    rt.hourAddPrice = Convert.ToDecimal(this.myMaskBoxMoneyHourAddPrice.Text);
            }
            else
            {
                roomTypeView rtt = ((IList<roomTypeView>)this.roomtypeBindingSource.List).FirstOrDefault(r => (r.typeName).Equals(this.typeNameTextBox.Text));
                if (rtt != null)
                {
                    MessageBox.Show("已经存在相同的房间类型名,无法修改");
                    return;
                }
                rt.typeName = this.typeNameTextBox.Text;
                rt.onePrice = Convert.ToDecimal(this.myMaskBoxMoneyOnePrice.Text);
                if (this.myMaskBoxMoneyHourStartPrice.Text != "")
                    rt.hourStartPrice = Convert.ToDecimal(this.myMaskBoxMoneyHourStartPrice.Text);
                if (this.myMaskBoxMoneyHourAddPrice.Text != "")
                    rt.hourAddPrice = Convert.ToDecimal(this.myMaskBoxMoneyHourAddPrice.Text);
            }
        }

        private void roomFloorUpdate()
        {
            if (this.roomFloorsBindingSource.Count == 0)
                return;
            roomFloorsView rf = ((IList<roomFloorsView>)this.roomFloorsBindingSource.List).FirstOrDefault(r => (r.floorName).Equals(this.textBoxFloorName.Text));
            if (rf != null)
            {
                MessageBox.Show("已经存在相同的楼层名,无法修改");
                return;
            } 
            int index = this.dataGridViewManageTableRoomFloor.SelectedRows[0].Index;
            rf = (roomFloorsView)this.roomFloorsBindingSource.List[index];                   
            rf.floorName = this.textBoxFloorName.Text;
        }

        /// <summary>
        /// 设置下拉选项,跟随表格移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewManageTableRoomManage_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewManageTableRoomManage.SelectedRows.Count > 0)
            {
                roomManage rf = (roomManage)this.dataGridViewManageTableRoomManage.SelectedRows[0].DataBoundItem;
                this.roomFloorsMyComboBoxNoEdit.SelectedValue = rf.rFloor;
                this.roomTypeMyComboBoxNoEdit.SelectedValue = rf.rType;
                this.roomIdMyMaskBoxDigit.Text = rf.roomId.ToString();
                this.descriptionTextBox.Text = rf.description;
                this.phoneMyMaskBoxDigit.Text = rf.phone.ToString();
                switch (rf.isHourRoom)
                {
                    case null: this.isHourRoomCheckBox.CheckState = CheckState.Indeterminate; break;
                    case true: this.isHourRoomCheckBox.CheckState = CheckState.Checked; break;
                    case false: this.isHourRoomCheckBox.CheckState = CheckState.Unchecked; break;
                }
            }
            else
            {
                this.roomIdMyMaskBoxDigit.Text = "";
                this.descriptionTextBox.Text = "";
                this.phoneMyMaskBoxDigit.Text = "";
                this.isHourRoomCheckBox.CheckState = CheckState.Indeterminate;
            }
        }

        private void dataGridViewManageTableRoomType_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewManageTableRoomType.SelectedRows.Count > 0)
            {
                roomTypeView rt = (roomTypeView)this.roomtypeBindingSource.List[this.dataGridViewManageTableRoomType.SelectedRows[0].Index];
                this.typeNameTextBox.Text = rt.typeName;
                this.myMaskBoxMoneyHourAddPrice.Text = rt.hourAddPrice.ToString();
                this.myMaskBoxMoneyHourStartPrice.Text = rt.hourStartPrice.ToString();
                this.myMaskBoxMoneyOnePrice.Text = rt.onePrice.ToString();
            }
            else
            {
                this.typeNameTextBox.Text = "";
                this.myMaskBoxMoneyHourAddPrice.Text = "";
                this.myMaskBoxMoneyHourStartPrice.Text ="";
                this.myMaskBoxMoneyOnePrice.Text = "";
            }
        }

        private void dataGridViewManageTableRoomFloor_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewManageTableRoomFloor.SelectedRows.Count > 0)
            {
                roomFloorsView rt = (roomFloorsView)this.roomFloorsBindingSource.List[this.dataGridViewManageTableRoomFloor.SelectedRows[0].Index];
                this.textBoxFloorName.Text = rt.floorName;
            }
            else
                this.textBoxFloorName.Text = "";
        }

        /// <summary>
        /// 更新客房表中的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (this.tabControl.SelectedIndex==0)
            {
                if (!this.isSave)
                    MessageBox.Show("如果想在客房表中查看更新信息,请先保存");
                
            }          
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMany_Click(object sender, EventArgs e)
        {
            if (!this.isSave)
            {
                MessageBox.Show("请先保存当前的基础数据设置信息!");
                return;
            }
            Form f = new 批量添加房间(this.roomManageBindingSource,db);
            using(f)
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();   
            }
            //this.Show();
        }

    }
}
