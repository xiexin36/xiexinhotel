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
    public partial class 入住登记 : Form
    {
        private RoomButton roomButtonNow;
        private DataClassesDataContext db = new DataClassesDataContext();
        private passenger passengerNow=new passenger();
        private room r;
        public 入住登记()
        {
            InitializeComponent();
        }
       

        private void 入住登记_Load(object sender, EventArgs e)
        {
            this.db = MainWindow.db;
            this.roomButtonNow = MainWindow.lastRoomButton;
            this.roomPricePlansBindingSource.DataSource = db.RoomPricePlans;
            this.passengerSoursesBindingSource.DataSource = db.passengerSourses;
            this.passengerTypesBindingSource.DataSource = db.passengerTypes;
            this.cardTypesBindingSource.DataSource = db.cardTypes;
            this.payWaysBindingSource.DataSource = db.payWays;
            this.myMaskBoxDigitCardNum.NumLength = 18;
            this.myMaskBoxDigitDays.NumLength = 3;
            this.myMaskBoxDigitPaidAccount.NumLength = 10;
            this.myMaskBoxDigitPeopleNum.NumLength = 2;
            this.labelUser.Text = MainWindow.u.Name;
            this.labelRoomId.Text = this.roomButtonNow.room.roomId.ToString();
            this.labelRoomType.Text = this.roomButtonNow.room.typeName;
            this.labelArriveDate.Text = DateTime.Now.ToLongDateString();
            r = db.room.First(r00 => r00.roomId == this.roomButtonNow.room.roomId);
            this.passengerNow.PstartDate = DateTime.Now;
            roomtype rt=db.roomtype.First(t => t.type == this.roomButtonNow.room.rType);
            this.labelRoomPrice.Text = rt.onePrice.ToString();
            this.labelRoomDisPrice.Text = (Convert.ToDouble(rt.onePrice) * 0.8).ToString();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabControl.SelectedIndex==1)
            {
                if(this.textBoxPassengerName.Text=="")
                    MessageBox.Show("请先输入客户名字!");
                else
                {
                    passengerNow=db.passenger.FirstOrDefault(p=>p.PName==this.textBoxPassengerName.Text);
                    if (passengerNow == null)
                        return;
                    else
                        this.passengerLiveRecordViewBindingSource.DataSource = db.passengerLiveRecordView.Select(p => p.passengerId == passengerNow.PassengerId);
                }
            }
        }

        private void buttonLive_Click(object sender, EventArgs e)
        {
            if (this.textBoxPassengerName.Text=="")
            {
                MessageBox.Show("客人姓名不能为空!");
                return;
            }
            if (this.myMaskBoxDigitPaidAccount.Text=="")
            {
                this.myMaskBoxDigitPaidAccount.Text = "0";
                if (MessageBox.Show("尚未输入押金,确定保存?", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            if (MessageBox.Show("确定添加该条记录?", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            passengerNow = db.passenger.FirstOrDefault(p => p.PName == this.textBoxPassengerName.Text);
            if (passengerNow == null)
            {
                passengerNow = new passenger();
                this.passengerNow.PName = this.textBoxPassengerName.Text;             
                this.passengerNow.PpaidAccount = Convert.ToDecimal(this.myMaskBoxDigitPaidAccount.Text);
                this.passengerNow.PpayWay =(int) this.comboBoxPayWays.SelectedValue;
                this.passengerNow.PbirthDay = this.dateTimePickerBirthday.Value;
                this.passengerNow.PCardNumber =this.myMaskBoxDigitCardNum.Text;
                this.passengerNow.PCardType = (int)this.comboBoxCardType.SelectedValue;
                this.passengerNow.Pdescription = this.textBoxPdescription.Text;
                this.passengerNow.PSex = Convert.ToBoolean(this.comboBoxSex.SelectedIndex);
                this.passengerNow.Psourse =(int) this.comboBoxPassengerSourse.SelectedValue;
                this.passengerNow.PRoomId = Convert.ToInt32(this.labelRoomId.Text);
                if (db.passenger.Count() == 0)
                    passengerNow.PassengerId = 1;
                else
                    this.passengerNow.PassengerId = db.passenger.Max(p => p.PassengerId)+1;
                db.passenger.InsertOnSubmit(passengerNow);               
            }
            db.SubmitChanges();
            this.roomButtonNow.room.rStatue = 2;
            this.roomButtonNow.UpdateRoomStatue(new object(), new EventArgs());
            this.roomButtonNow.Refresh();
            MessageBox.Show("添加入住记录成功!");
            this.Dispose();
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
