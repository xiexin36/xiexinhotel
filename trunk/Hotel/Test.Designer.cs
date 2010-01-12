namespace Hotels
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.roomtypeDataGridView = new System.Windows.Forms.DataGridView();
            this.myMaskBoxDigit1 = new DataGridViewManageTable.MyMaskBoxDigit(this.components);
            this.roomFloorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomFloorsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFloorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomtypeDataGridView
            // 
            this.roomtypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomtypeDataGridView.Location = new System.Drawing.Point(12, 28);
            this.roomtypeDataGridView.Name = "roomtypeDataGridView";
            this.roomtypeDataGridView.RowTemplate.Height = 23;
            this.roomtypeDataGridView.Size = new System.Drawing.Size(662, 220);
            this.roomtypeDataGridView.TabIndex = 1;
            // 
            // myMaskBoxDigit1
            // 
            this.myMaskBoxDigit1.Location = new System.Drawing.Point(12, 275);
            this.myMaskBoxDigit1.Name = "myMaskBoxDigit1";
            this.myMaskBoxDigit1.NumLength = 8;
            this.myMaskBoxDigit1.Size = new System.Drawing.Size(100, 21);
            this.myMaskBoxDigit1.TabIndex = 2;
            // 
            // roomFloorsBindingSource
            // 
            this.roomFloorsBindingSource.DataSource = typeof(Hotels.DataModels.roomFloors);
            // 
            // roomFloorsComboBox
            // 
            this.roomFloorsComboBox.DataSource = this.roomFloorsBindingSource;
            this.roomFloorsComboBox.DisplayMember = "floorName";
            this.roomFloorsComboBox.FormattingEnabled = true;
            this.roomFloorsComboBox.Location = new System.Drawing.Point(159, 276);
            this.roomFloorsComboBox.Name = "roomFloorsComboBox";
            this.roomFloorsComboBox.Size = new System.Drawing.Size(300, 20);
            this.roomFloorsComboBox.TabIndex = 3;
            this.roomFloorsComboBox.ValueMember = "floorId";
            this.roomFloorsComboBox.SelectedIndexChanged += new System.EventHandler(this.roomFloorsComboBox_SelectedIndexChanged);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 364);
            this.Controls.Add(this.roomFloorsComboBox);
            this.Controls.Add(this.myMaskBoxDigit1);
            this.Controls.Add(this.roomtypeDataGridView);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFloorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomtypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewManageTable.MyMaskBoxDigit myMaskBoxDigit1;
        private System.Windows.Forms.BindingSource roomFloorsBindingSource;
        private System.Windows.Forms.ComboBox roomFloorsComboBox;
    }
}