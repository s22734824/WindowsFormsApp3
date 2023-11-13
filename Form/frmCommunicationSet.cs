using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Tools.TcpServer;

namespace WindowsFormsApp3
{
    public partial class frmCommunicationSet : Form
    {                
        public UISwitch chkServerStatus = new UISwitch();//ip + port + 連線狀態
        public UIComboBox cmbClient = new UIComboBox();//client連線
        public UITextBox txtMessage = new UITextBox();//訊息
        public int tabPageIndex = 0;
        public MyTcpServer myTcpServer = new MyTcpServer();
        //public List<string> lstTcpClient;

        public frmCommunicationSet()
        {
            InitializeComponent();
            chkServerStatus = chkUITcpIPServerStatus;
            txtMessage = btnTcpIPServerSendMessage;
            cmbClient = cmbClientList;
        }

        private void frmCommunicationSet_Load(object sender, EventArgs e)
        {
                      
        }

        public void updataUI()
        {
            switch(uiTabControlMenu1.SelectedIndex)
            {
                case 0://tcp ip
                    //chkTcpServerStatus.Text = TcpServerIP;
                    //chkTcpServerStatus.ActiveText = TcpServerIP;
                    //chkTcpServerStatus.InActiveText = TcpServerIP;
                    //chkTcpServerStatus.Active = TcpServerRun;
                    break;
                case 1://tcp modbus

                    break;
                case 2://rs232        

                   break;
            }
            
        }

        private void chkTcpServerStatus_ValueChanged(object sender, bool value)
        {           
          
        }

        private void btnClearMessageBox_Click(object sender, EventArgs e)
        {
            Console.WriteLine("chkServerStatus.Active " + chkServerStatus.Active);
            Console.WriteLine("chkUITcpIPServerStatus " + chkUITcpIPServerStatus.Active);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            uiComboBox1.Items.Add("aaa");
        }

        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabPageIndex = this.uiTabControlMenu1.SelectedIndex;
        }

        private void btnTcpIPserverSend_Click(object sender, EventArgs e)
        {
            //cmbClientList  UI
            //comboBox_SocketList
            if (cmbClientList.Items.Count != 0)
            {
                if (cmbClientList.SelectedItem == null)
                {
                    MessageBox.Show("請選擇一個客戶端發送數據!");
                    return;
                }
                else
                {
                   
                    frmMainForm.sessionList[cmbClientList.SelectedItem.ToString()].Send(txtTcpServerSend.Text + frmMainForm.Endsymbol);
                    //richTextBox1.Invoke(new Action(() => { richTextBox1.AppendText("\r\n"); }));
                }
            }
            else
            {
                //richTextBox1.Invoke(new Action(() => { richTextBox1.AppendText("當前沒有正在連接的客戶端!" + "\r\n"); }));
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
