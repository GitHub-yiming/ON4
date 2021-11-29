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
    /// 用户信息录入与表号
    /// </summary>
    public partial class FrmUserEntry_and_TableNumber : Form
    {
        User_dataService objUser_dataService = new User_dataService();
        NumberofLayerService objNumber = new NumberofLayerService();
        Calorimeter1Entities db = new Calorimeter1Entities();
        List<User_data> user_Datas = new List<User_data>();
        Data1 data1 = new Data1();
        public FrmUserEntry_and_TableNumber()
        {
            InitializeComponent();
            //初始化楼层下拉框
            this.cboLay.DataSource = objNumber.GetAllClass();
            this.cboLay.DisplayMember = "NumberofLayersId";//设置下拉框显示文本
            this.cboLay.ValueMember = "NumberofLayersId";//设置下拉框显示文本对应的Value
            this.cboLay.SelectedIndex = -1;//默认不选中任何
            //禁止表格自动生成列
            this.dgvScoreList.AutoGenerateColumns = false;


        }
        #region 遗弃程序
        ///// <summary>
        ///// 录入用户信息
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnInput_Click(object sender, EventArgs e)
        //{
        //    if (txtTableNumber.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("表号不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if (txtName.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("姓名不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    if (rdoMale.Checked = false && rdoFemale.Checked == false)
        //    {
        //        MessageBox.Show("性别不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    if(this.cboFloor.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("楼层不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    //从数据库中判断表号是否存在
        //    if (objUser_dataService.IsIdNoExisted(this.txtTableNumber.Text.Trim()))
        //    {
        //        MessageBox.Show("当前表号已存在！", "提示信息");
        //        this.txtTableNumber.SelectAll();
        //        this.txtTableNumber.Focus();
        //        return;
        //    }

        //    //从数据库中判断手机号是否存在
        //    if (objUser_dataService.IsCardNoExisted(this.txtPhone.Text.Trim()))
        //    {
        //        MessageBox.Show("当前手机号已存在！", "提示信息");
        //        this.txtPhone.SelectAll();
        //        this.txtPhone.Focus();
        //        return;
        //    }

        //    //判断输入的表号是否录入
        //    if (!objUser_dataService.IsTableNumber(this.txtTableNumber.Text.Trim()))
        //    {
        //        MessageBox.Show("当前表号未录入！", "提示信息");
        //        this.txtRoomNumber.SelectAll();
        //        this.txtTableNumber.Focus();
        //        return;
        //    }

        //    //封装用户对象
        //    User_data objUser_data = new User_data()
        //    {
        //        Table_number = this.txtTableNumber.Text.Trim(),
        //        Names = this.txtName.Text.Trim(),
        //        Gender = this.rdoMale.Checked ? "男" : "女",
        //        Phone = this.txtPhone.Text.Trim(),
        //        NumberofLayersId=Convert.ToInt32(this. cboFloor.SelectedValue),
        //        NumberofLayer = cboFloor.Text,
        //        Room_No = txtRoomNumber.Text.Trim(),
        //        Building=txtBuilding.Text.Trim()
        //    };

        //    try
        //    {
        //        int studentId = objUser_dataService.AddUser(objUser_data);
        //        this.stuList.Add(objUser_data);
        //        this.dgvScoreList.DataSource = null;
        //        this.dgvScoreList.DataSource = this.stuList;
        //        //询问是否继续添加
        //        DialogResult result = MessageBox.Show("新学员添加成功！是否继续添加？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //            if (result == DialogResult.Yes)
        //            {
        //                //清空用户输入的信息
        //                foreach (Control item in this.gbstuinfo.Controls)
        //                {
        //                    if (item is TextBox)
        //                    {
        //                        item.Text = "";
        //                    }
        //                    else if (item is RadioButton)
        //                    {
        //                        ((RadioButton)item).Checked = false;
        //                    }
        //                }
        //                this.cboFloor.SelectedIndex = -1;
        //                //this.rdoMale.Checked = false;
        //                //this.rdoFemale.Checked = false;
        //                this.txtTableNumber.Focus();
        //            }
        //            else
        //            {
        //                this.Close();
        //            }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
        #endregion

        /// <summary>
        /// 添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(dgvScoreList, e);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (forUser_Info frm = new forUser_Info(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    userdata1BindingSource.DataSource = db.User_data1.ToList();
                }
            }
        }

        private void FrmUserEntry_and_TableNumber_Load(object sender, EventArgs e)
        {
            userdata1BindingSource.DataSource = db.User_data1.ToList();
        }



        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (userdata1BindingSource.Current == null)
                return;
            using (forUser_Info frm = new forUser_Info(userdata1BindingSource.Current as User_data1))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //userdata1BindingSource.DataSource = db.User_data1.ToList();
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
            if (userdata1BindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.User_data1.Remove(userdata1BindingSource.Current as User_data1);
                    userdata1BindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// 添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

        ///// <summary>
        ///// 根据楼层动态筛选
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void cboLay_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    user_Datas = objUser_dataService.GetStudentByClass(cboLay.Text);
        //    //if (ds == null) return;//目前不会出现(以后工作中要考虑这个问题)
        //    //this.ds.Tables[0].DefaultView.RowFilter = string.Format("NumberofLayersId='{0}'", this.cboLay.Text.Trim());
            
        //}

        /// <summary>
        /// 用户录入-表号过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotRed_Click(object sender, EventArgs e)
        {
            if (txtTablenumber.Text.Trim().Length != 0)
            {
            var result = from p in db.User_data1

                         where p.Table_number == txtTablenumber.Text.Trim()

                         select p;

            userdata1BindingSource.DataSource = result.ToList();
            userdata1BindingSource.ResetBindings(false);
            }


        }

        /// <summary>
        /// 用户录入-楼层过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLay_Click(object sender, EventArgs e)
        {
            if (cboLay.Text.Trim().Length != 0)
            {
                int aa = Convert.ToInt32(cboLay.Text.Trim());
                var result = from p in db.User_data1

                             where p.NumberofLayersId == aa

                             select p;

                userdata1BindingSource.DataSource = result.ToList();
                userdata1BindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// 用户录入-刷新表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            userdata1BindingSource.DataSource = db.User_data1.ToList();
        }

        /// <summary>
        /// 用户录入-姓名过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnName_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length != 0)
            {
                var result = from p in db.User_data1

                             where p.Names == txtName.Text.Trim()

                             select p;

                userdata1BindingSource.DataSource = result.ToList();
                userdata1BindingSource.ResetBindings(false);
            }
        }
        //失效
        private void uiButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                data1.DataGridviewShowToExcel(dgvScoreList, true, 0);
            })
            { IsBackground = true };
            thread.Start();
        }

        //导出EXCEL
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
