using ON4.Properties;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Modles;


namespace ON4
{
    public partial class Form1 : Form
    {
        Data1 data1 = new Data1();

        public Form1()
        {
            InitializeComponent();

            tree.ExpandAll();
        }
        FrmMonitor frmMonitor = new FrmMonitor();
        FrmUserEntry_and_TableNumber frmUserEntry = new FrmUserEntry_and_TableNumber();
        FrmAddTablenumber frmAddTablenumber = new FrmAddTablenumber();
        FrmInquire_User_and_TableNumber frmInquire = new FrmInquire_User_and_TableNumber();
        FrmTotalExpenses frmTotal = new FrmTotalExpenses();
        FrmUserPpayment frmUserPpayment = new FrmUserPpayment();
        FrmUnit_price frmUnit_Price = new FrmUnit_price();
        SystemSet frmsyStemSet = new SystemSet();
        Batchimport frmBatchimport = new Batchimport();
        //FrmValve_control frmValve_Control = new FrmValve_control();

        //记录秒数
        //int AddTimer = 0;

        //记录电表返回延迟时间
        int AddNum = 0;

        //阻拦同时发送数据
        bool bo = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenForm(frmMonitor);
            OpenForm(frmUserEntry);
            OpenForm(frmAddTablenumber);
            OpenForm(frmInquire);
            OpenForm(frmTotal);
            OpenForm(frmUserPpayment);
            OpenForm(frmUnit_Price);
            OpenForm(frmsyStemSet);
            OpenForm(frmBatchimport);
            //OpenForm(frmValve_Control);
            frmMonitor.BringToFront();
            timer1.Start();
            if(new DAL.NumberofLayerService().GetAllNum() == 0)
            {
                new DAL.NumberofLayerService().WriteInfo();
            }

        }

