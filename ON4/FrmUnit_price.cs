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

namespace ON4
{
    public partial class FrmUnit_price : Form
    {
        DAL.User__balances objuser_Balancess = new DAL.User__balances();
        public FrmUnit_price()
        { 
            InitializeComponent();

                }

        private void unit_pricessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unit_pricessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calorimeter1DataSet2);

        }

        private void FrmUnit_price_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet4.Unit_pricess”中。您可以根据需要移动或删除它。
            this.unit_pricessTableAdapter1.Fill(this.calorimeter1DataSet4.Unit_pricess);
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet2.Unit_pricess”中。您可以根据需要移动或删除它。
            this.unit_pricessTableAdapter.Fill(this.calorimeter1DataSet2.Unit_pricess);

        }

        /// <summary>
        /// 修改单价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Unit_prices objuser_Balances = new Unit_prices()
            {
                Calories = Convert.ToDecimal(this.caloriesTextBox.Text.Trim()),
                Cooling_capacity = Convert.ToDecimal(cooling_capacityTextBox.Text.Trim())
            };
            try
            {
                objuser_Balancess.ModifyStudent(objuser_Balances);
                MessageBox.Show("保存成功！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示信息");
            }
        }

        private void caloriesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(null, null);
            }
        }
    }
}
