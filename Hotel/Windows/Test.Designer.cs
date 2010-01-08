namespace Hotels.Windows
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
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewManageTable1 = new DataGridViewManageTable.DataGridViewManageTable();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataSource = typeof(Hotels.DataModels.roomtype);
            // 
            // dataGridViewManageTable1
            // 
            this.dataGridViewManageTable1.AllowUserToAddRows = false;
            this.dataGridViewManageTable1.AllowUserToDeleteRows = false;
            this.dataGridViewManageTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTable1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewManageTable1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageTable1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewManageTable1.MultiSelect = false;
            this.dataGridViewManageTable1.Name = "dataGridViewManageTable1";
            this.dataGridViewManageTable1.RowTemplate.Height = 23;
            this.dataGridViewManageTable1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageTable1.Size = new System.Drawing.Size(964, 226);
            this.dataGridViewManageTable1.TabIndex = 28;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(964, 468);
            this.Controls.Add(this.dataGridViewManageTable1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private DataGridViewManageTable.DataGridViewManageTable dataGridViewManageTable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomFloorsDataGridViewTextBoxColumn;


    }
}