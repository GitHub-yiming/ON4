
namespace ON4
{
    partial class FrmAddTablenumber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvScoreList = new Sunny.UI.UIDataGridView();
            this.txtTablenumber = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnTablenumber = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnAdd = new Sunny.UI.UIButton();
            this.cboLay = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnLay = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.tableNumbers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port_diection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNumbers1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToAddRows = false;
            this.dgvScoreList.AllowUserToDeleteRows = false;
            this.dgvScoreList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvScoreList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScoreList.AutoGenerateColumns = false;
            this.dgvScoreList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvScoreList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScoreList.ColumnHeadersHeight = 32;
            this.dgvScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ControlAddress,
            this.Port_diection});
            this.dgvScoreList.DataSource = this.tableNumbers1BindingSource;
            this.dgvScoreList.EnableHeadersVisualStyles = false;
            this.dgvScoreList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvScoreList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvScoreList.Location = new System.Drawing.Point(0, 52);
            this.dgvScoreList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            this.dgvScoreList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvScoreList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScoreList.RowTemplate.Height = 29;
            this.dgvScoreList.SelectedIndex = -1;
            this.dgvScoreList.ShowGridLine = true;
            this.dgvScoreList.Size = new System.Drawing.Size(1456, 689);
            this.dgvScoreList.TabIndex = 2;
            this.dgvScoreList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvScoreList_RowPostPaint);
            // 
            // txtTablenumber
            // 
            this.txtTablenumber.BackColor = System.Drawing.Color.Transparent;
            this.txtTablenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTablenumber.FillColor = System.Drawing.Color.White;
            this.txtTablenumber.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtTablenumber.Location = new System.Drawing.Point(676, 13);
            this.txtTablenumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTablenumber.Maximum = 2147483647D;
            this.txtTablenumber.MaxLength = 8;
            this.txtTablenumber.Minimum = -2147483648D;
            this.txtTablenumber.MinimumSize = new System.Drawing.Size(63, 1);
            this.txtTablenumber.Name = "txtTablenumber";
            this.txtTablenumber.Padding = new System.Windows.Forms.Padding(5);
            this.txtTablenumber.Radius = 20;
            this.txtTablenumber.Size = new System.Drawing.Size(117, 34);
            this.txtTablenumber.TabIndex = 14;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(619, 15);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(132, 30);
            this.uiLabel2.TabIndex = 13;
            this.uiLabel2.Text = "表号：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTablenumber
            // 
            this.btnTablenumber.BackColor = System.Drawing.Color.Transparent;
            this.btnTablenumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablenumber.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnTablenumber.Location = new System.Drawing.Point(804, 13);
            this.btnTablenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTablenumber.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTablenumber.Name = "btnTablenumber";
            this.btnTablenumber.Radius = 20;
            this.btnTablenumber.Size = new System.Drawing.Size(100, 35);
            this.btnTablenumber.TabIndex = 15;
            this.btnTablenumber.Text = "过滤";
            this.btnTablenumber.Click += new System.EventHandler(this.btnTablenumber_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDelete.Location = new System.Drawing.Point(254, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnEdit.Location = new System.Drawing.Point(133, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Radius = 20;
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboLay
            // 
            this.cboLay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboLay.FillColor = System.Drawing.Color.White;
            this.cboLay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboLay.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.cboLay.Location = new System.Drawing.Point(1011, 13);
            this.cboLay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLay.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboLay.Name = "cboLay";
            this.cboLay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboLay.Radius = 20;
            this.cboLay.Size = new System.Drawing.Size(91, 34);
            this.cboLay.TabIndex = 18;
            this.cboLay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(949, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(132, 28);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "楼层：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLay
            // 
            this.btnLay.BackColor = System.Drawing.Color.Transparent;
            this.btnLay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLay.Location = new System.Drawing.Point(1120, 13);
            this.btnLay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLay.Name = "btnLay";
            this.btnLay.Radius = 20;
            this.btnLay.Size = new System.Drawing.Size(100, 35);
            this.btnLay.TabIndex = 17;
            this.btnLay.Text = "过滤";
            this.btnLay.Click += new System.EventHandler(this.btnLay_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(496, 12);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 20;
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 17;
            this.uiButton1.Text = "导出";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(375, 12);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Radius = 20;
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "刷新表";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableNumbers1BindingSource
            // 
            this.tableNumbers1BindingSource.DataSource = typeof(ON4.Table_Numbers1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Table_Number1";
            this.dataGridViewTextBoxColumn1.HeaderText = "表号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumberofLayersId";
            this.dataGridViewTextBoxColumn2.HeaderText = "楼层";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // ControlAddress
            // 
            this.ControlAddress.DataPropertyName = "ControlAddress";
            this.ControlAddress.HeaderText = "继电器地址";
            this.ControlAddress.MinimumWidth = 6;
            this.ControlAddress.Name = "ControlAddress";
            this.ControlAddress.ReadOnly = true;
            this.ControlAddress.Width = 125;
            // 
            // Port_diection
            // 
            this.Port_diection.DataPropertyName = "Port_diection";
            this.Port_diection.HeaderText = "端口";
            this.Port_diection.MinimumWidth = 6;
            this.Port_diection.Name = "Port_diection";
            this.Port_diection.ReadOnly = true;
            this.Port_diection.Width = 125;
            // 
            // FrmAddTablenumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1456, 744);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cboLay);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.btnLay);
            this.Controls.Add(this.txtTablenumber);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btnTablenumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvScoreList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAddTablenumber";
            this.Text = "录入表号";
            this.Load += new System.EventHandler(this.FrmAddTablenumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNumbers1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvScoreList;
        private Sunny.UI.UITextBox txtTablenumber;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnTablenumber;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnAdd;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tableNumber1DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn numberofLayersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableNumbers1BindingSource;
        private Sunny.UI.UIComboBox cboLay;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnLay;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_diection;
    }
}