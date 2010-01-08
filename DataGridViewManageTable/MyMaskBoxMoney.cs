using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewManageTable
{
    public partial class MyMaskBoxMoney : MyMaskBoxDigit
    {
        private bool isPointGet;
        public MyMaskBoxMoney()
        {
            InitializeComponent();
        }

        public MyMaskBoxMoney(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskDecimal);
        }
        private void MaskDecimal(object o, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                if (this.Text.Length > 12)
                {
                    e.Handled = true;
                }
                else
                {
                    if (this.isPointGet && this.Text.Length - this.Text.IndexOf('.') > 2)
                    {
                        e.Handled = true;
                        return;
                    }
                    e.Handled = false;
                    errorProvider.SetError(this, "");
                }
                return;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                if (this.Text.Length>0&&this.Text[this.Text.Length-1]=='.')
                {
                    this.isPointGet = false;
                }
                return;
            }
            if (e.KeyChar=='.')
            {
                if (!this.isPointGet)
                {
                    this.isPointGet = true;
                }
                else
                {
                    e.Handled = true;
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
