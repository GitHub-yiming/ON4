using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ON4
{
    public partial class Batchimport : Form
    {
        DataSet ds;
        System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xlsx" };
        public Batchimport()
        {

            InitializeComponent();
        }

        public void TransferData(string excelFile, string sheetName, string connectionString)
        {
            try
            {
                //如果目标表不存在则创建
                string strSql = string.Format("if object_id('{0}') is null create table {0}(", sheetName);

                foreach (System.Data.DataColumn c in ds.Tables[0].Columns)
                {
                    strSql += string.Format("[{0}] varchar(255),", c.ColumnName);
                }
                strSql = strSql.Trim(',') + ");";

                if (comboBox1.Text == "用户信息")
                {
                    strSql += string.Format(" truncate table [{0}] ", sheetName);
                }



                using (System.Data.SqlClient.SqlConnection sqlconn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    System.Data.SqlClient.SqlCommand command = sqlconn.CreateCommand();
                    command.CommandText = strSql;
                    command.ExecuteNonQuery();
                    sqlconn.Close();
                }
                //用bcp导入数据
                using (System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(connectionString, SqlBulkCopyOptions.FireTriggers))
                {
                    bcp.SqlRowsCopied += new System.Data.SqlClient.SqlRowsCopiedEventHandler(bcp_SqlRowsCopied);
                    bcp.BatchSize = 100;//每次传输的行数
                    progressBar1.Value = 0;
                    progressBar1.Value=bcp.NotifyAfter = 100;//进度提示的行数
                    switch (comboBox1.Text)
                    {
                        case "用户信息":
                            bcp.DestinationTableName = "User_data1";//目标表
                            break;
                        case "表号信息":
                            bcp.DestinationTableName = "Table_NumberTest";//目标表
                            break;
                    }

                    bcp.WriteToServer(ds.Tables[0]);
                }

            }
            catch (Exception ex)
            {
                fd.Dispose();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void OpenFile(string excelFile, string sheetName)
        {
            ds = new DataSet();
            try
            {
                //获取全部数据
                string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + excelFile + ";" + "Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                strExcel = string.Format("select * from [{0}$]", sheetName);
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds, sheetName);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                fd.Dispose();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// 打开EXCEL表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            if (comboBox1.Text != "")
            {
            if (fd.ShowDialog() == DialogResult.OK)
            {
                switch (comboBox1.Text)
                {
                    case "用户信息":
                        OpenFile(fd.FileName, "User_data1");
                        break;
                    case "表号信息":
                        OpenFile(fd.FileName, "Table_NumberTest");
                        break;
                }
            }

            fd.Dispose();
            }
            else
            {
                MessageBox.Show("请选择需要打开的表格！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            }
            catch (Exception ex)
            {
                fd.Dispose();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



        }

        //进度显示
        void bcp_SqlRowsCopied(object sender, System.Data.SqlClient.SqlRowsCopiedEventArgs e)
        {
            this.Text = e.RowsCopied.ToString();
            this.Update();
        }

        /// <summary>
        /// 导入数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

            try
            {
            if (comboBox1.Text != "")
            {
            switch (comboBox1.Text)
            {
                case "用户信息":
                    TransferData(fd.FileName, "User_data1", connString);
                    break;
                case "表号信息":
                    TransferData(fd.FileName, "Table_NumberTest", connString);
                    break;
            }
            }
            else
            {
                MessageBox.Show("请选择需要打开的表格！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// 添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridView1, e);
        }
    }
}
