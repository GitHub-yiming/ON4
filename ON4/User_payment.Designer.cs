﻿
namespace ON4
{
    partial class User_payment
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.userpayment1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.userpayment1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(194, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "姓名：";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.Location = new System.Drawing.Point(518, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "&添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(194, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "表号：";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userpayment1BindingSource, "Table_number", true));
            this.textBox1.Location = new System.Drawing.Point(269, 76);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "20204456";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userpayment1BindingSource, "Names", true));
            this.textBox2.Location = new System.Drawing.Point(269, 135);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userpayment1BindingSource, "Cost", true));
            this.textBox3.Location = new System.Drawing.Point(269, 186);
            this.textBox3.MaxLength = 8;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 25);
            this.textBox3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(194, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "缴费：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(194, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "时间:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.Location = new System.Drawing.Point(518, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "&修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userpayment1BindingSource
            // 
            this.userpayment1BindingSource.AllowNew = false;
            this.userpayment1BindingSource.DataSource = typeof(ON4.User_payment1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userpayment1BindingSource, "CrateTime", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // User_payment
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(625, 332);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "User_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户缴费";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_payment_FormClosing);
            this.Load += new System.EventHandler(this.User_payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userpayment1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource userpayment1BindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}