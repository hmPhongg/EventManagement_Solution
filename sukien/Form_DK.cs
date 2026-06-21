using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SUKIEN
{
    public partial class Form_DK : Form
    {
        private Client _client;
        private string dangky = "dangky";

        public Form_DK()
        {
            InitializeComponent();
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
            _client.SendMessage(dangky);
            textBox_MK1.PasswordChar = '*';
            textBox_MK2.PasswordChar = '*';
        }

        private void button_DN_Click(object sender, EventArgs e)
        {
            Form_DN formDN = new Form_DN();
            this.Hide();
            formDN.Show();
        }

        private void button_DK_Click(object sender, EventArgs e)
        {
            string Username = textBox_TK.Text.Trim();
            bool hasVietnameseChars = ContainsVietnameseCharacters(Username);
            string Password_1 = textBox_MK1.Text;
            string Password_2 = textBox_MK2.Text;
            if (hasVietnameseChars)
            {
                MessageBox.Show("Tên tài khoản không được chứa ký tự tiếng việt");
            }
            else
            {
                if (Username == "" || Password_1 == "" || Password_2 == "")
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    if (Username.Length > 10 && Password_1.Length > 10)
                    {
                        if (Password_1 == Password_2)
                        {
                            _client.SendMessage(Username);
                            _client.SendMessage(Password_1);
                            string kq = _client.ReceiveData();
                            if (kq.Trim() == "true")
                            {
                                MessageBox.Show("Đăng ký thành công");
                                Form_TrangChu formMain = new Form_TrangChu(Username);
                                this.Hide();
                                formMain.Show();
                            }
                            else
                            {
                                MessageBox.Show("Đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                var ipAddress = "127.0.0.1";
                                var port = 8083;
                                _client.Connect(ipAddress, port);
                                _client.receiveData();
                                _client.SendMessage(dangky);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không giống nhau");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu phải lớn hơn 10 ký tự");
                    }
                }
            }
        }

        private bool ContainsVietnameseCharacters(string text)
        {
            Regex vietnameseRegex = new Regex("[àÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬđĐèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆìÌỉỈĩĨíÍịỊòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰỳỲỷỶỹỸýÝỵỴ]");
            return vietnameseRegex.IsMatch(text);
        }
    }
}