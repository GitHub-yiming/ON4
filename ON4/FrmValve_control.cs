using ON4.Properties;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ON4
{
    public partial class FrmValve_control : Form
    {
        public FrmValve_control()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotConn2_Click(object sender, EventArgs e)
        {
            Settings.Default.ControlComName = cboPot2.Text;
            OpenPot(btnPotConn1, serialPort1, uiGroupBox7);
        }


        public void potRefresh(UIComboBox uIComboBox)
        {
            string[] ports = SerialPort.GetPortNames();
            uIComboBox.Items.Clear();
            uIComboBox.Items.AddRange(ports);
            uIComboBox.SelectedIndex = 0;
        }

        private void OpenPot(UIButton button, SerialPort serialPort, UIGroupBox groupBox)
        {
            List<string> vs = new List<string>();

            try
            {

                if (button.Text == "连接")
                {
                    foreach (Control item in groupBox.Controls)
                    {
                        if (item is UIComboBox)
                        {
                            vs.Add(item.Text);
                        }
                    }
                    serialPort.PortName = Settings.Default.ControlComName;
                    serialPort.BaudRate = Convert.ToInt32(vs.ToArray()[1].ToString());
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), vs.ToArray()[2].ToString());
                    serialPort.DataBits = int.Parse(vs.ToArray()[3].ToString());
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), vs.ToArray()[4].ToString());
                    serialPort.Open();
                    button.Text = "断开";
                    //tssSerial_port_information.Text = "串口已连接：" + cboPort.Text + "-" + cboBaud_rate.Text + "-" + cbo_Check_Digit.Text + "-" + cboData_bit.Text + "-" + cboStop_bit.Text;
                }
                else if (button.Text == "断开")
                {
                    serialPort.Close();
                    //tssSerial_port_information.Text = "串口未连接";
                    button.Text = "连接";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 串口刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnRefresh_Click(object sender, EventArgs e)
        {
            //potRefresh(cboPot2);
        }

        private void FrmValve_control_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }

        public void btn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
            btnPotConn2_Click(null, null);
            }
        }
    }
}
