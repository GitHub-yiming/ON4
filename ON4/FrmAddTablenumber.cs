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
using DAL;

namespace ON4
{
    public partial class FrmAddTablenumber : Form
    {
        Calorimeter1Entities1 db1 = new Calorimeter1Entities1();
        Data1 data1 = new Data1();
        public FrmAddTablenumber()
        {
            InitializeComponent();
        }

        private void FrmAddTablenumber_Load(object sender, EventArgs e)
        {
            tableNumbers1BindingSource.DataSource = db1.Table_Numbers1.ToList();
        }

        /// <summary>
        /// 表号录入-添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmHeat_meter_entry frm = new frmHeat_meter_entry(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    tableNumbers1BindingSource.DataSource = db1.Table_Numbers1.ToList();
                }
            }
        }
        /// <summary>
        /// 表号录入-编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tableNumbers1BindingSource.Current == null)
                return;
            using (frmHeat_meter_entry frm = new frmHeat_meter_entry(tableNumbers1BindingSource.Current as Table_Numbers1))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    tableNumbers1BindingSource.DataSource = db1.Table_Numbers1.ToList();
                }
            }
        }
        /// <summary>
        /// 表号录入-删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tableNumbers1BindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db1.Table_Numbers1.Remove(tableNumbers1BindingSource.Current as Table_Numbers1);
                    tableNumbers1BindingSource.RemoveCurrent();
                    db1.SaveChanges();
                }
            }
        }

        /// <summary>
        /// 添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

        /// <summary>
        /// 表号录入-表号过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTablenumber_Click(object sender, EventArgs e)
        {
            if (txtTablenumber.Text.Trim().Length != 0)
            {
                var result = from p in db1.Table_Numbers1

                             where p.Table_Number1 == txtTablenumber.Text.Trim()

                             select p;

                tableNumbers1BindingSource.DataSource = result.ToList();
                tableNumbers1BindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// 表号录入-楼层过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLay_Click(object sender, EventArgs e)
        {
            if (cboLay.Text.Trim().Length != 0)
            {
                int aa = Convert.ToInt32(cboLay.Text.Trim());
                var result = from p in db1.Table_Numbers1

                             where p.NumberofLayersId == aa

                             select p;

                tableNumbers1BindingSource.DataSource = result.ToList();
                tableNumbers1BindingSource.ResetBindings(false);
            }
        }


        //导出excel
        private void uiButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                data1.DataGridviewShowToExcel(dgvScoreList, true, 0);
            })
            { IsBackground = true };
            thread.Start();
        }

        //刷新表
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tableNumbers1BindingSource.DataSource = db1.Table_Numbers1.ToList();
        }

        //新导出按钮
        private void uiButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FilterIndex = 1;
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;
            saveFile.Filter = ".xls|.xls";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                NPOIExcelHelper.DataGridViewToExcel(dgvScoreList, "测试", saveFile.FileName);
            }
            saveFile.Dispose();
        }
    }
}

