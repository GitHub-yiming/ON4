using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Modles;
using ON4.Properties;
using Sunny.UI;


namespace ON4
{
    public partial class FrmMonitor : Form
    {

        User_dataService objUser_dataService = new User_dataService();
        Data1 data1 = new Data1();
        FrmTotalExpenses objfrmTotalExpenses = new FrmTotalExpenses();
        FrmValve_control frmValve_Control1 = new FrmValve_control();
        public FrmMonitor()
        {
            InitializeComponent();
            //把楼层添加到下拉框
            this.cboFloor.DataSource = new NumberofLayerService().GetAllClass();
            this.cboFloor.DisplayMember = "NumberofLayer";
            this.cboFloor.ValueMember = "NumberofLayersId";
            this.cboFloor.SelectedIndex = -1;

            this.cboFloor.SelectedIndexChanged += new System.EventHandler(this.cboFloor_SelectedIndexChanged);

            //禁止表格自动生成列
            this.dgvScoreList1.AutoGenerateColumns = false;
        }

        string timer223 = "";//下一次记录时间
        public bool ii = true, hu = true;
        public string[] vs;//保存当前电表
        //int tt = vs.Length;//保存当前数
        //string[] vs2;//电表总数
        public int vs1 = 3;//表号类型(对应楼层数)
        public int vs2 = 0;
        public int bb = 1;//保存当前记录数量
        //int cc = 1;//保存当前电表总数
        //int timerChanged = 0;//用于判断热量表超时时间
        public SerialPort port;//用于保存当前串口号

        /// <summary>
        /// 根据楼层显示表号、用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboFloor.SelectedIndex == -1)
            {
                MessageBox.Show("请首先选择要查询的表号！", "查询提示");
                return;
            }
            this.dgvScoreList1.DataSource = objUser_dataService.GetInfoByFloor(this.cboFloor.Text.Trim());
        }

