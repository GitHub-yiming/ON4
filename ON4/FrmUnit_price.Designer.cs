
namespace ON4
{
    partial class FrmUnit_price
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.button1 = new System.Windows.Forms.Button();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.unit_pricessBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calorimeter1DataSet4 = new ON4.Calorimeter1DataSet4();
            this.cooling_capacityTextBox = new System.Windows.Forms.TextBox();
            this.unit_pricessTableAdapter1 = new ON4.Calorimeter1DataSet4TableAdapters.Unit_pricessTableAdapter();
            this.tableAdapterManager1 = new ON4.Calorimeter1DataSet4TableAdapters.TableAdapterManager();
            this.unit_pricessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calorimeter1DataSet2 = new ON4.Calorimeter1DataSet2();
            this.unit_pricessTableAdapter = new ON4.Calorimeter1DataSet2TableAdapters.Unit_pricessTableAdapter();
            this.tableAdapterManager = new ON4.Calorimeter1DataSet2TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.unit_pricessBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_pricessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(28, 29);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(132, 23);
            this.uiLabel2.TabIndex = 19;
            this.uiLabel2.Text = "热量：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(28, 100);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(132, 23);
            this.uiLabel1.TabIndex = 19;
            this.uiLabel1.Text = "冷量：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::ON4.Properties.Settings.Default, "允许修改额度", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.Enabled = global::ON4.Properties.Settings.Default.允许修改额度;
            this.button1.Location = new System.Drawing.Point(247, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(196, 102);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(132, 23);
            this.uiLabel3.TabIndex = 19;
            this.uiLabel3.Text = "KW/元";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(196, 31);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(132, 23);
            this.uiLabel4.TabIndex = 19;
            this.uiLabel4.Text = "KW/元";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unit_pricessBindingSource1, "Calories", true));
            this.caloriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::ON4.Properties.Settings.Default, "允许修改额度", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.caloriesTextBox.Enabled = global::ON4.Properties.Settings.Default.允许修改额度;
            this.caloriesTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.caloriesTextBox.Location = new System.Drawing.Point(90, 28);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(100, 30);
            this.caloriesTextBox.TabIndex = 26;
            this.caloriesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caloriesTextBox_KeyPress);
            // 
            // unit_pricessBindingSource1
            // 
            this.unit_pricessBindingSource1.DataMember = "Unit_pricess";
            this.unit_pricessBindingSource1.DataSource = this.calorimeter1DataSet4;
            // 
            // calorimeter1DataSet4
            // 
            this.calorimeter1DataSet4.DataSetName = "Calorimeter1DataSet4";
            this.calorimeter1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cooling_capacityTextBox
            // 
            this.cooling_capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unit_pricessBindingSource1, "Cooling_capacity", true));
            this.cooling_capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::ON4.Properties.Settings.Default, "允许修改额度", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cooling_capacityTextBox.Enabled = global::ON4.Properties.Settings.Default.允许修改额度;
            this.cooling_capacityTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.cooling_capacityTextBox.Location = new System.Drawing.Point(90, 99);
            this.cooling_capacityTextBox.Name = "cooling_capacityTextBox";
            this.cooling_capacityTextBox.Size = new System.Drawing.Size(100, 30);
            this.cooling_capacityTextBox.TabIndex = 27;
            this.cooling_capacityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caloriesTextBox_KeyPress);
            // 
            // unit_pricessTableAdapter1
            // 
            this.unit_pricessTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Unit_pricessTableAdapter = this.unit_pricessTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ON4.Calorimeter1DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // unit_pricessBindingSource
            // 
            this.unit_pricessBindingSource.DataMember = "Unit_pricess";
            this.unit_pricessBindingSource.DataSource = this.calorimeter1DataSet2;
            // 
            // calorimeter1DataSet2
            // 
            this.calorimeter1DataSet2.DataSetName = "Calorimeter1DataSet2";
            this.calorimeter1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unit_pricessTableAdapter
            // 
            this.unit_pricessTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Unit_pricessTableAdapter = this.unit_pricessTableAdapter;
            this.tableAdapterManager.UpdateOrder = ON4.Calorimeter1DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmUnit_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.cooling_capacityTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Name = "FrmUnit_price";
            this.Text = "单价设置";
            this.Load += new System.EventHandler(this.FrmUnit_price_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unit_pricessBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_pricessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Calorimeter1DataSet2 calorimeter1DataSet2;
        private System.Windows.Forms.BindingSource unit_pricessBindingSource;
        private Calorimeter1DataSet2TableAdapters.Unit_pricessTableAdapter unit_pricessTableAdapter;
        private Calorimeter1DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Calorimeter1DataSet4 calorimeter1DataSet4;
        private System.Windows.Forms.BindingSource unit_pricessBindingSource1;
        private Calorimeter1DataSet4TableAdapters.Unit_pricessTableAdapter unit_pricessTableAdapter1;
        private Calorimeter1DataSet4TableAdapters.TableAdapterManager tableAdapterManager1;
        public System.Windows.Forms.TextBox caloriesTextBox;
        public System.Windows.Forms.TextBox cooling_capacityTextBox;
    }
}