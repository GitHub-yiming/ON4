using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ON4
{
    /// <summary>
    /// 用户缴费
    /// </summary>
    public partial class FrmUserPpayment : Form
    {
        Calorimeter1Entities3 db = new Calorimeter1Entities3();
        Data1 data1 = new Data1();
        public FrmUserPpayment()
        {
            InitializeComponent();
        }

        private void FrmUserPpayment_Load(object sender, EventArgs e)
        {
            userpayment1BindingSource.DataSource = db.User_payment1.ToList();
        }

        /// <summary>
        /// 用户缴费-添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (User_payment frm = new User_payment(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    userpayment1BindingSource.DataSource = db.User_payment1.ToList();   
                }
            }

        }

        /// <summary>
        /// 用户缴费-编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (userpayment1BindingSource.Current == null)
                return;
            using (User_payment frm = new User_payment(userpayment1BindingSource.Current as User_payment1,0))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    userpayment1BindingSource.DataSource = db.User_payment1.ToList();
                }
            }
        }

        /// <summary>
        /// 用户缴费-删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userpayment1BindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.User_payment1.Remove(userpayment1BindingSource.Current as User_payment1);
                    userpayment1BindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// 添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.uiDataGridView1, e);
        }

        //导出excel
        private void uiButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                data1.DataGridviewShowToExcel(uiDataGridView1, true, 0);
            })
            { IsBackground = true };
            thread.Start();
        }


        /// <summary>
        /// 缴费--表号过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotRed_Click(object sender, EventArgs e)
        {
            if (txtTablenumber.Text.Trim().Length != 0)
            {
                var result = from p in db.User_payment1

                             where p.Table_number == txtTablenumber.Text.Trim()

                             select p;

                userpayment1BindingSource.DataSource = result.ToList();
                userpayment1BindingSource.ResetBindings(false);
            }
        }


        /// <summary>
        /// 缴费--姓名过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnName_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length != 0)
            {
                var result = from p in db.User_payment1

                             where p.Names == txtName.Text.Trim()

                             select p;

                userpayment1BindingSource.DataSource = result.ToList();
                userpayment1BindingSource.ResetBindings(false);
            }
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FilterIndex = 1;
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;
            saveFile.Filter = ".xls|.xls";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                NPOIExcelHelper.DataGridViewToExcel(uiDataGridView1, "测试", saveFile.FileName);
            }
            saveFile.Dispose();
        }
    }
    }
