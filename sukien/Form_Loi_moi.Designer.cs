namespace SUKIEN
{
    partial class Form_Loi_moi
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
            this.dataGridView_LM = new System.Windows.Forms.DataGridView();
            this.button_CN = new System.Windows.Forms.Button();
            this.button_TC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LM)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH LỜI MỜI";

            // dataGridView_LM
            this.dataGridView_LM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LM.Location = new System.Drawing.Point(20, 60);
            this.dataGridView_LM.Name = "dataGridView_LM";
            this.dataGridView_LM.ReadOnly = true;
            this.dataGridView_LM.Size = new System.Drawing.Size(750, 350);
            this.dataGridView_LM.TabIndex = 1;
            this.dataGridView_LM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LM_CellContentClick);

            // button_CN
            this.button_CN.BackColor = System.Drawing.Color.White;
            this.button_CN.Font = new System.Drawing.Font("Arial", 10F);
            this.button_CN.Location = new System.Drawing.Point(550, 430);
            this.button_CN.Name = "button_CN";
            this.button_CN.Size = new System.Drawing.Size(100, 35);
            this.button_CN.TabIndex = 2;
            this.button_CN.Text = "Chấp nhận";
            this.button_CN.UseVisualStyleBackColor = false;
            this.button_CN.Click += new System.EventHandler(this.button_CN_Click);

            // button_TC
            this.button_TC.BackColor = System.Drawing.Color.White;
            this.button_TC.Font = new System.Drawing.Font("Arial", 10F);
            this.button_TC.Location = new System.Drawing.Point(670, 430);
            this.button_TC.Name = "button_TC";
            this.button_TC.Size = new System.Drawing.Size(100, 35);
            this.button_TC.TabIndex = 3;
            this.button_TC.Text = "Từ chối";
            this.button_TC.UseVisualStyleBackColor = false;
            this.button_TC.Click += new System.EventHandler(this.button_TC_Click);

            // Form_Loi_moi
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button_TC);
            this.Controls.Add(this.button_CN);
            this.Controls.Add(this.dataGridView_LM);
            this.Controls.Add(this.label1);
            this.Name = "Form_Loi_moi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lời Mời";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_LM;
        private System.Windows.Forms.Button button_CN;
        private System.Windows.Forms.Button button_TC;
        private System.Windows.Forms.Label label1;
    }
}