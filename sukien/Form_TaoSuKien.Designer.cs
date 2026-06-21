namespace SUKIEN
{
    partial class Form_TaoSuKien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttensukien = new System.Windows.Forms.TextBox();
            this.txtdiadiem = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_gio = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_phut = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phut)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // label_title
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(20, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(200, 22);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "SỰ KIỆN POTATSUTY";

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sự Kiện";

            // txttensukien
            this.txttensukien.Font = new System.Drawing.Font("Arial", 10F);
            this.txttensukien.Location = new System.Drawing.Point(150, 75);
            this.txttensukien.Name = "txttensukien";
            this.txttensukien.Size = new System.Drawing.Size(300, 23);
            this.txttensukien.TabIndex = 2;

            // groupBox1
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.numericUpDown_gio);
            this.groupBox1.Controls.Add(this.numericUpDown_phut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(150, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày:";

            // dateTimePicker2
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 10F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker2.Location = new System.Drawing.Point(70, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 23);
            this.dateTimePicker2.TabIndex = 5;

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giờ:";

            // numericUpDown_gio
            this.numericUpDown_gio.Font = new System.Drawing.Font("Arial", 10F);
            this.numericUpDown_gio.Location = new System.Drawing.Point(60, 63);
            this.numericUpDown_gio.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            this.numericUpDown_gio.Name = "numericUpDown_gio";
            this.numericUpDown_gio.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_gio.TabIndex = 7;

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(140, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phút:";

            // numericUpDown_phut
            this.numericUpDown_phut.Font = new System.Drawing.Font("Arial", 10F);
            this.numericUpDown_phut.Location = new System.Drawing.Point(190, 63);
            this.numericUpDown_phut.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericUpDown_phut.Name = "numericUpDown_phut";
            this.numericUpDown_phut.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_phut.TabIndex = 9;

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa Điểm";

            // txtdiadiem
            this.txtdiadiem.Font = new System.Drawing.Font("Arial", 10F);
            this.txtdiadiem.Location = new System.Drawing.Point(150, 225);
            this.txtdiadiem.Name = "txtdiadiem";
            this.txtdiadiem.Size = new System.Drawing.Size(300, 23);
            this.txtdiadiem.TabIndex = 11;

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(30, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mô Tả";

            // txtmota
            this.txtmota.Font = new System.Drawing.Font("Arial", 10F);
            this.txtmota.Location = new System.Drawing.Point(150, 265);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(300, 23);
            this.txtmota.TabIndex = 13;

            // btntao
            this.btntao.BackColor = System.Drawing.Color.White;
            this.btntao.Font = new System.Drawing.Font("Arial", 10F);
            this.btntao.Location = new System.Drawing.Point(450, 320);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(80, 35);
            this.btntao.TabIndex = 14;
            this.btntao.Text = "Tạo";
            this.btntao.UseVisualStyleBackColor = false;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);

            // Form_TaoSuKien
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdiadiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttensukien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Name = "Form_TaoSuKien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Sự Kiện";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttensukien;
        private System.Windows.Forms.TextBox txtdiadiem;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericUpDown_gio;
        private System.Windows.Forms.NumericUpDown numericUpDown_phut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntao;
    }
}