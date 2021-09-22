
namespace ON4
{
    partial class forUser_Info
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.userdata1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userdata1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userdata1BindingSource, "Table_number", true));
            this.textBox1.Location = new System.Drawing.Point(91, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "表号：";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userdata1BindingSource, "Names", true));
            this.textBox2.Location = new System.Drawing.Point(91, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 25);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "性别：";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userdata1BindingSource, "Phone", true));
            this.textBox4.Location = new System.Drawing.Point(359, 12);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.MaxLength = 50;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 25);
            this.textBox4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(279, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "手机：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(279, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "楼层：";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userdata1BindingSource, "Room_No", true));
            this.textBox6.Location = new System.Drawing.Point(359, 129);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.MaxLength = 500;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 25);
            this.textBox6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(279, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "房号：";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userdata1BindingSource, "Building", true));
            this.textBox7.Location = new System.Drawing.Point(91, 180);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.MaxLength = 500;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(151, 25);
            this.textBox7.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "楼栋：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(279, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "日期:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userdata1BindingSource, "NumberofLayersId", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(359, 72);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.Location = new System.Drawing.Point(505, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "&确认";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userdata1BindingSource, "Gender", true));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox2.Location = new System.Drawing.Point(91, 125);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 23);
            this.comboBox2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userdata1BindingSource, "Billabletime", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(359, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // userdata1BindingSource
            // 
            this.userdata1BindingSource.DataSource = typeof(ON4.User_data1);
            // 
            // forUser_Info
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(625, 332);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "forUser_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户信息录入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.forUser_Info_FormClosing);
            this.Load += new System.EventHandler(this.forUser_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdata1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource userdata1BindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}