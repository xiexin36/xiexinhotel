using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewManageTable
{
    public partial class MyComboBoxNoEdit : ComboBox
    {
        public MyComboBoxNoEdit()
        {
            InitializeComponent();
        }

        public MyComboBoxNoEdit(IContainer container)
        {
            container.Add(this);          
            this.KeyPress+=new KeyPressEventHandler(MyComboBoxNoEdit_KeyPress);
            this.ContextMenuStrip = new ContextMenuStrip();
            InitializeComponent();
        }
        
        private void MyComboBoxNoEdit_KeyPress(object o, KeyPressEventArgs e)
        {
            e.Handled = true;
        }        
    }
}
