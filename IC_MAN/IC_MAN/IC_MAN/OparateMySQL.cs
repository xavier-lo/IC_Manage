using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace IC_MAN
{
    class OparateMySQL
    {
        /// <summary>
        /// 将数据更新入数据库
        /// </summary>
        /// <param name="DT"></param>
        /// 需要更新的数据表源数据
        /// <param name="sheetnum"></param>
        /// 需要更新的目标表号 
        public static void UpdateToMySQL(DataTable DT,int sheetnum)
        {
            try
            {
                //  DataSet ds = new DataSet();
                string connStr = @"Database=ic_man;Data Source=192.168.1.229;User Id=luoh;Password=62237976;pooling=true;CharSet=utf8;Allow Zero Datetime=true;Port=3300 ";
                //  string sqlList = "select * from TB_WriteRecord";
                //  string sqlcom = "insert into TB_WriteRecord(ICID,UserName) values(10002,'luoh')";
                List<string> list = null;
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                if (sheetnum == 0)
                {
                    list = (from DataRow row in DT.Rows select String.Format("insert into tb_writerecord2(ICID,UserName,UserID,LiveDepart,Contact,ICPosition,ControlFloor,CallStyle,Keep5s,VaildTime,VaildCount,WriteTime,LostState,ADID,ADName,LostTime) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16])).ToList();
                    string strdeletall = "truncate table tb_writerecord2";//清除所有数据，主键从1开始
                    MySqlCommand comn0 = new MySqlCommand(strdeletall, conn);
                    comn0.ExecuteNonQuery();
                }
                else if (sheetnum == 1)
                {
                    list = (from DataRow row in DT.Rows select String.Format("insert into tb_realtimedata2(ICID,UserName,UserID,LiveDepart,Contact,ICPosition,ControlFloor,CallStyle,Keep5s,VaildTime,VaildCount,WriteTime,LostState,ADID,ADName,LostTime) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16])).ToList();
                    string strdeletall = "truncate table tb_realtimedata2";//清除所有数据，主键从1开始
                    MySqlCommand comn1 = new MySqlCommand(strdeletall, conn);
                    comn1.ExecuteNonQuery();
                }

                foreach (string item in list)
                {
                    MySqlCommand comn = new MySqlCommand(item, conn);
                    comn.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("捕获到异常："+e.Message);
            }
                
        }

    }
}
