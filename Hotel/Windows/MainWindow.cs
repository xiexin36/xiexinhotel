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
    public partial class MainWindow : Form
    {
        private StringBuilder path = new StringBuilder("Hotels.Windows.");
        private user u = new user();
        private static RoomButton lastRoomButton = new RoomButton();
        private List<RoomButton> roomButtonList;
        public MainWindow()
        {
            InitializeComponent();
            //M
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            RoomButton roomButton = new RoomButton();
            RoomButton roomButton1 = new RoomButton();
            //注册RoomButton单击事件
            this.flowLayoutPanelRooms.Controls.Add(roomButton);
            this.flowLayoutPanelRooms.Controls.Add(roomButton1);
        }
        private void MenuTrip_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(path + sender.ToString());
            Form f=new Form();
            try
            {
            	f = (Form)Activator.CreateInstance(t);//创建所需的实例对象
            }
            catch (System.Exception ex)
            {
            	
            }
            
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
    }
}