        /// <summary>
        /// 双击表格获取学号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvScoreList1.CurrentRow != null)
            {
                //获取学号
                txtTableNumber1.Text = this.dgvScoreList1.CurrentRow.Cells["Table_number"].Value.ToString();
            }
        }

        /// <summary>
        /// 打开串口
        /// </summary>
        public void StatrPot()
        {
            serialPort1.Open();
        }

        #region 串口接收数据

        /// <summary>
        /// 串口1接收数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPortReceived(serialPort1, 1);
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPortReceived(serialPort2, 2);
        }

        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPortReceived(serialPort3, 3);
        }

        private void serialPort4_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPortReceived(serialPort4, 4);
        }

        #region 数据读取

        //存放热量表的数据
        public List<byte> hh = new List<byte>();
        #region 全部
        /// <summary>
        /// 串口接收数据
        /// </summary>
        /// <param name="serialPort">串口</param>
        /// <param name="num"></param>
        public void SerialPortReceived(SerialPort serialPort, int num)
        {

            port = serialPort;
            int aa = serialPort.BytesToRead;
            byte[] tt = new byte[aa];
            serialPort.Read(tt, 0, tt.Length);

            //判断此次读取的数据是否满足65个字节
            if (tt.Length != 65)
            {
                for (int i = 0; i < tt.Length; i++)
                {
                    hh.Add(tt[i]);
                }
            }
            else
            {
                for (int i = 0; i < tt.Length; i++)
                {
                    hh.Add(tt[i]);
                }
            }

            //对数据进行验证，满足后才可继续执行
            //不满足就清除hh中的数据
            try
            {
                if (hh.ToArray().Length >= 64 && hh.ToArray().Length <= 65)
                {
                    //对返回的数据进行校验，分别判断[63]和[62]是因为返回的数据有可能是65或者是64
                    if (data1.XSummation_check_2(hh.ToArray()) == hh[63] || data1.XSummation_check_2(hh.ToArray()) == hh[62])
                    {
                        //判断当前是否在记录中，如果是就把数据写入到数据库中
                        //如果不是在记录中，那么读取到的数据就只在监控界面中显示
                        if (btnRecording.Text == "记录中...")
                        {
                            //解析报文数据
                            string[] gg = Ordinary_meter_reading(hh.ToArray());
                            if (gg != null)
                            {
                                //判断本次金额是否大于上次金额，不满足则数据有误
                                if (Convert.ToDouble(gg[1]) >= objUser_dataService.QueryMax(gg[0]))
                                {
                                    //写入数据库
                                    data1.Fddd(gg);
                                }
                                else
                                {
                                    return;
                                }

                            }


                            #region 判断是否“启用计费”

                            if (Settings.Default.启用计费)
                            {
                                objUser_dataService.QueryScoreList1(vs[bb - 1]); //更新用户余额
                            }

                            #endregion

                            #region 判断是否启用继电器控制
                            if (Settings.Default.启用继电器控制)
                            {
                                if (objUser_dataService.Quota_calculation(vs[bb - 1]) == "信用超额")
                                {
                                    ValveControl(vs[bb - 1], 1);//关闭阀门
                                }
                                else
                                {
                                    ValveControl(vs[bb - 1], 0);//打开阀门
                                }
                            }
                            #endregion

                            if (uiComboBox9.Text == "全部")
                            {
                                #region 循环读取所有楼层的表号，直到结束
                                //判断当前楼层的表号数量是否与bb是否相等，相等就往下个一楼层增加
                                //否则就继续读取当前楼层剩余的表号
                                if (bb == data1.SQL_table_number_read(vs1).Length)
                                {
                                    bb = 1;
                                    vs2++;
                                    vs1++;
                                    //获取数据库中所有楼层的总和，并与vs2比较，如果相等就退出循环
                                    //不相等就继续读取表号
                                    if (vs2 == data1.SQL_table_number_read1().Length)
                                    {
                                        hu = true;
                                        this.btnRecording.Invoke(new Action<bool>(s => { btnRecording.Enabled = s; }), true);
                                        btnSave_Click(null, null);
                                        this.btnRecording.Invoke(new Action<string>(s => { btnRecording.Text = s; }), "立即记录");
                                        vs1 = 3;
                                        vs2 = 0;
                                        bb = 1;
                                        this.label2.Invoke(new Action<string>(s => { label2.Text = s; }), "当前未在记录");

                                    }
                                    else
                                    {
                                        vs = data1.SQL_table_number_read(vs1);
                                        //如果当前读取的楼层的表号为空，那么就跳过此次楼层，继续读取下一个楼层
                                        for (int i = 0; vs.Length == 0; i++)
                                        {
                                            vs1++;
                                            vs = data1.SQL_table_number_read(vs1);
                                            //读取到的表号不为空就跳出循环
                                            if (vs.Length != 0)
                                                break;
                                            //数据库的楼层总数等于VS1就跳出循环
                                            if (vs1 == data1.SQL_table_number_read1().Length + 1)
                                                break;
                                        }
                                        if (vs.Length != 0)
                                            Senddata(vs1);
                                        //bb=0;
                                        //hh.Clear();
                                        if (vs2 == data1.SQL_table_number_read1().Length + 2)
                                        {
                                            hu = true;
                                            this.btnRecording.Invoke(new Action<bool>(s => { btnRecording.Enabled = s; }), true);
                                            btnSave_Click(null, null);
                                            this.btnRecording.Invoke(new Action<string>(s => { btnRecording.Text = s; }), "立即记录");
                                            vs1 = 3;
                                            vs2 = 0;
                                            bb = 1;
                                            this.label2.Invoke(new Action<string>(s => { label2.Text = s; }), "当前未在记录");
                                        }
                                    }

                                }
                                else
                                {
                                    serialPort.Write(data1.Common_meter_reading(vs[bb]), 0, data1.Common_meter_reading(vs[bb]).Length);
                                    bb++;
                                    hh.Clear();
                                }

                                #endregion
                            }

                            #region 楼层三
                            if (uiComboBox9.Text == "楼层三")
                            {
                                if (data1.SQL_table_number_read(3).Length == bb)
                                {
                                    bb = 1;
                                    this.btnRecording.Invoke(new Action<bool>(s => { btnRecording.Enabled = s; }), true);
                                    btnSave_Click(null, null);
                                    this.btnRecording.Invoke(new Action<string>(s => { btnRecording.Text = s; }), "立即记录");
                                    //vs1 = 1;
                                    this.label2.Invoke(new Action<string>(s => { label2.Text = s; }), "当前未在记录");
                                }
                                else
                                {
                                    serialPort.Write(data1.Common_meter_reading(vs[bb]), 0, data1.Common_meter_reading(vs[bb]).Length);
                                    bb++;
                                    hh.Clear();
                                }

                            }
                            #endregion

                            #region 楼层四

                            if (uiComboBox9.Text == "楼层四")
                            {
                                if (data1.SQL_table_number_read(4).Length == bb)
                                {
                                    bb = 1;
                                    this.btnRecording.Invoke(new Action<bool>(s => { btnRecording.Enabled = s; }), true);
                                    btnSave_Click(null, null);
                                    this.btnRecording.Invoke(new Action<string>(s => { btnRecording.Text = s; }), "立即记录");
                                    //vs1 = 1;
                                    this.label2.Invoke(new Action<string>(s => { label2.Text = s; }), "当前未在记录");
                                }
                                else
                                {
                                    //循环发送三次
                                    //for (int i = 0; i < 3; i++)
                                    //{
                                    //    serialPort.Write(data1.Common_meter_reading(vs[bb]), 0, data1.Common_meter_reading(vs[bb]).Length);
                                    //    Thread.Sleep(1000);
                                    //}
                                    serialPort.Write(data1.Common_meter_reading(vs[bb]), 0, data1.Common_meter_reading(vs[bb]).Length);
                                    bb++;
                                    hh.Clear();
                                }


                            }

                            #endregion

                            #region 楼层五
                            if (uiComboBox9.Text == "楼层五")
                            {
                                if (data1.SQL_table_number_read(5).Length == bb)
                                {
                                    bb = 1;
                                    this.btnRecording.Invoke(new Action<bool>(s => { btnRecording.Enabled = s; }), true);
                                    btnSave_Click(null, null);
                                    this.btnRecording.Invoke(new Action<string>(s => { btnRecording.Text = s; }), "立即记录");
                                    //vs1 = 1;
                                    this.label2.Invoke(new Action<string>(s => { label2.Text = s; }), "当前未在记录");
                                }
                                else
                                {
                                    serialPort.Write(data1.Common_meter_reading(vs[bb]), 0, data1.Common_meter_reading(vs[bb]).Length);
                                    bb++;
                                    hh.Clear();
                                }


                            }
                            #endregion

                            #region 楼层六
                            if (uiComboBox9.Text == "楼层六")
                            {
                                if (data1.SQL_table_number_read(6).Length == bb)
                                {
                                    bb = 1;
                                    this.btnRecording.Invoke(new Action<bool>(s => { btnRecording.Enabled = s; }), true);
                                    btnSave_Click(null, null);
                                    this.btnRecording.Invoke(new Action<string>(s => { btnRecording.Text = s; }), "立即记录");
                                    //vs1 = 1;
                                    this.label2.Invoke(new Action<string>(s => { label2.Text = s; }), "当前未在记录");
                                }
                                else
                                {
                                    serialPort.Write(data1.Common_meter_reading(vs[bb]), 0, data1.Common_meter_reading(vs[bb]).Length);
                                    bb++;
                                    hh.Clear();
                                }


                            }
                            #endregion

                        }
                        else
                        {
                            //如果不在记录中...就不写入数据库，只在界面中显示
                            Ordinary_meter_reading(hh.ToArray());
                            //objUser_dataService.QueryScoreList1(txtTableNumber1.Text.Trim());//更新用户余额
                            hh.Clear();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            hh.Clear();
        }
        #endregion

        #region 单层
        public void SerialPortReceived(SerialPort serialPort, string num)
        {

        }
        #endregion


        /// <summary>
        /// 阀门控制
        /// </summary>
        public void ValveControl(string tablenumber, int Instruction)
        {
            byte[] vs = data1.Write_coil(Convert.ToUInt16(objUser_dataService.ValveClosed(tablenumber)), 0, Instruction);
            string vs1 = objUser_dataService.QueryFloor(tablenumber);
            string vs2 = objUser_dataService.SelectPort(tablenumber);
            switch (vs1)
            {
                case "3":
                    if (vs2 == "1")
                        serialPort5.Write(vs, 0, vs.Length);
                    else
                        serialPort9.Write(vs, 0, vs.Length);
                    break;
                case "4":
                    if (vs2 == "1")
                        serialPort6.Write(vs, 0, vs.Length);
                    else
                        serialPort10.Write(vs, 0, vs.Length);
                    break;
                case "5":
                    if (vs2 == "1")
                        serialPort7.Write(vs, 0, vs.Length);
                    else
                        serialPort11.Write(vs, 0, vs.Length);
                    break;
                case "6":
                    if (vs2 == "1")
                        serialPort8.Write(vs, 0, vs.Length);
                    else
                        serialPort12.Write(vs, 0, vs.Length);
                    break;

            }
            serialPort5.Write(vs, 0, vs.Length);

        }

        /// <summary>
        /// 楼层串口数据发送
        /// </summary>
        /// <param name="num"></param>
        public void Senddata(int num)
        {
            switch (num)
            {
                case 3:
                    serialPort1.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                    break;
                case 4:
                    serialPort2.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                    break;
                case 5:
                    serialPort3.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                    break;
                case 6:
                    serialPort4.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                    break;
            }

        }




        #region 普通读表


        public string[] Ordinary_meter_reading(byte[] hh)
        {


            int n = 0;
            for (int i = 0; i < hh.Length; i++)
            {
                if (hh[i].ToString("X2") == "FE")
                {
                    n++;
                }
            }
            //vs是去除了FE和校验码之后的数据
            byte[] vsS = new byte[hh.Length - (n + 2)];
            Array.Copy(hh, n, vsS, 0, hh.Length - (n + 2));
            //uiDataGridView1.Rows[0].Cells[0].Value = vs[0].ToString("X2");
            for (int i = 0; i < data1.Ordinary_message_analysis_2(vsS).Length; i++)
            {
                //监控界面显示
                uiDataGridView1.Rows[0].Cells[i].Value = data1.Ordinary_message_analysis_3(vsS)[i];
            }

            return data1.Ordinary_message_analysis_2(vsS);
        }
        #endregion

        #endregion

        #endregion

        private void FrmMonitor_Load(object sender, EventArgs e)
        {
            if (Settings.Default.自动连接串口)
            {
                PotConn1_Click(null, null);
                PotConn2_Click(null, null);
                PotConn3_Click(null, null);
                PotConn4_Click(null, null);
                btnPotConn5_Click(null, null);
                btnPotConn6_Click(null, null);
                btnPotConn7_Click(null, null);
                btnPotConn8_Click(null, null);
                btnPotConn9_Click(null, null);
                btnPotConn10_Click(null, null);
                btnPotConn11_Click(null, null);
                btnPotConn12_Click(null, null);
            }
            // btnRefresh_Click(null, null);
            //ComBilding();//串口绑定
            uiComboBox8_SelectedIndexChanged(null, null);//切换串口界面
            uiComboBox2_SelectedIndexChanged(null, null);
            //toolStripStatusLabel3.Text = "下一次记录是在：" + Settings.Default.Recording;
            label1.Text = "下一次记录是在：" + Settings.Default.Recording;

            if (Settings.Default.启用清零)
                btnClear.Enabled = true;

            if (Settings.Default.启用检定)
                btnVerification.Enabled = true;

        }


        #region 发送串口报文
        /// <summary>
        /// 发送串口报文
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PotRed_Click(object sender, EventArgs e)
        {

            if (cboFloor.Text == "三楼")
            {
                if (!serialPort1.IsOpen)
                {
                    MessageBox.Show("楼层三的串口未打开！请打开后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Sendpk(serialPort1, btnPotRed);
            }
            if (cboFloor.Text == "四楼")
            {
                if (!serialPort2.IsOpen)
                {
                    MessageBox.Show("楼层四的串口未打开！请打开后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Sendpk(serialPort2, btnPotRed);
            }
            if (cboFloor.Text == "五楼")
            {
                if (!serialPort3.IsOpen)
                {
                    MessageBox.Show("楼层五的串口未打开！请打开后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Sendpk(serialPort3, btnPotRed);
            }
            if (cboFloor.Text == "六楼")
            {
                if (!serialPort4.IsOpen)
                {
                    MessageBox.Show("楼层六的串口未打开！请打开后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Sendpk(serialPort4, btnPotRed);
            }
        }

        private void Sendpk(SerialPort serialPort, UIButton uIButton)
        {
            if (cboFloor.SelectedIndex != -1 && txtTableNumber1.Text.Trim().Length != 0 && txtTableNumber1.Text.Trim().Length == 8)
            {
                if (serialPort.IsOpen)
                {
                    if (uIButton == btnPotRed)
                    {
                        serialPort.Write(data1.Common_meter_reading(txtTableNumber1.Text.Trim()), 0, data1.Common_meter_reading(txtTableNumber1.Text.Trim()).Length);
                    }

                    if (uIButton == btnClear)
                    {
                        serialPort.Write(data1.Cumulative_reset(txtTableNumber1.Text.Trim()), 0, data1.Cumulative_reset(txtTableNumber1.Text.Trim()).Length);
                    }

                    if (uIButton == btnVerification)
                    {
                        serialPort.Write(data1.Enter_verification(txtTableNumber1.Text.Trim()), 0, data1.Enter_verification(txtTableNumber1.Text.Trim()).Length);
                    }
                }
            }
            else
            {
                MessageBox.Show("相应楼层串口未打开！请检查！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// 累积量清零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cboFloor.Text == "一楼")
            {
                Sendpk(serialPort1, btnClear);
            }
            if (cboFloor.Text == "二楼")
            {
                Sendpk(serialPort2, btnClear);
            }
            if (cboFloor.Text == "三楼")
            {
                Sendpk(serialPort3, btnClear);
            }
            if (cboFloor.Text == "四楼")
            {
                Sendpk(serialPort4, btnClear);
            }
        }

        /// <summary>
        /// 进入检定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerification_Click(object sender, EventArgs e)
        {
            if (cboFloor.Text == "一楼")
            {
                Sendpk(serialPort1, btnVerification);
            }
            if (cboFloor.Text == "二楼")
            {
                Sendpk(serialPort2, btnVerification);
            }
            if (cboFloor.Text == "三楼")
            {
                Sendpk(serialPort3, btnVerification);
            }
            if (cboFloor.Text == "四楼")
            {
                Sendpk(serialPort4, btnVerification);
            }
        }

        #endregion
        #region 打开、关闭串口
        private void PotConn1_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn1, serialPort1, uiGroupBox6);
        }

        private void PotConn2_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn2, serialPort2, uiGroupBox7);
        }

        private void PotConn3_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn3, serialPort3, uiGroupBox8);
        }

        private void PotConn4_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn4, serialPort4, uiGroupBox9);
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
                    serialPort.PortName = vs.ToArray()[0].ToString();
                    serialPort.BaudRate = Convert.ToInt32(vs.ToArray()[1].ToString());
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), vs.ToArray()[2].ToString());
                    serialPort.DataBits = int.Parse(vs.ToArray()[3].ToString());
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), vs.ToArray()[4].ToString());
                    serialPort.Open();
                    button.Text = "断开";
                }
                else if (button.Text == "断开")
                {
                    serialPort.Close();
                    button.Text = "连接";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region 串口刷新
        /// <summary>
        /// 串口刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            potRefresh(cboPot1);
            potRefresh(cboPot2);
            potRefresh(cboPot3);
            potRefresh(cboPot4);
            potRefresh(cboPot5);
            potRefresh(cboPot6);
            potRefresh(cboPot7);
            potRefresh(cboPot8);

        }

        /// <summary>
        /// 串口绑定
        /// </summary>
        public void ComBilding()
        {
            cboPot1.Text = Settings.Default.cboPot1;
            cboPot2.Text = Settings.Default.cboPot2;
            cboPot3.Text = Settings.Default.cboPot3;
            cboPot4.Text = Settings.Default.cboPot4;
            cboPot5.Text = Settings.Default.cboPot5;

        }

        private void potRefresh(UIComboBox uIComboBox)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                uIComboBox.Items.Clear();
                uIComboBox.Items.AddRange(ports);
                uIComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// 立刻记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnRecording_Click(object sender, EventArgs e)
        {
            try
            {
                #region 全部
                if (uiComboBox9.Text == "全部")
                {
                    if (serialPort1.IsOpen && serialPort2.IsOpen && serialPort3.IsOpen && serialPort4.IsOpen)
                    {
                        if (Settings.Default.启用继电器控制)
                        {
                            if (serialPort5.IsOpen && serialPort6.IsOpen && serialPort7.IsOpen && serialPort8.IsOpen && serialPort9.IsOpen && serialPort10.IsOpen && serialPort11.IsOpen && serialPort12.IsOpen)
                            {
                                MessageBox.Show("楼层串口与继电器串口未全部打开！ 请检查串口！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        btnRecording.Enabled = false;
                        btnRecording.Text = "记录中...";
                        vs = data1.SQL_table_number_read(3);
                        if (vs.Length != 0)
                        {
                            serialPort1.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                            //bb++;
                        }
                        else
                        {
                            for (int i = 2; vs.Length == 0; i++)
                            {
                                vs1++;
                                vs = data1.SQL_table_number_read(vs1);
                                if (vs.Length != 0)
                                {
                                    Sends(i);
                                    break;
                                }
                                //if(i==new NumberofLayerService().GetAllnum()+1)
                                //{
                                //    btnRecording.Enabled = true;
                                //    btnRecording.Text = "立刻记录";
                                //    MessageBox.Show("用户信息中无任何楼层信息！检查用户信息", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //    return;
                                //}
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("楼层串口未全部打开！ 请检查串口！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                #endregion

                #region 楼层三
                if (uiComboBox9.Text == "楼层三")
                {
                    if (serialPort1.IsOpen)
                    {
                        btnRecording.Enabled = false;
                        btnRecording.Text = "记录中...";
                        vs = data1.SQL_table_number_read(3);
                        if (vs.Length != 0)
                        {
                            serialPort1.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                        }
                        else
                        {
                            MessageBox.Show("楼层三未找到表号信息！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnRecording.Enabled = true;
                            btnRecording.Text = "立刻记录";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("楼层三串口未打开！  请检查后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRecording.Enabled = true;
                        btnRecording.Text = "立刻记录";
                        return;
                    }
                }


                #endregion

                #region 楼层四
                if (uiComboBox9.Text == "楼层四")
                {
                    if (serialPort2.IsOpen)
                    {
                        btnRecording.Enabled = false;
                        btnRecording.Text = "记录中...";
                        vs = data1.SQL_table_number_read(4);
                        if (vs.Length != 0)
                        {
                            serialPort2.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                        }
                        else
                        {
                            MessageBox.Show("楼层四未找到表号信息！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnRecording.Enabled = true;
                            btnRecording.Text = "立刻记录";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("楼层四串口未打开！  请检查后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRecording.Enabled = true;
                        btnRecording.Text = "立刻记录";
                        return;
                    }
                }

                #endregion

                #region 楼层五
                if (uiComboBox9.Text == "楼层五")
                {
                    if (serialPort3.IsOpen)
                    {
                        btnRecording.Enabled = false;
                        btnRecording.Text = "记录中...";
                        vs = data1.SQL_table_number_read(5);
                        if (vs.Length != 0)
                        {
                            serialPort3.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                        }
                        else
                        {
                            MessageBox.Show("楼层五未找到表号信息！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnRecording.Enabled = true;
                            btnRecording.Text = "立刻记录";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("楼层五串口未打开！  请检查后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRecording.Enabled = true;
                        btnRecording.Text = "立刻记录";
                        return;
                    }
                }

                #endregion

                #region 楼层六
                if (uiComboBox9.Text == "楼层六")
                {
                    if (serialPort4.IsOpen)
                    {
                        btnRecording.Enabled = false;
                        btnRecording.Text = "记录中...";
                        vs = data1.SQL_table_number_read(6);
                        if (vs.Length != 0)
                        {
                            serialPort4.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                        }
                        else
                        {
                            MessageBox.Show("楼层六未找到表号信息！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnRecording.Enabled = true;
                            btnRecording.Text = "立刻记录";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("楼层六串口未打开！  请检查后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRecording.Enabled = true;
                        btnRecording.Text = "立刻记录";
                        return;
                    }
                }

                #endregion

            }
            catch (Exception ex)
            {
                btnRecording.Enabled = true;
                btnRecording.Text = "立刻记录";
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //识别串口
        public void Sends(int num)
        {
            switch (num)
            {
                case 1:
                    serialPort1.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                    //bb++;
                    break;
                case 2:
                    serialPort2.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                    //bb++;
                    break;
                case 3:
                    serialPort3.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                    //bb++;
                    break;
                case 4:
                    serialPort4.Write(data1.Common_meter_reading(vs[0]), 0, data1.Common_meter_reading(vs[0]).Length);
                    //bb++;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmValve_Control1.serialPort1.Open();
            frmValve_Control1.btnRefresh_Click(null, null);
            frmValve_Control1.btn_Click(null, null);
            byte[] vs = new byte[2];
            vs[0] = 0x01;
            vs[1] = 0x02;
            if (frmValve_Control1.serialPort1.IsOpen)
                frmValve_Control1.serialPort1.Write(vs, 0, vs.Length);
        }



        private void cboPot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Settings.Default.cboPot1 = cboPot1.Text;
            //Settings.Default.cboPot2 = cboPot2.Text;
            //Settings.Default.cboPot3 = cboPot3.Text;
            //Settings.Default.cboPot4 = cboPot4.Text;
            //Settings.Default.cboPot5 = cboPot5.Text;
            //Settings.Default.cboPot6 = cboPot6.Text;
            //Settings.Default.cboPot7 = cboPot7.Text;
            //Settings.Default.cboPot8 = cboPot8.Text;
        }

        /// <summary>
        /// 切换串口显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox8.Text == "三四层")
            {
                uiGroupBox6.Visible = true;
                uiGroupBox7.Visible = true;
                uiGroupBox8.Visible = false;
                uiGroupBox9.Visible = false;
            }
            if (uiComboBox8.Text == "五六层")
            {
                uiGroupBox8.Visible = true;
                uiGroupBox9.Visible = true;
                uiGroupBox6.Visible = false;
                uiGroupBox7.Visible = false;
            }

        }

        /// <summary>
        /// 阀门控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotConn5_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn5, serialPort5, uiGroupBox4);
        }

        private void btnPotConn6_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn6, serialPort6, uiGroupBox14);
        }

        private void btnPotConn7_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn7, serialPort7, uiGroupBox16);
        }

        private void btnPotConn8_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn8, serialPort8, uiGroupBox5);
        }

        private void btnPotConn9_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn9, serialPort9, uiGroupBox3);
        }

        private void btnPotConn10_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn10, serialPort10, uiGroupBox15);
        }

        private void btnPotConn11_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn11, serialPort11, uiGroupBox17);
        }

        private void btnPotConn12_Click(object sender, EventArgs e)
        {
            OpenPot(btnPotConn12, serialPort12, uiGroupBox18);
        }

        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox2.Text == "三四层")
            {
                uiGroupBox10.Visible = true;
                uiGroupBox11.Visible = true;
                uiGroupBox12.Visible = false;
                uiGroupBox13.Visible = false;
            }
            if (uiComboBox2.Text == "五六层")
            {
                uiGroupBox10.Visible = false;
                uiGroupBox11.Visible = false;
                uiGroupBox12.Visible = true;
                uiGroupBox13.Visible = true;
            }
        }

        /// <summary>
        /// 停止记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uBtnStop_Click(object sender, EventArgs e)
        {
            hu = true;
            this.btnRecording.Invoke(new Action<bool>(s => { btnRecording.Enabled = s; }), true);
            btnSave_Click(null, null);
            this.btnRecording.Invoke(new Action<string>(s => { btnRecording.Text = s; }), "立即记录");
            vs1 = 3;
            vs2 = 0;
            bb = 1;
            this.label2.Invoke(new Action<string>(s => { label2.Text = s; }), "当前未在记录");
        }










        #region 判断是否超时
        /// <summary>
        /// 判断是否超时回复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        #endregion

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.小时触发 = uiComboBox1.Text;
            if (DateTime.Now.Hour < Convert.ToInt32(Settings.Default.小时触发))
            {
                //int HourTimer = Convert.ToInt32(Settings.Default.小时触发) - DateTime.Now.Hour;
                //timer223 = DateTime.Now.AddHours(Convert.ToDouble(HourTimer)).ToString("yyyy年MM月dd日hh时");
                timer223 = DateTime.Now.ToString("yyyy年MM月dd日") + uiComboBox1.Text + "时";
            }
            else
            {
                timer223 = DateTime.Now.AddDays(Convert.ToDouble(uiComboBox6.Text)).ToString("yyyy年MM月dd日") + Settings.Default.小时触发 + "时";
            }
            Settings.Default.Recording = timer223;
            label1.Invoke(new Action<string>(s => { label1.Text = s; }), "下一次记录是在：" + Settings.Default.Recording);

        }
    }
}
#endregion