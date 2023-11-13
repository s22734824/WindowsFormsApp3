
namespace WindowsFormsApp3
{
    partial class frmMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnFileOpen = new Sunny.UI.UISymbolButton();
            this.btnMainForm = new Sunny.UI.UISymbolButton();
            this.frmCommunicationSet = new Sunny.UI.UISymbolButton();
            this.btnIoSet = new Sunny.UI.UISymbolButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnFileOpen);
            this.uiPanel1.Controls.Add(this.btnMainForm);
            this.uiPanel1.Controls.Add(this.frmCommunicationSet);
            this.uiPanel1.Controls.Add(this.btnIoSet);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1924, 124);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileOpen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnFileOpen.Location = new System.Drawing.Point(219, 3);
            this.btnFileOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(102, 93);
            this.btnFileOpen.Symbol = 61717;
            this.btnFileOpen.SymbolSize = 64;
            this.btnFileOpen.TabIndex = 2;
            this.btnFileOpen.Text = "開啟文件";
            this.btnFileOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFileOpen.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // btnMainForm
            // 
            this.btnMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainForm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMainForm.Location = new System.Drawing.Point(327, 3);
            this.btnMainForm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(102, 93);
            this.btnMainForm.Symbol = 61515;
            this.btnMainForm.SymbolSize = 64;
            this.btnMainForm.TabIndex = 3;
            this.btnMainForm.Text = "主頁面";
            this.btnMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainForm.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // frmCommunicationSet
            // 
            this.frmCommunicationSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmCommunicationSet.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.frmCommunicationSet.Location = new System.Drawing.Point(3, 3);
            this.frmCommunicationSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.frmCommunicationSet.Name = "frmCommunicationSet";
            this.frmCommunicationSet.Size = new System.Drawing.Size(102, 93);
            this.frmCommunicationSet.Symbol = 57400;
            this.frmCommunicationSet.SymbolSize = 64;
            this.frmCommunicationSet.TabIndex = 1;
            this.frmCommunicationSet.Text = "通訊設定";
            this.frmCommunicationSet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.frmCommunicationSet.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.frmCommunicationSet.Click += new System.EventHandler(this.btnCommunicationSet_Click);
            // 
            // btnIoSet
            // 
            this.btnIoSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIoSet.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnIoSet.Location = new System.Drawing.Point(111, 3);
            this.btnIoSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnIoSet.Name = "btnIoSet";
            this.btnIoSet.Size = new System.Drawing.Size(102, 93);
            this.btnIoSet.Symbol = 61459;
            this.btnIoSet.SymbolSize = 64;
            this.btnIoSet.TabIndex = 0;
            this.btnIoSet.Text = "IO設定";
            this.btnIoSet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIoSet.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIoSet.Click += new System.EventHandler(this.btnIoSet_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 124);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(280, 931);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(280, 124);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(1644, 931);
            this.uiPanel3.TabIndex = 2;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainForm";
            this.Text = "ATR自動化開發整合平台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UISymbolButton btnFileOpen;
        private Sunny.UI.UISymbolButton frmCommunicationSet;
        private Sunny.UI.UISymbolButton btnIoSet;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UISymbolButton btnMainForm;
    }
}

