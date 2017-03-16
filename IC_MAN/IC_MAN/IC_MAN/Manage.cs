using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC_MAN
{
    public partial class Manage : UserControl
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NPOI_OprateExcl.ReadExcelFile(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", CB_QueryOption.SelectedIndex, DGV_Data,TB_SearchItemData.Text,CB_QuaryItems.SelectedIndex);
        }

        private void button1_Layout(object sender, LayoutEventArgs e)
        {
            CB_QueryOption.SelectedIndex = 0;
        }

        private void groupBox1_Layout(object sender, LayoutEventArgs e)
        {
            CB_QuaryItems.SelectedIndex = 0;
        }
    }
}
