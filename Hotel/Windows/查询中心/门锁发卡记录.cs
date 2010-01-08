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
    public partial class 门锁发卡记录 :房价调整记录
    {
        public 门锁发卡记录()
        {
            InitializeComponent();
        }

        private void 门锁发卡记录_Load(object sender, EventArgs e)
        {
            this.label2.Text = "房号:";
            this.label3.Text = "操作员:";
        }
    }
}
