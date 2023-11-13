using Sunny.UI;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tools.csv;
using Tools.ini;
using Tools.Log;
using Tools.TcpServer;
using WindowsFormsApp3.Tools;

namespace WindowsFormsApp3
{
    public partial class frmMainForm : Form
    {
        #region 變數
        bool isThreadRun = true;
        string tcpModbusIP = string.Empty;
        string tcpModbusPort = string.Empty;
        #endregion

        IniHelper iniHelper;

        #region form宣告
        frmCommunicationSet frmCommunicationSet1 = new frmCommunicationSet();
        frmIoSet frmIoSet1 = new frmIoSet();
        frmStartMainForm frmStartMainForm1 = new frmStartMainForm();
        #endregion

        #region 輸出 + 輸出模組
        readonly string OutputModelSetName = "OutputModelSet.csv";//輸出模組
        readonly string IntputModelSetName = "IntputModelSet.csv";//輸入模組

        IOModel[] inputSet = new IOModel[5];//輸入模組
        IOModel[] outputSet = new IOModel[5];//輸出模組
        #endregion

        #region TCP IP
        public static readonly string Endsymbol = "#";
        MyTcpServer myTcpServer;
        //存储session和对应ip端口号的泛型集合
        public static Dictionary<string, MyTcpSession> sessionList = new Dictionary<string, MyTcpSession>();

        #region server

        #endregion

        #region client

        #endregion

        #endregion

           
        Thread threadTcpModbus;

        CsvHelper csvHelper = new CsvHelper();

        DeltaTCP PLC1;

        string strMainFormShow = string.Empty;//當前顯示的form Name

        public frmMainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            string runPathBase = System.Environment.CurrentDirectory;
            logHelper.init();

