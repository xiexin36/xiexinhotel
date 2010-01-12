namespace Hotels.Windows
{
    partial class 房价方案
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonManage = new System.Windows.Forms.Button();
            this.dataGridViewManageTable = new DataGridViewManageTable.DataGridViewManageTable();
            this.roomPriceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePlanStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPricePlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPricePlansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(463, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(45, 269);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "添加&A";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "关闭&C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(247, 269);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "删除&D";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonManage
            // 
            this.buttonManage.Location = new System.Drawing.Point(146, 269);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(75, 23);
            this.buttonManage.TabIndex = 4;
            this.buttonManage.Text = "编辑&E";
            this.buttonManage.UseVisualStyleBackColor = true;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // dataGridViewManageTable
            // 
            this.dataGridViewManageTable.AllowUserToAddRows = false;
            this.dataGridViewManageTable.AllowUserToDeleteRows = false;
            this.dataGridViewManageTable.AutoGenerateColumns = false;
            this.dataGridViewManageTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomPriceNameDataGridViewTextBoxColumn,
            this.pricePlanStyleDataGridViewTextBoxColumn});
            this.dataGridViewManageTable.DataSource = this.roomPricePlansBindingSource;
            this.dataGridViewManageTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageTable.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewManageTable.MultiSelect = false;
            this.dataGridViewManageTable.Name = "dataGridViewManageTable";
            this.dataGridViewManageTable.RowTemplate.Height = 23;
            this.dataGridViewManageTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageTable.Size = new System.Drawing.Size(463, 237);
            this.dataGridViewManageTable.TabIndex = 5;
            // 
            // roomPriceNameDataGridViewTextBoxColumn
            // 
            this.roomPriceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomPriceNameDataGridViewTextBoxColumn.DataPropertyName = "roomPriceName";
            this.roomPriceNameDataGridViewTextBoxColumn.HeaderText = "方案名称";
            this.roomPriceNameDataGridViewTextBoxColumn.Name = "roomPriceNameDataGridViewTextBoxColumn";
            // 
            // pricePlanStyleDataGridViewTextBoxColumn
            // 
            this.pricePlanStyleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricePlanStyleDataGridViewTextBoxColumn.DataPropertyName = "PricePlanStyle";
            this.pricePlanStyleDataGridViewTextBoxColumn.HeaderText = "计费方式";
            this.pricePlanStyleDataGridViewTextBoxColumn.Name = "pricePlanStyleDataGridViewTextBoxColumn";
            // 
            // roomPricePlansBindingSource
            // 
            this.roomPricePlansBindingSource.DataSource = typeof(Hotels.DataModels.RoomPricePlans);
            // 
            // 房价方案
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 311);
            this.Controls.Add(this.dataGridViewManageTable);
            this.Controls.Add(this.buttonManage);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "房价方案";
            this.Text = "房价方案";
            this.Load += new System.EventHandler(this.房价方案_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPricePlansBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonManage;
        private DataGridViewManageTable.DataGridViewManageTable dataGridViewManageTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePlanStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roomPricePlansBindingSource;
    }
}