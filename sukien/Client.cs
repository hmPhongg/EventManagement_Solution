using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUKIEN
{
    internal class Client
    {
        private TcpClient _client;
        public event EventHandler<SuKienData[]> SuKienReceived;
        public event EventHandler<SuKienData[]> QLSuKienReceived;
        public event EventHandler<SuKienData[]> SuKienReceivedLM;
        public event EventHandler<YCTH[]> YCTHReceived;
        public event EventHandler<SLND[]> SLNDReceived;
        public event EventHandler<string> Message;
        public event EventHandler<string> MessageReceived;

        public void Connect(string ipAddress, int port)
        {
            _client = new TcpClient();
            _client.Connect(ipAddress, port);
        }

        public string ReceiveData()
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            return data;
        }

        public void SendMessage(string message)
        {
            _ = MessageSendAsync(message);
        }

        public void receiveData_SK()
        {
            _ = ReceiveDataAsync_SK();
        }

        public void QLreceiveData_SK()
        {
            _ = ReceiveDataAsync_QLSK();
        }

        public void YCTHreceiveData()
        {
            _ = ReceiveDataAsync_YCTH();
        }

        public void SLNDreceiveData()
        {
            _ = ReceiveDataAsync_SLND();
        }

        public void LMSKreceiveData()
        {
            _ = ReceiveDataAsync_LMSK();
        }

        public void receiveData()
        {
            _ = ReceiveDataAsync();
        }

        private async Task MessageSendAsync(string message)
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(buffer, 0, buffer.Length);
            await Task.Delay(1000);
        }

        private async Task ReceiveDataAsync()
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            while (true)
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                bool data1 = bool.Parse(data);
                OnMessageReceived(data1.ToString());
            }
        }

        private async Task ReceiveDataAsync_SK()
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            int soLuongSuKien = int.Parse(data);
            SuKienData[] suKienDatas = new SuKienData[soLuongSuKien];
            for (int i = 0; i < soLuongSuKien; i++)
            {
                string ID_SK = await ReadLineAsync(stream);
                string Ten_SK = await ReadLineAsync(stream);
                string Ngay_SK = await ReadLineAsync(stream);
                string DiaDiem_SK = await ReadLineAsync(stream);
                string MoTa_SK = await ReadLineAsync(stream);
                string NgTao_SK = await ReadLineAsync(stream);
                suKienDatas[i] = new SuKienData(ID_SK, Ten_SK, Ngay_SK, DiaDiem_SK, MoTa_SK, NgTao_SK, soLuongSuKien);
            }
            OnSuKienReceived(suKienDatas);
        }

        private async Task ReceiveDataAsync_QLSK()
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            int soLuongSuKien = int.Parse(data);
            SuKienData[] suKienDatas = new SuKienData[soLuongSuKien];
            for (int i = 0; i < soLuongSuKien; i++)
            {
                string ID_SK = await ReadLineAsync(stream);
                string Ten_SK = await ReadLineAsync(stream);
                string Ngay_SK = await ReadLineAsync(stream);
                string DiaDiem_SK = await ReadLineAsync(stream);
                string MoTa_SK = await ReadLineAsync(stream);
                string NgTao_SK = await ReadLineAsync(stream);
                suKienDatas[i] = new SuKienData(ID_SK, Ten_SK, Ngay_SK, DiaDiem_SK, MoTa_SK, NgTao_SK, soLuongSuKien);
            }
            OnQLSuKienReceived(suKienDatas);
        }

        private async Task ReceiveDataAsync_YCTH()
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            int SLYCTG = int.Parse(data);
            YCTH[] ycth = new YCTH[SLYCTG];
            for (int i = 0; i < SLYCTG; i++)
            {
                string Ten_username = await ReadLineAsync(stream);
                string Ten_SK = await ReadLineAsync(stream);
                string TrangThai = await ReadLineAsync(stream);
                ycth[i] = new YCTH(Ten_username, Ten_SK, TrangThai);
            }
            OnYCTHReceived(ycth);
        }

        private async Task ReceiveDataAsync_SLND()
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            int SLND = int.Parse(data);
            SLND[] ten_username = new SLND[SLND];
            for (int i = 0; i < SLND; i++)
            {
                string Ten_user = await ReadLineAsync(stream);
                ten_username[i] = new SLND(Ten_user);
            }
            OnSLNDReceived(ten_username);
        }

        private async Task ReceiveDataAsync_LMSK()
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            int soLuongSuKien = int.Parse(data);
            SuKienData[] LMsuKienDatas = new SuKienData[soLuongSuKien];
            for (int i = 0; i < soLuongSuKien; i++)
            {
                string TenSK = await ReadLineAsync(stream);
                string TenNgay = await ReadLineAsync(stream);
                string TenDiaDiem = await ReadLineAsync(stream);
                string TenMota = await ReadLineAsync(stream);
                string TenNGTao = await ReadLineAsync(stream);
                LMsuKienDatas[i] = new SuKienData(TenSK, TenNgay, TenDiaDiem, TenMota, TenNGTao);
            }
            OnSLSuKienReceived(LMsuKienDatas);
        }

        private async Task<string> ReadLineAsync(NetworkStream stream)
        {
            var ms = new MemoryStream();
            var buffer = new byte[4096];
            int readCount;
            while ((readCount = await stream.ReadAsync(buffer, 0, 1)) > 0)
            {
                if (buffer[0] == '\n')
                {
                    break;
                }
                ms.Write(buffer, 0, readCount);
            }
            return Encoding.UTF8.GetString(ms.ToArray());
        }

        protected virtual void OnSLSuKienReceived(SuKienData[] LMsuKienDatas)
        {
            SuKienReceivedLM?.Invoke(this, LMsuKienDatas);
        }

        protected virtual void OnSuKienReceived(SuKienData[] suKienDatas)
        {
            SuKienReceived?.Invoke(this, suKienDatas);
        }

        protected virtual void OnSLNDReceived(SLND[] ten_username)
        {
            SLNDReceived?.Invoke(this, ten_username);
        }

        protected virtual void OnQLSuKienReceived(SuKienData[] suKienDatas)
        {
            QLSuKienReceived?.Invoke(this, suKienDatas);
        }

        protected virtual void OnYCTHReceived(YCTH[] ycth)
        {
            YCTHReceived?.Invoke(this, ycth);
        }

        public void Disconnect()
        {
            _client?.Close();
        }

        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(this, message);
        }
    }
}