namespace SUKIEN
{
    partial class Form_QLNTG
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
            this.dataGridView_SLNTG = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_SLNTG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SLNTG)).BeginInit();
            this.SuspendLayout();

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn sự kiện:";

            // comboBox1
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 21);
            this.comboBox1.TabIndex = 1;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số người tham gia:";

            // label_SLNTG
            this.label_SLNTG.AutoSize = true;
            this.label_SLNTG.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_SLNTG.ForeColor = System.Drawing.Color.White;
            this.label_SLNTG.Location = new System.Drawing.Point(180, 55);
            this.label_SLNTG.Name = "label_SLNTG";
            this.label_SLNTG.Size = new System.Drawing.Size(25, 26);
            this.label_SLNTG.TabIndex = 3;
            this.label_SLNTG.Text = "0";

            // dataGridView_SLNTG
            this.dataGridView_SLNTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SLNTG.Location = new System.Drawing.Point(20, 90);
            this.dataGridView_SLNTG.Name = "dataGridView_SLNTG";
            this.dataGridView_SLNTG.ReadOnly = true;
            this.dataGridView_SLNTG.Size = new System.Drawing.Size(750, 350);
            this.dataGridView_SLNTG.TabIndex = 4;

            // Form_QLNTG
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.dataGridView_SLNTG);
            this.Controls.Add(this.label_SLNTG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form_QLNTG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Người Tham Gia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SLNTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SLNTG;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_SLNTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}