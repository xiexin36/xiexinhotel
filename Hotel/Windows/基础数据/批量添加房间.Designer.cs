namespace Hotels.Windows
{
    partial class 批量添加房间
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myMaskBoxDigitStartNum = new DataGridViewManageTable.MyMaskBoxDigit(this.components);
            this.myMaskBoxDigitEndNum = new DataGridViewManageTable.MyMaskBoxDigit(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxLastNum = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.myMaskBoxDigitRoomPhone = new DataGridViewManageTable.MyMaskBoxDigit(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.myComboBoxNoEditRoomType = new DataGridViewManageTable.MyComboBoxNoEdit(this.components);
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myComboBoxNoEditRoomFloor = new DataGridViewManageTable.MyComboBoxNoEdit(this.components);
            this.roomFloorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxIsHourRoom = new System.Windows.Forms.CheckBox();
            this.buttonAddMany = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFloorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房号从:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "至";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(361, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "提示:房号只能输入数字";
            // 
            // myMaskBoxDigitStartNum
            // 
            this.myMaskBoxDigitStartNum.Location = new System.Drawing.Point(89, 10);
            this.myMaskBoxDigitStartNum.Name = "myMaskBoxDigitStartNum";
            this.myMaskBoxDigitStartNum.Size = new System.Drawing.Size(95, 21);
            this.myMaskBoxDigitStartNum.TabIndex = 2;
            // 
            // myMaskBoxDigitEndNum
            // 
            this.myMaskBoxDigitEndNum.Location = new System.Drawing.Point(245, 10);
            this.myMaskBoxDigitEndNum.Name = "myMaskBoxDigitEndNum";
            this.myMaskBoxDigitEndNum.Size = new System.Drawing.Size(84, 21);
            this.myMaskBoxDigitEndNum.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "房号尾数为:";
            // 
            // checkedListBoxLastNum
            // 
            this.checkedListBoxLastNum.CheckOnClick = true;
            this.checkedListBoxLastNum.ColumnWidth = 30;
            this.checkedListBoxLastNum.FormattingEnabled = true;
            this.checkedListBoxLastNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.checkedListBoxLastNum.Location = new System.Drawing.Point(89, 52);
            this.checkedListBoxLastNum.MultiColumn = true;
            this.checkedListBoxLastNum.Name = "checkedListBoxLastNum";
            this.checkedListBoxLastNum.Size = new System.Drawing.Size(157, 36);
            this.checkedListBoxLastNum.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "的房间不添加";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(361, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "提示:可以进行多选";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "分机号码在房号前加:";
            // 
            // myMaskBoxDigitRoomPhone
            // 
            this.myMaskBoxDigitRoomPhone.Location = new System.Drawing.Point(137, 107);
            this.myMaskBoxDigitRoomPhone.Name = "myMaskBoxDigitRoomPhone";
            this.myMaskBoxDigitRoomPhone.Size = new System.Drawing.Size(192, 21);
            this.myMaskBoxDigitRoomPhone.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(361, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "提示:如果分机号码和房号相同此处不用填写";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "楼层:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "类型:";
            // 
            // myComboBoxNoEditRoomType
            // 
            this.myComboBoxNoEditRoomType.DataSource = this.roomtypeBindingSource;
            this.myComboBoxNoEditRoomType.DisplayMember = "typeName";
            this.myComboBoxNoEditRoomType.FormattingEnabled = true;
            this.myComboBoxNoEditRoomType.Location = new System.Drawing.Point(89, 147);
            this.myComboBoxNoEditRoomType.Name = "myComboBoxNoEditRoomType";
            this.myComboBoxNoEditRoomType.Size = new System.Drawing.Size(133, 20);
            this.myComboBoxNoEditRoomType.TabIndex = 6;
            this.myComboBoxNoEditRoomType.ValueMember = "type";
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataSource = typeof(Hotels.DataModels.roomTypeView);
            // 
            // myComboBoxNoEditRoomFloor
            // 
            this.myComboBoxNoEditRoomFloor.DataSource = this.roomFloorsBindingSource;
            this.myComboBoxNoEditRoomFloor.DisplayMember = "floorName";
            this.myComboBoxNoEditRoomFloor.FormattingEnabled = true;
            this.myComboBoxNoEditRoomFloor.Location = new System.Drawing.Point(89, 182);
            this.myComboBoxNoEditRoomFloor.Name = "myComboBoxNoEditRoomFloor";
            this.myComboBoxNoEditRoomFloor.Size = new System.Drawing.Size(133, 20);
            this.myComboBoxNoEditRoomFloor.TabIndex = 6;
            this.myComboBoxNoEditRoomFloor.ValueMember = "floorId";
            // 
            // roomFloorsBindingSource
            // 
            this.roomFloorsBindingSource.DataSource = typeof(Hotels.DataModels.roomFloorsView);
            // 
            // checkBoxIsHourRoom
            // 
            this.checkBoxIsHourRoom.AutoSize = true;
            this.checkBoxIsHourRoom.Location = new System.Drawing.Point(233, 150);
            this.checkBoxIsHourRoom.Name = "checkBoxIsHourRoom";
            this.checkBoxIsHourRoom.Size = new System.Drawing.Size(96, 16);
            this.checkBoxIsHourRoom.TabIndex = 7;
            this.checkBoxIsHourRoom.Text = "可作为钟点房";
            this.checkBoxIsHourRoom.UseVisualStyleBackColor = true;
            // 
            // buttonAddMany
            // 
            this.buttonAddMany.Location = new System.Drawing.Point(147, 225);
            this.buttonAddMany.Name = "buttonAddMany";
            this.buttonAddMany.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMany.TabIndex = 8;
            this.buttonAddMany.Text = "批量添加";
            this.buttonAddMany.UseVisualStyleBackColor = true;
            this.buttonAddMany.Click += new System.EventHandler(this.buttonAddMany_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(341, 225);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // 批量添加房间
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 260);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddMany);
            this.Controls.Add(this.checkBoxIsHourRoom);
            this.Controls.Add(this.myComboBoxNoEditRoomFloor);
            this.Controls.Add(this.myComboBoxNoEditRoomType);
            this.Controls.Add(this.myMaskBoxDigitRoomPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBoxLastNum);
            this.Controls.Add(this.myMaskBoxDigitEndNum);
            this.Controls.Add(this.myMaskBoxDigitStartNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "批量添加房间";
            this.Text = "批量添加房间";
            this.Load += new System.EventHandler(this.批量添加房间_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFloorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataGridViewManageTable.MyMaskBoxDigit myMaskBoxDigitStartNum;
        private DataGridViewManageTable.MyMaskBoxDigit myMaskBoxDigitEndNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBoxLastNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DataGridViewManageTable.MyMaskBoxDigit myMaskBoxDigitRoomPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DataGridViewManageTable.MyComboBoxNoEdit myComboBoxNoEditRoomType;
        private DataGridViewManageTable.MyComboBoxNoEdit myComboBoxNoEditRoomFloor;
        private System.Windows.Forms.CheckBox checkBoxIsHourRoom;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private System.Windows.Forms.BindingSource roomFloorsBindingSource;
        private System.Windows.Forms.Button buttonAddMany;
        private System.Windows.Forms.Button buttonClose;
    }
}