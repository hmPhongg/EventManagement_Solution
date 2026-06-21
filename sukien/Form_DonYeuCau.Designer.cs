namespace SUKIEN
{
    partial class Form_DonYeuCau
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView_dataYC = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton_CN = new System.Windows.Forms.RadioButton();
            this.radioButton_TC = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dataYC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // dataGridView_dataYC
            this.dataGridView_dataYC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dataYC.Location = new System.Drawing.Point(20, 20);
            this.dataGridView_dataYC.Name = "dataGridView_dataYC";
            this.dataGridView_dataYC.ReadOnly = true;
            this.dataGridView_dataYC.Size = new System.Drawing.Size(750, 300);
            this.dataGridView_dataYC.TabIndex = 0;
            this.dataGridView_dataYC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dataYC_CellContentClick);

            // comboBox1
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn sự kiện:";

            // groupBox1
            this.groupBox1.Controls.Add(this.radioButton_CN);
            this.groupBox1.Controls.Add(this.radioButton_TC);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(250, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";

            // radioButton_CN
            this.radioButton_CN.AutoSize = true;
            this.radioButton_CN.Location = new System.Drawing.Point(10, 25);
            this.radioButton_CN.Name = "radioButton_CN";
            this.radioButton_CN.Size = new System.Drawing.Size(90, 20);
            this.radioButton_CN.TabIndex = 0;
            this.radioButton_CN.TabStop = true;
            this.radioButton_CN.Text = "Chấp nhận";
            this.radioButton_CN.UseVisualStyleBackColor = true;

            // radioButton_TC
            this.radioButton_TC.AutoSize = true;
            this.radioButton_TC.Location = new System.Drawing.Point(110, 25);
            this.radioButton_TC.Name = "radioButton_TC";
            this.radioButton_TC.Size = new System.Drawing.Size(70, 20);
            this.radioButton_TC.TabIndex = 1;
            this.radioButton_TC.TabStop = true;
            this.radioButton_TC.Text = "Từ chối";
            this.radioButton_TC.UseVisualStyleBackColor = true;

            // button1
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 10F);
            this.button1.Location = new System.Drawing.Point(480, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xử lý";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Form_DonYeuCau
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView_dataYC);
            this.Name = "Form_DonYeuCau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đơn Yêu Cầu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dataYC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_dataYC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton_CN;
        private System.Windows.Forms.RadioButton radioButton_TC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}