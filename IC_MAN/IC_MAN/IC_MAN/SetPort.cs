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
    public partial class SetPort : Form
    {
        public SetPort()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (CB_COM_PORT.SelectedItem != null)
            {   /*fp文件 用于存放选择的端口号*/
                FileStream fport = new FileStream("fp", FileMode.Open);
                StreamWriter sw = new StreamWriter(fport);
                sw.WriteLine(CB_COM_PORT.SelectedItem.ToString());
                sw.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("端口不能为空！");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPort_Load(object sender, EventArgs e)
        {
            Oprate_PortCom com = new Oprate_PortCom();
            List<string> list = new List<string>(com.GetComList());
            CB_COM_PORT.Items.Clear();
            foreach (string sName in list)
            {
                CB_COM_PORT.Items.Add(sName);
            }
        }
    }
}
