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
namespace WindowsFormsApp3
{
    public partial class frmStartMainForm : Form
    {
        public UITextBox txtMessage = new UITextBox();
        Color Blue = Color.FromArgb(80, 160, 255);
        Color Red = Color.Red;
        public frmStartMainForm()
        {
            InitializeComponent();
            //txtMessage = txtMainFormMessage;
        }
        private void frmStartMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            if (btnMainForm.Symbol == 61515)
            {
                btnMainForm.Symbol = 61516;
                btnMainForm.FillColor = Red;
                btnMainForm.Text = "暫停";
            }
            else
            {
                btnMainForm.Symbol = 61515;
                btnMainForm.FillColor = Blue;
                btnMainForm.Text = "執行";
            }

        }
    }
}
