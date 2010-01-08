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
    public partial class 库存单据 : Form
    {
        private string className;
        private StringBuilder begin=new StringBuilder();
        public 库存单据()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            供应商资料 a = new 供应商资料();
            using(a)
            {
                a.StartPosition = FormStartPosition.CenterParent;
                a.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            仓库资料 a = new 仓库资料();
            using(a)
            {
                a.StartPosition = FormStartPosition.CenterParent;              
                a.ShowDialog(this);
            }
        }

        private void 库存单据_Load(object sender, EventArgs e)
        {
            this.className = this.GetType().Name;
            this.lableName.Text = this.className;
            DateTime dt1= DateTime.Now;

            switch (this.className)
            {
                case "入库单": this.begin.Append("R" + string.Format("{0:yyyyMMdd}", dt1)) ; break;
                case "退货单": this.begin.Append("T" + string.Format("{0:yyyyMMdd}", dt1)); break;
                case "领料单": this.begin.Append("L" + string.Format("{0:yyyyMMdd}", dt1)); this.labelTotalMoney.Visible = false; this.textBoxTotalMoney.Visible = false; break;
                case "领料退货单": this.begin.Append("F" + string.Format("{0:yyyyMMdd}", dt1)); this.labelTotalMoney.Visible = false; this.textBoxTotalMoney.Visible = false; break;
                case "仓库调拨单": this.begin.Append("C" + string.Format("{0:yyyyMMdd}", dt1)); this.labelTotalMoney.Visible = false; this.textBoxTotalMoney.Visible = false; break;
            }
            this.textBoxNum.Text = this.begin.ToString();

        }

    }
}
