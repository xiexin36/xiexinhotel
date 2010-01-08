using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotels.Windows
{
    public partial class RoomButton : UserControl
    {
        public RoomLable roomLable = new RoomLable();
        public RoomButton()
        {
            InitializeComponent();
        }


        private void RoomButton_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            this.listBox.BackColor = this.BackColor;
            this.Controls.Add(this.roomLable);
            this.roomLable.Visible = false;
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            MainWindow.MainRoomButton_Click(this);
            this.roomLable.Visible = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 2;
            Color borderColor = Color.Black;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

    }
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
