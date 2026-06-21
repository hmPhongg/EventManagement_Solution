namespace SUKIEN
{
    partial class Form_DK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TK = new System.Windows.Forms.TextBox();
            this.textBox_MK1 = new System.Windows.Forms.TextBox();
            this.textBox_MK2 = new System.Windows.Forms.TextBox();
            this.button_DN = new System.Windows.Forms.Button();
            this.button_DK = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label4 - Tiêu đề
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(150, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "WELCOME TO";

            // label5 - Tiêu đề phụ
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "EVENT POTATSUTY";

            // label1 - Tài Khoản
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản :";

            // label2 - Mật khẩu
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu :";

            // label3 - Nhập lại mật khẩu
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu :";

            // textBox_TK
            this.textBox_TK.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_TK.Location = new System.Drawing.Point(280, 155);
            this.textBox_TK.Name = "textBox_TK";
            this.textBox_TK.Size = new System.Drawing.Size(200, 23);
            this.textBox_TK.TabIndex = 5;

            // textBox_MK1
            this.textBox_MK1.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_MK1.Location = new System.Drawing.Point(280, 205);
            this.textBox_MK1.Name = "textBox_MK1";
            this.textBox_MK1.PasswordChar = '*';
            this.textBox_MK1.Size = new System.Drawing.Size(200, 23);
            this.textBox_MK1.TabIndex = 6;

            // textBox_MK2
            this.textBox_MK2.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_MK2.Location = new System.Drawing.Point(280, 255);
            this.textBox_MK2.Name = "textBox_MK2";
            this.textBox_MK2.PasswordChar = '*';
            this.textBox_MK2.Size = new System.Drawing.Size(200, 23);
            this.textBox_MK2.TabIndex = 7;

            // button_DN
            this.button_DN.BackColor = System.Drawing.Color.White;
            this.button_DN.Font = new System.Drawing.Font("Arial", 10F);
            this.button_DN.Location = new System.Drawing.Point(150, 320);
            this.button_DN.Name = "button_DN";
            this.button_DN.Size = new System.Drawing.Size(120, 35);
            this.button_DN.TabIndex = 8;
            this.button_DN.Text = "Đăng nhập";
            this.button_DN.UseVisualStyleBackColor = false;
            this.button_DN.Click += new System.EventHandler(this.button_DN_Click);

            // button_DK
            this.button_DK.BackColor = System.Drawing.Color.White;
            this.button_DK.Font = new System.Drawing.Font("Arial", 10F);
            this.button_DK.Location = new System.Drawing.Point(320, 320);
            this.button_DK.Name = "button_DK";
            this.button_DK.Size = new System.Drawing.Size(120, 35);
            this.button_DK.TabIndex = 9;
            this.button_DK.Text = "Đăng ký";
            this.button_DK.UseVisualStyleBackColor = false;
            this.button_DK.Click += new System.EventHandler(this.button_DK_Click);

            // Form_DK
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.button_DK);
            this.Controls.Add(this.button_DN);
            this.Controls.Add(this.textBox_MK2);
            this.Controls.Add(this.textBox_MK1);
            this.Controls.Add(this.textBox_TK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form_DK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Kí";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TK;
        private System.Windows.Forms.TextBox textBox_MK1;
        private System.Windows.Forms.TextBox textBox_MK2;
        private System.Windows.Forms.Button button_DN;
        private System.Windows.Forms.Button button_DK;
    }
}