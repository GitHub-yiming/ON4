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
    public partial class FrmModify_quota : Form
    {
        Calorimeter1Entities4 db = new Calorimeter1Entities4();
        public FrmModify_quota(User_balance obj)
        {
            InitializeComponent();
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

        private void FrmModify_quota_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox1.Text.Trim()))
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
