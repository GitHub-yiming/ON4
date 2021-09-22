
namespace ON4
{
    partial class ForTotalExpenses_info
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userbalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calorimeter1DataSet6 = new ON4.Calorimeter1DataSet6();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_balanceTableAdapter = new ON4.Calorimeter1DataSet6TableAdapters.User_balanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userbalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userbalanceBindingSource, "NumberofLayersId", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(376, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // userbalanceBindingSource
            // 
            this.userbalanceBindingSource.DataMember = "User_balance";
            this.userbalanceBindingSource.DataSource = this.calorimeter1DataSet6;
            // 
            // calorimeter1DataSet6
            // 
            this.calorimeter1DataSet6.DataSetName = "Calorimeter1DataSet6";
            this.calorimeter1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(296, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "房号：";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userbalanceBindingSource, "Room_No", true));
            this.textBox6.Location = new System.Drawing.Point(376, 92);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.MaxLength = 500;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 25);
            this.textBox6.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(296, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "楼层：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "姓名：";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userbalanceBindingSource, "Names", true));
            this.textBox2.Location = new System.Drawing.Point(115, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 25);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "表号：";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userbalanceBindingSource, "Table_number", true));
            this.textBox1.Location = new System.Drawing.Point(115, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 25);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.Location = new System.Drawing.Point(444, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "&确认";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userbalanceBindingSource, "Balance", true));
            this.textBox3.Location = new System.Drawing.Point(115, 155);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.MaxLength = 8;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 25);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "余额：";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userbalanceBindingSource, "Quota", true));
            this.textBox4.Location = new System.Drawing.Point(115, 215);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 25);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(36, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "额度：";
            // 
            // user_balanceTableAdapter
            // 
            this.user_balanceTableAdapter.ClearBeforeFill = true;
            // 
            // ForTotalExpenses_info
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(562, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ForTotalExpenses_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用统计信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForTotalExpenses_info_FormClosing);
            this.Load += new System.EventHandler(this.ForTotalExpenses_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userbalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorimeter1DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private Calorimeter1DataSet6 calorimeter1DataSet6;
        private System.Windows.Forms.BindingSource userbalanceBindingSource;
        private Calorimeter1DataSet6TableAdapters.User_balanceTableAdapter user_balanceTableAdapter;
    }
}