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
    public partial class 批量添加房间 : Form
    {
        private DataClassesDataContext db ;
        private BindingSource roomManageBindingSource;
        public 批量添加房间()
        {
            InitializeComponent();
        }

        public 批量添加房间(BindingSource roomManageBindingSource,DataClassesDataContext db)
        {
            InitializeComponent();
            this.db = db;
            this.roomManageBindingSource = roomManageBindingSource;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainWindow.mWindow.comboBoxRoomStatus_SelectionChangeCommitted(new object(), new EventArgs());
        }

        private void buttonAddMany_Click(object sender, EventArgs e)
        {
            if (this.myMaskBoxDigitStartNum.Text == "" || this.myMaskBoxDigitEndNum.Text == "")
            {
                MessageBox.Show("开始房号与结束房号不能为空!");
                return;
            }
            int startNum = Convert.ToInt32(this.myMaskBoxDigitStartNum.Text);
            int endNum = Convert.ToInt32(this.myMaskBoxDigitEndNum.Text);
            if (startNum > endNum)
            {
                MessageBox.Show("开始房号不能大于结束房号");
                return;
            }
            int? selsetRoomCount = 0;
            db.selectRoomAddMany(startNum, endNum, ref selsetRoomCount);
            if (selsetRoomCount > 0)
            {
                MessageBox.Show("要添加的房号已经存在");
                return;
            }
            if (endNum - startNum > 100)
            {
                DialogResult rusult = MessageBox.Show("开始房号与结束房号相差超过一百个房间,确定添加?", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rusult == DialogResult.No)
                    return;
            }
            int type = (int)this.myComboBoxNoEditRoomType.SelectedValue;
            int floor = (int)this.myComboBoxNoEditRoomFloor.SelectedValue;
            string typeName = this.myComboBoxNoEditRoomType.Text;
            string floorName=this.myComboBoxNoEditRoomFloor.Text;
            bool? isHourRoom=null;
            if (this.checkBoxIsHourRoom.CheckState == CheckState.Checked)
                isHourRoom = true;
            StringBuilder phone = new StringBuilder("");
            CheckedListBox.CheckedIndexCollection indexCount = this.checkedListBoxLastNum.CheckedIndices; 
            if (this.myMaskBoxDigitRoomPhone.Text == "")
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    if (indexCount.Contains(i%10))
                        continue;
                    roomManage rm = new roomManage();
                    rm.rType =type;
                    rm.rFloor = floor;
                    rm.rStatue = 1;
                    rm.statusName = "空房";
                    rm.typeName = typeName;
                    rm.floorName = floorName;
                    rm.isHourRoom = isHourRoom;
                    rm.roomId = i;
                    rm.phone = i;
                    this.roomManageBindingSource.Add(rm);
                }
            }
            else
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    if (indexCount.Contains(i%10))
                        continue;
                    roomManage rm = new roomManage();
                    rm.rType = type;
                    rm.rFloor = floor;
                    rm.rStatue = 1;
                    rm.statusName = "空房";
                    rm.typeName = typeName;
                    rm.floorName = floorName;
                    rm.isHourRoom = isHourRoom;
                    rm.roomId = i;
                    phone.Length = 0;
                    phone.Append(this.myMaskBoxDigitRoomPhone.Text+i);
                    rm.phone = Convert.ToInt32(phone.ToString());
                    this.roomManageBindingSource.Add(rm);
                }
            }
            
        }

        private void 批量添加房间_Load(object sender, EventArgs e)
        {
            this.roomFloorsBindingSource.DataSource = db.roomFloorsView;
            this.roomtypeBindingSource.DataSource = db.roomTypeView;
            this.myMaskBoxDigitStartNum.NumLength = 3;
            this.myMaskBoxDigitEndNum.NumLength = 3;
        }
    }
}
