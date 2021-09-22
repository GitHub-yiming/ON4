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
    public partial class SystemSet : Form
    {
        FrmMonitor frmMonitor = new FrmMonitor();
        public SystemSet()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

                frmMonitor.btnClear.Enabled = true;

        }
    }
}
