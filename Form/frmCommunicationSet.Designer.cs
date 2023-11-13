
namespace WindowsFormsApp3
{
    partial class frmCommunicationSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTcpIPserverSend = new Sunny.UI.UISymbolButton();
            this.btnClearMessageBox = new Sunny.UI.UISymbolButton();
            this.chkUITcpIPServerStatus = new Sunny.UI.UISwitch();
            this.cmbClientList = new Sunny.UI.UIComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTcpIPServerSendMessage = new Sunny.UI.UITextBox();
            this.txtTcpServerSend = new Sunny.UI.UITextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Controls.Add(this.tabPage3);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControlMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(1924, 1055);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabIndex = 0;
            this.uiTabControlMenu1.SelectedIndexChanged += new System.EventHandler(this.uiTabControlMenu1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1723, 1055);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1723, 1055);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnTcpIPserverSend, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnClearMessageBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.chkUITcpIPServerStatus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbClientList, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 1047);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnTcpIPserverSend
            // 
            this.btnTcpIPserverSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTcpIPserverSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTcpIPserverSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnTcpIPserverSend.Location = new System.Drawing.Point(4, 212);
            this.btnTcpIPserverSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnTcpIPserverSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTcpIPserverSend.Name = "btnTcpIPserverSend";
            this.btnTcpIPserverSend.Size = new System.Drawing.Size(242, 96);
            this.btnTcpIPserverSend.Symbol = 61443;
            this.btnTcpIPserverSend.TabIndex = 2;
            this.btnTcpIPserverSend.Text = "server發送";
            this.btnTcpIPserverSend.Click += new System.EventHandler(this.btnTcpIPserverSend_Click);
            // 
            // btnClearMessageBox
            // 
            this.btnClearMessageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearMessageBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClearMessageBox.Location = new System.Drawing.Point(4, 316);
            this.btnClearMessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearMessageBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearMessageBox.Name = "btnClearMessageBox";
            this.btnClearMessageBox.Size = new System.Drawing.Size(242, 96);
            this.btnClearMessageBox.Symbol = 57369;
            this.btnClearMessageBox.TabIndex = 3;
            this.btnClearMessageBox.Text = "清除";
            this.btnClearMessageBox.Click += new System.EventHandler(this.btnClearMessageBox_Click);
            // 
            // chkUITcpIPServerStatus
            // 
            this.chkUITcpIPServerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUITcpIPServerStatus.Enabled = false;
            this.chkUITcpIPServerStatus.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.chkUITcpIPServerStatus.Location = new System.Drawing.Point(4, 4);
            this.chkUITcpIPServerStatus.Margin = new System.Windows.Forms.Padding(4);
            this.chkUITcpIPServerStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkUITcpIPServerStatus.Name = "chkUITcpIPServerStatus";
            this.chkUITcpIPServerStatus.Size = new System.Drawing.Size(242, 96);
            this.chkUITcpIPServerStatus.TabIndex = 0;
            this.chkUITcpIPServerStatus.Text = "uiSwitch1";
            // 
            // cmbClientList
            // 
            this.cmbClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbClientList.FillColor = System.Drawing.Color.White;
            this.cmbClientList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbClientList.Location = new System.Drawing.Point(5, 110);
            this.cmbClientList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbClientList.MinimumSize = new System.Drawing.Size(84, 0);
            this.cmbClientList.Name = "cmbClientList";
            this.cmbClientList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbClientList.Size = new System.Drawing.Size(240, 34);
            this.cmbClientList.TabIndex = 4;
            this.cmbClientList.Text = "client";
            this.cmbClientList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(262, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1457, 1047);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnTcpIPServerSendMessage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtTcpServerSend, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.59276F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.40724F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1449, 515);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btnTcpIPServerSendMessage
            // 
            this.btnTcpIPServerSendMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnTcpIPServerSendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTcpIPServerSendMessage.FillColor = System.Drawing.Color.White;
            this.btnTcpIPServerSendMessage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnTcpIPServerSendMessage.Location = new System.Drawing.Point(5, 6);
            this.btnTcpIPServerSendMessage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTcpIPServerSendMessage.Maximum = 2147483647D;
            this.btnTcpIPServerSendMessage.Minimum = -2147483648D;
            this.btnTcpIPServerSendMessage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTcpIPServerSendMessage.Multiline = true;
            this.btnTcpIPServerSendMessage.Name = "btnTcpIPServerSendMessage";
            this.btnTcpIPServerSendMessage.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTcpIPServerSendMessage.Size = new System.Drawing.Size(1439, 449);
            this.btnTcpIPServerSendMessage.TabIndex = 2;
            // 
            // txtTcpServerSend
            // 
            this.txtTcpServerSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTcpServerSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTcpServerSend.FillColor = System.Drawing.Color.White;
            this.txtTcpServerSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtTcpServerSend.Location = new System.Drawing.Point(5, 467);
            this.txtTcpServerSend.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTcpServerSend.Maximum = 2147483647D;
            this.txtTcpServerSend.Minimum = -2147483648D;
            this.txtTcpServerSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTcpServerSend.Name = "txtTcpServerSend";
            this.txtTcpServerSend.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTcpServerSend.Size = new System.Drawing.Size(1439, 34);
            this.txtTcpServerSend.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiButton1);
            this.tabPage2.Controls.Add(this.uiComboBox1);
            this.tabPage2.Location = new System.Drawing.Point(201, 0);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1723, 1055);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCP ModBus";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(272, 410);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(133, 44);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "uiButton1";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(311, 290);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(84, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(200, 34);
            this.uiComboBox1.TabIndex = 0;
            this.uiComboBox1.Text = "uiComboBox1";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(201, 0);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1723, 1055);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RS232";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmCommunicationSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCommunicationSet";
            this.Text = "frmCommunicationSet";
            this.Load += new System.EventHandler(this.frmCommunicationSet_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UITextBox btnTcpIPServerSendMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UISwitch chkUITcpIPServerStatus;
        private Sunny.UI.UISymbolButton btnClearMessageBox;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIComboBox cmbClientList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Sunny.UI.UITextBox txtTcpServerSend;
        private Sunny.UI.UISymbolButton btnTcpIPserverSend;
    }
}