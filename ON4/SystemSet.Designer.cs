
namespace ON4
{
    partial class SystemSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(589, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "从";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(674, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "点到";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(779, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "开始自动记录";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(589, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "每隔";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(699, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "小时记录一次";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(12, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "读表失败处理时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(247, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "秒";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ON4.Properties.Settings.Default, "__开始自动记录", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox2.Location = new System.Drawing.Point(729, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(44, 23);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = global::ON4.Properties.Settings.Default.@__开始自动记录;
            this.comboBox2.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ON4.Properties.Settings.Default, "每隔__小时记录一次", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "半个",
            "一个",
            "两个"});
            this.comboBox3.Location = new System.Drawing.Point(644, 81);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(55, 23);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.Text = global::ON4.Properties.Settings.Default.每隔__小时记录一次;
            this.comboBox3.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ON4.Properties.Settings.Default, "读表失败处理时间", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox4.Location = new System.Drawing.Point(197, 345);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(44, 23);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.Text = global::ON4.Properties.Settings.Default.读表失败处理时间;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ON4.Properties.Settings.Default, "从__点到", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox1.Location = new System.Drawing.Point(624, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = global::ON4.Properties.Settings.Default.从__点到;
            this.comboBox1.Visible = false;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = global::ON4.Properties.Settings.Default.允许修改额度;
            this.checkBox11.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "允许修改额度", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox11.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox11.Location = new System.Drawing.Point(12, 312);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(151, 24);
            this.checkBox11.TabIndex = 2;
            this.checkBox11.Text = "允许修改额度";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = global::ON4.Properties.Settings.Default.启用费用统计删除;
            this.checkBox10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用费用统计删除", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox10.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox10.Location = new System.Drawing.Point(12, 282);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(191, 24);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "启用费用统计删除";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = global::ON4.Properties.Settings.Default.启用费用统计编辑;
            this.checkBox9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用费用统计编辑", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox9.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox9.Location = new System.Drawing.Point(12, 252);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(191, 24);
            this.checkBox9.TabIndex = 2;
            this.checkBox9.Text = "启用费用统计编辑";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = global::ON4.Properties.Settings.Default.启用缴费删除;
            this.checkBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用缴费删除", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox8.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox8.Location = new System.Drawing.Point(12, 222);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(151, 24);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Text = "启用缴费删除";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = global::ON4.Properties.Settings.Default.启用缴费编辑;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用缴费编辑", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox7.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox7.Location = new System.Drawing.Point(12, 192);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(151, 24);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "启用缴费编辑";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = global::ON4.Properties.Settings.Default.自动连接串口;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "自动连接串口", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox6.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox6.Location = new System.Drawing.Point(12, 162);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(151, 24);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "自动连接串口";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = global::ON4.Properties.Settings.Default.启用自动记录;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用自动记录", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox5.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox5.Location = new System.Drawing.Point(12, 132);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(151, 24);
            this.checkBox5.TabIndex = 2;
            this.checkBox5.Text = "启用自动记录";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = global::ON4.Properties.Settings.Default.启用计费;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用计费", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox4.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox4.Location = new System.Drawing.Point(12, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(111, 24);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "启用计费";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = global::ON4.Properties.Settings.Default.启用检定;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用检定", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox3.Location = new System.Drawing.Point(12, 72);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(111, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "启用检定";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::ON4.Properties.Settings.Default.启用清零;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用清零", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox2.Location = new System.Drawing.Point(12, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "启用清零";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::ON4.Properties.Settings.Default.启用继电器控制;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ON4.Properties.Settings.Default, "启用继电器控制", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "启用继电器控制";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SystemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(949, 610);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "SystemSet";
            this.Text = "SystemSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        public System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}