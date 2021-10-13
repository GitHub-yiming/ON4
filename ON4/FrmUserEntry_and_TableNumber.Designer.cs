
namespace ON4
{
    partial class FrmUserEntry_and_TableNumber
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
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnAdd = new Sunny.UI.UIButton();
            this.dgvScoreList = new Sunny.UI.UIDataGridView();
            this.txtTablenumber = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnTablenumber = new Sunny.UI.UIButton();
            this.cboLay = new Sunny.UI.UIComboBox();
            this.btnLay = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.btnName = new Sunny.UI.UIButton();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.tablenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofLayersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billabletimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdata1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdata1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDelete.Location = new System.Drawing.Point(250, 12);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnEdit.Location = new System.Drawing.Point(131, 12);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Radius = 20;
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvScoreList
            // 
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
            this.tablenumberDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.buildingDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.numberofLayersIdDataGridViewTextBoxColumn,
            this.billabletimeDataGridViewTextBoxColumn});
            this.dgvScoreList.DataSource = this.userdata1BindingSource;
            this.dgvScoreList.EnableHeadersVisualStyles = false;
            this.dgvScoreList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvScoreList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvScoreList.Location = new System.Drawing.Point(0, 53);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvScoreList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScoreList.RowTemplate.Height = 29;
            this.dgvScoreList.SelectedIndex = -1;
            this.dgvScoreList.ShowGridLine = true;
            this.dgvScoreList.Size = new System.Drawing.Size(1571, 691);
            this.dgvScoreList.TabIndex = 1;
            this.dgvScoreList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvScoreList_RowPostPaint_1);
            // 
            // txtTablenumber
            // 
            this.txtTablenumber.BackColor = System.Drawing.Color.Transparent;
            this.txtTablenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTablenumber.FillColor = System.Drawing.Color.White;
            this.txtTablenumber.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtTablenumber.Location = new System.Drawing.Point(662, 12);
            this.txtTablenumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTablenumber.Maximum = 2147483647D;
            this.txtTablenumber.MaxLength = 8;
            this.txtTablenumber.Minimum = -2147483648D;
            this.txtTablenumber.MinimumSize = new System.Drawing.Size(63, 1);
            this.txtTablenumber.Name = "txtTablenumber";
            this.txtTablenumber.Padding = new System.Windows.Forms.Padding(5);
            this.txtTablenumber.Radius = 20;
            this.txtTablenumber.Size = new System.Drawing.Size(117, 34);
            this.txtTablenumber.TabIndex = 8;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(604, 17);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(132, 23);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "表号：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTablenumber
            // 
            this.btnTablenumber.BackColor = System.Drawing.Color.Transparent;
            this.btnTablenumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablenumber.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnTablenumber.Location = new System.Drawing.Point(790, 12);
            this.btnTablenumber.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTablenumber.Name = "btnTablenumber";
            this.btnTablenumber.Radius = 20;
            this.btnTablenumber.Size = new System.Drawing.Size(100, 35);
            this.btnTablenumber.TabIndex = 9;
            this.btnTablenumber.Text = "过滤";
            this.btnTablenumber.Click += new System.EventHandler(this.btnPotRed_Click);
            // 
            // cboLay
            // 
            this.cboLay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboLay.FillColor = System.Drawing.Color.White;
            this.cboLay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboLay.Location = new System.Drawing.Point(966, 12);
            this.cboLay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLay.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboLay.Name = "cboLay";
            this.cboLay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboLay.Radius = 20;
            this.cboLay.Size = new System.Drawing.Size(91, 34);
            this.cboLay.TabIndex = 10;
            this.cboLay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLay
            // 
            this.btnLay.BackColor = System.Drawing.Color.Transparent;
            this.btnLay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLay.Location = new System.Drawing.Point(1075, 12);
            this.btnLay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLay.Name = "btnLay";
            this.btnLay.Radius = 20;
            this.btnLay.Size = new System.Drawing.Size(100, 35);
            this.btnLay.TabIndex = 9;
            this.btnLay.Text = "过滤";
            this.btnLay.Click += new System.EventHandler(this.btnLay_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(905, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(132, 23);
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = "楼层：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(1196, 17);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(132, 23);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "姓名：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtName.Location = new System.Drawing.Point(1254, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.MaxLength = 8;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(63, 1);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 20;
            this.txtName.Size = new System.Drawing.Size(117, 34);
            this.txtName.TabIndex = 8;
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Transparent;
            this.btnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnName.Location = new System.Drawing.Point(1378, 12);
            this.btnName.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnName.Name = "btnName";
            this.btnName.Radius = 20;
            this.btnName.Size = new System.Drawing.Size(100, 35);
            this.btnName.TabIndex = 9;
            this.btnName.Text = "过滤";
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(369, 12);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Radius = 20;
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "刷新表";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(488, 12);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 20;
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 11;
            this.uiButton1.Text = "导出";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click_1);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Enabled = false;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(1494, 11);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 20;
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 11;
            this.uiButton2.Text = "导出";
            this.uiButton2.Visible = false;
            this.uiButton2.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // tablenumberDataGridViewTextBoxColumn
            // 
            this.tablenumberDataGridViewTextBoxColumn.DataPropertyName = "Table_number";
            this.tablenumberDataGridViewTextBoxColumn.HeaderText = "表号";
            this.tablenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tablenumberDataGridViewTextBoxColumn.Name = "tablenumberDataGridViewTextBoxColumn";
            this.tablenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.tablenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.namesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            this.namesDataGridViewTextBoxColumn.ReadOnly = true;
            this.namesDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "性别";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "Room_No";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "房号";
            this.roomNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildingDataGridViewTextBoxColumn
            // 
            this.buildingDataGridViewTextBoxColumn.DataPropertyName = "Building";
            this.buildingDataGridViewTextBoxColumn.HeaderText = "楼栋";
            this.buildingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingDataGridViewTextBoxColumn.Name = "buildingDataGridViewTextBoxColumn";
            this.buildingDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildingDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "手机";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofLayersIdDataGridViewTextBoxColumn
            // 
            this.numberofLayersIdDataGridViewTextBoxColumn.DataPropertyName = "NumberofLayersId";
            this.numberofLayersIdDataGridViewTextBoxColumn.HeaderText = "楼层";
            this.numberofLayersIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofLayersIdDataGridViewTextBoxColumn.Name = "numberofLayersIdDataGridViewTextBoxColumn";
            this.numberofLayersIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberofLayersIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // billabletimeDataGridViewTextBoxColumn
            // 
            this.billabletimeDataGridViewTextBoxColumn.DataPropertyName = "Billabletime";
            this.billabletimeDataGridViewTextBoxColumn.HeaderText = "计费时间";
            this.billabletimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billabletimeDataGridViewTextBoxColumn.Name = "billabletimeDataGridViewTextBoxColumn";
            this.billabletimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.billabletimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userdata1BindingSource
            // 
            this.userdata1BindingSource.DataSource = typeof(ON4.User_data1);
            // 
            // FrmUserEntry_and_TableNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1571, 744);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.cboLay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTablenumber);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnLay);
            this.Controls.Add(this.btnTablenumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvScoreList);
            this.Name = "FrmUserEntry_and_TableNumber";
            this.Text = "用户信息录入";
            this.Load += new System.EventHandler(this.FrmUserEntry_and_TableNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdata1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIDataGridView dgvScoreList;
        private System.Windows.Forms.BindingSource userdata1BindingSource;
        private Sunny.UI.UITextBox txtTablenumber;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnTablenumber;
        private Sunny.UI.UIComboBox cboLay;
        private Sunny.UI.UIButton btnLay;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UIButton btnName;
        private Sunny.UI.UIButton btnRefresh;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofLayersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billabletimeDataGridViewTextBoxColumn;
        private Sunny.UI.UIButton uiButton2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tablenumberDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn numberofLayersIdDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn billabletimeDataGridViewTextBoxColumn;
    }
}