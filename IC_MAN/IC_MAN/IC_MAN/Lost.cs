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
    public partial class Lost : UserControl
    {
        public Lost()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NPOI_OprateExcl.ReadFromExclFile(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 1, DGV_Lost, TB_SearchICID.Text);
         }

        private void DGV_Lost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (DGV_Lost.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
            { //获取当前被点击的单元格  
                DataGridViewButtonCell vCell = (DataGridViewButtonCell)DGV_Lost.CurrentCell;
                if (vCell.Value.ToString() != "已挂失") 
                { 
                    NPOI_OprateExcl.ModifyACellToExcel(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 1, e.RowIndex, 13, true);
                    NPOI_OprateExcl.ReadFromExclFile(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 1, DGV_Lost,"");
                }                
            }
        }
    }
}
