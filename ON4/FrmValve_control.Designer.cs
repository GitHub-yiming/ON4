
namespace ON4
{
    partial class FrmValve_control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiGroupBox7 = new Sunny.UI.UIGroupBox();
            this.cboPot2 = new Sunny.UI.UIComboBox();
            this.cboBri2 = new Sunny.UI.UIComboBox();
            this.cboChe2 = new Sunny.UI.UIComboBox();
            this.cboData2 = new Sunny.UI.UIComboBox();
            this.cboStop2 = new Sunny.UI.UIComboBox();
            this.btnPotConn1 = new Sunny.UI.UIButton();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnRefresh = new Sunny.UI.UIButton();
            this.btn = new Sunny.UI.UIButton();
            this.uiGroupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox7
            // 
            this.uiGroupBox7.Controls.Add(this.cboPot2);
            this.uiGroupBox7.Controls.Add(this.cboBri2);
            this.uiGroupBox7.Controls.Add(this.cboChe2);
            this.uiGroupBox7.Controls.Add(this.cboData2);
            this.uiGroupBox7.Controls.Add(this.cboStop2);
            this.uiGroupBox7.Controls.Add(this.btnPotConn1);
            this.uiGroupBox7.Controls.Add(this.uiLabel14);
            this.uiGroupBox7.Controls.Add(this.uiLabel8);
            this.uiGroupBox7.Controls.Add(this.uiLabel12);
            this.uiGroupBox7.Controls.Add(this.uiLabel9);
            this.uiGroupBox7.Controls.Add(this.uiLabel10);
            this.uiGroupBox7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox7.Location = new System.Drawing.Point(13, 14);
            this.uiGroupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox7.Name = "uiGroupBox7";
            this.uiGroupBox7.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox7.Radius = 20;
            this.uiGroupBox7.Size = new System.Drawing.Size(1121, 112);
            this.uiGroupBox7.TabIndex = 1;
            this.uiGroupBox7.Text = "设置";
            // 
            // cboPot2
            // 
            this.cboPot2.FillColor = System.Drawing.Color.White;
            this.cboPot2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboPot2.Location = new System.Drawing.Point(66, 45);
            this.cboPot2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPot2.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboPot2.Name = "cboPot2";
            this.cboPot2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboPot2.Radius = 20;
            this.cboPot2.Size = new System.Drawing.Size(117, 34);
            this.cboPot2.TabIndex = 15;
            this.cboPot2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBri2
            // 
            this.cboBri2.FillColor = System.Drawing.Color.White;
            this.cboBri2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboBri2.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "115200"});
            this.cboBri2.Location = new System.Drawing.Point(269, 45);
            this.cboBri2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBri2.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboBri2.Name = "cboBri2";
            this.cboBri2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboBri2.Radius = 20;
            this.cboBri2.Size = new System.Drawing.Size(106, 34);
            this.cboBri2.TabIndex = 14;
            this.cboBri2.Text = "2400";
            this.cboBri2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboChe2
            // 
            this.cboChe2.FillColor = System.Drawing.Color.White;
            this.cboChe2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboChe2.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cboChe2.Location = new System.Drawing.Point(470, 45);
            this.cboChe2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboChe2.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboChe2.Name = "cboChe2";
            this.cboChe2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboChe2.Radius = 20;
            this.cboChe2.Size = new System.Drawing.Size(106, 34);
            this.cboChe2.TabIndex = 13;
            this.cboChe2.Text = "Even";
            this.cboChe2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboData2
            // 
            this.cboData2.FillColor = System.Drawing.Color.White;
            this.cboData2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboData2.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cboData2.Location = new System.Drawing.Point(675, 45);
            this.cboData2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboData2.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboData2.Name = "cboData2";
            this.cboData2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboData2.Radius = 20;
            this.cboData2.Size = new System.Drawing.Size(106, 34);
            this.cboData2.TabIndex = 12;
            this.cboData2.Text = "8";
            this.cboData2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStop2
            // 
            this.cboStop2.FillColor = System.Drawing.Color.White;
            this.cboStop2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboStop2.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive"});
            this.cboStop2.Location = new System.Drawing.Point(877, 45);
            this.cboStop2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStop2.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboStop2.Name = "cboStop2";
            this.cboStop2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboStop2.Radius = 20;
            this.cboStop2.Size = new System.Drawing.Size(106, 34);
            this.cboStop2.TabIndex = 11;
            this.cboStop2.Text = "One";
            this.cboStop2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPotConn1
            // 
            this.btnPotConn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotConn1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPotConn1.Location = new System.Drawing.Point(990, 45);
            this.btnPotConn1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPotConn1.Name = "btnPotConn1";
            this.btnPotConn1.Radius = 20;
            this.btnPotConn1.Size = new System.Drawing.Size(100, 35);
            this.btnPotConn1.TabIndex = 10;
            this.btnPotConn1.Text = "连接";
            this.btnPotConn1.Click += new System.EventHandler(this.btnPotConn2_Click);
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel14.Location = new System.Drawing.Point(8, 49);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(73, 23);
            this.uiLabel14.TabIndex = 8;
            this.uiLabel14.Text = "串口：";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(594, 49);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(106, 23);
            this.uiLabel8.TabIndex = 5;
            this.uiLabel8.Text = "数据位：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.Location = new System.Drawing.Point(192, 49);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(95, 23);
            this.uiLabel12.TabIndex = 7;
            this.uiLabel12.Text = "波特率：";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(391, 49);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(96, 23);
            this.uiLabel9.TabIndex = 6;
            this.uiLabel9.Text = "校验位：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(795, 49);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(115, 23);
            this.uiLabel10.TabIndex = 4;
            this.uiLabel10.Text = "停止位：";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM29";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(12, 134);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Radius = 20;
            this.btnRefresh.Size = new System.Drawing.Size(111, 111);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "串口刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn
            // 
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn.Location = new System.Drawing.Point(176, 186);
            this.btn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn.Name = "btn";
            this.btn.Radius = 20;
            this.btn.Size = new System.Drawing.Size(100, 35);
            this.btn.TabIndex = 10;
            this.btn.Text = "连接";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // FrmValve_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1151, 625);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.uiGroupBox7);
            this.Controls.Add(this.btn);
            this.Name = "FrmValve_control";
            this.Text = "阀门控制";
            this.Load += new System.EventHandler(this.FrmValve_control_Load);
            this.uiGroupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox7;
        private Sunny.UI.UIComboBox cboPot2;
        private Sunny.UI.UIComboBox cboBri2;
        private Sunny.UI.UIComboBox cboChe2;
        private Sunny.UI.UIComboBox cboData2;
        private Sunny.UI.UIComboBox cboStop2;
        private Sunny.UI.UIButton btnPotConn1;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIButton btnRefresh;
        public System.IO.Ports.SerialPort serialPort1;
        private Sunny.UI.UIButton btn;
    }
}