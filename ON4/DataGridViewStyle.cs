using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ON4
{
    public class DataGridViewStyle
    {

        /// <summary>
        /// 给DataGridView添加行号
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        public static void DgvRowPostPaint(DataGridView dgv, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                //添加行号
                SolidBrush v_SolidBrush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor);
                int v_LineNo = 0;
                v_LineNo = e.RowIndex + 1;
                string v_Line = v_LineNo.ToString();
                e.Graphics.DrawString(v_Line, e.InheritedRowStyle.Font, v_SolidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);

            }
            catch (Exception ex)
            {

                MessageBox.Show("添加行号时发生错误，错误信息:" + ex.Message, "操作失败");
            }
        }

    }
}
