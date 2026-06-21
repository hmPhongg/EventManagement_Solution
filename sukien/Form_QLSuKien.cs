using SUKIEN;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUKIEN
{
    public partial class Form_QLSK : Form
    {
        Client _client;
        string QLsukien = "QLsukien";

        public Form_QLSK(string username)
        {
            InitializeComponent();
            _client = new Client();
            var ipAddress = "127.0.0.1";
            var port = 8083;
            try
            {
                _client.Connect(ipAddress, port);
                _client.SendMessage(QLsukien);
                _client.QLreceiveData_SK();
                _client.QLSuKienReceived += Client_SuKienReceived;
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Mã sự kiện";
                dataGridView1.Columns[1].Name = "Tên Sự kiện";
                dataGridView1.Columns[2].Name = "Thời gian";
                dataGridView1.Columns[3].Name = "Địa điểm";
                dataGridView1.Columns[4].Name = "Mô tả";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Task.Delay(500).ContinueWith(_ =>
            {
                _client.SendMessage(username);
            });
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            _client.SendMessage("sua");
            string tensukien = txttensukien.Text;
            string diadiem = txtdiadiem.Text;
            string mota = txtmota.Text;
            string ngay = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string gio = numericUpDown_gio.Value.ToString();
            string phut = numericUpDown_phut.Value.ToString();
            string ID = ID_SK.Text;
            string time = gio + ":" + phut;
            string[] ngay1 = ngay.Split(' ');
            string[] time1 = time.Split(':');
            string ngaygio = ngay1[0] + " " + time1[0] + ":" + time1[1] + ":00";
            string query = $"UPDATE Sukien SET TenSuKien = '{tensukien.Trim()}', ThoiDiem = '{ngaygio}', DiaDiem = '{diadiem.Trim()}' ,MoTa = '{mota.Trim()}' WHERE MaSuKien = {ID.Trim()};";
            _client.SendMessage(query);
            string result = _client.ReceiveData();
            if (result.Trim() == "true")
            {
                MessageBox.Show("Sửa sự kiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa sự kiện thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_SuKienReceived(object sender, SuKienData[] suKienDatas)
        {
            foreach (SuKienData suKienData in suKienDatas)
            {
                dataGridView1.Rows.Add(suKienData.ID_SK, suKienData.Ten_SK, suKienData.Ngay_SK, suKienData.DiaDiem_SK, suKienData.MoTa_SK);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_SK.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string ngay = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string[] ngay1 = ngay.Split(' ');
            DateTime dateTime = DateTime.Parse(ngay1[0]);
            dateTimePicker2.Value = dateTime;
            string time = ngay1[1];
            string[] time1 = time.Split(':');
            if (ngay1.Length > 2 && ngay1[2].Trim() == "PM")
            {
                numericUpDown_gio.Text = (int.Parse(time1[0]) + 12).ToString();
            }
            else
            {
                numericUpDown_gio.Text = time1[0];
            }
            numericUpDown_phut.Text = time1[1];
            txttensukien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdiadiem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmota.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Task.Delay(500).ContinueWith(_ =>
            {
                _client.SendMessage("gui");
            });
            Task.Delay(500).ContinueWith(_ =>
            {
                _client.SendMessage(txttensukien.Text);
            });
            _client.SLNDreceiveData();
            _client.SLNDReceived += Client_MessageReceived;
        }

        private void Client_MessageReceived(object sender, SLND[] Ten_username)
        {
            checkedListBox_ND.Items.Clear();
            foreach (var item in Ten_username)
            {
                checkedListBox_ND.Items.Add(item.Ten_user);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            _client.SendMessage("xoa");
            string ID = ID_SK.Text;
            string query = $"DELETE FROM Sukien WHERE MaSuKien = {ID.Trim()};";
            _client.SendMessage(query);
            string result = _client.ReceiveData();
            if (result.Trim() == "true")
            {
                MessageBox.Show("Xóa sự kiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa sự kiện thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngui_Click(object sender, EventArgs e)
        {
            _client.SendMessage("GuiLoiMoi");
            int SLGui = checkedListBox_ND.CheckedItems.Count;
            string TenSK = txttensukien.Text;
            Task.Delay(500).ContinueWith(_ =>
            {
                _client.SendMessage(SLGui.ToString());
            });
            Task.Delay(500).ContinueWith(async _ =>
            {
                for (int i = 0; i < SLGui; i++)
                {
                    await Task.Delay(500);
                    _client.SendMessage($"INSERT INTO MoiThamGiaSuKien (MaSuKien, MaNguoiDung, TrangThai) SELECT (SELECT MaSuKien FROM SuKien WHERE TenSuKien = N'{TenSK.Trim()}'), (SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = N'{checkedListBox_ND.CheckedItems[i].ToString().Trim()}'), N'Đang chờ';");
                }
            });
            string kq = _client.ReceiveData();
            if (kq.Trim() == "true")
            {
                MessageBox.Show("Gửi lời mời thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gửi lời mời thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}