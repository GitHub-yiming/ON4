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
using Modles;

namespace ON4
{
    /// <summary>
    /// 费用查询
    /// </summary>
    public partial class FrmTotalExpenses : Form
    {
        User_dataService user_DataService = new User_dataService();
        Calorimeter1Entities4 db = new Calorimeter1Entities4();
        Data1 data1 = new Data1();
        public FrmTotalExpenses()
        {
            InitializeComponent();
        }

        private void FrmTotalExpenses_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet3.View_user_balance”中。您可以根据需要移动或删除它。
            //this.view_user_balanceTableAdapter.Fill(this.calorimeter1DataSet3.View_user_balance);
            //this.dgvScoreList.DataSource = user_DataService.QueryScoreList(dpTimer1.Value, dpTimer2.Value);
            userbalanceBindingSource.DataSource = db.User_balance.ToList();
        }

        /// <summary>
        /// 费用查询-刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnRefresh_Click(object sender, EventArgs e)
        {
            Calorimeter1Entities4 db = new Calorimeter1Entities4();
            userbalanceBindingSource.DataSource = db.User_balance.ToList();
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
        /// 统一修改额度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnified_modification_Click(object sender, EventArgs e)
        {
            Calorimeter1Entities4 db = new Calorimeter1Entities4();
            int Quota = Convert.ToInt32(txtQuota.Text.Trim());
            user_DataService.ModifyStudent2(Quota);
            userbalanceBindingSource.DataSource = db.User_balance.ToList();
        }

        /// <summary>
        /// 修改额度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_quota_Click(object sender, EventArgs e)
        {
            if (userbalanceBindingSource.Current == null)
                return;
            using (FrmModify_quota frm = new FrmModify_quota(userbalanceBindingSource.Current as User_balance))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Calorimeter1Entities4 db = new Calorimeter1Entities4();
                    userbalanceBindingSource.DataSource = db.User_balance.ToList();
                }
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userbalanceBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.User_balance.Remove(userbalanceBindingSource.Current as User_balance);
                    userbalanceBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                data1.DataGridviewShowToExcel(dgvScoreList, true, 0);
            })
            { IsBackground = true };
            thread.Start();
        }

        /// <summary>
        /// 费用统计--表号过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTablenumber_Click(object sender, EventArgs e)
        {
            if (txtTablenumber.Text.Trim().Length != 0)
            {
                var result = from p in db.User_balance

                             where p.Table_number == txtTablenumber.Text.Trim()

                             select p;

                userbalanceBindingSource.DataSource = result.ToList();
                userbalanceBindingSource.ResetBindings(false);
            }

        }

        /// <summary>
        /// 费用统计--楼层过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLay_Click(object sender, EventArgs e)
        {
            if (cboLay.Text.Trim().Length != 0)
            {
                int aa = Convert.ToInt32(cboLay.Text.Trim());
                var result = from p in db.User_balance

                             where p.NumberofLayersId == aa

                             select p;

                userbalanceBindingSource.DataSource = result.ToList();
                userbalanceBindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// 费用统计--姓名过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnName_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length != 0)
            {
                var result = from p in db.User_balance

                             where p.Names == txtName.Text.Trim()

                             select p;

                userbalanceBindingSource.DataSource = result.ToList();
                userbalanceBindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// 费用统计--编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (userbalanceBindingSource.Current == null)
                return;
            using (ForTotalExpenses_info frm = new ForTotalExpenses_info(userbalanceBindingSource.Current as User_balance))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //userdata1BindingSource.DataSource = db.User_data1.ToList();
                }
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
                NPOIExcelHelper.DataGridViewToExcel(dgvScoreList, "测试", saveFile.FileName);
            }
            saveFile.Dispose();
        }
    }
}

