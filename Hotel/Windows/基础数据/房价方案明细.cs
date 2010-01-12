using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotels.DataModels;
using System.Diagnostics;

namespace Hotels.Windows
{
    public partial class 房价方案明细 : Form
    {
        private DataClassesDataContext db;
        private RoomPricePlans plan;
        public 房价方案明细()
        {
            InitializeComponent();
        }

        public 房价方案明细(RoomPricePlans plan)
        {
            InitializeComponent();
            this.plan = plan;
        }

        private void 房价方案明细_Load(object sender, EventArgs e)
        {
            this.db = MainWindow.db;
            if (this.plan == null)
                this.AddPricePlan();
            else
                this.UpdatePricePlan();
            
        }

        private void UpdatePricePlan()
        {
            if (this.plan.PricePlanStyle.Equals("按天计"))
            {
                this.radioButtonPriceStyleDay.Checked = true;
            }
            else
            {
                this.radioButtonPriceStyleHour.Checked = true;
            }
        }

        private void AddPricePlan()
        {
            this.radioButtonPriceStyleDay.Checked = true;
        }

        private void numericUpDownBeingOneHour_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDownBeingHalfHour.Maximum = this.numericUpDownBeingOneHour.Value;
        }

        private void radioButtonPriceStyleDay_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonPriceStyleDay.Checked)
            {
                this.panelHourRoom.Visible = false;
                this.panelDayRoom.Visible = true;              
            }
            else
            {
                this.panelDayRoom.Visible = false;
                this.panelHourRoom.Visible = true;              
            }
        }

        private void pricePlanDayRoomViewDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataView = sender as DataGridView;
            DataGridViewCell cell = dataView.CurrentCell;
            try
            {
            	Convert.ToDecimal(cell.Value);
            }
            catch (System.Exception ex)
            {
                cell.ErrorText = "只能输入金额!";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxPlanName.Text=="")
            {
                MessageBox.Show("方案名称不能为空!");
                return;
            }
            MessageBox.Show("保存成功");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        } 
       
    }
}
