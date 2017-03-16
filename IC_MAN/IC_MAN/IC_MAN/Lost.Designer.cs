namespace IC_MAN
{
    partial class Lost
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
            this.DGV_Lost = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.TB_SearchICID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IC卡号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.挂失时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.挂失管理员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.挂失状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.挂失操作 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lost)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Lost
            // 
            this.DGV_Lost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Lost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IC卡号,
            this.用户名,
            this.挂失时间,
            this.挂失管理员,
            this.挂失状态,
            this.挂失操作});
            this.DGV_Lost.Location = new System.Drawing.Point(73, 51);
            this.DGV_Lost.Name = "DGV_Lost";
            this.DGV_Lost.RowTemplate.Height = 23;
            this.DGV_Lost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Lost.Size = new System.Drawing.Size(704, 258);
            this.DGV_Lost.TabIndex = 11;
            this.DGV_Lost.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Lost_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB_SearchICID
            // 
            this.TB_SearchICID.Location = new System.Drawing.Point(320, 21);
            this.TB_SearchICID.Name = "TB_SearchICID";
            this.TB_SearchICID.Size = new System.Drawing.Size(100, 21);
            this.TB_SearchICID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "IC卡号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Lost);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_SearchICID);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 314);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IC卡挂失及无效状态查询";
            // 
            // IC卡号
            // 
            this.IC卡号.HeaderText = "IC卡号";
            this.IC卡号.Name = "IC卡号";
            this.IC卡号.ReadOnly = true;
            // 
            // 用户名
            // 
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            this.用户名.ReadOnly = true;
            // 
            // 挂失时间
            // 
            this.挂失时间.HeaderText = "挂失时间";
            this.挂失时间.Name = "挂失时间";
            this.挂失时间.ReadOnly = true;
            // 
            // 挂失管理员
            // 
            this.挂失管理员.HeaderText = "挂失管理员";
            this.挂失管理员.Name = "挂失管理员";
            this.挂失管理员.ReadOnly = true;
            // 
            // 挂失状态
            // 
            this.挂失状态.HeaderText = "挂失及无效状态";
            this.挂失状态.Name = "挂失状态";
            this.挂失状态.ReadOnly = true;
            this.挂失状态.Width = 140;
            // 
            // 挂失操作
            // 
            this.挂失操作.HeaderText = "挂失操作";
            this.挂失操作.Name = "挂失操作";
            this.挂失操作.Text = "";
            // 
            // Lost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.groupBox1);
            this.Name = "Lost";
            this.Size = new System.Drawing.Size(870, 320);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lost)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Lost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TB_SearchICID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IC卡号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 挂失时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 挂失管理员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 挂失状态;
        private System.Windows.Forms.DataGridViewButtonColumn 挂失操作;
    }
}
