
namespace ON4
{
    partial class FrmUserPpayment
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
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnAdd = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.txtTablenumber = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnPotRed = new Sunny.UI.UIButton();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.txtName = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btnName = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.tablenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpayment1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpayment1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            this.uiDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataGridView1.AutoGenerateColumns = false;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tablenumberDataGridViewTextBoxColumn,
            this.Names,
            this.costDataGridViewTextBoxColumn,
            this.CreateTime});
            this.uiDataGridView1.DataSource = this.userpayment1BindingSource;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(0, 63);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(1588, 656);
            this.uiDataGridView1.TabIndex = 0;
            this.uiDataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.uiDataGridView1_RowPostPaint);
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Names";
            this.Names.HeaderText = "姓名";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 125;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CrateTime";
            this.CreateTime.HeaderText = "时间";
            this.CreateTime.MinimumWidth = 6;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::ON4.Properties.Settings.Default, "启用缴费删除", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnDelete.Enabled = global::ON4.Properties.Settings.Default.启用缴费删除;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDelete.Location = new System.Drawing.Point(250, 12);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::ON4.Properties.Settings.Default, "启用缴费编辑", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnEdit.Enabled = global::ON4.Properties.Settings.Default.启用缴费编辑;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnEdit.Location = new System.Drawing.Point(131, 12);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Radius = 20;
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 7;
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
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.uiButton1.TabIndex = 6;
            this.uiButton1.Text = "导出";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click_1);
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
            this.txtTablenumber.TabIndex = 15;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(604, 17);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(132, 23);
            this.uiLabel2.TabIndex = 13;
            this.uiLabel2.Text = "表号：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPotRed
            // 
            this.btnPotRed.BackColor = System.Drawing.Color.Transparent;
            this.btnPotRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotRed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPotRed.Location = new System.Drawing.Point(790, 12);
            this.btnPotRed.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPotRed.Name = "btnPotRed";
            this.btnPotRed.Radius = 20;
            this.btnPotRed.Size = new System.Drawing.Size(100, 35);
            this.btnPotRed.TabIndex = 18;
            this.btnPotRed.Text = "过滤";
            this.btnPotRed.Click += new System.EventHandler(this.btnPotRed_Click);
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
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "刷新表";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtName.Location = new System.Drawing.Point(971, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.MaxLength = 8;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(63, 1);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 20;
            this.txtName.Size = new System.Drawing.Size(117, 34);
            this.txtName.TabIndex = 23;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(913, 17);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(132, 23);
            this.uiLabel3.TabIndex = 21;
            this.uiLabel3.Text = "姓名：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Transparent;
            this.btnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnName.Location = new System.Drawing.Point(1095, 12);
            this.btnName.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnName.Name = "btnName";
            this.btnName.Radius = 20;
            this.btnName.Size = new System.Drawing.Size(100, 35);
            this.btnName.TabIndex = 24;
            this.btnName.Text = "过滤";
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Enabled = false;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(1267, 17);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 20;
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 6;
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
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "缴费";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // userpayment1BindingSource
            // 
            this.userpayment1BindingSource.DataSource = typeof(ON4.User_payment1);
            // 
            // FrmUserPpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1594, 715);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtTablenumber);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btnPotRed);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.uiLabel3);
            this.Name = "FrmUserPpayment";
            this.Text = "缴费";
            this.Load += new System.EventHandler(this.FrmUserPpayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpayment1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.BindingSource userpayment1BindingSource;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox txtTablenumber;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnPotRed;
        private Sunny.UI.UIButton btnRefresh;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton btnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private Sunny.UI.UIButton uiButton2;
    }
}