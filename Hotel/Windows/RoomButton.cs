using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotels.DataModels;

namespace Hotels.Windows
{
    public partial class RoomButton : UserControl
    {
        public RoomLable roomLable = new RoomLable();//用于显示被选中时的红色边框
        public SelectRoomButton_个结果 room;
        public static bool isFrontChange;
        private StringBuilder path = new StringBuilder("Hotels.Windows.");
        private static DataClassesDataContext db;
        public RoomButton()
        {
            InitializeComponent();                    
        }

        public RoomButton(SelectRoomButton_个结果 room, DataClassesDataContext db)
        {
            InitializeComponent();           
            this.room = room;
            RoomButton.db = db;
            setRoomButton();
            this.listBox.Items.Add(this.room.roomId);
            this.listBox.Items.Add(this.room.typeName);          
            this.Controls.Add(this.roomLable);
            this.contextMenuStripEmpty.Items[0].Text =this.contextMenuStripElse.Items[0].Text=this.contextMenuStripLive.Items[0].Text=this.contextMenuStripReserved.Items[0].Text= "房号: " + this.room.roomId;
            this.contextMenuStripEmpty.Items[1].Text =this.contextMenuStripElse.Items[1].Text=this.contextMenuStripLive.Items[1].Text=this.contextMenuStripReserved.Items[1].Text= this.room.typeName +" , "+ this.room.floorName;
        }
        
        private void RoomButton_Load(object sender, EventArgs e)
        {
             this.roomLable.Visible = false;
             this.listBox.BackColor = this.BackColor;
             this.Controls.Add(this.roomLable);         
        }

        private void setRoomButton()
        {
            if (this.DataBindings.Count>1)
                this.DataBindings.RemoveAt(1);         
            switch (this.room.rStatue)
            {
                case 1: this.ContextMenuStrip = this.contextMenuStripEmpty; this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotels.Properties.Settings.Default, "roomEmpty", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)); break;
                case 2: this.ContextMenuStrip = this.contextMenuStripLive; this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotels.Properties.Settings.Default, "roomLive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)); break;
                case 3: this.ContextMenuStrip = this.contextMenuStripElse; this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotels.Properties.Settings.Default, "roomCleaning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)); break;
                case 4: this.ContextMenuStrip = this.contextMenuStripElse; this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotels.Properties.Settings.Default, "roomRepair", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)); break;
                case 5: this.ContextMenuStrip = this.contextMenuStripReserved; this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotels.Properties.Settings.Default, "roomReserved", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)); break;
                case 6: this.ContextMenuStrip = this.contextMenuStripElse; this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotels.Properties.Settings.Default, "roomNeedClean", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)); break;
            }
        }
        
        private void RoomButton_Click(object sender, EventArgs e)
        {
            MainWindow.MainRoomButton_Click(this);
            this.roomLable.Visible = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (isFrontChange)
            {
                isFrontChange = false;
                return;
            }
            base.OnPaint(e);
            int borderWidth = 2;
            Color borderColor = Color.Black;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void RoomButton_BackColorChanged(object sender, EventArgs e)
        {
            this.listBox.BackColor = this.BackColor;
        }

        private void RoomButton_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void listBox_FontChanged(object sender, EventArgs e)
        {
            RoomButton.isFrontChange = true;
        }

        private void openWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(path + sender.ToString());
            Form f = new Form();
            try
            {
                f = (Form)Activator.CreateInstance(t);//创建所需的实例对象
            }
            catch (System.Exception ex)
            { }          
            using (f)
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            }
        }        

        public void UpdateRoomStatue(object sender, EventArgs e)
        {
            int statue=2;
            switch(sender.ToString())
            {
                case "置为空房间": statue=1; break;
                case "置为打扫中": statue = 3; break;
                case "置为修理中": statue = 4; break;
                case "置为预留房": statue = 5; break;
                case "置为即打扫": statue = 6; break;
            }
            this.room.rStatue = statue;
            db.room.First(r => r.roomId == this.room.roomId).rStatue = statue;
            db.SubmitChanges();
            this.setRoomButton();
        }

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            MainWindow.MainRoomButton_Click(this);
            this.roomLable.Visible = true;
        }     
    }

    //重绘边框的Lable类
    public class RoomLable : UserControl
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 3;
            Color borderColor = Color.Red;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

    }
}
