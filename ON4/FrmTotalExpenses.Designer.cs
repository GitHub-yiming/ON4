
namespace ON4
{
    partial class FrmTotalExpenses
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
            this.Quota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberofLayersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.btnModify_quota = new Sunny.UI.UIButton();
            this.btnUnified_modification = new Sunny.UI.UIButton();
            this.txtQuota = new Sunny.UI.UITextBox();
            this.btnDelete = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.cboLay = new Sunny.UI.UIComboBox();
            this.txtName = new Sunny.UI.UITextBox();
            this.txtTablenumber = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnName = new Sunny.UI.UIButton();
            this.btnLay = new Sunny.UI.UIButton();
            this.btnTablenumber = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.viewuserbalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calorimeter1DataSet3 = new ON4.Calorimeter1DataSet3();
            this.view_user_balanceTableAdapter = new ON4.Calorimeter1DataSet3TableAdapters.View_user_balanceTableAdapter();
            this.tablenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userbalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewuserbalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbalanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToDeleteRows = false;
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
            this.balanceDataGridViewTextBoxColumn,
            this.Quota,
            this.roomNoDataGridViewTextBoxColumn,
            this.NumberofLayersId});
            this.dgvScoreList.DataSource = this.userbalanceBindingSource;
            this.dgvScoreList.EnableHeadersVisualStyles = false;
            this.dgvScoreList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvScoreList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvScoreList.Location = new System.Drawing.Point(6, 53);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvScoreList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScoreList.RowTemplate.Height = 29;
            this.dgvScoreList.SelectedIndex = -1;
            this.dgvScoreList.ShowGridLine = true;
            this.dgvScoreList.Size = new System.Drawing.Size(1726, 627);
            this.dgvScoreList.TabIndex = 0;
            this.dgvScoreList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvScoreList_RowPostPaint);
            // 
            // Quota
            // 
            this.Quota.DataPropertyName = "Quota";
            this.Quota.HeaderText = "额度";
            this.Quota.MinimumWidth = 6;
            this.Quota.Name = "Quota";
            this.Quota.ReadOnly = true;
            this.Quota.Width = 125;
            // 
            // NumberofLayersId
            // 
            this.NumberofLayersId.DataPropertyName = "NumberofLayersId";
            this.NumberofLayersId.HeaderText = "楼层";
            this.NumberofLayersId.MinimumWidth = 6;
            this.NumberofLayersId.Name = "NumberofLayersId";
            this.NumberofLayersId.ReadOnly = true;
            this.NumberofLayersId.Width = 125;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(6, 12);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Radius = 20;
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnModify_quota
            // 
            this.btnModify_quota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify_quota.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnModify_quota.Location = new System.Drawing.Point(326, 12);
            this.btnModify_quota.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnModify_quota.Name = "btnModify_quota";
            this.btnModify_quota.Radius = 20;
            this.btnModify_quota.Size = new System.Drawing.Size(100, 35);
            this.btnModify_quota.TabIndex = 6;
            this.btnModify_quota.Text = "修改额度";
            this.btnModify_quota.Click += new System.EventHandler(this.btnModify_quota_Click);
            // 
            // btnUnified_modification
            // 
            this.btnUnified_modification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnified_modification.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUnified_modification.Location = new System.Drawing.Point(663, 12);
            this.btnUnified_modification.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUnified_modification.Name = "btnUnified_modification";
            this.btnUnified_modification.Radius = 20;
            this.btnUnified_modification.Size = new System.Drawing.Size(100, 35);
            this.btnUnified_modification.TabIndex = 6;
            this.btnUnified_modification.Text = "统一修改";
            this.btnUnified_modification.Click += new System.EventHandler(this.btnUnified_modification_Click);
            // 
            // txtQuota
            // 
            this.txtQuota.BackColor = System.Drawing.Color.Transparent;
            this.txtQuota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuota.FillColor = System.Drawing.Color.White;
            this.txtQuota.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtQuota.Location = new System.Drawing.Point(539, 13);
            this.txtQuota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuota.Maximum = 2147483647D;
            this.txtQuota.MaxLength = 8;
            this.txtQuota.Minimum = -2147483648D;
            this.txtQuota.MinimumSize = new System.Drawing.Size(63, 1);
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.Padding = new System.Windows.Forms.Padding(5);
            this.txtQuota.Radius = 20;
            this.txtQuota.Size = new System.Drawing.Size(117, 34);
            this.txtQuota.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::ON4.Properties.Settings.Default, "启用费用统计删除", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnDelete.Enabled = global::ON4.Properties.Settings.Default.启用费用统计删除;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDelete.Location = new System.Drawing.Point(112, 12);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(432, 12);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 20;
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 6;
            this.uiButton1.Text = "导出";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click_1);
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
            this.cboLay.Location = new System.Drawing.Point(1133, 14);
            this.cboLay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLay.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboLay.Name = "cboLay";
            this.cboLay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboLay.Radius = 20;
            this.cboLay.Size = new System.Drawing.Size(91, 34);
            this.cboLay.TabIndex = 25;
            this.cboLay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtName.Location = new System.Drawing.Point(1421, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.MaxLength = 8;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(63, 1);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 20;
            this.txtName.Size = new System.Drawing.Size(117, 34);
            this.txtName.TabIndex = 20;
            // 
            // txtTablenumber
            // 
            this.txtTablenumber.BackColor = System.Drawing.Color.Transparent;
            this.txtTablenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTablenumber.FillColor = System.Drawing.Color.White;
            this.txtTablenumber.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtTablenumber.Location = new System.Drawing.Point(829, 14);
            this.txtTablenumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTablenumber.Maximum = 2147483647D;
            this.txtTablenumber.MaxLength = 8;
            this.txtTablenumber.Minimum = -2147483648D;
            this.txtTablenumber.MinimumSize = new System.Drawing.Size(63, 1);
            this.txtTablenumber.Name = "txtTablenumber";
            this.txtTablenumber.Padding = new System.Windows.Forms.Padding(5);
            this.txtTablenumber.Radius = 20;
            this.txtTablenumber.Size = new System.Drawing.Size(117, 34);
            this.txtTablenumber.TabIndex = 21;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(1363, 19);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(132, 23);
            this.uiLabel3.TabIndex = 17;
            this.uiLabel3.Text = "姓名：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(1072, 19);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(132, 23);
            this.uiLabel1.TabIndex = 18;
            this.uiLabel1.Text = "楼层：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(771, 19);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(132, 23);
            this.uiLabel2.TabIndex = 19;
            this.uiLabel2.Text = "表号：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Transparent;
            this.btnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnName.Location = new System.Drawing.Point(1545, 14);
            this.btnName.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnName.Name = "btnName";
            this.btnName.Radius = 20;
            this.btnName.Size = new System.Drawing.Size(100, 35);
            this.btnName.TabIndex = 22;
            this.btnName.Text = "过滤";
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnLay
            // 
            this.btnLay.BackColor = System.Drawing.Color.Transparent;
            this.btnLay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLay.Location = new System.Drawing.Point(1242, 14);
            this.btnLay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLay.Name = "btnLay";
            this.btnLay.Radius = 20;
            this.btnLay.Size = new System.Drawing.Size(100, 35);
            this.btnLay.TabIndex = 23;
            this.btnLay.Text = "过滤";
            this.btnLay.Click += new System.EventHandler(this.btnLay_Click);
            // 
            // btnTablenumber
            // 
            this.btnTablenumber.BackColor = System.Drawing.Color.Transparent;
            this.btnTablenumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablenumber.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnTablenumber.Location = new System.Drawing.Point(957, 14);
            this.btnTablenumber.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTablenumber.Name = "btnTablenumber";
            this.btnTablenumber.Radius = 20;
            this.btnTablenumber.Size = new System.Drawing.Size(100, 35);
            this.btnTablenumber.TabIndex = 24;
            this.btnTablenumber.Text = "过滤";
            this.btnTablenumber.Click += new System.EventHandler(this.btnTablenumber_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::ON4.Properties.Settings.Default, "启用费用统计编辑", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnEdit.Enabled = global::ON4.Properties.Settings.Default.启用费用统计编辑;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnEdit.Location = new System.Drawing.Point(218, 12);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Radius = 20;
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Enabled = false;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(1662, 12);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 20;
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 6;
            this.uiButton2.Text = "导出";
            this.uiButton2.Visible = false;
            this.uiButton2.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // viewuserbalanceBindingSource
            // 
            this.viewuserbalanceBindingSource.DataMember = "View_user_balance";
            this.viewuserbalanceBindingSource.DataSource = this.calorimeter1DataSet3;
            // 
            // calorimeter1DataSet3
            // 
            this.calorimeter1DataSet3.DataSetName = "Calorimeter1DataSet3";
            this.calorimeter1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_user_balanceTableAdapter
            // 
            this.view_user_balanceTableAdapter.ClearBeforeFill = true;
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
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "余额";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn.Width = 125;
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
            // userbalanceBindingSource
            // 
            this.userbalanceBindingSource.DataSource = typeof(ON4.User_balance);
            // 
            // FrmTotalExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1744, 692);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cboLay);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTablenumber);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnLay);
            this.Controls.Add(this.btnTablenumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtQuota);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.btnUnified_modification);
            this.Controls.Add(this.btnModify_quota);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvScoreList);
            this.Name = "FrmTotalExpenses";
            this.Text = "费用统计";
            this.Load += new System.EventHandler(this.FrmTotalExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewuserbalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbalanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Sunny.UI.UIDataGridView dgvScoreList;
        private Calorimeter1DataSet3 calorimeter1DataSet3;
        private System.Windows.Forms.BindingSource viewuserbalanceBindingSource;
        private Calorimeter1DataSet3TableAdapters.View_user_balanceTableAdapter view_user_balanceTableAdapter;
        private System.Windows.Forms.BindingSource userbalanceBindingSource;
        private Sunny.UI.UIButton btnModify_quota;
        private Sunny.UI.UIButton btnUnified_modification;
        private Sunny.UI.UITextBox txtQuota;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton uiButton1;
        public Sunny.UI.UIButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quota;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberofLayersId;
        private Sunny.UI.UIComboBox cboLay;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UITextBox txtTablenumber;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnName;
        private Sunny.UI.UIButton btnLay;
        private Sunny.UI.UIButton btnTablenumber;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton uiButton2;
    }
}