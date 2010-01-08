namespace Hotels.Windows
{
    partial class RoomButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "hao",
            "hao",
            "hao",
            "hao"});
            this.listBox.Location = new System.Drawing.Point(8, 9);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox.Size = new System.Drawing.Size(107, 52);
            this.listBox.TabIndex = 0;
            this.listBox.Click += new System.EventHandler(this.RoomButton_Click);
            // 
            // RoomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "RoomButton";
            this.Size = new System.Drawing.Size(123, 71);
            this.Load += new System.EventHandler(this.RoomButton_Load);
            this.Click += new System.EventHandler(this.RoomButton_Click);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.ListBox listBox;












    }
}