            #region ini設定
            string iniFilePath = runPathBase + "\\config.ini";
            iniHelper = new IniHelper(iniFilePath);
            tcpModbusIP =  iniHelper.ReadValue("TcpModbus", "ip");
            tcpModbusPort = iniHelper.ReadValue("TcpModbus", "port");
            #endregion
            #region IO模組設定
            try
            {
                logHelper.Info("info:IO的CSV讀取");
                List<string[]> lstOutputModelSet;
                List<string[]> lstIntputModelSet;
                string outputModelPath = runPathBase + "\\" + OutputModelSetName;
                string intputModelPath = runPathBase + "\\" + IntputModelSetName;
                lstOutputModelSet = csvHelper.ReadCsv(outputModelPath);
                lstIntputModelSet = csvHelper.ReadCsv(intputModelPath);

                List<string[]> lstIntputModelName = csvHelper.SearchList(lstIntputModelSet, "Module name");//輸入模組
                List<string[]> lstOutputModelName = csvHelper.SearchList(lstOutputModelSet, "Module name");//輸出模組
                List<int> lstIntputModelIndex = csvHelper.SearchListIndex(lstIntputModelSet, "Enable");//輸入模組名稱index起始位置
                List<int> lstOutputModelIndex = csvHelper.SearchListIndex(lstOutputModelSet, "Enable");//輸出模組名稱index起始位置
                List<string[]> lstOutputModelEnable = csvHelper.SearchList(lstOutputModelSet, "Enable");//輸出模組
                List<string[]> lstIntputModelEnable = csvHelper.SearchList(lstIntputModelSet, "Enable");//輸入模組

                logHelper.Info("info:IO初始化, 並設定form上的IO狀態");
                #region inputSet
                for (int i = 0; i < inputSet.Length; i++)
                {
                    inputSet[i] = new IOModel();
                    inputSet[i].Dock = DockStyle.Fill;

                    #region 設定模組名稱
                    string[] groupNames = lstIntputModelName[i];
                    inputSet[i].modelTitle = groupNames[1];
                    #endregion

                    #region IOModelType
                    inputSet[i].ioModelData.ModelType = dataStruct.IOModelType.Input;
                    #endregion

                    #region isEnabel
                    string[] enableTemp = lstIntputModelEnable[i];
                    bool isRun = Convert.ToBoolean(Convert.ToInt32(enableTemp[3]));
                    inputSet[i].isEnabel = isRun;
                    #endregion

                    #region 設定模組IO名稱
                    for (int offset = 0; offset < 16; offset++)
                    {
                        int index = lstIntputModelIndex[i] + offset + 1;
                        string[] sTemp = lstIntputModelSet[index];
                        inputSet[i].ioModelData.ioStatuses[offset].title = sTemp[1];
                    }
                    #endregion

                    #region 設定模組IOaddress
                    for (int offset = 0; offset < 16; offset++)
                    {
                        int index = lstIntputModelIndex[i] + offset + 1;
                        string[] sTemp = lstIntputModelSet[index];
                        inputSet[i].ioModelData.ioStatuses[offset].address = Convert.ToInt32(sTemp[2]);
                    }
                    #endregion

                    #region 設定模組IO初始狀態
                    for (int offset = 0; offset < 16; offset++)
                    {
                        int index = lstIntputModelIndex[i] + offset + 1;
                        string[] sTemp = lstIntputModelSet[index];
                        bool ioInitialState = Convert.ToBoolean(Convert.ToInt32(sTemp[3]));
                        inputSet[i].ioModelData.ioStatuses[offset].status = ioInitialState;
                    }
                    #endregion

                    frmIoSet1.panelInput.Controls.Add(inputSet[i]);
                    inputSet[i].setBaseProperty();
                    inputSet[i].updataUI();
                }
                #endregion

                #region outputSet
                for (int i = 0; i < outputSet.Length; i++)
                {
                    outputSet[i] = new IOModel();
                    outputSet[i].Dock = DockStyle.Fill;

                    #region 設定模組名稱
                    string[] groupNames = lstIntputModelName[i];
                    outputSet[i].modelTitle = groupNames[1];
                    #endregion

                    #region IOModelType
                    outputSet[i].ioModelData.ModelType = dataStruct.IOModelType.Output;
                    #endregion

                    #region isEnabel
                    string[] enableTemp = lstOutputModelEnable[i];
                    bool isRun = Convert.ToBoolean(Convert.ToInt32(enableTemp[3]));
                    outputSet[i].isEnabel = isRun;
                    #endregion

                    #region 設定模組IO名稱
                    for (int offset = 0; offset < 16; offset++)
                    {
                        int index = lstOutputModelIndex[i] + offset + 1;
                        string[] sTemp = lstOutputModelSet[index];
                        outputSet[i].ioModelData.ioStatuses[offset].title = sTemp[1];
                    }
                    #endregion

                    #region 設定模組IOaddress
                    for (int offset = 0; offset < 16; offset++)
                    {
                        int index = lstOutputModelIndex[i] + offset + 1;
                        string[] sTemp = lstOutputModelSet[index];
                        outputSet[i].ioModelData.ioStatuses[offset].address = Convert.ToInt32(sTemp[2]);
                    }
                    #endregion

                    #region 設定模組IO初始狀態
                    for (int offset = 0; offset < 16; offset++)
                    {
                        int index = lstOutputModelIndex[i] + offset + 1;
                        string[] sTemp = lstOutputModelSet[index];
                        bool ioInitialState = Convert.ToBoolean(Convert.ToInt32(sTemp[3]));
                        //outputSet[i].ioModelData.ioStatuses[offset].status = ioInitialState;
                    }
                    #endregion


                    frmIoSet1.panelOutput.Controls.Add(outputSet[i]);
                    outputSet[i].setBaseProperty();
                    outputSet[i].updataUI();
                }
                #endregion

                
            }
            catch (Exception e)
            {
                logHelper.Warn("winform初始化錯誤!",e.Message);
                
            }
            #endregion

            #region Tcp Modbus設定
            try
            {
                PLC1 = new DeltaTCP(Convert.ToInt32(tcpModbusPort), tcpModbusIP);
                PLC1.SettingModule(5, 5);
                PLC1.AddDList("D0", 0);
                PLC1.AddDList("D2", 2);
            }
            catch (Exception)
            {
                throw new Exception("TCP Modbus init fails! 初始化失敗");
            }
            #endregion

