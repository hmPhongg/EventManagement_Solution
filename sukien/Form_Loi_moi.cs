using SUKIEN;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUKIEN
{
    public partial class Form_Loi_moi : Form
    {
        Client _client;
        public string Username { get; set; }
        public string EventName { get; set; }

        public Form_Loi_moi(string Username)
        {
            InitializeComponent();
            this.Username = Username.Trim();
            _client = new Client();
            var ipAddress = "127.0.0.1";
            var port = 8083;
            try
            {
                _client.Connect(ipAddress, port);
                _client.SendMessage("moi");
                _client.LMSKreceiveData();
                _client.SuKienReceivedLM += Client_SuKienReceivedLM;
                dataGridView_LM.ColumnCount = 5;
                dataGridView_LM.Columns[0].Name = "Tên Sự kiện";
                dataGridView_LM.Columns[1].Name = "Thời gian";
                dataGridView_LM.Columns[2].Name = "Địa điểm";
                dataGridView_LM.Columns[3].Name = "Mô tả";
                dataGridView_LM.Columns[4].Name = "Người tạo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Task.Delay(500).ContinueWith(_ =>
            {
                _client.SendMessage(Username);
            });
        }

        private void button_CN_Click(object sender, EventArgs e)
        {
            if (Username != null && EventName != null)
            {
                _client.SendMessage("dongy");
                string query = $"UPDATE MoiThamGiaSuKien SET TrangThai = N'Đã chấp nhận' WHERE MaSuKien = (SELECT TOP 1 MaSuKien FROM SuKien WHERE TenSuKien = N'{EventName.Trim()}') AND MaNguoiDung = (SELECT TOP 1 MaNguoiDung FROM NguoiDung WHERE TenDangNhap = N'{Username.Trim()}');";
                Task.Delay(500).ContinueWith(_ =>
                {
                    _client.SendMessage(query);
                });
                if (_client.ReceiveData().Trim() == "true")
                {
                    MessageBox.Show("Chấp nhận thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Chọn sự kiện cần chấp nhận");
            }
        }

        private void button_TC_Click(object sender, EventArgs e)
        {
            if (Username != null && EventName != null)
            {
                _client.SendMessage("tuchoi");
                string query = $"UPDATE MoiThamGiaSuKien SET TrangThai = N'Đã từ chối' WHERE MaSuKien = (SELECT TOP 1 MaSuKien FROM SuKien WHERE TenSuKien = N'{EventName.Trim()}') AND MaNguoiDung = (SELECT TOP 1 MaNguoiDung FROM NguoiDung WHERE TenDangNhap = N'{Username.Trim()}');";
                Task.Delay(500).ContinueWith(_ =>
                {
                    _client.SendMessage(query);
                });
                if (_client.ReceiveData().Trim() == "true")
                {
                    MessageBox.Show("Từ chối thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Chọn sự kiện cần từ chối");
            }
        }

        private void Client_SuKienReceivedLM(object sender, SuKienData[] LMsuKienDatas)
        {
            dataGridView_LM.Rows.Clear();
            foreach (SuKienData suKienData in LMsuKienDatas)
            {
                dataGridView_LM.Rows.Add(suKienData.Ten_SK, suKienData.Ngay_SK, suKienData.DiaDiem_SK, suKienData.MoTa_SK, suKienData.NgTao_SK);
            }
        }

        private void dataGridView_LM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EventName = dataGridView_LM.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}