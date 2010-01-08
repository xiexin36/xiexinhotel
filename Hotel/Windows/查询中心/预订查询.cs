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
    public partial class 预订查询 : 预订登记
    {
        public 预订查询()
        {
            InitializeComponent();
        }

        private void 预订查询_Load(object sender, EventArgs e)
        {
            this.button3.Text = "明细";
        }
    }
}
