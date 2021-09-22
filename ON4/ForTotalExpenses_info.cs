using DAL;
using Modles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ON4
{
    public partial class ForTotalExpenses_info : Form
    {
        User_dataService objUser_dataService = new User_dataService();
        Calorimeter1Entities4 db;
        public ForTotalExpenses_info(User_balance obj)
        {
            InitializeComponent();
            db = new Calorimeter1Entities4();
            if (obj == null)
            {
                userbalanceBindingSource.DataSource = new User_balance();
                db.User_balance.Add(userbalanceBindingSource.Current as User_balance);
            }
            else
            {
                userbalanceBindingSource.DataSource = obj;
                db.User_balance.Attach(userbalanceBindingSource.Current as User_balance);
            }
        }

        private void ForTotalExpenses_info_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“calorimeter1DataSet6.User_balance”中。您可以根据需要移动或删除它。
            this.user_balanceTableAdapter.Fill(this.calorimeter1DataSet6.User_balance);

        }

        private void ForTotalExpenses_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox1.Text)/*|| objUser_dataService.IsTableNumber(textBox1.Text.Trim())*/)
                {
                    MessageBox.Show("输入的表号在数据库中找不到\t或者表号已存在！请检查后重试！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
