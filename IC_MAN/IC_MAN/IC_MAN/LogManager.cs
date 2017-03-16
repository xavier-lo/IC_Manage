using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_MAN
{
    class LogManager
    {
          private  string logPath = string.Empty;
            ///<summary>
            /// 保存日志的文件夹
            ///</summary>
            public  string LogPath
            {
                get
                {
                   if (logPath == string.Empty)
                    {
                       if (System.Web.HttpContext.Current == null)
                           // Windows Forms 应用
                           logPath = AppDomain.CurrentDomain.BaseDirectory;
                       else
                           // Web 应用
                           logPath = AppDomain.CurrentDomain.BaseDirectory + @"bin\";
                    }
                   return logPath;
                }
                set{logPath = value;}
            }

            private  string logFielPrefix = string.Empty;
            ///<summary>
            /// 日志文件前缀
            ///</summary>
            public  string LogFielPrefix
            {
                get {return logFielPrefix; }
                set {logFielPrefix = value; }
            }

            ///<summary>
            /// 写日志
            ///</summary>
            private  void WriteLog(string logFile, string msg)
            {
                try
                {
                       System.IO.StreamWriter sw = System.IO.File.AppendText(
                       LogPath + LogFielPrefix + logFile + " " + 
                       DateTime.Now.ToString("yyyyMMdd") + ".Log"
                       );
                   sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") +msg);
                   sw.Close();
                }
                catch
                { }
            }
            ///<summary>
            /// 写日志
            ///</summary>
            public  void WriteLog(LogFile logFile, string msg)
            {
               WriteLog(logFile.ToString(), msg);
            }
        }

        /// <summary>
        /// 日志类型
        /// </summary>
        public enum LogFile
        {
            Trace,
            Warning,
            Error,
            SQL
        }
    
}
