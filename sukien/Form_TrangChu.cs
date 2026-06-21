using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUKIEN
{
    public partial class Form_TrangChu : Form
    {
        private Client _client;
        private string sukien = "sukien";

        public Form_TrangChu(string NameUS)
        {
            InitializeComponent();
            _client = new Client();
            var ipAddress = "127.0.0.1";
            var port = 8083;
            try
            {
                _client.Connect(ipAddress, port);
                _client.SendMessage(sukien);
                _client.receiveData_SK();
                _client.SuKienReceived += Client_SuKienReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label_usename.Text = NameUS;
        }

        private void btntaosukien_Click(object sender, EventArgs e)
        {
            Form_TaoSuKien formQLSuKien = new Form_TaoSuKien(label_usename.Text);
            this.Hide();
            formQLSuKien.FormClosed += (s, args) => this.Show();
            formQLSuKien.ShowDialog();
        }

        private void Client_SuKienReceived(object sender, SuKienData[] suKienDatas)
        {
            FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.Size = new Size(600, 500);
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.TabStop = true;
            flowLayoutPanel1.Location = new Point(10, 20);
            for (int i = 0; i < suKienDatas.Length; i++)
            {
                SuKienData sukienData = suKienDatas[i];
                GroupBox groupBox1 = new GroupBox
                {
                    Name = $"groupBox{i}",
                    Text = $"{sukienData.Ten_SK} ",
                    Size = new Size(500, 110),
                    Tag = sukienData.ID_SK
                };
                Button btnsua = new Button
                {
                    Name = "btn_YCTG",
                    Text = "Tham gia",
                    Location = new Point(380, 30),
                    Size = new Size(100, 60),
                };
                btnsua.Click += new EventHandler(btnsua_Click);
                Label label1 = new Label
                {
                    Text = $"thời gian : {sukienData.Ngay_SK}",
                    Location = new Point(10, 20),
                    Size = new Size(300, 20)
                };
                Label label2 = new Label
                {
                    Text = $"Địa điểm : {sukienData.DiaDiem_SK}",
                    Location = new Point(10, 40),
                    Size = new Size(300, 20)
                };
                Label label3 = new Label
                {
                    Text = $"Nội dung : {sukienData.MoTa_SK}",
                    Location = new Point(10, 60),
                    Size = new Size(300, 20)
                };
                Label label4 = new Label
                {
                    Text = $"Người tạo : {sukienData.NgTao_SK}",
                    Location = new Point(10, 80),
                    Size = new Size(300, 20)
                };
                groupBox1.Controls.Add(label1);
                groupBox1.Controls.Add(label2);
                groupBox1.Controls.Add(label3);
                groupBox1.Controls.Add(label4);
                groupBox1.Controls.Add(btnsua);
                flowLayoutPanel1.Controls.Add(groupBox1);
            }
            this.Controls.Add(flowLayoutPanel1);
            groupBox_usename.Controls.Add(flowLayoutPanel1);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GroupBox groupBox = (GroupBox)btn.Parent;
            string username = label_usename.Text;
            var ipAddress = "127.0.0.1";
            var port = 8083;
            _client.Connect(ipAddress, port);
            _client.SendMessage("YC_thamgia");
            Task.Delay(600).ContinueWith(_ =>
            {
                _client.SendMessage(username);
            });
            Task.Delay(600).ContinueWith(_ =>
            {
                _client.SendMessage(groupBox.Tag.ToString());
            });
            string result = _client.ReceiveData();
            if (result.Trim() == "true")
            {
                MessageBox.Show("Yêu cầu tham gia sự kiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yêu cầu tham gia sự kiện thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnqlsukien_Click(object sender, EventArgs e)
        {
            Form_QLSK formQLSuKien = new Form_QLSK(label_usename.Text);
            this.Hide();
            formQLSuKien.FormClosed += (s, args) => this.Show();
            formQLSuKien.ShowDialog();
        }

        private void QLYCSK_Click(object sender, EventArgs e)
        {
            Form_DonYeuCau form_DonYeuCau = new Form_DonYeuCau(label_usename.Text);
            this.Hide();
            form_DonYeuCau.FormClosed += (s, args) => this.Show();
            form_DonYeuCau.ShowDialog();
        }

        private void QLLM_Click(object sender, EventArgs e)
        {
            Form_Loi_moi form_Loi_moi = new Form_Loi_moi(label_usename.Text);
            this.Hide();
            form_Loi_moi.FormClosed += (s, args) => this.Show();
            form_Loi_moi.ShowDialog();
        }

        private void QLNTG_Click(object sender, EventArgs e)
        {
            Form_QLNTG form_QLNTG = new Form_QLNTG(label_usename.Text);
            this.Hide();
            form_QLNTG.FormClosed += (s, args) => this.Show();
            form_QLNTG.ShowDialog();
        }
    }
}