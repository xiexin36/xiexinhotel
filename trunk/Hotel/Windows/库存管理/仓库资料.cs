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
    public partial class 仓库资料 : Form
    {
        public 仓库资料()
        {
            InitializeComponent();
        }

        private void 仓库资料_Load(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = false;
            this.buttonCancle.Enabled = false;
        }

    }
}
