using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.dataStruct;

namespace WindowsFormsApp3
{

    public partial class IOModel : UserControl
    {
        
        public bool isEnabel = true;
        public string modelTitle = string.Empty;
        public IoModel ioModelData;//資料層

        public IOModel()
        {
            InitializeComponent();
            ioModelData = new IoModel();
            ioModelData.ioStatuses = new IoStatus[16];           
        }

        public void updataUI()
        {
            btnIO_1.On  = ioModelData.ioStatuses[0].status;
            btnIO_2.On  = ioModelData.ioStatuses[1].status;
            btnIO_3.On  = ioModelData.ioStatuses[2].status;
            btnIO_4.On  = ioModelData.ioStatuses[3].status;
            btnIO_5.On  = ioModelData.ioStatuses[4].status;
            btnIO_6.On  = ioModelData.ioStatuses[5].status;
            btnIO_7.On  = ioModelData.ioStatuses[6].status;
            btnIO_8.On  = ioModelData.ioStatuses[7].status;
            btnIO_9.On  = ioModelData.ioStatuses[8].status;
            btnIO_10.On = ioModelData.ioStatuses[9].status;
            btnIO_11.On = ioModelData.ioStatuses[10].status;
            btnIO_12.On = ioModelData.ioStatuses[11].status;
            btnIO_13.On = ioModelData.ioStatuses[12].status;
            btnIO_14.On = ioModelData.ioStatuses[13].status;
            btnIO_15.On = ioModelData.ioStatuses[14].status;
            btnIO_16.On = ioModelData.ioStatuses[15].status;
        }

        public void setBaseProperty()
        {
            uiGroupBox1.Text = modelTitle;

            #region io title
            List<Control> foundControls = FindControlsByType(this, typeof(Sunny.UI.UILabel));
            foundControls.Reverse(); // 反向排序
            int index = 0;
            foreach (Sunny.UI.UILabel control in foundControls)
            {
                control.Text = ioModelData.ioStatuses[index].title;
                index++;
            }
            #endregion

            uiCheckBox1.Checked = isEnabel;           
        }

        private List<Control> FindControlsByType(Control parent, Type targetType)
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

        private void btnIO_1_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if(ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[0].status = !ioModelData.ioStatuses[0].status;
                btnIO_1.On = ioModelData.ioStatuses[0].status;
            }            
        }

        private void btnIO_2_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[1].status = !ioModelData.ioStatuses[1].status;
                btnIO_2.On = ioModelData.ioStatuses[1].status;
            }
        }

        private void btnIO_3_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[2].status = !ioModelData.ioStatuses[2].status;
                btnIO_3.On = ioModelData.ioStatuses[2].status;
            }
        }

        private void btnIO_4_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[3].status = !ioModelData.ioStatuses[3].status;
                btnIO_4.On = ioModelData.ioStatuses[3].status;
            }
        }

        private void btnIO_5_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[4].status = !ioModelData.ioStatuses[4].status;
                btnIO_5.On = ioModelData.ioStatuses[4].status;
            }

        }

        private void btnIO_6_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[5].status = !ioModelData.ioStatuses[5].status;
                btnIO_6.On = ioModelData.ioStatuses[5].status;
            }
        }

        private void btnIO_7_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[6].status = !ioModelData.ioStatuses[6].status;
                btnIO_7.On = ioModelData.ioStatuses[6].status;
            }
        }

        private void btnIO_8_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;
            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[7].status = !ioModelData.ioStatuses[7].status;
                btnIO_8.On = ioModelData.ioStatuses[7].status;
            }
        }

        private void btnIO_9_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[8].status = !ioModelData.ioStatuses[8].status;
                btnIO_9.On = ioModelData.ioStatuses[8].status;
            }
        }

        private void btnIO_10_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[9].status = !ioModelData.ioStatuses[9].status;
                btnIO_10.On = ioModelData.ioStatuses[9].status;
            }
        }

        private void btnIO_11_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[10].status = !ioModelData.ioStatuses[10].status;
                btnIO_11.On = ioModelData.ioStatuses[10].status;
            }
        }

        private void btnIO_12_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[11].status = !ioModelData.ioStatuses[11].status;
                btnIO_12.On = ioModelData.ioStatuses[11].status;
            }
        }

        private void btnIO_13_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[12].status = !ioModelData.ioStatuses[12].status;
                btnIO_13.On = ioModelData.ioStatuses[12].status;
            }
        }

        private void btnIO_14_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[13].status = !ioModelData.ioStatuses[13].status;
                btnIO_14.On = ioModelData.ioStatuses[13].status;
            }

        }

        private void btnIO_15_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[14].status = !ioModelData.ioStatuses[14].status;
                btnIO_15.On = ioModelData.ioStatuses[14].status;
            }
        }

        private void btnIO_16_Click(object sender, EventArgs e)
        {
            if (!isEnabel)
                return;

            if (ioModelData.ModelType == IOModelType.Output)
            {
                ioModelData.ioStatuses[15].status = !ioModelData.ioStatuses[15].status;
                btnIO_16.On = ioModelData.ioStatuses[15].status;
            }
        }
    }
}
