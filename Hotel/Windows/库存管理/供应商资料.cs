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
    public partial class 供应商资料 : Form
    {
        public 供应商资料()
        {
            InitializeComponent();
        }

        private void 供应商资料_Load(object sender, EventArgs e)
        {
            this.buttonCancle.Enabled = false;
            this.buttonSave.Enabled = false;
        }

     
    }
}
