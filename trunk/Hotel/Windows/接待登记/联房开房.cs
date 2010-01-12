using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotels.Windows
{
    public partial class 联房开房 : Form
    {
        private RoomButton roomButtonNow;
        public 联房开房()
        {
            InitializeComponent();
        }
        public 联房开房(RoomButton roomButtonNow)
        {
            InitializeComponent();
            this.roomButtonNow = roomButtonNow;
        }

        private void 联房开房_Load(object sender, EventArgs e)
        {

        }
    }
}
