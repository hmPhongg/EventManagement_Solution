using System;
using System.Windows.Forms;

namespace SUKIEN
{
    public partial class Form_DN : Form
    {
        private Client _client;
        private string dangnhap = "dangnhap";

        public Form_DN()
        {
            InitializeComponent(); // ✅ Chỉ GỌI hàm này, KHÔNG định nghĩa lại
            _client = new Client();
            var ipAddress = "127.0.0.1";
            var port = 8083;
            try
            {
                _client.Connect(ipAddress, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _client.SendMessage(dangnhap);
            textBox_MK.PasswordChar = '*';
        }

        private void button_DK_Click(object sender, EventArgs e)
        {
            Form_DK formDK = new Form_DK();
            this.Hide();
            formDK.Show();
        }

        private void button_DN_Click(object sender, EventArgs e)
        {
            string Username = textBox_TK.Text.Trim();
            string Password = textBox_MK.Text.Trim();
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _client.SendMessage(Username);
            _client.SendMessage(Password);
            string data = _client.ReceiveData();

            if (data.Trim() == "false_alreadyLoggedIn")
            {
                MessageBox.Show("Tài khoản đã đăng nhập ở nơi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_TK.Text = "";
                textBox_MK.Text = "";
                var ipAddress = "127.0.0.1";
                var port = 8083;
                _client.Connect(ipAddress, port);
                _client.receiveData();
                _client.SendMessage(dangnhap);
            }
            else if (data.Trim() == "false")
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var ipAddress = "127.0.0.1";
                var port = 8083;
                _client.Connect(ipAddress, port);
                _client.receiveData();
                _client.SendMessage(dangnhap);
            }
            else
            {
                Form_TrangChu form2 = new Form_TrangChu(Username);
                this.Hide();
                form2.Show();
            }
        }
    }
}