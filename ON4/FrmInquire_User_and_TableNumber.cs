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
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet5.AdvancedView”中。您可以根据需要移动或删除它。
            this.advancedViewTableAdapter.Fill(this.calorimeter1DataSet5.AdvancedView);
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet1.CalorimeterTable1”中。您可以根据需要移动或删除它。
            this.calorimeterTable1TableAdapter.Fill(this.calorimeter1DataSet1.CalorimeterTable1);
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet1.CalorimeterTable1”中。您可以根据需要移动或删除它。
            this.calorimeterTable1TableAdapter.Fill(this.calorimeter1DataSet1.CalorimeterTable1);

        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.advancedViewBindingSource.Sort = this.advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.advancedViewBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }

        private void userdata1BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            label1.Text = string.Format("Total rows: {0}", this.advancedViewBindingSource.List.Count);
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
