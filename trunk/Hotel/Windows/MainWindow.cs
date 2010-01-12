using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Windows.Forms;
using Hotels.DataModels;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Hotels.Windows
{
    public partial class MainWindow : Form
    {
        private StringBuilder path = new StringBuilder("Hotels.Windows.");
        public static DataClassesDataContext db = new DataClassesDataContext();
        public static user u = new user();
        public static RoomButton lastRoomButton;
        private List<RoomButton> roomButtonList=new List<RoomButton>();
        public static MainWindow mWindow;
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.labelDateTime.Text = DateTime.Now.ToString();
            this.roomFloorsBindingSource.DataSource = db.roomFloors;
            this.roomStatusBindingSource.DataSource = db.roomStatus;
            this.roomtypeComboBoxBindingSource.DataSource = db.roomtypeComboBox;
            this.comboBoxRoomStatus_SelectionChangeCommitted(this, new EventArgs());
            if(this.roomButtonList.Count>0)
                MainWindow.lastRoomButton = this.roomButtonList[0];
            MainWindow.mWindow=this;
            
        }
        private void MenuTrip_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(path + sender.ToString());
            Form f = new Form();
            try
            {
                f = (Form)Activator.CreateInstance(t);//创建所需的实例对象
            }
            catch (System.Exception ex)
            { }

            //窗体以ShowDialog()形式显示时,在使用close()后,不能释放资源	         
            using (f)
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            }

        }

        public static void MainRoomButton_Click(RoomButton sender)
        {
            if (sender == lastRoomButton)
                return;
            lastRoomButton.roomLable.Visible = false;
            lastRoomButton = sender;
        }
     
        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel.Visible = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel.Refresh();
            this.tableLayoutPanel.Visible = true;
        }

        /// <summary>
        /// 填充渐变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWatch_Tick(object sender, EventArgs e)
        {
            this.labelDateTime.Text = DateTime.Now.ToString();
        }

        private void panelBrushColor_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.panelBrushColor.ClientRectangle, Color.DarkBlue, Color.White, LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, this.panelBrushColor.ClientRectangle);
        }
       
        public void comboBoxRoomStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int rtypeBegin = 0, rtypeEnd, rfloorBegin = 0, rfloorEnd, rstatueBegin = 0, rstatueEnd;
            rtypeBegin = rtypeEnd = ((roomtypeComboBox)this.comboBoxRoomTypes.SelectedItem).type;
            rfloorBegin = rfloorEnd = ((roomFloors)this.comboBoxRoomFloors.SelectedItem).floorId;
            rstatueBegin = rstatueEnd = ((roomStatus)this.comboBoxRoomStatus.SelectedItem).status;
            if (rtypeBegin == 0)
                rtypeEnd = ((IList<roomtypeComboBox>)this.roomtypeComboBoxBindingSource.List).Max(r => r.type);
            if (rfloorBegin == 0)
                rfloorEnd = ((IList<roomFloors>)this.roomFloorsBindingSource.List).Max(r => r.floorId);
            if (rstatueBegin == 0)
                rstatueEnd = ((IList<roomStatus>)this.roomStatusBindingSource.List).Max(r => r.status);
            ISingleResult<SelectRoomButton_个结果> roomSelectList = db.SelectRoomButton(rtypeBegin, rtypeEnd, rfloorBegin, rfloorEnd, rstatueBegin, rstatueEnd);
            this.roomButtonList.Clear();
            foreach (var i in roomSelectList)
            {
                this.roomButtonList.Add(new RoomButton(i,db));
            }
            this.flowLayoutPanelRooms.Controls.Clear();
            this.flowLayoutPanelRooms.Controls.AddRange(this.roomButtonList.ToArray());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel.Visible)
                MessageBox.Show("房态图已经打开,请在房态图上选择房间右键单击操作");
            else
                this.tableLayoutPanel.Visible = true;
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Form f = new Registe(MainWindow.u);
            using(f)
            {
                f.ShowDialog();
            }
        }     
    }
}
