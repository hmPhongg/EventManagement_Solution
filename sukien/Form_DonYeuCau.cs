using SUKIEN;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SUKIEN
{
    public partial class Form_DonYeuCau : Form
    {
        Client _client;
        string donyeucau = "donyeucau";
        string data_username;
        string data_sukien;

        public Form_DonYeuCau(string username)
        {
            InitializeComponent();
            _client = new Client();
            var ipAddress = "127.0.0.1";
            var port = 8083;
            try
            {
                _client.Connect(ipAddress, port);
                _client.SendMessage(donyeucau);
                dataGridView_dataYC.ColumnCount = 3;
                dataGridView_dataYC.Columns[0].Name = "Tên người dùng";
                dataGridView_dataYC.Columns[1].Name = "Tên sự kiện";
                dataGridView_dataYC.Columns[2].Name = "Trạng thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Task.Delay(500).ContinueWith(_ =>
            {
                _client.SendMessage(username);
            });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            int SL = int.Parse(_client.ReceiveData());
            string[] data = new string[SL];
            for (int i = 0; i < SL; i++)
            {
                data[i] = _client.ReceiveData();
                comboBox1.Items.Add(data[i]);
            }
        }

        private void Client_YCTHReceived(object sender, YCTH[] ycth)
        {
            dataGridView_dataYC.Rows.Clear();
            for (int i = 0; i < ycth.Length; i++)
            {
                YCTH ycthData = ycth[i];
                dataGridView_dataYC.Rows.Add(ycthData.Ten_user, ycthData.Ten_SK, ycthData.TrangThai);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            _client.SendMessage(selectedItem);
            _client.YCTHreceiveData();
            _client.YCTHReceived += Client_YCTHReceived;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
            if (data_sukien != null)
            {
                if (radioButton_CN.Checked)
                {
                    query = $"UPDATE YeuCauThamGia SET TrangThai = N'Đã chấp nhận' WHERE MaNguoiDung IN (SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = '{data_username}') AND MaSuKien IN (SELECT MaSuKien FROM SuKien WHERE TenSuKien = N'{data_sukien}');";
                    _client.SendMessage("Done");
                    Task.Delay(500).ContinueWith(_ =>
                    {
                        _client.SendMessage(query);
                        if (_client.ReceiveData().Trim() == "true")
                        {
                            MessageBox.Show("Chấp nhận thành công");
                        }
                    });
                    return;
                }
                if (radioButton_TC.Checked)
                {
                    query = $"UPDATE YeuCauThamGia SET TrangThai = N'Đã từ chối' WHERE MaNguoiDung IN (SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = '{data_username}') AND MaSuKien IN (SELECT MaSuKien FROM SuKien WHERE TenSuKien = N'{data_sukien}');";
                    _client.SendMessage("Done");
                    Task.Delay(500).ContinueWith(_ =>
                    {
                        _client.SendMessage(query);
                        if (_client.ReceiveData().Trim() == "true")
                        {
                            MessageBox.Show("Từ chối thành công");
                        }
                    });
                    return;
                }
                else
                {
                    MessageBox.Show("Chưa chọn trạng thái");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng nào");
            }
        }

        private void dataGridView_dataYC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            data_username = dataGridView_dataYC.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            data_sukien = dataGridView_dataYC.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
        }
    }
}