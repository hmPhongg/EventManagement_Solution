namespace SUKIEN
{
    partial class Form_DN
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
            this.textBox_TK = new System.Windows.Forms.TextBox();
            this.textBox_MK = new System.Windows.Forms.TextBox();
            this.button_DN = new System.Windows.Forms.Button();
            this.button_DK = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(150, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "WELCOME TO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "EVENT POTATSUTY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";

            // textBox_TK
            this.textBox_TK.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_TK.Location = new System.Drawing.Point(220, 175);
            this.textBox_TK.Name = "textBox_TK";
            this.textBox_TK.Size = new System.Drawing.Size(250, 23);
            this.textBox_TK.TabIndex = 4;

            // textBox_MK
            this.textBox_MK.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_MK.Location = new System.Drawing.Point(220, 225);
            this.textBox_MK.Name = "textBox_MK";
            this.textBox_MK.PasswordChar = '*';
            this.textBox_MK.Size = new System.Drawing.Size(250, 23);
            this.textBox_MK.TabIndex = 5;

            // button_DN
            this.button_DN.BackColor = System.Drawing.Color.White;
            this.button_DN.Font = new System.Drawing.Font("Arial", 10F);
            this.button_DN.Location = new System.Drawing.Point(150, 290);
            this.button_DN.Name = "button_DN";
            this.button_DN.Size = new System.Drawing.Size(120, 35);
            this.button_DN.TabIndex = 6;
            this.button_DN.Text = "Đăng nhập";
            this.button_DN.UseVisualStyleBackColor = false;
            this.button_DN.Click += new System.EventHandler(this.button_DN_Click);

            // button_DK
            this.button_DK.BackColor = System.Drawing.Color.White;
            this.button_DK.Font = new System.Drawing.Font("Arial", 10F);
            this.button_DK.Location = new System.Drawing.Point(320, 290);
            this.button_DK.Name = "button_DK";
            this.button_DK.Size = new System.Drawing.Size(120, 35);
            this.button_DK.TabIndex = 7;
            this.button_DK.Text = "Đăng ký";
            this.button_DK.UseVisualStyleBackColor = false;
            this.button_DK.Click += new System.EventHandler(this.button_DK_Click);

            // Form_DN
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button_DK);
            this.Controls.Add(this.button_DN);
            this.Controls.Add(this.textBox_MK);
            this.Controls.Add(this.textBox_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form_DN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TK;
        private System.Windows.Forms.TextBox textBox_MK;
        private System.Windows.Forms.Button button_DN;
        private System.Windows.Forms.Button button_DK;
    }
}