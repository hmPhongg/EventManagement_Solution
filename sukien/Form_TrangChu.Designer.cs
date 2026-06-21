namespace SUKIEN
{
    partial class Form_TrangChu
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_subtitle = new System.Windows.Forms.Label();
            this.label_usename = new System.Windows.Forms.Label();
            this.btntaosukien = new System.Windows.Forms.Button();
            this.btnqlsukien = new System.Windows.Forms.Button();
            this.QLNTG = new System.Windows.Forms.Button();
            this.QLYCSK = new System.Windows.Forms.Button();
            this.QLLM = new System.Windows.Forms.Button();
            this.groupBox_usename = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(27, 18);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(260, 29);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "SỰ KIỆN POTATSUTY";
            // 
            // label_subtitle
            // 
            this.label_subtitle.AutoSize = true;
            this.label_subtitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_subtitle.ForeColor = System.Drawing.Color.White;
            this.label_subtitle.Location = new System.Drawing.Point(27, 55);
            this.label_subtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_subtitle.Name = "label_subtitle";
            this.label_subtitle.Size = new System.Drawing.Size(170, 24);
            this.label_subtitle.TabIndex = 1;
            this.label_subtitle.Text = "Sự Kiện Đặc Biệt";
            // 
            // label_usename
            // 
            this.label_usename.AutoSize = true;
            this.label_usename.Font = new System.Drawing.Font("Arial", 10F);
            this.label_usename.ForeColor = System.Drawing.Color.White;
            this.label_usename.Location = new System.Drawing.Point(867, 25);
            this.label_usename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_usename.Name = "label_usename";
            this.label_usename.Size = new System.Drawing.Size(69, 19);
            this.label_usename.TabIndex = 2;
            this.label_usename.Text = "rrrrrrrrrr";
            // 
            // btntaosukien
            // 
            this.btntaosukien.BackColor = System.Drawing.Color.White;
            this.btntaosukien.Font = new System.Drawing.Font("Arial", 9F);
            this.btntaosukien.Location = new System.Drawing.Point(27, 92);
            this.btntaosukien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntaosukien.Name = "btntaosukien";
            this.btntaosukien.Size = new System.Drawing.Size(133, 37);
            this.btntaosukien.TabIndex = 3;
            this.btntaosukien.Text = "Tạo Sự Kiện";
            this.btntaosukien.UseVisualStyleBackColor = false;
            this.btntaosukien.Click += new System.EventHandler(this.btntaosukien_Click);
            // 
            // btnqlsukien
            // 
            this.btnqlsukien.BackColor = System.Drawing.Color.White;
            this.btnqlsukien.Font = new System.Drawing.Font("Arial", 9F);
            this.btnqlsukien.Location = new System.Drawing.Point(173, 92);
            this.btnqlsukien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnqlsukien.Name = "btnqlsukien";
            this.btnqlsukien.Size = new System.Drawing.Size(160, 37);
            this.btnqlsukien.TabIndex = 4;
            this.btnqlsukien.Text = "Quản Lý Sự Kiện";
            this.btnqlsukien.UseVisualStyleBackColor = false;
            this.btnqlsukien.Click += new System.EventHandler(this.btnqlsukien_Click);
            // 
            // QLNTG
            // 
            this.QLNTG.BackColor = System.Drawing.Color.White;
            this.QLNTG.Font = new System.Drawing.Font("Arial", 9F);
            this.QLNTG.Location = new System.Drawing.Point(347, 92);
            this.QLNTG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QLNTG.Name = "QLNTG";
            this.QLNTG.Size = new System.Drawing.Size(200, 37);
            this.QLNTG.TabIndex = 5;
            this.QLNTG.Text = "Quản Lý Người Tham Gia";
            this.QLNTG.UseVisualStyleBackColor = false;
            this.QLNTG.Click += new System.EventHandler(this.QLNTG_Click);
            // 
            // QLYCSK
            // 
            this.QLYCSK.BackColor = System.Drawing.Color.White;
            this.QLYCSK.Font = new System.Drawing.Font("Arial", 9F);
            this.QLYCSK.Location = new System.Drawing.Point(560, 92);
            this.QLYCSK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QLYCSK.Name = "QLYCSK";
            this.QLYCSK.Size = new System.Drawing.Size(187, 37);
            this.QLYCSK.TabIndex = 6;
            this.QLYCSK.Text = "Quản Lý Đơn Yêu Cầu";
            this.QLYCSK.UseVisualStyleBackColor = false;
            this.QLYCSK.Click += new System.EventHandler(this.QLYCSK_Click);
            // 
            // QLLM
            // 
            this.QLLM.BackColor = System.Drawing.Color.White;
            this.QLLM.Font = new System.Drawing.Font("Arial", 9F);
            this.QLLM.Location = new System.Drawing.Point(760, 92);
            this.QLLM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QLLM.Name = "QLLM";
            this.QLLM.Size = new System.Drawing.Size(160, 37);
            this.QLLM.TabIndex = 7;
            this.QLLM.Text = "Quản Lý Lời Mời";
            this.QLLM.UseVisualStyleBackColor = false;
            this.QLLM.Click += new System.EventHandler(this.QLLM_Click);
            // 
            // groupBox_usename
            // 
            this.groupBox_usename.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox_usename.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox_usename.Location = new System.Drawing.Point(27, 142);
            this.groupBox_usename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_usename.Name = "groupBox_usename";
            this.groupBox_usename.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_usename.Size = new System.Drawing.Size(1013, 554);
            this.groupBox_usename.TabIndex = 8;
            this.groupBox_usename.TabStop = false;
            this.groupBox_usename.Text = "Sự Kiện";
            // 
            // Form_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.groupBox_usename);
            this.Controls.Add(this.QLLM);
            this.Controls.Add(this.QLYCSK);
            this.Controls.Add(this.QLNTG);
            this.Controls.Add(this.btnqlsukien);
            this.Controls.Add(this.btntaosukien);
            this.Controls.Add(this.label_usename);
            this.Controls.Add(this.label_subtitle);
            this.Controls.Add(this.label_title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_subtitle;
        private System.Windows.Forms.Label label_usename;
        private System.Windows.Forms.Button btntaosukien;
        private System.Windows.Forms.Button btnqlsukien;
        private System.Windows.Forms.Button QLNTG;
        private System.Windows.Forms.Button QLYCSK;
        private System.Windows.Forms.Button QLLM;
        private System.Windows.Forms.GroupBox groupBox_usename;
    }
}