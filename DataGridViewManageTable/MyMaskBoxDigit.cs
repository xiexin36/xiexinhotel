using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewManageTable
{
    public partial class MyMaskBoxDigit : TextBox
    {
        private int numLength;

        public int NumLength
        {
            get { return numLength; }
            set { numLength = value; }
        }
        protected System.Windows.Forms.ErrorProvider errorProvider= new System.Windows.Forms.ErrorProvider();
        public MyMaskBoxDigit()
        {            
            InitializeComponent();               
        }

        public MyMaskBoxDigit(IContainer container)
        {
            container.Add(this);            
            InitializeComponent();
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskDecimal);
            this.numLength = 8;
        }        
        private void MaskDecimal(object o,KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (this.Text.Length>=this.numLength)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                    errorProvider.SetError(this, "");
                }
            }
            else
            {
                //此处声明事件已经响应完,不再进行回显处理
                e.Handled = true;
                errorProvider.SetError(this, "只能输入数字");
            }
        }        
    }
}
