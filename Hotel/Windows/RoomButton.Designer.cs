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
            this.components = new System.ComponentModel.Container();
            this.listBox = new System.Windows.Forms.ListBox();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.房号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.入住登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联房开房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预订登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.修改房态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置为空房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置为修理中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置为预留房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置为即打扫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.维修房登记与查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量修改房态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripLive = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.换房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.换房ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.宾客续住ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.消费入账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.费用入账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.退房入账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripReserved = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.预订入住ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.批量修改房态ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripElse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripEmpty.SuspendLayout();
            this.contextMenuStripLive.SuspendLayout();
            this.contextMenuStripReserved.SuspendLayout();
            this.contextMenuStripElse.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotels.Properties.Settings.Default, "roomButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBox.Font = global::Hotels.Properties.Settings.Default.roomButtonFont;
            this.listBox.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(5, 4);
            this.listBox.MaximumSize = new System.Drawing.Size(93, 66);
            this.listBox.MinimumSize = new System.Drawing.Size(93, 66);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox.Size = new System.Drawing.Size(93, 64);
            this.listBox.TabIndex = 0;
            this.listBox.FontChanged += new System.EventHandler(this.listBox_FontChanged);
            this.listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            this.listBox.Click += new System.EventHandler(this.RoomButton_Click);
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房号ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.入住登记ToolStripMenuItem,
            this.联房开房ToolStripMenuItem,
            this.预订登记ToolStripMenuItem,
            this.toolStripSeparator2,
            this.修改房态ToolStripMenuItem,
            this.批量修改房态ToolStripMenuItem});
            this.contextMenuStripEmpty.Name = "contextMenuStrip";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(149, 170);
            // 
            // 房号ToolStripMenuItem
            // 
            this.房号ToolStripMenuItem.Name = "房号ToolStripMenuItem";
            this.房号ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 入住登记ToolStripMenuItem
            // 
            this.入住登记ToolStripMenuItem.Name = "入住登记ToolStripMenuItem";
            this.入住登记ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.入住登记ToolStripMenuItem.Text = "入住登记";
            this.入住登记ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // 联房开房ToolStripMenuItem
            // 
            this.联房开房ToolStripMenuItem.Name = "联房开房ToolStripMenuItem";
            this.联房开房ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.联房开房ToolStripMenuItem.Text = "联房开房";
            this.联房开房ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // 预订登记ToolStripMenuItem
            // 
            this.预订登记ToolStripMenuItem.Name = "预订登记ToolStripMenuItem";
            this.预订登记ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.预订登记ToolStripMenuItem.Text = "预定登记";
            this.预订登记ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // 修改房态ToolStripMenuItem
            // 
            this.修改房态ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.置为空房间ToolStripMenuItem,
            this.置为ToolStripMenuItem,
            this.置为修理中ToolStripMenuItem,
            this.置为预留房ToolStripMenuItem,
            this.置为即打扫ToolStripMenuItem,
            this.toolStripSeparator3,
            this.维修房登记与查询ToolStripMenuItem});
            this.修改房态ToolStripMenuItem.Name = "修改房态ToolStripMenuItem";
            this.修改房态ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改房态ToolStripMenuItem.Text = "修改房态";
            // 
            // 置为空房间ToolStripMenuItem
            // 
            this.置为空房间ToolStripMenuItem.Name = "置为空房间ToolStripMenuItem";
            this.置为空房间ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.置为空房间ToolStripMenuItem.Text = "置为空房间";
            this.置为空房间ToolStripMenuItem.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // 置为ToolStripMenuItem
            // 
            this.置为ToolStripMenuItem.Name = "置为ToolStripMenuItem";
            this.置为ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.置为ToolStripMenuItem.Text = "置为打扫中";
            this.置为ToolStripMenuItem.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // 置为修理中ToolStripMenuItem
            // 
            this.置为修理中ToolStripMenuItem.Name = "置为修理中ToolStripMenuItem";
            this.置为修理中ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.置为修理中ToolStripMenuItem.Text = "置为修理中";
            this.置为修理中ToolStripMenuItem.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // 置为预留房ToolStripMenuItem
            // 
            this.置为预留房ToolStripMenuItem.Name = "置为预留房ToolStripMenuItem";
            this.置为预留房ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.置为预留房ToolStripMenuItem.Text = "置为预留房";
            this.置为预留房ToolStripMenuItem.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // 置为即打扫ToolStripMenuItem
            // 
            this.置为即打扫ToolStripMenuItem.Name = "置为即打扫ToolStripMenuItem";
            this.置为即打扫ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.置为即打扫ToolStripMenuItem.Text = "置为即打扫";
            this.置为即打扫ToolStripMenuItem.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // 维修房登记与查询ToolStripMenuItem
            // 
            this.维修房登记与查询ToolStripMenuItem.Name = "维修房登记与查询ToolStripMenuItem";
            this.维修房登记与查询ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.维修房登记与查询ToolStripMenuItem.Text = "维修房登记与查询";
            this.维修房登记与查询ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // 批量修改房态ToolStripMenuItem
            // 
            this.批量修改房态ToolStripMenuItem.Name = "批量修改房态ToolStripMenuItem";
            this.批量修改房态ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.批量修改房态ToolStripMenuItem.Text = "批量修改房态";
            this.批量修改房态ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // contextMenuStripLive
            // 
            this.contextMenuStripLive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.换房ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripSeparator4,
            this.换房ToolStripMenuItem1,
            this.宾客续住ToolStripMenuItem,
            this.toolStripSeparator5,
            this.消费入账ToolStripMenuItem,
            this.费用入账ToolStripMenuItem,
            this.toolStripSeparator6,
            this.退房入账ToolStripMenuItem});
            this.contextMenuStripLive.Name = "contextMenuStripLive";
            this.contextMenuStripLive.Size = new System.Drawing.Size(125, 176);
            // 
            // 换房ToolStripMenuItem
            // 
            this.换房ToolStripMenuItem.Name = "换房ToolStripMenuItem";
            this.换房ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(121, 6);
            // 
            // 换房ToolStripMenuItem1
            // 
            this.换房ToolStripMenuItem1.Name = "换房ToolStripMenuItem1";
            this.换房ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.换房ToolStripMenuItem1.Text = "换房";
            this.换房ToolStripMenuItem1.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // 宾客续住ToolStripMenuItem
            // 
            this.宾客续住ToolStripMenuItem.Name = "宾客续住ToolStripMenuItem";
            this.宾客续住ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.宾客续住ToolStripMenuItem.Text = "宾客续住";
            this.宾客续住ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(121, 6);
            // 
            // 消费入账ToolStripMenuItem
            // 
            this.消费入账ToolStripMenuItem.Name = "消费入账ToolStripMenuItem";
            this.消费入账ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.消费入账ToolStripMenuItem.Text = "消费入账";
            this.消费入账ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // 费用入账ToolStripMenuItem
            // 
            this.费用入账ToolStripMenuItem.Name = "费用入账ToolStripMenuItem";
            this.费用入账ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.费用入账ToolStripMenuItem.Text = "费用入账";
            this.费用入账ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(121, 6);
            // 
            // 退房入账ToolStripMenuItem
            // 
            this.退房入账ToolStripMenuItem.Name = "退房入账ToolStripMenuItem";
            this.退房入账ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退房入账ToolStripMenuItem.Text = "退房结账";
            this.退房入账ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // contextMenuStripReserved
            // 
            this.contextMenuStripReserved.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator7,
            this.预订入住ToolStripMenuItem,
            this.toolStripSeparator8,
            this.toolStripMenuItem1,
            this.批量修改房态ToolStripMenuItem1});
            this.contextMenuStripReserved.Name = "contextMenuStripReserved";
            this.contextMenuStripReserved.Size = new System.Drawing.Size(149, 126);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 22);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(148, 22);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(145, 6);
            // 
            // 预订入住ToolStripMenuItem
            // 
            this.预订入住ToolStripMenuItem.Name = "预订入住ToolStripMenuItem";
            this.预订入住ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.预订入住ToolStripMenuItem.Text = "预订入住";
            this.预订入住ToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripSeparator9,
            this.toolStripMenuItem11});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "修改房态";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem6.Text = "置为空房间";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem7.Text = "置为打扫中";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem8.Text = "置为修理中";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem9.Text = "置为预留房";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem10.Text = "置为即打扫";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem11.Text = "维修房登记与查询";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // 批量修改房态ToolStripMenuItem1
            // 
            this.批量修改房态ToolStripMenuItem1.Name = "批量修改房态ToolStripMenuItem1";
            this.批量修改房态ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.批量修改房态ToolStripMenuItem1.Text = "批量修改房态";
            this.批量修改房态ToolStripMenuItem1.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // contextMenuStripElse
            // 
            this.contextMenuStripElse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripSeparator10,
            this.toolStripMenuItem15,
            this.toolStripMenuItem22});
            this.contextMenuStripElse.Name = "contextMenuStripElse";
            this.contextMenuStripElse.Size = new System.Drawing.Size(153, 120);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(152, 22);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(152, 22);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripSeparator12,
            this.toolStripMenuItem21});
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem15.Text = "修改房态";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem16.Text = "置为空房间";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem17.Text = "置为打扫中";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem18.Text = "置为修理中";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem19.Text = "置为预留房";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem20.Text = "置为即打扫";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.UpdateRoomStatue);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem21.Text = "维修房登记与查询";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem22.Text = "批量修改房态";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // RoomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataBindings.Add(new System.Windows.Forms.Binding("Size", global::Hotels.Properties.Settings.Default, "roomButtonSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F);
            this.Name = "RoomButton";
            this.Size = global::Hotels.Properties.Settings.Default.roomButtonSize;
            this.Load += new System.EventHandler(this.RoomButton_Load);
            this.Click += new System.EventHandler(this.RoomButton_Click);
            this.BackColorChanged += new System.EventHandler(this.RoomButton_BackColorChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            this.SizeChanged += new System.EventHandler(this.RoomButton_SizeChanged);
            this.contextMenuStripEmpty.ResumeLayout(false);
            this.contextMenuStripLive.ResumeLayout(false);
            this.contextMenuStripReserved.ResumeLayout(false);
            this.contextMenuStripElse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.ToolStripMenuItem 房号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 入住登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联房开房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预订登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 修改房态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置为空房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置为修理中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置为预留房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置为即打扫ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 维修房登记与查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量修改房态ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLive;
        private System.Windows.Forms.ToolStripMenuItem 换房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 换房ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 宾客续住ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 消费入账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 费用入账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 退房入账ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripReserved;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 预订入住ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem 批量修改房态ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripElse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;

















    }
}
