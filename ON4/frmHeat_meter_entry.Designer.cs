
namespace ON4
{
    partial class frmHeat_meter_entry
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtControlAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableNumbers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableNumbers1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableNumbers1BindingSource, "Table_Number1", true));
            this.textBox1.Location = new System.Drawing.Point(256, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 25);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(171, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "表号：";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.Location = new System.Drawing.Point(511, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "&确认";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(171, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "楼层：";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableNumbers1BindingSource, "NumberofLayersId", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(256, 124);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // txtControlAddress
            // 
            this.txtControlAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtControlAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableNumbers1BindingSource, "ControlAddress", true));
            this.txtControlAddress.Location = new System.Drawing.Point(256, 180);
            this.txtControlAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtControlAddress.MaxLength = 8;
            this.txtControlAddress.Name = "txtControlAddress";
            this.txtControlAddress.Size = new System.Drawing.Size(151, 25);
            this.txtControlAddress.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(107, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "继电器地址：";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableNumbers1BindingSource, "Port_diection", true));
            this.textBox2.Location = new System.Drawing.Point(256, 245);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 25);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(107, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "端口：";
            // 
            // tableNumbers1BindingSource
            // 
            this.tableNumbers1BindingSource.DataSource = typeof(ON4.Table_Numbers1);
            // 
            // frmHeat_meter_entry
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(625, 332);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtControlAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHeat_meter_entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "表号录入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHeat_meter_entry_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tableNumbers1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tableNumbers1BindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtControlAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}