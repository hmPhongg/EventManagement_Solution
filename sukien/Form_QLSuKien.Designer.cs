namespace SUKIEN
{
    partial class Form_QLSK
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_SK = new System.Windows.Forms.TextBox();
            this.txttensukien = new System.Windows.Forms.TextBox();
            this.txtdiadiem = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_gio = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_phut = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox_ND = new System.Windows.Forms.CheckedListBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btngui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phut)).BeginInit();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SK:";

            // ID_SK
            this.ID_SK.Location = new System.Drawing.Point(100, 237);
            this.ID_SK.Name = "ID_SK";
            this.ID_SK.Size = new System.Drawing.Size(100, 20);
            this.ID_SK.TabIndex = 2;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên SK:";

            // txttensukien
            this.txttensukien.Location = new System.Drawing.Point(300, 237);
            this.txttensukien.Name = "txttensukien";
            this.txttensukien.Size = new System.Drawing.Size(200, 20);
            this.txttensukien.TabIndex = 4;

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa điểm:";

            // txtdiadiem
            this.txtdiadiem.Location = new System.Drawing.Point(100, 277);
            this.txtdiadiem.Name = "txtdiadiem";
            this.txtdiadiem.Size = new System.Drawing.Size(200, 20);
            this.txtdiadiem.TabIndex = 6;

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mô tả:";

            // txtmota
            this.txtmota.Location = new System.Drawing.Point(380, 277);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(200, 20);
            this.txtmota.TabIndex = 8;

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày:";

            // dateTimePicker2
            this.dateTimePicker2.Location = new System.Drawing.Point(80, 317);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(300, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giờ:";

            // numericUpDown_gio
            this.numericUpDown_gio.Location = new System.Drawing.Point(350, 318);
            this.numericUpDown_gio.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            this.numericUpDown_gio.Name = "numericUpDown_gio";
            this.numericUpDown_gio.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_gio.TabIndex = 12;

            // label7
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(430, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phút:";

            // numericUpDown_phut
            this.numericUpDown_phut.Location = new System.Drawing.Point(480, 318);
            this.numericUpDown_phut.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericUpDown_phut.Name = "numericUpDown_phut";
            this.numericUpDown_phut.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_phut.TabIndex = 14;

            // label8
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gửi lời mời cho:";

            // checkedListBox_ND
            this.checkedListBox_ND.FormattingEnabled = true;
            this.checkedListBox_ND.Location = new System.Drawing.Point(150, 360);
            this.checkedListBox_ND.Name = "checkedListBox_ND";
            this.checkedListBox_ND.Size = new System.Drawing.Size(200, 100);
            this.checkedListBox_ND.TabIndex = 16;

            // btnsua
            this.btnsua.BackColor = System.Drawing.Color.White;
            this.btnsua.Font = new System.Drawing.Font("Arial", 10F);
            this.btnsua.Location = new System.Drawing.Point(400, 360);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(80, 30);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);

            // btnxoa
            this.btnxoa.BackColor = System.Drawing.Color.White;
            this.btnxoa.Font = new System.Drawing.Font("Arial", 10F);
            this.btnxoa.Location = new System.Drawing.Point(490, 360);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(80, 30);
            this.btnxoa.TabIndex = 18;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);

            // btngui
            this.btngui.BackColor = System.Drawing.Color.White;
            this.btngui.Font = new System.Drawing.Font("Arial", 10F);
            this.btngui.Location = new System.Drawing.Point(580, 360);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(100, 30);
            this.btngui.TabIndex = 19;
            this.btngui.Text = "Gửi lời mời";
            this.btngui.UseVisualStyleBackColor = false;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);

            // Form_QLSK
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btngui);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.checkedListBox_ND);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_phut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_gio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdiadiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttensukien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_SK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_QLSK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sự Kiện";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_phut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID_SK;
        private System.Windows.Forms.TextBox txttensukien;
        private System.Windows.Forms.TextBox txtdiadiem;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericUpDown_gio;
        private System.Windows.Forms.NumericUpDown numericUpDown_phut;
        private System.Windows.Forms.CheckedListBox checkedListBox_ND;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btngui;
    }
}