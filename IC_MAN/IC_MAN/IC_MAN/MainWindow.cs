using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace IC_MAN
{
    public partial class MainWindow : Form
    {
        public OneCard oneCard;
        public Manage manage;
        public Lost lost;
        public string ComPort;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void 通信设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPort set = new SetPort();
            set.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            bool internet = false;
            /*新建fp文件 用于存放选择的端口号*/
            FileStream fport = new FileStream("fp", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fport);
            sw.Close();
            oneCard = new OneCard();
            manage = new Manage();
            lost = new Lost();
            internet = InternetCheck.IsConnectInternet();
            if (internet)
            {                
                SLB_Internet.Text="已接入互联网";
                DataTable dt=NPOI_OprateExcl.ExcelToTable(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 0);
                OparateMySQL.UpdateToMySQL(dt,0);
                dt = NPOI_OprateExcl.ExcelToTable(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 1);
                OparateMySQL.UpdateToMySQL(dt, 1);

            }
            else {
                SLB_Internet.Text = "未接入互联网";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oneCard.Show();
            BasePl.Controls.Clear();
            BasePl.Controls.Add(oneCard);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manage.Show();
            BasePl.Controls.Clear();
            BasePl.Controls.Add(manage);
        }

        private void 单卡管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oneCard.Show();
            BasePl.Controls.Clear();
            BasePl.Controls.Add(oneCard);
        }

        private void 列表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage.Show();
            BasePl.Controls.Clear();
            BasePl.Controls.Add(manage);
        }

        private void 挂失处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lost.Show();
            BasePl.Controls.Clear();
            BasePl.Controls.Add(lost);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
             if (SLB_Internet.Text.ToString() == "已接入互联网")
            {
                DataTable dt = NPOI_OprateExcl.ExcelToTable(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 0);
                OparateMySQL.UpdateToMySQL(dt, 0);
                dt = NPOI_OprateExcl.ExcelToTable(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 1);
                OparateMySQL.UpdateToMySQL(dt, 1);
            }
        }

        private void 许可管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }




    }
}
