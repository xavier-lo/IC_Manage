namespace IC_MAN
{
    partial class Manage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_QuaryItems = new System.Windows.Forms.ComboBox();
            this.CB_QueryOption = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.IC卡号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发卡时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.有效时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.有效次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.有效楼层 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发卡管理员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_SearchItemData = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_QuaryItems);
            this.groupBox1.Controls.Add(this.CB_QueryOption);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DGV_Data);
            this.groupBox1.Controls.Add(this.TB_SearchItemData);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1281, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IC卡信息查询";
            this.groupBox1.Layout += new System.Windows.Forms.LayoutEventHandler(this.groupBox1_Layout);
            // 
            // CB_QuaryItems
            // 
            this.CB_QuaryItems.FormattingEnabled = true;
            this.CB_QuaryItems.Items.AddRange(new object[] {
            "IC卡号：",
            "用户名：",
            "发卡日期："});
            this.CB_QuaryItems.Location = new System.Drawing.Point(540, 34);
            this.CB_QuaryItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_QuaryItems.Name = "CB_QuaryItems";
            this.CB_QuaryItems.Size = new System.Drawing.Size(151, 26);
            this.CB_QuaryItems.TabIndex = 11;
            // 
            // CB_QueryOption
            // 
            this.CB_QueryOption.FormattingEnabled = true;
            this.CB_QueryOption.Items.AddRange(new object[] {
            "写卡记录",
            "实时信息"});
            this.CB_QueryOption.Location = new System.Drawing.Point(240, 33);
            this.CB_QueryOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_QueryOption.Name = "CB_QueryOption";
            this.CB_QueryOption.Size = new System.Drawing.Size(152, 26);
            this.CB_QueryOption.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "查询选项：";
            // 
            // DGV_Data
            // 
            this.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IC卡号,
            this.用户名,
            this.身份证,
            this.发卡时间,
            this.有效时间,
            this.有效次数,
            this.有效楼层,
            this.发卡管理员});
            this.DGV_Data.Location = new System.Drawing.Point(10, 93);
            this.DGV_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Data.Name = "DGV_Data";
            this.DGV_Data.RowTemplate.Height = 23;
            this.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Data.Size = new System.Drawing.Size(1258, 363);
            this.DGV_Data.TabIndex = 8;
            // 
            // IC卡号
            // 
            this.IC卡号.HeaderText = "IC卡号";
            this.IC卡号.Name = "IC卡号";
            this.IC卡号.ReadOnly = true;
            this.IC卡号.Width = 70;
            // 
            // 用户名
            // 
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            this.用户名.ReadOnly = true;
            this.用户名.Width = 70;
            // 
            // 身份证
            // 
            this.身份证.HeaderText = "身份证";
            this.身份证.Name = "身份证";
            this.身份证.ReadOnly = true;
            // 
            // 发卡时间
            // 
            this.发卡时间.HeaderText = "发卡时间";
            this.发卡时间.Name = "发卡时间";
            this.发卡时间.ReadOnly = true;
            this.发卡时间.Width = 140;
            // 
            // 有效时间
            // 
            this.有效时间.HeaderText = "有效时间";
            this.有效时间.Name = "有效时间";
            this.有效时间.ReadOnly = true;
            this.有效时间.Width = 140;
            // 
            // 有效次数
            // 
            this.有效次数.HeaderText = "有效次数";
            this.有效次数.Name = "有效次数";
            this.有效次数.ReadOnly = true;
            this.有效次数.Width = 80;
            // 
            // 有效楼层
            // 
            this.有效楼层.HeaderText = "有效楼层";
            this.有效楼层.Name = "有效楼层";
            this.有效楼层.ReadOnly = true;
            this.有效楼层.Width = 80;
            // 
            // 发卡管理员
            // 
            this.发卡管理员.HeaderText = "发卡管理员";
            this.发卡管理员.Name = "发卡管理员";
            this.发卡管理员.ReadOnly = true;
            this.发卡管理员.Width = 90;
            // 
            // TB_SearchItemData
            // 
            this.TB_SearchItemData.Location = new System.Drawing.Point(702, 33);
            this.TB_SearchItemData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_SearchItemData.Name = "TB_SearchItemData";
            this.TB_SearchItemData.Size = new System.Drawing.Size(148, 28);
            this.TB_SearchItemData.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1000, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Layout += new System.Windows.Forms.LayoutEventHandler(this.button1_Layout);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Manage";
            this.Size = new System.Drawing.Size(1305, 480);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_SearchItemData;
        private System.Windows.Forms.DataGridView DGV_Data;
        private System.Windows.Forms.ComboBox CB_QueryOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IC卡号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发卡时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效次数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效楼层;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发卡管理员;
        private System.Windows.Forms.ComboBox CB_QuaryItems;
    }
}
