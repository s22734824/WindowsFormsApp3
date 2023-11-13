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
    public class MyTcpServer : AppServer<MyTcpSession>
    {
        public static string strEndsymbol = "#";
        public string serverName = "MyTcpServer";
        public string ServerTypeName = "MyTcpServer";
        public bool ClearIdleSession = false;//600秒执行一次清理300秒没数据传送的连接
        public int ClearIdleSessionInterval = 600;
        public int IdleSessionTimeOut = 300;
        public int MaxRequestLength = 2048; //最大封包长度
        private string IP = "127.0.0.1";
        private int Port = 15000;
        public int MaxConnectionNumber = 50;

        public MyTcpServer() : base(new TerminatorReceiveFilterFactory(strEndsymbol))
        {            
        }

        public MyTcpServer(string Endsymbol) : base(new TerminatorReceiveFilterFactory(strEndsymbol))
        {
            strEndsymbol = Endsymbol;            
        }

        public bool setPort(int port)
        {
            if(port>0 && port < 65536)
            {
                Port = port;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setIP(string ip)
        {
            System.Net.IPAddress _ip;
            if (System.Net.IPAddress.TryParse(ip, out _ip))
            {
                IP = _ip.ToString();
                return true;
            }  
            else
            {
                return false;
            }
        }

        public bool init()
        {
            var config = new SuperSocket.SocketBase.Config.ServerConfig()
            {
                Name = this.serverName,
                ServerTypeName = this.ServerTypeName,

                ClearIdleSession = this.ClearIdleSession, //600秒执行一次清理300秒没数据传送的连接
                ClearIdleSessionInterval = this.ClearIdleSessionInterval,
                IdleSessionTimeOut = this.IdleSessionTimeOut,

                MaxRequestLength = this.MaxRequestLength, //最大包长度
                Ip = this.IP,
                Port = this.Port,
                MaxConnectionNumber = this.MaxConnectionNumber,
            };
            bool setupResult =  base.Setup(config);
            return setupResult;
        }


        protected override void OnStarted()
        {            
            //Console.WriteLine("服务已开始" + base.Config.Ip);
            base.OnStarted();
        }

        protected override void OnStopped()
        {
            //Console.WriteLine("服务已停止");
            base.OnStopped();
        }

    }
}
