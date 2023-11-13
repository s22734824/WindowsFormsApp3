using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SuperSocket.Common;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketEngine;

namespace Tools.TcpServer
{
    public class MyTcpSession : AppSession<MyTcpSession>
    {
        public override void Send(string message)
        {
            //Console.WriteLine("发送消息:" + message);
            base.Send(message);
        }

        protected override void OnSessionStarted()
        {
            //输出客户端IP地址  
            //Console.WriteLine(this.LocalEndPoint.Address.ToString());
        }


        /// <summary>  
        /// 连接关闭  
        /// </summary>  
        /// <param name="reason"></param>  
        protected override void OnSessionClosed(CloseReason reason)
        {
            base.OnSessionClosed(reason);
        }

        protected override void HandleUnknownRequest(StringRequestInfo requestInfo)
        {
            //Console.WriteLine($"遇到未知的请求 Key:" + requestInfo.Key + $" Body:" + requestInfo.Body);
            base.HandleUnknownRequest(requestInfo);
        }

        /// <summary>  
        /// 捕捉异常并输出  
        /// </summary>  
        /// <param name="e"></param>  
        protected override void HandleException(Exception e)
        {
            this.Send("error: {0}", e.Message);
        }

    }
}
