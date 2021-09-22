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
    /// 用户与表号查询
    /// </summary>
    public partial class FrmInquire_User_and_TableNumber : Form
    {
        Data1 data1 = new Data1();
        public FrmInquire_User_and_TableNumber()
        {

            InitializeComponent();
        }

        private void FrmInquire_User_and_TableNumber_Load(object sender, EventArgs e)
        {
            //修改表格标题颜色
            advancedDataGridView1.EnableHeadersVisualStyles = false;//修改为可设置颜色
            advancedDataGridView1.Columns["Cooling_price"].HeaderCell.Style.BackColor = Color.Lime;
            advancedDataGridView1.Columns["Calories_price"].HeaderCell.Style.BackColor = Color.Lime;
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet5.AdvancedView”中。您可以根据需要移动或删除它。
            this.advancedViewTableAdapter.Fill(this.calorimeter1DataSet5.AdvancedView);
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet1.CalorimeterTable1”中。您可以根据需要移动或删除它。
            this.calorimeterTable1TableAdapter.Fill(this.calorimeter1DataSet1.CalorimeterTable1);
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet1.CalorimeterTable1”中。您可以根据需要移动或删除它。
            this.calorimeterTable1TableAdapter.Fill(this.calorimeter1DataSet1.CalorimeterTable1);
            Cost();

        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.advancedViewBindingSource.Sort = this.advancedDataGridView1.SortString;
            Cost();
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.advancedViewBindingSource.Filter = this.advancedDataGridView1.FilterString;
            Cost();
        }

        public void Cost()
        {
            decimal Total_cost = 0;
            for (int i = 0; i < advancedDataGridView1.Rows.Count; i++)
            {
                Total_cost += Convert.ToDecimal(advancedDataGridView1.Rows[i].Cells["Total_cost"].Value);
            }
            advancedDataGridView1.Columns["Total_cost"].HeaderText = "合计：" + Convert.ToString(Total_cost);
        }

        private void userdata1BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            label1.Text = string.Format("行数: {0}", this.advancedViewBindingSource.List.Count);
        }

        //添加行号
        private void advancedDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.advancedDataGridView1, e);
        }

        //导出excel
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                data1.DataGridviewShowToExcel(advancedDataGridView1, true, 0);
            })
            { IsBackground = true };
            thread.Start();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet5.AdvancedView”中。您可以根据需要移动或删除它。
            this.advancedViewTableAdapter.Fill(this.calorimeter1DataSet5.AdvancedView);

            label1.Text = string.Format("Total rows: {0}", this.advancedViewBindingSource.List.Count);
        }
    }
}
