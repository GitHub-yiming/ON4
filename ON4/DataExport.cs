using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ON4
{
    public class DataExport
    {
        public bool Export(DataGridView dgv)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Worksheet workSheet = excelApp.Workbooks.Add().Worksheets[1];

            workSheet.Cells[2, 2] = "456789";
            workSheet.Cells[2, 2].RowHeight = 25;
            Microsoft.Office.Interop.Excel.Range range = workSheet.get_Range("B2", "H2");
            range.Merge(0);
            range.Borders.Value = 1;
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            range.Font.Size = 15;

            int columCount = dgv.ColumnCount;
            int rowCount = dgv.RowCount;

            for(int i = 0; i < columCount; i++)
            {
                workSheet.Cells[3, i + 2] = dgv.Columns[i].HeaderText;
                workSheet.Cells[3, i + 2].Borders.Value = 1;
                workSheet.Cells[3, i + 2].RowHeight = 23;
            }

            for(int i = 0; i < rowCount - 1; i++)
            {
                for (int n = 0; n < columCount; n++)
                {
                    workSheet.Cells[i + 4, n + 2] = dgv.Rows[i + 1].Cells[n].Value;
                    workSheet.Cells[i + 4, n + 2].Borders.Value = 1;
                    workSheet.Cells[i + 4, n + 2].RowHeight = 23;
                }
            }

            workSheet.Columns.AutoFit();

            excelApp.Visible = true;
            excelApp.Sheets.PrintPreview();

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            excelApp = null;
            return true;

        }
    }
}
