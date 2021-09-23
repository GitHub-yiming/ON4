
namespace ON4
{
    partial class FrmInquire_User_and_TableNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.calorimeterTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calorimeter1DataSet1 = new ON4.Calorimeter1DataSet1();
            this.calorimeterTable1TableAdapter = new ON4.Calorimeter1DataSet1TableAdapters.CalorimeterTable1TableAdapter();
            this.advancedViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calorimeter1DataSet5 = new ON4.Calorimeter1DataSet5();
            this.advancedViewTableAdapter = new ON4.Calorimeter1DataSet5TableAdapters.AdvancedViewTableAdapter();
            this.tablenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coolingcapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage_Cooling_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cooling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Cooling_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage_Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeterTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.advancedDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tablenumberDataGridViewTextBoxColumn,
            this.Names,
            this.Room_No,
            this.Building,
            this.coolingcapacityDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn,
            this.Dosage_Cooling_capacity,
            this.Cooling_price,
            this.Cost_Cooling_capacity,
            this.Dosage_Calories,
            this.Calories_price,
            this.Cost_Calories,
            this.Total_cost,
            this.createTimeDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.advancedViewBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(2, 70);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 27;
            this.advancedDataGridView1.Size = new System.Drawing.Size(1452, 662);
            this.advancedDataGridView1.TabIndex = 2;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.advancedDataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.advancedDataGridView1_RowPostPaint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "&导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "&刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calorimeterTable1BindingSource
            // 
            this.calorimeterTable1BindingSource.DataMember = "CalorimeterTable1";
            this.calorimeterTable1BindingSource.DataSource = this.calorimeter1DataSet1;
            this.calorimeterTable1BindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.userdata1BindingSource_ListChanged);
            // 
            // calorimeter1DataSet1
            // 
            this.calorimeter1DataSet1.DataSetName = "Calorimeter1DataSet1";
            this.calorimeter1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calorimeterTable1TableAdapter
            // 
            this.calorimeterTable1TableAdapter.ClearBeforeFill = true;
            // 
            // advancedViewBindingSource
            // 
            this.advancedViewBindingSource.DataMember = "AdvancedView";
            this.advancedViewBindingSource.DataSource = this.calorimeter1DataSet5;
            // 
            // calorimeter1DataSet5
            // 
            this.calorimeter1DataSet5.DataSetName = "Calorimeter1DataSet5";
            this.calorimeter1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advancedViewTableAdapter
            // 
            this.advancedViewTableAdapter.ClearBeforeFill = true;
            // 
            // tablenumberDataGridViewTextBoxColumn
            // 
            this.tablenumberDataGridViewTextBoxColumn.DataPropertyName = "Table_number";
            this.tablenumberDataGridViewTextBoxColumn.HeaderText = "表号";
            this.tablenumberDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tablenumberDataGridViewTextBoxColumn.Name = "tablenumberDataGridViewTextBoxColumn";
            this.tablenumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tablenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Names";
            this.Names.HeaderText = "姓名";
            this.Names.MinimumWidth = 22;
            this.Names.Name = "Names";
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Names.Width = 125;
            // 
            // Room_No
            // 
            this.Room_No.DataPropertyName = "Room_No";
            this.Room_No.HeaderText = "房号";
            this.Room_No.MinimumWidth = 22;
            this.Room_No.Name = "Room_No";
            this.Room_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Room_No.Width = 125;
            // 
            // Building
            // 
            this.Building.DataPropertyName = "Building";
            this.Building.HeaderText = "楼栋";
            this.Building.MinimumWidth = 22;
            this.Building.Name = "Building";
            this.Building.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Building.Width = 125;
            // 
            // coolingcapacityDataGridViewTextBoxColumn
            // 
            this.coolingcapacityDataGridViewTextBoxColumn.DataPropertyName = "Cooling_capacity";
            this.coolingcapacityDataGridViewTextBoxColumn.HeaderText = "总冷量Kwh";
            this.coolingcapacityDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.coolingcapacityDataGridViewTextBoxColumn.Name = "coolingcapacityDataGridViewTextBoxColumn";
            this.coolingcapacityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.coolingcapacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories";
            this.caloriesDataGridViewTextBoxColumn.HeaderText = "总热量Kwh";
            this.caloriesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            this.caloriesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.caloriesDataGridViewTextBoxColumn.Width = 125;
            // 
            // Dosage_Cooling_capacity
            // 
            this.Dosage_Cooling_capacity.DataPropertyName = "Dosage_Cooling_capacity";
            this.Dosage_Cooling_capacity.HeaderText = "使用冷量";
            this.Dosage_Cooling_capacity.MinimumWidth = 22;
            this.Dosage_Cooling_capacity.Name = "Dosage_Cooling_capacity";
            this.Dosage_Cooling_capacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Dosage_Cooling_capacity.Width = 125;
            // 
            // Cooling_price
            // 
            this.Cooling_price.DataPropertyName = "Cooling_price";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Cooling_price.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cooling_price.HeaderText = "冷量单价";
            this.Cooling_price.MinimumWidth = 22;
            this.Cooling_price.Name = "Cooling_price";
            this.Cooling_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Cooling_price.Width = 80;
            // 
            // Cost_Cooling_capacity
            // 
            this.Cost_Cooling_capacity.DataPropertyName = "Cost_Cooling_capacity";
            this.Cost_Cooling_capacity.HeaderText = "冷量费用";
            this.Cost_Cooling_capacity.MinimumWidth = 22;
            this.Cost_Cooling_capacity.Name = "Cost_Cooling_capacity";
            this.Cost_Cooling_capacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Cost_Cooling_capacity.Width = 125;
            // 
            // Dosage_Calories
            // 
            this.Dosage_Calories.DataPropertyName = "Dosage_Calories";
            this.Dosage_Calories.HeaderText = "使用热量";
            this.Dosage_Calories.MinimumWidth = 22;
            this.Dosage_Calories.Name = "Dosage_Calories";
            this.Dosage_Calories.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Dosage_Calories.Width = 125;
            // 
            // Calories_price
            // 
            this.Calories_price.DataPropertyName = "Calories_price";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.Calories_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Calories_price.HeaderText = "热量单价";
            this.Calories_price.MinimumWidth = 22;
            this.Calories_price.Name = "Calories_price";
            this.Calories_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Calories_price.Width = 80;
            // 
            // Cost_Calories
            // 
            this.Cost_Calories.DataPropertyName = "Cost_Calories";
            this.Cost_Calories.HeaderText = "热量费用";
            this.Cost_Calories.MinimumWidth = 22;
            this.Cost_Calories.Name = "Cost_Calories";
            this.Cost_Calories.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Cost_Calories.Width = 125;
            // 
            // Total_cost
            // 
            this.Total_cost.DataPropertyName = "Total_cost";
            this.Total_cost.HeaderText = "合计";
            this.Total_cost.MinimumWidth = 22;
            this.Total_cost.Name = "Total_cost";
            this.Total_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Total_cost.Width = 125;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "记录时间";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.createTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmInquire_User_and_TableNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1456, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmInquire_User_and_TableNumber";
            this.Text = "用户与表号查询";
            this.Load += new System.EventHandler(this.FrmInquire_User_and_TableNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeterTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private Calorimeter1DataSet1 calorimeter1DataSet1;
        private System.Windows.Forms.BindingSource calorimeterTable1BindingSource;
        private Calorimeter1DataSet1TableAdapters.CalorimeterTable1TableAdapter calorimeterTable1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Calorimeter1DataSet5 calorimeter1DataSet5;
        private System.Windows.Forms.BindingSource advancedViewBindingSource;
        private Calorimeter1DataSet5TableAdapters.AdvancedViewTableAdapter advancedViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewTextBoxColumn coolingcapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage_Cooling_capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cooling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Cooling_capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage_Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
    }
}