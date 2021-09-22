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
    public partial class frmHeat_meter_entry : Form
    {
        User_dataService objUser_dataService = new User_dataService();
        Calorimeter1Entities1 db1;
        public frmHeat_meter_entry(Table_Numbers1 obj)
        {
            InitializeComponent();
            db1 = new Calorimeter1Entities1();
            if (obj == null)
            {
                tableNumbers1BindingSource.DataSource = new Table_Numbers1();
                db1.Table_Numbers1.Add(tableNumbers1BindingSource.Current as Table_Numbers1);
            }
            else
            {
                tableNumbers1BindingSource.DataSource = obj;
                db1.Table_Numbers1.Attach(tableNumbers1BindingSource.Current as Table_Numbers1);
            }
        }

        private void frmHeat_meter_entry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox1.Text)||string.IsNullOrEmpty(txtControlAddress.Text)/* || objUser_dataService.IsTableNumber(textBox1.Text.Trim())*/)
                {
                    MessageBox.Show("表号为空\t或者表号重复\t或者未选中楼层！\n请检查！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                db1.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