            #region tcp IP    
            try
            {
                logHelper.Info("info:TCP IP", "設定與初始化!");
                myTcpServer = new MyTcpServer(Endsymbol);
                
                if (myTcpServer.setIP("127.0.0.1") && myTcpServer.setPort(54601))
                {
                    frmCommunicationSet1.chkServerStatus.ActiveText = "127.0.0.1:54601";
                    
                }
                else
                {
                    frmCommunicationSet1.chkServerStatus.InActiveText = "TcpServer啟動失敗";                    
                    throw new Exception("ip或port有問題");
                }
                    
                
                if (!myTcpServer.init())
                {
                    throw new Exception("tcpIP server init()失敗");
                }


                if (myTcpServer.Start())
                {
                    frmCommunicationSet1.chkServerStatus.Active = true;
                }
                else
                {
                    frmCommunicationSet1.chkServerStatus.Active = false;
                }
                                
                myTcpServer.NewSessionConnected += myTcpServer_NewSessionConnected; //连接事件
                myTcpServer.NewRequestReceived += myTcpServer_NewRequestReceived;   //接收事件
                myTcpServer.SessionClosed += myTcpServer_SessionClosed;             //关闭事件

                logHelper.Info("info:TCP IP", "server啟動");
            }
            catch (Exception e)
            {
                logHelper.Warn("TCP IP啟動失敗", e.Message);
            }

            #endregion

            //logHelper.Data("data分類符1:我是dataLog輸出, 自己一個資料夾");
            //logHelper.Debug("debug分類符3:我是Debug輸出");
            //logHelper.Info("info分類符5:我是操作輸出");
            //logHelper.Warn("Warn分類符7:我是報警輸出");

        }
        void myTcpServer_NewSessionConnected(MyTcpSession session)
        {
            //有新连接的时候,添加记录  session.LocalEndPoint属性获取当前session的ip和端口号
            //AppSession 代表一个和客户端的逻辑连接，基于连接的操作应该定于在该类之中。你可以用该类的实例发送数据到客户端，接收客户端发送的数据或者关闭连接。

            //获取远程客户端的ip端口号
            string ipAddress_Connect = session.RemoteEndPoint.ToString();
            sessionList.Add(ipAddress_Connect, session);
            frmCommunicationSet1.cmbClient.Items.Add(ipAddress_Connect);
            frmStartMainForm1.txtMessage.BeginInvoke(new Action(() => { frmStartMainForm1.txtMessage.AppendText("client連入 :" + session.RemoteEndPoint.ToString() + "連入" + "\r\n"); }));  
            
            if(strMainFormShow == "frmCommunicationSet1" && frmCommunicationSet1.tabPageIndex==0)
            {              
                frmCommunicationSet1.txtMessage.BeginInvoke(new Action(() => { frmCommunicationSet1.txtMessage.AppendText("client連入 :" + session.RemoteEndPoint.ToString() + "連入" + "\r\n"); }));
            }
        }

        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestInfo"></param>
        void myTcpServer_NewRequestReceived(MyTcpSession session, StringRequestInfo requestInfo)
        {
            //requestInfo.Key 是请求的命令行用空格分隔开的第一部分
            //requestInfo.Parameters 是用空格分隔开的其余部分
            //requestInfo.Body 是出了请求头之外的所有内容

            string ipAddress_Receive = session.RemoteEndPoint.ToString();

            //richTextBox1.Invoke(new Action(() => { richTextBox1.AppendText("receive" + ipAddress_Receive + " Info : " + requestInfo.Key + " " + requestInfo.Body + "\r\n"); }));
            frmStartMainForm1.txtMessage.BeginInvoke(new Action(() => { frmStartMainForm1.txtMessage.AppendText("receive" + ipAddress_Receive + " Info : " + requestInfo.Key + " " + requestInfo.Body + "\r\n"); }));

            frmStartMainForm1.txtMessage.BeginInvoke(new Action(() => {
                frmStartMainForm1.txtMessage.SelectionStart = frmStartMainForm1.txtMessage.Text.Length;
                frmStartMainForm1.txtMessage.ScrollToCaret();
            }));

            if (strMainFormShow == "frmCommunicationSet1" && frmCommunicationSet1.tabPageIndex == 0)
            {                
                frmCommunicationSet1.txtMessage.BeginInvoke(new Action(() => { frmCommunicationSet1.txtMessage.AppendText("receive" + ipAddress_Receive + " Info : " + requestInfo.Key + " " + requestInfo.Body + "\r\n"); }));

                frmCommunicationSet1.txtMessage.BeginInvoke(new Action(() => {
                    frmCommunicationSet1.txtMessage.SelectionStart = frmCommunicationSet1.txtMessage.Text.Length;
                    frmCommunicationSet1.txtMessage.ScrollToCaret();
                }));
            }
            
           
            //frmStartMainForm1.txtMessage.ScrollToCaret();
        }


