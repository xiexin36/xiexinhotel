namespace Hotels.Windows
{
    partial class 客房管理
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
            System.Windows.Forms.Label roomFloorNameLabel;
            System.Windows.Forms.Label hourAddPriceLabel;
            System.Windows.Forms.Label hourStartPriceLabel;
            System.Windows.Forms.Label onePriceLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label floorNameLabel;
            System.Windows.Forms.Label typeNameLabel;
            System.Windows.Forms.Label roomIdLabel1;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label descriptionLabel1;
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxFloorName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewManageTableRoomFloor = new DataGridViewManageTable.DataGridViewManageTable();
            this.floorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomFloorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.myMaskBoxMoneyHourAddPrice = new DataGridViewManageTable.MyMaskBoxMoney(this.components);
            this.myMaskBoxMoneyOnePrice = new DataGridViewManageTable.MyMaskBoxMoney(this.components);
            this.myMaskBoxMoneyHourStartPrice = new DataGridViewManageTable.MyMaskBoxMoney(this.components);
            this.typeNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewManageTableRoomType = new DataGridViewManageTable.DataGridViewManageTable();
            this.typeNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourStartPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourAddPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.isHourRoomCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneMyMaskBoxDigit = new DataGridViewManageTable.MyMaskBoxDigit(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomTypeMyComboBoxNoEdit = new DataGridViewManageTable.MyComboBoxNoEdit(this.components);
            this.roomFloorsMyComboBoxNoEdit = new DataGridViewManageTable.MyComboBoxNoEdit(this.components);
            this.roomIdMyMaskBoxDigit = new DataGridViewManageTable.MyMaskBoxDigit(this.components);
            this.dataGridViewManageTableRoomManage = new DataGridViewManageTable.DataGridViewManageTable();
            this.roomManageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddMany = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isHourRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            roomFloorNameLabel = new System.Windows.Forms.Label();
            hourAddPriceLabel = new System.Windows.Forms.Label();
            hourStartPriceLabel = new System.Windows.Forms.Label();
            onePriceLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            floorNameLabel = new System.Windows.Forms.Label();
            typeNameLabel = new System.Windows.Forms.Label();
            roomIdLabel1 = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTableRoomFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFloorsBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTableRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTableRoomManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomManageBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomFloorNameLabel
            // 
            roomFloorNameLabel.AutoSize = true;
            roomFloorNameLabel.Location = new System.Drawing.Point(18, 397);
            roomFloorNameLabel.Name = "roomFloorNameLabel";
            roomFloorNameLabel.Size = new System.Drawing.Size(47, 12);
            roomFloorNameLabel.TabIndex = 11;
            roomFloorNameLabel.Text = "楼层名:";
            // 
            // hourAddPriceLabel
            // 
            hourAddPriceLabel.AutoSize = true;
            hourAddPriceLabel.Location = new System.Drawing.Point(350, 391);
            hourAddPriceLabel.Name = "hourAddPriceLabel";
            hourAddPriceLabel.Size = new System.Drawing.Size(83, 12);
            hourAddPriceLabel.TabIndex = 21;
            hourAddPriceLabel.Text = "钟点房加钟价:";
            // 
            // hourStartPriceLabel
            // 
            hourStartPriceLabel.AutoSize = true;
            hourStartPriceLabel.Location = new System.Drawing.Point(350, 364);
            hourStartPriceLabel.Name = "hourStartPriceLabel";
            hourStartPriceLabel.Size = new System.Drawing.Size(83, 12);
            hourStartPriceLabel.TabIndex = 19;
            hourStartPriceLabel.Text = "钟点房起钟价:";
            // 
            // onePriceLabel
            // 
            onePriceLabel.AutoSize = true;
            onePriceLabel.Location = new System.Drawing.Point(5, 390);
            onePriceLabel.Name = "onePriceLabel";
            onePriceLabel.Size = new System.Drawing.Size(71, 12);
            onePriceLabel.TabIndex = 17;
            onePriceLabel.Text = "全天房标价:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(5, 364);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 12);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "类型名:";
            // 
            // floorNameLabel
            // 
            floorNameLabel.AutoSize = true;
            floorNameLabel.Location = new System.Drawing.Point(8, 390);
            floorNameLabel.Name = "floorNameLabel";
            floorNameLabel.Size = new System.Drawing.Size(53, 12);
            floorNameLabel.TabIndex = 3;
            floorNameLabel.Text = "楼层(&A):";
            // 
            // typeNameLabel
            // 
            typeNameLabel.AutoSize = true;
            typeNameLabel.Location = new System.Drawing.Point(291, 390);
            typeNameLabel.Name = "typeNameLabel";
            typeNameLabel.Size = new System.Drawing.Size(77, 12);
            typeNameLabel.TabIndex = 21;
            typeNameLabel.Text = "房间类型(&T):";
            // 
            // roomIdLabel1
            // 
            roomIdLabel1.AutoSize = true;
            roomIdLabel1.Location = new System.Drawing.Point(8, 362);
            roomIdLabel1.Name = "roomIdLabel1";
            roomIdLabel1.Size = new System.Drawing.Size(65, 12);
            roomIdLabel1.TabIndex = 26;
            roomIdLabel1.Text = "房间号(&R):";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(291, 362);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 12);
            phoneLabel.TabIndex = 27;
            phoneLabel.Text = "电话(&P):";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(7, 430);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(77, 12);
            descriptionLabel1.TabIndex = 32;
            descriptionLabel1.Text = "房间特征(&T):";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.textBoxFloorName);
            this.tabPage3.Controls.Add(roomFloorNameLabel);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dataGridViewManageTableRoomFloor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(754, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "客房楼层";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxFloorName
            // 
            this.textBoxFloorName.Location = new System.Drawing.Point(84, 394);
            this.textBoxFloorName.Name = "textBoxFloorName";
            this.textBoxFloorName.Size = new System.Drawing.Size(100, 21);
            this.textBoxFloorName.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(230, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(371, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "提示：为了保证楼层排序显示正确,楼层名以数字开头:如1楼,2楼,3楼";
            // 
            // dataGridViewManageTableRoomFloor
            // 
            this.dataGridViewManageTableRoomFloor.AllowUserToAddRows = false;
            this.dataGridViewManageTableRoomFloor.AllowUserToDeleteRows = false;
            this.dataGridViewManageTableRoomFloor.AutoGenerateColumns = false;
            this.dataGridViewManageTableRoomFloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTableRoomFloor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.floorNameDataGridViewTextBoxColumn1});
            this.dataGridViewManageTableRoomFloor.DataSource = this.roomFloorsBindingSource;
            this.dataGridViewManageTableRoomFloor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewManageTableRoomFloor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageTableRoomFloor.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewManageTableRoomFloor.MultiSelect = false;
            this.dataGridViewManageTableRoomFloor.Name = "dataGridViewManageTableRoomFloor";
            this.dataGridViewManageTableRoomFloor.RowTemplate.Height = 23;
            this.dataGridViewManageTableRoomFloor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageTableRoomFloor.Size = new System.Drawing.Size(746, 372);
            this.dataGridViewManageTableRoomFloor.TabIndex = 13;
            this.dataGridViewManageTableRoomFloor.SelectionChanged += new System.EventHandler(this.dataGridViewManageTableRoomFloor_SelectionChanged);
            // 
            // floorNameDataGridViewTextBoxColumn1
            // 
            this.floorNameDataGridViewTextBoxColumn1.DataPropertyName = "floorName";
            this.floorNameDataGridViewTextBoxColumn1.HeaderText = "楼层名";
            this.floorNameDataGridViewTextBoxColumn1.Name = "floorNameDataGridViewTextBoxColumn1";
            // 
            // roomFloorsBindingSource
            // 
            this.roomFloorsBindingSource.DataSource = typeof(Hotels.DataModels.roomFloorsView);
            this.roomFloorsBindingSource.Filter = "";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.myMaskBoxMoneyHourAddPrice);
            this.tabPage2.Controls.Add(this.myMaskBoxMoneyOnePrice);
            this.tabPage2.Controls.Add(this.myMaskBoxMoneyHourStartPrice);
            this.tabPage2.Controls.Add(this.typeNameTextBox);
            this.tabPage2.Controls.Add(nameLabel);
            this.tabPage2.Controls.Add(onePriceLabel);
            this.tabPage2.Controls.Add(hourStartPriceLabel);
            this.tabPage2.Controls.Add(hourAddPriceLabel);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridViewManageTableRoomType);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "客房类别";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // myMaskBoxMoneyHourAddPrice
            // 
            this.myMaskBoxMoneyHourAddPrice.Location = new System.Drawing.Point(459, 390);
            this.myMaskBoxMoneyHourAddPrice.Name = "myMaskBoxMoneyHourAddPrice";
            this.myMaskBoxMoneyHourAddPrice.NumLength = 8;
            this.myMaskBoxMoneyHourAddPrice.Size = new System.Drawing.Size(161, 21);
            this.myMaskBoxMoneyHourAddPrice.TabIndex = 3;
            // 
            // myMaskBoxMoneyOnePrice
            // 
            this.myMaskBoxMoneyOnePrice.Location = new System.Drawing.Point(83, 391);
            this.myMaskBoxMoneyOnePrice.Name = "myMaskBoxMoneyOnePrice";
            this.myMaskBoxMoneyOnePrice.NumLength = 8;
            this.myMaskBoxMoneyOnePrice.Size = new System.Drawing.Size(171, 21);
            this.myMaskBoxMoneyOnePrice.TabIndex = 2;
            // 
            // myMaskBoxMoneyHourStartPrice
            // 
            this.myMaskBoxMoneyHourStartPrice.Location = new System.Drawing.Point(459, 360);
            this.myMaskBoxMoneyHourStartPrice.Name = "myMaskBoxMoneyHourStartPrice";
            this.myMaskBoxMoneyHourStartPrice.NumLength = 8;
            this.myMaskBoxMoneyHourStartPrice.Size = new System.Drawing.Size(161, 21);
            this.myMaskBoxMoneyHourStartPrice.TabIndex = 1;
            // 
            // typeNameTextBox
            // 
            this.typeNameTextBox.Location = new System.Drawing.Point(85, 360);
            this.typeNameTextBox.Name = "typeNameTextBox";
            this.typeNameTextBox.Size = new System.Drawing.Size(169, 21);
            this.typeNameTextBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(389, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "提示：房间将自动读取房间类别的房价。房间折扣价请在房价方案中设置";
            // 
            // dataGridViewManageTableRoomType
            // 
            this.dataGridViewManageTableRoomType.AllowUserToAddRows = false;
            this.dataGridViewManageTableRoomType.AllowUserToDeleteRows = false;
            this.dataGridViewManageTableRoomType.AutoGenerateColumns = false;
            this.dataGridViewManageTableRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTableRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeNameDataGridViewTextBoxColumn1,
            this.onePriceDataGridViewTextBoxColumn,
            this.hourStartPriceDataGridViewTextBoxColumn,
            this.hourAddPriceDataGridViewTextBoxColumn});
            this.dataGridViewManageTableRoomType.DataSource = this.roomtypeBindingSource;
            this.dataGridViewManageTableRoomType.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewManageTableRoomType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageTableRoomType.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewManageTableRoomType.MultiSelect = false;
            this.dataGridViewManageTableRoomType.Name = "dataGridViewManageTableRoomType";
            this.dataGridViewManageTableRoomType.RowTemplate.Height = 23;
            this.dataGridViewManageTableRoomType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageTableRoomType.Size = new System.Drawing.Size(746, 345);
            this.dataGridViewManageTableRoomType.TabIndex = 23;
            this.dataGridViewManageTableRoomType.SelectionChanged += new System.EventHandler(this.dataGridViewManageTableRoomType_SelectionChanged);
            // 
            // typeNameDataGridViewTextBoxColumn1
            // 
            this.typeNameDataGridViewTextBoxColumn1.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn1.HeaderText = "房间类型";
            this.typeNameDataGridViewTextBoxColumn1.Name = "typeNameDataGridViewTextBoxColumn1";
            // 
            // onePriceDataGridViewTextBoxColumn
            // 
            this.onePriceDataGridViewTextBoxColumn.DataPropertyName = "onePrice";
            this.onePriceDataGridViewTextBoxColumn.HeaderText = "房间标价";
            this.onePriceDataGridViewTextBoxColumn.Name = "onePriceDataGridViewTextBoxColumn";
            // 
            // hourStartPriceDataGridViewTextBoxColumn
            // 
            this.hourStartPriceDataGridViewTextBoxColumn.DataPropertyName = "hourStartPrice";
            this.hourStartPriceDataGridViewTextBoxColumn.HeaderText = "房间起钟价";
            this.hourStartPriceDataGridViewTextBoxColumn.Name = "hourStartPriceDataGridViewTextBoxColumn";
            // 
            // hourAddPriceDataGridViewTextBoxColumn
            // 
            this.hourAddPriceDataGridViewTextBoxColumn.DataPropertyName = "hourAddPrice";
            this.hourAddPriceDataGridViewTextBoxColumn.HeaderText = "房间加钟价";
            this.hourAddPriceDataGridViewTextBoxColumn.Name = "hourAddPriceDataGridViewTextBoxColumn";
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataSource = typeof(Hotels.DataModels.roomTypeView);
            this.roomtypeBindingSource.Filter = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.isHourRoomCheckBox);
            this.tabPage1.Controls.Add(this.phoneMyMaskBoxDigit);
            this.tabPage1.Controls.Add(this.descriptionTextBox);
            this.tabPage1.Controls.Add(descriptionLabel1);
            this.tabPage1.Controls.Add(this.roomTypeMyComboBoxNoEdit);
            this.tabPage1.Controls.Add(this.roomFloorsMyComboBoxNoEdit);
            this.tabPage1.Controls.Add(this.roomIdMyMaskBoxDigit);
            this.tabPage1.Controls.Add(phoneLabel);
            this.tabPage1.Controls.Add(roomIdLabel1);
            this.tabPage1.Controls.Add(this.dataGridViewManageTableRoomManage);
            this.tabPage1.Controls.Add(this.buttonAddMany);
            this.tabPage1.Controls.Add(floorNameLabel);
            this.tabPage1.Controls.Add(typeNameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "客房信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isHourRoomCheckBox
            // 
            this.isHourRoomCheckBox.AutoSize = true;
            this.isHourRoomCheckBox.Location = new System.Drawing.Point(572, 359);
            this.isHourRoomCheckBox.Name = "isHourRoomCheckBox";
            this.isHourRoomCheckBox.Size = new System.Drawing.Size(126, 16);
            this.isHourRoomCheckBox.TabIndex = 5;
            this.isHourRoomCheckBox.Text = "是否可作钟点房(&S)";
            this.isHourRoomCheckBox.UseVisualStyleBackColor = true;
            // 
            // phoneMyMaskBoxDigit
            // 
            this.phoneMyMaskBoxDigit.Location = new System.Drawing.Point(380, 359);
            this.phoneMyMaskBoxDigit.Name = "phoneMyMaskBoxDigit";
            this.phoneMyMaskBoxDigit.NumLength = 8;
            this.phoneMyMaskBoxDigit.Size = new System.Drawing.Size(147, 21);
            this.phoneMyMaskBoxDigit.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(91, 430);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(435, 21);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // roomTypeMyComboBoxNoEdit
            // 
            this.roomTypeMyComboBoxNoEdit.DataSource = this.roomtypeBindingSource;
            this.roomTypeMyComboBoxNoEdit.DisplayMember = "typeName";
            this.roomTypeMyComboBoxNoEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeMyComboBoxNoEdit.FormattingEnabled = true;
            this.roomTypeMyComboBoxNoEdit.Location = new System.Drawing.Point(380, 388);
            this.roomTypeMyComboBoxNoEdit.Name = "roomTypeMyComboBoxNoEdit";
            this.roomTypeMyComboBoxNoEdit.Size = new System.Drawing.Size(147, 20);
            this.roomTypeMyComboBoxNoEdit.TabIndex = 3;
            this.roomTypeMyComboBoxNoEdit.ValueMember = "type";
            // 
            // roomFloorsMyComboBoxNoEdit
            // 
            this.roomFloorsMyComboBoxNoEdit.DataSource = this.roomFloorsBindingSource;
            this.roomFloorsMyComboBoxNoEdit.DisplayMember = "floorName";
            this.roomFloorsMyComboBoxNoEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomFloorsMyComboBoxNoEdit.FormattingEnabled = true;
            this.roomFloorsMyComboBoxNoEdit.Location = new System.Drawing.Point(91, 389);
            this.roomFloorsMyComboBoxNoEdit.Name = "roomFloorsMyComboBoxNoEdit";
            this.roomFloorsMyComboBoxNoEdit.Size = new System.Drawing.Size(152, 20);
            this.roomFloorsMyComboBoxNoEdit.TabIndex = 2;
            this.roomFloorsMyComboBoxNoEdit.ValueMember = "floorId";
            // 
            // roomIdMyMaskBoxDigit
            // 
            this.roomIdMyMaskBoxDigit.Location = new System.Drawing.Point(91, 359);
            this.roomIdMyMaskBoxDigit.Name = "roomIdMyMaskBoxDigit";
            this.roomIdMyMaskBoxDigit.NumLength = 8;
            this.roomIdMyMaskBoxDigit.Size = new System.Drawing.Size(152, 21);
            this.roomIdMyMaskBoxDigit.TabIndex = 0;
            // 
            // dataGridViewManageTableRoomManage
            // 
            this.dataGridViewManageTableRoomManage.AllowUserToAddRows = false;
            this.dataGridViewManageTableRoomManage.AllowUserToDeleteRows = false;
            this.dataGridViewManageTableRoomManage.AutoGenerateColumns = false;
            this.dataGridViewManageTableRoomManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTableRoomManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn,
            this.floorNameDataGridViewTextBoxColumn,
            this.statusNameDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.isHourRoomDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewManageTableRoomManage.DataSource = this.roomManageBindingSource;
            this.dataGridViewManageTableRoomManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewManageTableRoomManage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageTableRoomManage.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewManageTableRoomManage.MultiSelect = false;
            this.dataGridViewManageTableRoomManage.Name = "dataGridViewManageTableRoomManage";
            this.dataGridViewManageTableRoomManage.RowTemplate.Height = 23;
            this.dataGridViewManageTableRoomManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageTableRoomManage.Size = new System.Drawing.Size(746, 327);
            this.dataGridViewManageTableRoomManage.TabIndex = 26;
            this.dataGridViewManageTableRoomManage.SelectionChanged += new System.EventHandler(this.dataGridViewManageTableRoomManage_SelectionChanged);
            // 
            // roomManageBindingSource
            // 
            this.roomManageBindingSource.DataSource = typeof(Hotels.DataModels.roomManage);
            // 
            // buttonAddMany
            // 
            this.buttonAddMany.Location = new System.Drawing.Point(572, 385);
            this.buttonAddMany.Name = "buttonAddMany";
            this.buttonAddMany.Size = new System.Drawing.Size(111, 23);
            this.buttonAddMany.TabIndex = 23;
            this.buttonAddMany.Text = "批量添加";
            this.buttonAddMany.UseVisualStyleBackColor = true;
            this.buttonAddMany.Click += new System.EventHandler(this.buttonAddMany_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(762, 485);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 492);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(148, 492);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(262, 492);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "修改";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(376, 492);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(490, 491);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "返回";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "房间号";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            // 
            // floorNameDataGridViewTextBoxColumn
            // 
            this.floorNameDataGridViewTextBoxColumn.DataPropertyName = "floorName";
            this.floorNameDataGridViewTextBoxColumn.HeaderText = "楼层";
            this.floorNameDataGridViewTextBoxColumn.Name = "floorNameDataGridViewTextBoxColumn";
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "statusName";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "房间状态";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            this.statusNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "房间类型";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // isHourRoomDataGridViewTextBoxColumn
            // 
            this.isHourRoomDataGridViewTextBoxColumn.DataPropertyName = "isHourRoom";
            this.isHourRoomDataGridViewTextBoxColumn.HeaderText = "是否可作钟点房";
            this.isHourRoomDataGridViewTextBoxColumn.Name = "isHourRoomDataGridViewTextBoxColumn";
            this.isHourRoomDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isHourRoomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isHourRoomDataGridViewTextBoxColumn.Width = 120;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "房间特征";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // 客房管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 527);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "客房管理";
            this.Text = "客房管理";
            this.Load += new System.EventHandler(this.客房管理_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTableRoomFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFloorsBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTableRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTableRoomManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomManageBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion      
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private DataGridViewManageTable.DataGridViewManageTable dataGridViewManageTableRoomType;
        private DataGridViewManageTable.DataGridViewManageTable dataGridViewManageTableRoomFloor;
        private System.Windows.Forms.Button buttonAddMany;
        private DataGridViewManageTable.DataGridViewManageTable dataGridViewManageTableRoomManage;
        private DataGridViewManageTable.MyMaskBoxDigit roomIdMyMaskBoxDigit;
        private DataGridViewManageTable.MyComboBoxNoEdit roomTypeMyComboBoxNoEdit;
        private DataGridViewManageTable.MyComboBoxNoEdit roomFloorsMyComboBoxNoEdit;
        private System.Windows.Forms.TextBox typeNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private DataGridViewManageTable.MyMaskBoxDigit phoneMyMaskBoxDigit;
        private System.Windows.Forms.CheckBox isHourRoomCheckBox;
        private DataGridViewManageTable.MyMaskBoxMoney myMaskBoxMoneyHourAddPrice;
        private DataGridViewManageTable.MyMaskBoxMoney myMaskBoxMoneyOnePrice;
        private DataGridViewManageTable.MyMaskBoxMoney myMaskBoxMoneyHourStartPrice;
        private System.Windows.Forms.TextBox textBoxFloorName;
        private System.Windows.Forms.BindingSource roomFloorsBindingSource;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn onePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourStartPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourAddPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource roomManageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isHourRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}