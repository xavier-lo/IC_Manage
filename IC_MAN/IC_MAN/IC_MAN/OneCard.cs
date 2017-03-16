using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace IC_MAN
{
    public partial class OneCard : UserControl
    {
     
        public OneCard()
        {
            InitializeComponent();
        }

        private void TB_CarTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允许输入:数字、退格键(8)、全选(1)、复制(3)、粘贴(22)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&
            e.KeyChar != 1 && e.KeyChar != 3 && e.KeyChar != 22)
            {
                e.Handled = true;
            }
        }

        private void TB_icID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允许输入:数字、退格键(8)、全选(1)、复制(3)、粘贴(22)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&
            e.KeyChar != 1 && e.KeyChar != 3 && e.KeyChar != 22)
            {
                e.Handled = true;
            }
        }

        private void TB_userID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允许输入:数字、退格键(8)、全选(1)、复制(3)、粘贴(22)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&
            e.KeyChar != 1 && e.KeyChar != 3 && e.KeyChar != 22)
            {
                e.Handled = true;
            }
        }

        private void TB_comtact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允许输入:数字、退格键(8)、全选(1)、复制(3)、粘贴(22)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&
            e.KeyChar != 1 && e.KeyChar != 3 && e.KeyChar != 22)
            {
                e.Handled = true;
            }
        }

        private void BTN_WriteCard_Click(object sender, EventArgs e)
        {
            try
            {
                /*写入数据到写卡信息*/
                if (TB_icID.Text == "")
                {
                    MessageBox.Show("IC卡号不能为空!");
                }
                else
                {
                    List<Card> newc = new List<Card>();
                    List<int> floor = new List<int>();
                    DateTime time = DateTime.Now;
                    object[] data = { 0, "", (Int64)0, 0, 0, "", "", false, false, time, 0, time, false, 0, "", time };
                    Int64 userid = 0;
                    int contact = 0;
                    if (TB_userID.Text == "") userid = 000000000000000000;
                    else if (Convert.ToInt64(TB_userID.Text) < 100000000000000000) userid = 000000000000000000;
                    else userid = Convert.ToInt64(TB_userID.Text);
                    if (TB_comtact.Text != "") contact = Convert.ToInt32(TB_comtact.Text);

                    if (TC_Car.SelectedTab.Name == "TP_Incar")
                    {
                        if ((CKB_InFloor.SelectedItems.Count == 0) || (TB_InCount.Text == ""))
                        {
                            MessageBox.Show("控制楼层和有效次数不能为空！");
                        }
                        else
                        {
                            List<int> floor0 = new List<int>();
                            bool style = false, style1 = false;
                            for (int i = 0; i < CKB_InFloor.Items.Count; i++)
                            {
                                if (CKB_InFloor.GetItemChecked(i) == true)
                                    floor0.Add(i + 1);
                            }
                            if (RB_InAutocheck.Checked) style = true;
                            else if (RB_InHandlecheck.Checked) style = false;

                            if (RB_InHold5s.Checked) style1 = true;
                            else if (RB_InNoHold5s.Checked) style1 = false;
                            newc.Add(new Card
                            {
                                ICID = int.Parse(TB_icID.Text),
                                UserName = TB_userName.Text,
                                UserID = userid,
                                LiveDepart = TB_userRom.Text,
                                Contact = contact,
                                Position = TC_Car.SelectedTab.Name,
                                ControlFloor = floor0,
                                CallStyle = style,
                                Keep5s = style1,
                                ValidTime = DTP_In.Value,
                                ValidCount = int.Parse(TB_InCount.Text),
                                WriteTime = DateTime.Now,
                                ADID = int.Parse(TB_ADID.Text),
                                ADName = TB_ADName.Text,
                                LostState = false,
                            });
                            data[0] = newc[0].ICID;
                            data[1] = newc[0].UserName;
                            data[3] = newc[0].LiveDepart;
                            data[4] = newc[0].Contact;
                            data[5] = newc[0].Position;
                            data[7] = newc[0].CallStyle;
                            data[8] = newc[0].Keep5s;
                            data[9] = newc[0].ValidTime;
                            data[10] = newc[0].ValidCount;
                            data[11] = newc[0].WriteTime;
                            data[12] = newc[0].LostState;
                            data[14] = newc[0].ADName;
                            data[15] = newc[0].LostTime;
                            string str1 = null;
                            foreach (var xx in newc[0].ControlFloor)
                            {
                                // str1 += acct.ControlFloor[xx - 1].ToString() + ",";
                                str1 += xx.ToString() + ",";
                            }
                            data[6] = str1;
                            if (newc[0].UserID != 0) data[2] = newc[0].UserID;
                            if (newc[0].ADID != 0) data[13] = newc[0].ADID;
                            NPOI_OprateExcl.UpdateExcl(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 0, 1, data);
                            NPOI_OprateExcl.UpdatetoExcl(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 1, 1, data);
                            MessageBox.Show("写卡成功!");
                        }
                    }
                    else if (TC_Car.SelectedTab.Name == "TP_Outcar")
                    {
                        if ((CKB_OutFloor.SelectedItems.Count == 0) || (TB_OutCount.Text == ""))
                        {
                            MessageBox.Show("控制楼层和有效次数不能为空！");
                        }
                        else
                        {
                            List<int> floor0 = new List<int>();
                            bool style = false, style1 = false;
                            for (int i = 0; i < CKB_OutFloor.Items.Count; i++)
                            {
                                if (CKB_OutFloor.GetItemChecked(i) == true)
                                    floor0.Add(i + 1);
                            }
                            if (RB_OutAutocheck.Checked) style = true;
                            else if (RB_OutHandlecheck.Checked) style = false;

                            if (RB_OutHold5s.Checked) style1 = true;
                            else if (RB_OutNoHold5s.Checked) style1 = false;
                            newc.Add(new Card
                            {
                                ICID = int.Parse(TB_icID.Text),
                                UserName = TB_userName.Text,
                                UserID = userid,
                                LiveDepart = TB_userRom.Text,
                                Contact = contact,
                                Position = TC_Car.SelectedTab.Name,
                                ControlFloor = floor0,
                                CallStyle = style,
                                Keep5s = style1,
                                ValidTime = DTP_Out.Value,
                                ValidCount = int.Parse(TB_OutCount.Text),
                                WriteTime = DateTime.Now,
                                ADID = int.Parse(TB_ADID.Text),
                                ADName = TB_ADName.Text,
                                LostState = false,
                            });
                            data[0] = newc[0].ICID;
                            data[1] = newc[0].UserName;
                            data[2] = newc[0].UserID;
                            data[3] = newc[0].LiveDepart;
                            data[4] = newc[0].Contact;
                            data[5] = newc[0].Position;
                            data[7] = newc[0].CallStyle;
                            data[8] = newc[0].Keep5s;
                            data[9] = newc[0].ValidTime;
                            data[10] = newc[0].ValidCount;
                            data[11] = newc[0].WriteTime;
                            data[12] = newc[0].LostState;
                            data[13] = newc[0].ADID;
                            data[14] = newc[0].ADName;
                            data[15] = newc[0].LostTime;
                            string str1 = null;
                            foreach (var xx in newc[0].ControlFloor)
                            {
                                // str1 += acct.ControlFloor[xx - 1].ToString() + ",";
                                str1 += xx.ToString() + ",";
                            }
                            data[6] = str1;
                            NPOI_OprateExcl.UpdateExcl(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 0, 1, data);
                            NPOI_OprateExcl.UpdatetoExcl(System.Windows.Forms.Application.StartupPath + @"\IC_Data.xls", 1, 1, data);
                            MessageBox.Show("写卡成功!");
                        }
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void BTN_ReadCard_Click(object sender, EventArgs e)
        {

        }
            

    }
}
