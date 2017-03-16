namespace IC_MAN
{
    partial class MainWindow
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通信设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.许可管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单卡管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.挂失处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作说明书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasePl = new System.Windows.Forms.Panel();
            this.SS_States = new System.Windows.Forms.StatusStrip();
            this.SLB_Internet = new System.Windows.Forms.ToolStripStatusLabel();
            this.用户登录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SS_States.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通信设置ToolStripMenuItem,
            this.许可管理ToolStripMenuItem,
            this.用户登录DToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.选项ToolStripMenuItem.Text = "选项(&O)";
            // 
            // 通信设置ToolStripMenuItem
            // 
            this.通信设置ToolStripMenuItem.Name = "通信设置ToolStripMenuItem";
            this.通信设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.通信设置ToolStripMenuItem.Text = "通信设置(&C)";
            this.通信设置ToolStripMenuItem.Click += new System.EventHandler(this.通信设置ToolStripMenuItem_Click);
            // 
            // 许可管理ToolStripMenuItem
            // 
            this.许可管理ToolStripMenuItem.Name = "许可管理ToolStripMenuItem";
            this.许可管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.许可管理ToolStripMenuItem.Text = "许可管理(&L)";
            this.许可管理ToolStripMenuItem.Click += new System.EventHandler(this.许可管理ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出(&Q)";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单卡管理ToolStripMenuItem,
            this.列表管理ToolStripMenuItem,
            this.挂失处理ToolStripMenuItem});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.管理ToolStripMenuItem.Text = "管理(&M)";
            // 
            // 单卡管理ToolStripMenuItem
            // 
            this.单卡管理ToolStripMenuItem.Name = "单卡管理ToolStripMenuItem";
            this.单卡管理ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.单卡管理ToolStripMenuItem.Text = "单卡发布(&W)";
            this.单卡管理ToolStripMenuItem.Click += new System.EventHandler(this.单卡管理ToolStripMenuItem_Click);
            // 
            // 列表管理ToolStripMenuItem
            // 
            this.列表管理ToolStripMenuItem.Name = "列表管理ToolStripMenuItem";
            this.列表管理ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.列表管理ToolStripMenuItem.Text = "IC卡信息查询(&I)";
            this.列表管理ToolStripMenuItem.Click += new System.EventHandler(this.列表管理ToolStripMenuItem_Click);
            // 
            // 挂失处理ToolStripMenuItem
            // 
            this.挂失处理ToolStripMenuItem.Name = "挂失处理ToolStripMenuItem";
            this.挂失处理ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.挂失处理ToolStripMenuItem.Text = "IC卡挂失及无效状态查询(&N)";
            this.挂失处理ToolStripMenuItem.Click += new System.EventHandler(this.挂失处理ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作说明书ToolStripMenuItem,
            this.版本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 操作说明书ToolStripMenuItem
            // 
            this.操作说明书ToolStripMenuItem.Name = "操作说明书ToolStripMenuItem";
            this.操作说明书ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.操作说明书ToolStripMenuItem.Text = "操作说明书(&D)";
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.版本ToolStripMenuItem.Text = "版本(&V)";
            // 
            // BasePl
            // 
            this.BasePl.Location = new System.Drawing.Point(7, 32);
            this.BasePl.Name = "BasePl";
            this.BasePl.Size = new System.Drawing.Size(870, 320);
            this.BasePl.TabIndex = 1;
            // 
            // SS_States
            // 
            this.SS_States.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SLB_Internet});
            this.SS_States.Location = new System.Drawing.Point(0, 357);
            this.SS_States.Name = "SS_States";
            this.SS_States.Size = new System.Drawing.Size(884, 22);
            this.SS_States.TabIndex = 2;
            this.SS_States.Text = "statusStrip1";
            // 
            // SLB_Internet
            // 
            this.SLB_Internet.Name = "SLB_Internet";
            this.SLB_Internet.Size = new System.Drawing.Size(0, 17);
            // 
            // 用户登录DToolStripMenuItem
            // 
            this.用户登录DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.添加用户ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.用户登录DToolStripMenuItem.Name = "用户登录DToolStripMenuItem";
            this.用户登录DToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.用户登录DToolStripMenuItem.Text = "用户(&D)";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.登录ToolStripMenuItem.Text = "用户登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 379);
            this.Controls.Add(this.SS_States);
            this.Controls.Add(this.BasePl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "IC卡管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SS_States.ResumeLayout(false);
            this.SS_States.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通信设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.Panel BasePl;
        private System.Windows.Forms.ToolStripMenuItem 单卡管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip SS_States;
        private System.Windows.Forms.ToolStripMenuItem 挂失处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 许可管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作说明书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel SLB_Internet;
        private System.Windows.Forms.ToolStripMenuItem 用户登录DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
    }
}

