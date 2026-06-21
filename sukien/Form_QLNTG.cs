using SUKIEN;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SUKIEN
{
    public partial class Form_QLNTG : Form
    {
        Client _client;
        string username;

        public Form_QLNTG(string NameUS)
        {
            InitializeComponent();
            username = NameUS;
            _client = new Client();
            var ipAddress = "127.0.0.1";
            var port = 8083;
            try
            {
                _client.Connect(ipAddress, port);
                _client.SendMessage("QLNTG");
                dataGridView_SLNTG.ColumnCount = 2;
                dataGridView_SLNTG.Columns[0].Name = "STT";
                dataGridView_SLNTG.Columns[1].Name = "Tên người tham gia";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            _client.SendMessage(selectedItem);
            _client.SLNDreceiveData();
            _client.SLNDReceived += Client_SLNTGReceived;
        }

        private void Client_SLNTGReceived(object sender, SLND[] Ten_username)
        {
            int stt = 0;
            dataGridView_SLNTG.Rows.Clear();
            foreach (SLND slnd in Ten_username)
            {
                stt++;
                dataGridView_SLNTG.Rows.Add(stt, slnd.Ten_user);
            }
            label_SLNTG.Text = stt.ToString();
        }
    }
}