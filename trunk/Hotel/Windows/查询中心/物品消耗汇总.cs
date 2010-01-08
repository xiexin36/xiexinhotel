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
    public partial class 物品消耗汇总 :物品消耗清单
    {
        public 物品消耗汇总()
        {
            InitializeComponent();
        }

        private void 物品消耗汇总_Load(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.textBox1.Visible = false;
        }
    }
}
