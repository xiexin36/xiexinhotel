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
    public partial class 换房 : Form
    {
        public 换房()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 换房_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.label11.Visible = true;
            this.label12.Visible = true;
            this.textBox8.Visible = true;
            this.comboBox3.Visible = true;
            this.label9.Location = new Point(16,167);
            this.textBox7.Location =new Point(92,162);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.label11.Visible = false;
            this.label12.Visible = false;
            this.textBox8.Visible = false;
            this.comboBox3.Visible = false ;
            this.label9.Location = this.label11.Location;
            this.textBox7.Location = this.textBox8.Location;
        }
    }
}