        /// <summary>
        /// 切换界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                if (e.Node.Tag.ToString() == "frmMonitor")
                    frmMonitor.BringToFront();
                if (e.Node.Tag.ToString()== "frmUserEntry")
                    frmUserEntry.BringToFront();
                if (e.Node.Tag.ToString() == "frmAddTablenumber")
                    frmAddTablenumber.BringToFront();
                if (e.Node.Tag.ToString() == "frmInquire")
                    frmInquire.BringToFront();
                if (e.Node.Tag.ToString() == "frmTotal")
                    frmTotal.BringToFront();
                if (e.Node.Tag.ToString() == "frmUserPpayment")
                    frmUserPpayment.BringToFront();
                if(e.Node.Tag.ToString()== "frmUnit_Price")
                    frmUnit_Price.BringToFront();
                //if (e.Node.Tag.ToString() == "frmValve_Control")
                //    frmValve_Control.BringToFront();
                if (e.Node.Tag.ToString() == "frmsyStemSet")
                    frmsyStemSet.BringToFront();
                if (e.Node.Tag.ToString() == "frmBatchimport")
                    frmBatchimport.BringToFront();
            }
        }

        private void OpenForm(Form objForm)
        {
            //ClosePreForm();
            objForm.TopLevel = false;//将子窗体设置成非顶级控件
            objForm.FormBorderStyle = FormBorderStyle.None;//去掉子窗体的边框
            objForm.Parent = this.spContainer.Panel2;//指定子窗体显示的容器
            objForm.Dock = DockStyle.Fill;//随着容器的大小自动调整窗体大小
            objForm.Show();
        }

        /// <summary>
        /// 串口关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "热量："+frmUnit_Price.caloriesTextBox.Text+"元";
            toolStripStatusLabel4.Text = "冷量：" + frmUnit_Price.cooling_capacityTextBox.Text+"元";
            toolStripStatusLabel2.Text = DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒");
            string hvh = DateTime.Now.AddDays(Convert.ToDouble(frmMonitor.uiComboBox6.Text)).ToString("yyyy年MM月dd日hh时");

            if (frmMonitor.btnRecording.Text == "记录中..."&&frmMonitor.hh.Count==0)
            {
                AddNum++;
            }
            else
            {
                AddNum = 0;
            }

            if (AddNum >= 5 && frmMonitor.uiComboBox9.Text == "全部")
            {
                bo = false;

                if (frmMonitor.bb == data1.SQL_table_number_read(frmMonitor.vs1).Length)
                {
                    frmMonitor.bb = 1;
                    frmMonitor.vs2++;
                    frmMonitor.vs1++;
                    bo = true;
                    if (frmMonitor.vs2 == data1.SQL_table_number_read1().Length)
                    {
                        frmMonitor.hu = true;
                        frmMonitor.btnRecording.Enabled = true;
                        frmMonitor.btnRecording.Text = "立即记录";
                        frmMonitor.btnSave_Click(null, null);
                        frmMonitor.vs1 = 3;
                        frmMonitor.vs2 = 0;
                        frmMonitor.bb = 1;
                        bo = false;
                    }
                    else
                    {
                        frmMonitor.vs = data1.SQL_table_number_read(frmMonitor.vs1);
                        for (int i = 0; frmMonitor.vs.Length == 0; i++)
                        {
                            frmMonitor.vs1++;
                            frmMonitor.vs = data1.SQL_table_number_read(frmMonitor.vs1);
                            //读取到的表号不为空就跳出循环
                            if (frmMonitor.vs.Length != 0)
                                break;
                            //数据库的楼层总数等于VS1就跳出循环
                            if (frmMonitor.vs1 == data1.SQL_table_number_read1().Length + 1)
                                break;
                        }

                        if (frmMonitor.vs.Length != 0)
                        {
                            frmMonitor.Senddata(frmMonitor.vs1);
                            AddNum = 0;
                        }

                        if (frmMonitor.vs2 == data1.SQL_table_number_read1().Length + 2)
                        {
                            frmMonitor.hu = true;
                            frmMonitor.btnRecording.Enabled = true;
                            frmMonitor.btnSave_Click(null, null);
                            frmMonitor.btnRecording.Text = "立刻记录";
                            frmMonitor.vs1 = 3;
                            frmMonitor.vs2 = 0;
                            frmMonitor.bb = 1;
                            bo = false;
                        }
                    }
                }
                if (frmMonitor.port == null&&bo==false)
                {
                    frmMonitor.SerialPortReceived(frmMonitor.serialPort1, 1);
                    frmMonitor.port.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                    frmMonitor.bb++;
                    frmMonitor.hh.Clear();
                    AddNum = 0;
                }
                else if(frmMonitor.btnRecording.Text == "记录中..."&&bo==false)
                {
                    if (frmMonitor.vs1 == 3)
                    {
                        frmMonitor.serialPort1.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                        frmMonitor.bb++;
                        frmMonitor.hh.Clear();
                        AddNum = 0;
                    }
                    if (frmMonitor.vs1 == 4)
                    {
                        frmMonitor.serialPort2.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                        frmMonitor.bb++;
                        frmMonitor.hh.Clear();
                        AddNum = 0;
                    }
                    if (frmMonitor.vs1 == 5)
                    {
                        frmMonitor.serialPort3.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                        frmMonitor.bb++;
                        frmMonitor.hh.Clear();
                        AddNum = 0;
                    }
                    if (frmMonitor.vs1 == 6)
                    {
                        frmMonitor.serialPort4.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                        frmMonitor.bb++;
                        frmMonitor.hh.Clear();
                        AddNum = 0;
                    }

                }



            }

            if (AddNum == 10 && frmMonitor.uiComboBox9.Text == "楼层三")
            {

                if (frmMonitor.vs.Length == frmMonitor.bb)
                {
                    frmMonitor.bb = 1;
                    frmMonitor.btnRecording.Enabled = true;
                    frmMonitor.btnRecording.Text = "立即记录";
                    frmMonitor.btnSave_Click(null, null);
                }
                frmMonitor.serialPort1.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                frmMonitor.bb++;
                frmMonitor.hh.Clear();
                AddNum = 0;
            }

            if (AddNum == 10 && frmMonitor.uiComboBox9.Text == "楼层四")
            {

                if (frmMonitor.vs.Length == frmMonitor.bb)
                {
                    frmMonitor.bb = 1;
                    frmMonitor.btnRecording.Enabled = true;
                    frmMonitor.btnRecording.Text = "立即记录";
                    frmMonitor.btnSave_Click(null, null);
                }
                frmMonitor.serialPort2.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                frmMonitor.bb++;
                frmMonitor.hh.Clear();
                AddNum = 0;
            }

            if (AddNum == 10 && frmMonitor.uiComboBox9.Text == "楼层五")
            {

                if (frmMonitor.vs.Length == frmMonitor.bb)
                {
                    frmMonitor.bb = 1;
                    frmMonitor.btnRecording.Enabled = true;
                    frmMonitor.btnRecording.Text = "立即记录";
                    frmMonitor.btnSave_Click(null, null);
                }
                frmMonitor.serialPort3.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                frmMonitor.bb++;
                frmMonitor.hh.Clear();
                AddNum = 0;
            }

            if (AddNum == 10 && frmMonitor.uiComboBox9.Text == "楼层六")
            {

                if (frmMonitor.vs.Length == frmMonitor.bb)
                {
                    frmMonitor.bb = 1;
                    frmMonitor.btnRecording.Enabled = true;
                    frmMonitor.btnRecording.Text = "立即记录";
                    frmMonitor.btnSave_Click(null, null);
                }
                frmMonitor.serialPort4.Write(data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]), 0, data1.Common_meter_reading(frmMonitor.vs[frmMonitor.bb]).Length);
                frmMonitor.bb++;
                frmMonitor.hh.Clear();
                AddNum = 0;
            }


            if (Settings.Default.启用自动记录)
            {
            if (Settings.Default.Recording == DateTime.Now.ToString("yyyy年MM月dd日HH时") && frmMonitor.hu)
            {
                    frmMonitor.hu = false;
                    frmMonitor.btnRecording_Click(null, null);
            }
            }

            #region 每小时记录--需要可以启用

            //if (Settings.Default.启用自动记录)
            //{
            //    if (Convert.ToInt32(frmsyStemSet.comboBox1.Text + "00") <= Convert.ToInt32(DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString()) && Convert.ToInt32(frmsyStemSet.comboBox2.Text + "00") >= Convert.ToInt32(DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString()))
            //    {
            //        AddTimer++;
            //        switch (frmsyStemSet.comboBox3.Text)
            //        {
            //            case "半个":
            //                if (AddTimer >= 1800)
            //                {
            //                    frmMonitor.hu = false;
            //                    frmMonitor.btnRecording_Click(null, null);
            //                    AddTimer = 0;
            //                }
            //                break;
            //            case "一个":
            //                if (AddTimer >= 3600)
            //                {
            //                    frmMonitor.hu = false;
            //                    frmMonitor.btnRecording_Click(null, null);
            //                    AddTimer = 0;
            //                }
            //                break;

            //            case "两个":
            //                if (AddTimer >= 7200)
            //                {
            //                    frmMonitor.hu = false;
            //                    frmMonitor.btnRecording_Click(null, null);
            //                    AddTimer = 0;
            //                }
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        AddTimer = 0;
            //    }
            //    if (Convert.ToInt32(DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString()) == Convert.ToInt32(frmsyStemSet.comboBox2.Text + "00"))
            //    {
            //        frmMonitor.hu = false;
            //        frmMonitor.btnRecording_Click(null, null);
            //        AddTimer = 0;
            //    }

            //}

            #endregion




        }

    }
}
