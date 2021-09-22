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

namespace ON4
{
    public partial class forUser_Info : Form
    {
        User_dataService objUser_dataService = new User_dataService();
        Calorimeter1Entities db;
        bool mode = false;
        public forUser_Info(User_data1 obj)
        {
            InitializeComponent();
            db = new Calorimeter1Entities();
            if (obj == null)
            {
                userdata1BindingSource.DataSource = new User_data1();
                db.User_data1.Add(userdata1BindingSource.Current as User_data1);
                mode = true;
            }
            else
            {
                userdata1BindingSource.DataSource = obj;
                db.User_data1.Attach(userdata1BindingSource.Current as User_data1);
            }
        }

        private void forUser_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("请输入表号！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                if (objUser_dataService.IsTableNumber(textBox1.Text.Trim()))
                {
                    MessageBox.Show("输入的表号在数据库中找不到!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                if (objUser_dataService.NotUserRepeat(textBox1.Text.Trim()))
                {
                    MessageBox.Show("用户已存在！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                if (dateTimePicker1.Text==" ")
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

        /// <summary>
        /// 查找楼层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 8)
            {
                label9.Text = objUser_dataService.QueryFloor(textBox1.Text);
                label9.Visible = true;
            }

        }

        private void forUser_Info_Load(object sender, EventArgs e)
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
    }
}
