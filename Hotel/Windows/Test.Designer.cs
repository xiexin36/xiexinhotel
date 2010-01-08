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
            System.Windows.Forms.Label floorIdLabel;
            System.Windows.Forms.Label floorNameLabel;
            System.Windows.Forms.Label roomStatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.roomManageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.roomManageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.roomManageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.floorIdComboBox = new System.Windows.Forms.ComboBox();
            this.floorNameComboBox = new System.Windows.Forms.ComboBox();
            this.roomFloorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomStatusComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewManageTable1 = new DataGridViewManageTable.DataGridViewManageTable();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStatueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isHourRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomFloorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            floorIdLabel = new System.Windows.Forms.Label();
            floorNameLabel = new System.Windows.Forms.Label();
            roomStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomManageBindingNavigator)).BeginInit();
            this.roomManageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomManageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFloorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // floorIdLabel
            // 
            floorIdLabel.AutoSize = true;
            floorIdLabel.Location = new System.Drawing.Point(96, 247);
            floorIdLabel.Name = "floorIdLabel";
            floorIdLabel.Size = new System.Drawing.Size(59, 12);
            floorIdLabel.TabIndex = 24;
            floorIdLabel.Text = "floor Id:";
            // 
            // floorNameLabel
            // 
            floorNameLabel.AutoSize = true;
            floorNameLabel.Location = new System.Drawing.Point(93, 344);
            floorNameLabel.Name = "floorNameLabel";
            floorNameLabel.Size = new System.Drawing.Size(71, 12);
            floorNameLabel.TabIndex = 25;
            floorNameLabel.Text = "floor Name:";
            // 
            // roomStatusLabel
            // 
            roomStatusLabel.AutoSize = true;
            roomStatusLabel.Location = new System.Drawing.Point(139, 295);
            roomStatusLabel.Name = "roomStatusLabel";
            roomStatusLabel.Size = new System.Drawing.Size(77, 12);
            roomStatusLabel.TabIndex = 26;
            roomStatusLabel.Text = "room Status:";
            // 
            // roomManageBindingNavigator
            // 
            this.roomManageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roomManageBindingNavigator.BindingSource = this.roomManageBindingSource;
            this.roomManageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomManageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roomManageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.roomManageBindingNavigatorSaveItem});
            this.roomManageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roomManageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomManageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomManageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomManageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomManageBindingNavigator.Name = "roomManageBindingNavigator";
            this.roomManageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomManageBindingNavigator.Size = new System.Drawing.Size(964, 25);
            this.roomManageBindingNavigator.TabIndex = 0;
            this.roomManageBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // roomManageBindingSource
            // 
            this.roomManageBindingSource.DataSource = typeof(Hotels.DataModels.roomManage);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // roomManageBindingNavigatorSaveItem
            // 
            this.roomManageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roomManageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roomManageBindingNavigatorSaveItem.Image")));
            this.roomManageBindingNavigatorSaveItem.Name = "roomManageBindingNavigatorSaveItem";
            this.roomManageBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.roomManageBindingNavigatorSaveItem.Text = "保存数据";
            this.roomManageBindingNavigatorSaveItem.Click += new System.EventHandler(this.roomManageBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // floorIdComboBox
            // 
            this.floorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomManageBindingSource, "roomFloors.floorId", true));
            this.floorIdComboBox.FormattingEnabled = true;
            this.floorIdComboBox.Location = new System.Drawing.Point(161, 244);
            this.floorIdComboBox.Name = "floorIdComboBox";
            this.floorIdComboBox.Size = new System.Drawing.Size(121, 20);
            this.floorIdComboBox.TabIndex = 25;
            // 
            // floorNameComboBox
            // 
            this.floorNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomManageBindingSource, "roomFloors.floorName", true));
            this.floorNameComboBox.FormattingEnabled = true;
            this.floorNameComboBox.Location = new System.Drawing.Point(170, 341);
            this.floorNameComboBox.Name = "floorNameComboBox";
            this.floorNameComboBox.Size = new System.Drawing.Size(121, 20);
            this.floorNameComboBox.TabIndex = 26;
            // 
            // roomFloorsBindingSource
            // 
            this.roomFloorsBindingSource.DataSource = typeof(Hotels.DataModels.roomFloors);
            // 
            // roomStatusBindingSource
            // 
            this.roomStatusBindingSource.DataSource = typeof(Hotels.DataModels.roomStatus);
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataSource = typeof(Hotels.DataModels.roomtype);
            // 
            // roomStatusComboBox
            // 
            this.roomStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomManageBindingSource, "roomStatus", true));
            this.roomStatusComboBox.DataSource = this.roomStatusBindingSource;
            this.roomStatusComboBox.DisplayMember = "status";
            this.roomStatusComboBox.FormattingEnabled = true;
            this.roomStatusComboBox.Location = new System.Drawing.Point(222, 292);
            this.roomStatusComboBox.Name = "roomStatusComboBox";
            this.roomStatusComboBox.Size = new System.Drawing.Size(121, 20);
            this.roomStatusComboBox.TabIndex = 27;
            this.roomStatusComboBox.ValueMember = "statusName";
            // 
            // dataGridViewManageTable1
            // 
            this.dataGridViewManageTable1.AllowUserToAddRows = false;
            this.dataGridViewManageTable1.AllowUserToDeleteRows = false;
            this.dataGridViewManageTable1.AutoGenerateColumns = false;
            this.dataGridViewManageTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn,
            this.rTypeDataGridViewTextBoxColumn,
            this.rStatueDataGridViewTextBoxColumn,
            this.rFloorDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.isHourRoomDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.floorNameDataGridViewTextBoxColumn,
            this.statusNameDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.roomStatusDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.roomFloorsDataGridViewTextBoxColumn});
            this.dataGridViewManageTable1.DataSource = this.roomManageBindingSource;
            this.dataGridViewManageTable1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewManageTable1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageTable1.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewManageTable1.MultiSelect = false;
            this.dataGridViewManageTable1.Name = "dataGridViewManageTable1";
            this.dataGridViewManageTable1.RowTemplate.Height = 23;
            this.dataGridViewManageTable1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageTable1.Size = new System.Drawing.Size(964, 158);
            this.dataGridViewManageTable1.TabIndex = 28;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "roomId";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            // 
            // rTypeDataGridViewTextBoxColumn
            // 
            this.rTypeDataGridViewTextBoxColumn.DataPropertyName = "rType";
            this.rTypeDataGridViewTextBoxColumn.HeaderText = "rType";
            this.rTypeDataGridViewTextBoxColumn.Name = "rTypeDataGridViewTextBoxColumn";
            // 
            // rStatueDataGridViewTextBoxColumn
            // 
            this.rStatueDataGridViewTextBoxColumn.DataPropertyName = "rStatue";
            this.rStatueDataGridViewTextBoxColumn.HeaderText = "rStatue";
            this.rStatueDataGridViewTextBoxColumn.Name = "rStatueDataGridViewTextBoxColumn";
            // 
            // rFloorDataGridViewTextBoxColumn
            // 
            this.rFloorDataGridViewTextBoxColumn.DataPropertyName = "rFloor";
            this.rFloorDataGridViewTextBoxColumn.HeaderText = "rFloor";
            this.rFloorDataGridViewTextBoxColumn.Name = "rFloorDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // isHourRoomDataGridViewTextBoxColumn
            // 
            this.isHourRoomDataGridViewTextBoxColumn.DataPropertyName = "isHourRoom";
            this.isHourRoomDataGridViewTextBoxColumn.HeaderText = "isHourRoom";
            this.isHourRoomDataGridViewTextBoxColumn.Name = "isHourRoomDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // floorNameDataGridViewTextBoxColumn
            // 
            this.floorNameDataGridViewTextBoxColumn.DataPropertyName = "floorName";
            this.floorNameDataGridViewTextBoxColumn.HeaderText = "floorName";
            this.floorNameDataGridViewTextBoxColumn.Name = "floorNameDataGridViewTextBoxColumn";
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "statusName";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "statusName";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "typeName";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // roomStatusDataGridViewTextBoxColumn
            // 
            this.roomStatusDataGridViewTextBoxColumn.DataPropertyName = "roomStatus";
            this.roomStatusDataGridViewTextBoxColumn.HeaderText = "roomStatus";
            this.roomStatusDataGridViewTextBoxColumn.Name = "roomStatusDataGridViewTextBoxColumn";
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "roomtype";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "roomtype";
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            // 
            // roomFloorsDataGridViewTextBoxColumn
            // 
            this.roomFloorsDataGridViewTextBoxColumn.DataPropertyName = "roomFloors";
            this.roomFloorsDataGridViewTextBoxColumn.HeaderText = "roomFloors";
            this.roomFloorsDataGridViewTextBoxColumn.Name = "roomFloorsDataGridViewTextBoxColumn";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(964, 468);
            this.Controls.Add(this.dataGridViewManageTable1);
            this.Controls.Add(roomStatusLabel);
            this.Controls.Add(this.roomStatusComboBox);
            this.Controls.Add(floorNameLabel);
            this.Controls.Add(this.floorNameComboBox);
            this.Controls.Add(floorIdLabel);
            this.Controls.Add(this.floorIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomManageBindingNavigator);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomManageBindingNavigator)).EndInit();
            this.roomManageBindingNavigator.ResumeLayout(false);
            this.roomManageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomManageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFloorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTable1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.BindingSource roomManageBindingSource;
        private System.Windows.Forms.BindingNavigator roomManageBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton roomManageBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource roomFloorsBindingSource;
        private System.Windows.Forms.BindingSource roomStatusBindingSource;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox floorIdComboBox;
        private System.Windows.Forms.ComboBox floorNameComboBox;
        private System.Windows.Forms.ComboBox roomStatusComboBox;
        private DataGridViewManageTable.DataGridViewManageTable dataGridViewManageTable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStatueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isHourRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomFloorsDataGridViewTextBoxColumn;


    }
}