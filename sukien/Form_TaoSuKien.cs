using System;
using System.Windows.Forms;

namespace SUKIEN
{
    public partial class Form_TaoSuKien : Form
    {
        private Client _client;
        private string DK_sukien = "DK_sukien";
        private string username1 = null;

        public Form_TaoSuKien(string username)
        {
            InitializeComponent();
            numericUpDown_gio.Maximum = 23;
            numericUpDown_gio.Minimum = 0;
            numericUpDown_phut.Maximum = 59;
            numericUpDown_phut.Minimum = 0;
            username1 = username;
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
            _client.SendMessage(DK_sukien);
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            DateTime eventTime = dateTimePicker2.Value;
            string eventname = txttensukien.Text;
            string eventlocation = txtdiadiem.Text;
            string eventmota = txtmota.Text;
            string year = eventTime.Year.ToString();
            string month = eventTime.Month.ToString();
            string day = eventTime.Day.ToString();
            string hour = numericUpDown_gio.Value.ToString();
            string minute = numericUpDown_phut.Value.ToString();
            if (eventname == "" || eventlocation == "" || eventmota == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = $"INSERT INTO Sukien (TenSuKien, ThoiDiem, DiaDiem, MoTa, NguoiTao) VALUES (N'{eventname}','{year}-{month}-{day} {hour}:{minute}:00', N'{eventlocation}', N'{eventmota}', ";
            _client.SendMessage(username1);
            _client.SendMessage(query);
            string kq = _client.ReceiveData();
            if (kq.Trim() == "true")
            {
                txtdiadiem.Text = "";
                txtmota.Text = "";
                txttensukien.Text = "";
                numericUpDown_gio.Value = 0;
                numericUpDown_phut.Value = 0;
                dateTimePicker2.Value = DateTime.Now;
                MessageBox.Show("Tạo sự kiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tạo sự kiện thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}