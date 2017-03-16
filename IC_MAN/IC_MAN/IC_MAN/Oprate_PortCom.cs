using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace IC_MAN
{
    /// <summary>
    /// 用于操作串口 管理IC刷卡器
    /// </summary>
    class Oprate_PortCom
    {
        /*字段*/
        /// <summary>
        /// 
        /// </summary>
        /*属性*/
        ///<summary>
        ///
        ///<summary>



        /*方法*/
        /// <summary>
        /// 获取本机com列表 返回string[] ComList
        /// </summary>
        public List<string> GetComList()
        {
            List<string> ComList = new List<string>();
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCom != null)
            {
                string[] sSubKeys = keyCom.GetValueNames();
                ComList.Clear();
                foreach (string sName in sSubKeys)
                {
                    string sValue = (string)keyCom.GetValue(sName);
                    ComList.Add(sValue);
                }
             }
            return ComList;
        }
 
    }
}
