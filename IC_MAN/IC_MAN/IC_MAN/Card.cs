using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_MAN
{
    public class Card
    {
        public int ICID { get; set; }//IC卡号
        public int ADID { get; set; }//管理员工号
        public string UserName { get; set; }//用户名
        public string ADName { get; set; }//管理员名
        public Int64 UserID { get; set; }//用户身份证
        public string LiveDepart { get; set; }//用户居住单元
        public int Contact { get; set; }//用户联系方式
        public List<int> ControlFloor { get; set; }//用户控制楼层数
        public string Position { get; set; }//刷卡器所在位置
        public DateTime ValidTime { get; set; }//IC卡有效时间
        public DateTime WriteTime { get; set; }//IC卡写卡时间
        public int ValidCount { get; set; }//IC卡有效次数
        public bool CallStyle { get; set; }//呼梯方式
        public bool Keep5s { get; set; }//刷卡保持5s
        public bool LostState { get; set; }//挂失状态
        public DateTime LostTime { get; set; }//挂失时间
    }
}
