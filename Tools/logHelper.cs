using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace Tools.Log
{
    public class logHelper
    {

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly object locker = new object();
        
        private logHelper()
        {
           
        }

        #region 通用功能

        /// <summary>
        /// 初始化
        /// </summary>
        public static void init()
        {
            //由於採用async寫入, 避免程式關閉資料沒寫完
            NLog.LogManager.AutoShutdown = true;            
        }

     
        /// <summary>
        /// 釋放資源
        /// </summary>
        public static void close()
        {
            //釋放資源, 讓所有的log資料寫入文件(因為是async寫入), 初始化做了AutoShutdown, 這邊再做一次雙重保護
            NLog.LogManager.Shutdown();
        }

        ~logHelper()
        {
            NLog.LogManager.Shutdown();
        }

        #endregion

        #region data (採集到的資料)

        /// <summary>
        /// 高效能資料輸出
        /// </summary>
        /// <param name="description">訊息描述</param>
        public static void HighData(string description)
        {
            lock (locker)
            {
                logger.Fatal(description);
            }
        }

        /// <summary>
        /// 採集到的資料
        /// </summary>
        /// <param name="data">訊息描述</param>
        public static void Data(string description , [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Fatal(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + description);
            }
        }

        /// <summary>
        /// 採集到的資料
        /// </summary>
        /// <param name="type">類型/param>
        /// <param name="description">訊息描述</param>
        public static void Data(string type ,string description , [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Fatal(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + type + ":" + description);
            }
        }

        /// <summary>
        /// 採集到的資料
        /// </summary>
        /// <param name="type">類型</param>
        /// <param name="description">訊息描述</param>
        public static void Data(Enum type, string description , [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Fatal(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + type + ":" + description);
            }
        }

        #endregion

        #region Debug (用於紀錄機台的"內部變數變化","代碼運行結果輸出" )

        /// <summary>
        /// 用於紀錄機台的"內部變數變化","代碼運行結果輸出"      
        /// </summary>
        /// <param name="s">訊息描述</param>
        public static void Debug(string description, [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();

                //Console.WriteLine("Called from file: " + method.DeclaringType.FullName);
                //Console.WriteLine("Called from class: " + method.Name);
                //Console.WriteLine("Called from line: " + lineNumber);

                logger.Debug(method.DeclaringType.FullName + "("+method.Name + ":" + lineNumber  +")@"+ description);
            }
        }

        /// <summary>
        /// 用於紀錄機台的"內部變數變化","代碼運行結果輸出"  
        /// </summary>
        /// <param name="type">類型</param>
        /// <param name="description">訊息描述</param>
        public static void Debug(string type , string description, [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Debug(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + type + ":"+ description);
                //logger.Debug(type + ":" + description);
            }
        }

        /// <summary>
        /// 用於紀錄機台的"內部變數變化","代碼運行結果輸出"  
        /// </summary>
        /// <param name="type">類型</param>
        /// <param name="description">訊息描述</param>
        public static void Debug(Enum type, string description ,[System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Debug(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + type + ":" + description);
                //logger.Debug(type + ":" + description);
            }
        }

        #endregion

        #region Info (用於紀錄機台的"運行紀錄", "操作行為")
        /// <summary>
        /// 用於紀錄機台的"運行紀錄", "操作行為"
        /// </summary>
        /// <param name="s">訊息描述</param>
        public static void Info(string description , [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Info(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + description);
            }
        }

        /// <summary>
        /// 用於紀錄機台的"運行紀錄", "操作行為"
        /// </summary>
        /// <param name="type">類型</param>
        /// <param name="description">訊息描述</param>
        public static void Info(string type, string description, [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Info(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + type + ":" + description);
            }
        }

        /// <summary>
        /// 用於紀錄機台的"運行紀錄", "操作行為"
        /// </summary>
        /// <param name="type">類型</param>
        /// <param name="description">訊息描述</param>
        public static void Info(Enum type, string description , [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Info(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + type + ":" + description);
            }
        }

        #endregion

        #region Warn (紀錄報錯相關)
        /// <summary>
        /// 紀錄報錯相關
        /// </summary>
        /// <param name="s">訊息描述</param>
        public static void Warn(string description , [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Warn(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + description);
            }
        }

        /// <summary>
        /// 紀錄報錯相關
        /// </summary>
        /// <param name="type">類型</param>
        /// <param name="description">訊息描述</param>
        public static void Warn(string type , string description , [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Warn(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + type + ":" + description);
            }
        }

        /// <summary>
        /// 紀錄報錯相關
        /// </summary>
        /// <param name="type">類型</param>
        /// <param name="description">訊息描述</param>
        public static void Warn(Enum type, string description , [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            lock (locker)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase method = stackFrame.GetMethod();
                logger.Warn(method.DeclaringType.FullName + "(" + method.Name + ":" + lineNumber + ")@" + type + ":" + description);
            }
        }
        #endregion

        

    }
}
