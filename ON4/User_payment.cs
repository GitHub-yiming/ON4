using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Modles;
using ON4.Properties;

namespace ON4
{
    public partial class User_payment : Form
    {
        Calorimeter1Entities3 db = new Calorimeter1Entities3();
        SQLHelper sQLHelper = new SQLHelper();
        User_dataService objuser_DataService = new User_dataService();
        FrmTotalExpenses frmTotalExpenses = new FrmTotalExpenses();
        User_dataService objUser_dataService = new User_dataService();
        FrmMonitor frmMonitor = new FrmMonitor();
        bool mode = false;
        
        public User_payment(User_payment1 obj )
        {
            InitializeComponent();
            button2.Enabled = false;
            button1.Enabled = true;
            if (obj == null)
            {
                mode = true;
                userpayment1BindingSource.DataSource = new User_payment1();
                db.User_payment1.Add(userpayment1BindingSource.Current as User_payment1);
            }
            else
            {
                userpayment1BindingSource.DataSource = obj;
                db.User_payment1.Attach(userpayment1BindingSource.Current as User_payment1);
            }
        }
        public User_payment(User_payment1 obj,int i)
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = true;
            if (obj == null)
            {
                userpayment1BindingSource.DataSource = new User_payment1();
                db.User_payment1.Add(userpayment1BindingSource.Current as User_payment1);
            }
            else
            {
                userpayment1BindingSource.DataSource = obj;
                db.User_payment1.Attach(userpayment1BindingSource.Current as User_payment1);
            }
        }


        private void User_payment_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text.Trim())||string.IsNullOrEmpty(textBox3.Text.Trim()))
                {
                    MessageBox.Show("信息未输入完整！  请检查后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                if(textBox1.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("表号输入错误！ 请检查表号！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Focus();
                        e.Cancel = true;
                        return;
                    }
                    if (objUser_dataService.IsTableNumber(textBox1.Text.Trim()))
                    {
                        MessageBox.Show("输入的表号在数据库中找不到\t", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Focus();
                        e.Cancel = true;
                        return;
                    }
                    if (dateTimePicker1.Text == " ")
                    {
                        MessageBox.Show("请选择日期！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                        return;
                    }
                    db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void User_payment_Load(object sender, EventArgs e)
        {
            if (mode)
            {
                InitDateTimePicker(dateTimePicker1);
            }

        }

        #region  日期控件初始为空值处理

        /// <summary>
        /// 初始化日期时间控件
        /// </summary>
        /// <param name="dtp"></param>
        public static void InitDateTimePicker(DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = " ";  //必须设置成" "
            dtp.ValueChanged -= DateTimePicker_ValueChanged;
            dtp.ValueChanged += DateTimePicker_ValueChanged;
            dtp.KeyPress -= DateTimePicker_KeyPress;
            dtp.KeyPress += DateTimePicker_KeyPress;
        }

        public static void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.Format = DateTimePickerFormat.Long;
            dtp.CustomFormat = null; //null;
            dtp.Checked = false;// 解决BUG ：防止日期控件不能选择相同日期的 --- 要放置在设置格式之后
        }

        public static void DateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)  // backspace左删除键
            {
                DateTimePicker dtp = (DateTimePicker)sender;
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = " ";
            }
        }
        #endregion

        /// <summary>
        /// 添加缴费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //User_balances objuser_Balances = new User_balances()
                //{
                //    Table_number = this.textBox1.Text.Trim().ToString(),
                //    Balance = Convert.ToDecimal(textBox3.Text.Trim())
                //};
                //objuser_DataService.ModifyStudent(objuser_Balances);

                if (Settings.Default.启用继电器控制)
                {
                    if (objUser_dataService.Quota_calculation(textBox1.Text.Trim()) == "信用正常")
                    {
                        frmMonitor.ValveControl(textBox1.Text.Trim(), 0);//打开阀门
                    }
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "提示信息");
            }

        }



        /// <summary>
        /// 修改缴费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //User_balances objuser_Balances = new User_balances()
            //{
            //    Table_number = this.textBox1.Text.Trim().ToString(),
            //    Balance = Convert.ToDecimal(textBox3.Text.Trim())
            //};
            try
            {
                if (Settings.Default.启用继电器控制)
                {
                    if (objUser_dataService.Quota_calculation(textBox1.Text.Trim()) == "信用正常")
                    {
                        frmMonitor.ValveControl(textBox1.Text.Trim(), 0);//打开阀门
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示信息");
            }
            frmTotalExpenses.btnRefresh_Click(null, null);
        }

    }
}