        /// <summary>
        /// 關閉連接
        /// </summary>
        /// <param name="session"></param>
        /// <param name="value"></param> 
        /// 
        //static void appServer_SessionClosed(AppSession session, CloseReason value)
        void myTcpServer_SessionClosed(MyTcpSession session, SuperSocket.SocketBase.CloseReason value)
        {
             string ipAddress_Close = session.RemoteEndPoint.ToString();
            //Combobox_Handle_ipAddress(ipAddress_Close, OperateType.Remove);
            frmCommunicationSet1.cmbClient.Items.Remove(ipAddress_Close);
            sessionList.Remove(ipAddress_Close);

            frmStartMainForm1.txtMessage.BeginInvoke(new Action(() => { frmStartMainForm1.txtMessage.AppendText(ipAddress_Close + "Closed connection!" + "\r\n"); }));
        }

        private void btnCommunicationSet_Click(object sender, EventArgs e)
        {
            strMainFormShow = "frmCommunicationSet1";
            this.uiPanel3.Controls.Clear();
            frmCommunicationSet1.Parent = this.uiPanel3;
            frmCommunicationSet1.Dock = DockStyle.Fill;
            frmCommunicationSet1.Show();           

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            frmCommunicationSet1.TopLevel = false;
            frmCommunicationSet1.FormBorderStyle = FormBorderStyle.None;
            frmCommunicationSet1.Dock = DockStyle.Fill;

            frmIoSet1.TopLevel = false;
            frmIoSet1.FormBorderStyle = FormBorderStyle.None;
            frmIoSet1.Dock = DockStyle.Fill;

            frmStartMainForm1.TopLevel = false;
            frmStartMainForm1.FormBorderStyle = FormBorderStyle.None;
            frmStartMainForm1.Dock = DockStyle.Fill;

            btnMainForm_Click(this, e);
            threadTcpModbus = new Thread(new ThreadStart(threadFunctionTCPModbus)) { IsBackground = true };
            threadTcpModbus.Start();

        }
        public List<Control> FindControlsByType(Control parent, Type targetType)
        {
            List<Control> result = new List<Control>();

            foreach (Control control in parent.Controls)
            {
                if (control.GetType() == targetType)
                {
                    result.Add(control);
                }

                if (control.HasChildren)
                {
                    result.AddRange(FindControlsByType(control, targetType));
                }
            }

            return result;
        }
        private void btnIoSet_Click(object sender, EventArgs e)
        {
            strMainFormShow = "frmIoSet1";
            this.uiPanel3.Controls.Clear();
            frmIoSet1.Parent = this.uiPanel3;
            frmIoSet1.Dock = DockStyle.Fill;
            frmIoSet1.Show();
        }

        void threadFunctionTCPModbus()
        {
            while (isThreadRun)
            {
                PLC1.Scan();
                for (int i = 0; i < PLC1.XList.Count; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        inputSet[i].ioModelData.ioStatuses[j].status = PLC1.XList[i][j];
                    }
                }
                for (int i = 0; i < PLC1.YList.Count; i++)
                {
                    bool[] send = new bool[16];
                    for (int j = 0; j < 16; j++)
                    {
                        send[j] = outputSet[i].ioModelData.ioStatuses[j].status;
                    }           
                    PLC1.YList[i] = (bool[])send.Clone();
                }

                Thread.Sleep(15);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 更新UI, 只更新當前畫面, 避免資源消耗
            switch (strMainFormShow)
            {
                case "frmIoSet1":
                    //Console.WriteLine("frmIoSet1");

                    List<Control> foundControls = FindControlsByType(frmIoSet1, typeof(IOModel));
                    foreach (IOModel control in foundControls)
                    {
                        control.updataUI();
                    }                    
                    break;
                case "frmCommunicationSet1":

                    frmCommunicationSet1.updataUI();
                    break;
                case "frmStartMainForm1":
                    
                    break;

                default:
                    break;
            }
            #endregion

        }

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logHelper.close();
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            strMainFormShow = "frmStartMainForm1";
            this.uiPanel3.Controls.Clear();
            frmStartMainForm1.Parent = this.uiPanel3;
            frmStartMainForm1.Dock = DockStyle.Fill;
            frmStartMainForm1.Show();
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            frmCommunicationSet1.txtMessage.Text = "aaa";
        }
    }
}
