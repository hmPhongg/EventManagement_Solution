using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    internal class server
    {
        private TcpListener _server;
        private readonly string _ipAddress;
        private readonly int _port;
        public event EventHandler<string> MessageReceived;

        // ✅ ĐÃ SỬA: Kết nối LocalDB và database QuanLySuKien
        public string connString = @"Data Source=LENOVO-LOQ;Initial Catalog=QuanLySuKien;User Id=sa;Password=123456;TrustServerCertificate=True";

        public server(string ipAddress = "127.0.0.1", int port = 8083)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public async Task Start()
        {
            if (_server != null)
            {
                throw new InvalidOperationException("Server is already running!");
            }
            IPAddress localAddr = IPAddress.Parse(_ipAddress);
            _server = new TcpListener(localAddr, _port);
            _server.Start();
            while (true)
            {
                TcpClient client = await _server.AcceptTcpClientAsync();
                OnMessageReceived($"Connected! Client IP: {client.Client.RemoteEndPoint}");
                _ = HandleClientAsync(client);
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            string request = await ReadStringFromStream(stream);
            OnMessageReceived(request);
            switch (request.Trim())
            {
                case "dangnhap":
                    await HandleDangNhap(stream);
                    break;
                case "dangky":
                    await HandleDangKy(stream);
                    break;
                default:
                    await HandleRequest(stream, request);
                    break;
            }
        }

        private readonly Dictionary<string, DateTime> Us_Dang_nhap = new Dictionary<string, DateTime>();
        private bool US_Dang_nhap(string username)
        {
            return Us_Dang_nhap.ContainsKey(username);
        }

        private async Task HandleRequest(NetworkStream stream, string request)
        {
            switch (request.Trim())
            {
                case "YC_thamgia":
                    await HandleYCThamGia(stream);
                    break;
                case "sukien":
                    await HandleThongTinSK(stream);
                    break;
                case "DK_sukien":
                    await HandleDangKySK(stream);
                    break;
                case "QLsukien":
                    await HandleQuanLySK(stream);
                    break;
                case "donyeucau":
                    await HandleDanhSachMoi(stream);
                    break;
                case "moi":
                    await HandleMoiThamGiaSK(stream);
                    break;
                case "QLNTG":
                    await HandleQuanLyNTG(stream);
                    break;
                default:
                    await SendMessage(stream, "Yêu cầu không hợp lệ!");
                    break;
            }
        }

        private async Task HandleDangNhap(NetworkStream stream)
        {
            string username = await ReadStringFromStream(stream);
            string password = await ReadStringFromStream(stream);
            if (US_Dang_nhap(username.Trim()))
            {
                await SendMessage(stream, "false_alreadyLoggedIn");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT * FROM NguoiDung WHERE TenDangNhap = @username AND MatKhau = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username.Trim());
                    command.Parameters.AddWithValue("@password", password.Trim());
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Us_Dang_nhap[username.Trim()] = DateTime.Now;
                        OnMessageReceived($"Logged in: {username}");
                        await SendMessage(stream, "true");
                    }
                    else
                    {
                        await SendMessage(stream, "false");
                    }
                }
            }
        }

        private async Task HandleYCThamGia(NetworkStream stream)
        {
            string Data_Usname = await ReadStringFromStream(stream);
            OnMessageReceived(Data_Usname);
            string Data_IDSK = await ReadStringFromStream(stream);
            OnMessageReceived(Data_IDSK);
            string query_YCTG = "INSERT INTO YeuCauThamGia (MaSuKien, MaNguoiDung, TrangThai) VALUES ";
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query_MND = "SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = @name;";
                    using (SqlCommand command = new SqlCommand(query_MND, connection))
                    {
                        command.Parameters.AddWithValue("@name", Data_Usname.Trim());
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        query_YCTG += $"({Data_IDSK.Trim()},{int.Parse(dataSet.Tables[0].Rows[0][0].ToString())}, N'Đang chờ');";
                    }
                    using (SqlCommand command = new SqlCommand(query_YCTG, connection))
                    {
                        command.ExecuteNonQuery();
                        await SendMessage(stream, "true");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task HandleDangKy(NetworkStream stream)
        {
            string data_TK = await ReadStringFromStream(stream);
            string data_MK = await ReadStringFromStream(stream);
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = "INSERT INTO NguoiDung (TenDangNhap, MatKhau) VALUES (@TK, @MK)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TK", data_TK.Trim());
                        command.Parameters.AddWithValue("@MK", data_MK.Trim());
                        command.ExecuteNonQuery();
                        await SendMessage(stream, "true");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task HandleThongTinSK(NetworkStream stream)
        {
            SqlConnection conn = new SqlConnection { ConnectionString = connString };
            conn.Open();
            string CMD_SK = "select * from SuKien";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(CMD_SK, conn);
            DataSet dataSet_SK = new DataSet();
            dataAdapter.Fill(dataSet_SK);
            string CMD_TenND = "SELECT s.TenSuKien, u.TenDangNhap AS TenNguoiTao FROM Sukien s JOIN NguoiDung u ON s.NguoiTao = u.MaNguoiDung;";
            SqlDataAdapter dataAdapter_TenND = new SqlDataAdapter(CMD_TenND, conn);
            DataSet dataSet_ND = new DataSet();
            dataAdapter_TenND.Fill(dataSet_ND);
            conn.Close();

            int SLSK = dataSet_SK.Tables[0].Rows.Count;
            await SendMessage(stream, SLSK.ToString());
            for (int i = 0; i < dataSet_SK.Tables[0].Rows.Count; i++)
            {
                string ID_SK = dataSet_SK.Tables[0].Rows[i][0].ToString();
                string Ten_SK = dataSet_SK.Tables[0].Rows[i][1].ToString();
                string Ngay_SK = dataSet_SK.Tables[0].Rows[i][2].ToString();
                string DiaDiem_SK = dataSet_SK.Tables[0].Rows[i][3].ToString();
                string MoTa_SK = dataSet_SK.Tables[0].Rows[i][4].ToString();
                string NgTao_SK = dataSet_ND.Tables[0].Rows[i][1].ToString();

                await SendMessage(stream, ID_SK);
                await SendMessage(stream, Ten_SK);
                await SendMessage(stream, Ngay_SK);
                await SendMessage(stream, DiaDiem_SK);
                await SendMessage(stream, MoTa_SK);
                await SendMessage(stream, NgTao_SK);
            }
        }

        private async Task HandleDangKySK(NetworkStream stream)
        {
            string data_username = await ReadStringFromStream(stream);
            string data_query = await ReadStringFromStream(stream);
            string cmd_query;
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = @ID_username;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_username", data_username.Trim());
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataSet dataSet1 = new DataSet();
                        dataAdapter.Fill(dataSet1);
                        cmd_query = $"{data_query}{int.Parse(dataSet1.Tables[0].Rows[0][0].ToString())})";
                    }
                }
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(cmd_query, connection))
                    {
                        command.ExecuteNonQuery();
                        await SendMessage(stream, "true");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task HandleQuanLySK(NetworkStream stream)
        {
            string data_username = await ReadStringFromStream(stream);
            string cmd_query;
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = @username;";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", data_username.Trim());
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataSet dataSet1 = new DataSet();
                        dataAdapter.Fill(dataSet1);
                        cmd_query = $"SELECT * FROM Sukien WHERE NguoiTao = {int.Parse(dataSet1.Tables[0].Rows[0][0].ToString())};";
                    }
                }
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(cmd_query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        int SLSK = dataSet.Tables[0].Rows.Count;
                        await SendMessage(stream, SLSK.ToString());
                        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        {
                            await SendMessage(stream, dataSet.Tables[0].Rows[i][0].ToString());
                            await SendMessage(stream, dataSet.Tables[0].Rows[i][1].ToString());
                            await SendMessage(stream, dataSet.Tables[0].Rows[i][2].ToString());
                            await SendMessage(stream, dataSet.Tables[0].Rows[i][3].ToString());
                            await SendMessage(stream, dataSet.Tables[0].Rows[i][4].ToString());
                            await SendMessage(stream, data_username);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            while (true)
            {
                string Data_QL = await ReadStringFromStream(stream);
                if (Data_QL.Trim() == "sua")
                {
                    string Data_Query = await ReadStringFromStream(stream);
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(Data_Query, connection))
                            {
                                command.ExecuteNonQuery();
                                await SendMessage(stream, "true");
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                if (Data_QL.Trim() == "xoa")
                {
                    string Data_Query = await ReadStringFromStream(stream);
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(Data_Query, connection))
                            {
                                command.ExecuteNonQuery();
                                await SendMessage(stream, "true");
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                if (Data_QL.Trim() == "gui")
                {
                    string Data_NameSK = await ReadStringFromStream(stream);
                    string query = $"DECLARE @TenSuKien NVARCHAR(100) = N'{Data_NameSK.Trim()}'; " +
                                   $"WITH EventUsers AS (SELECT DISTINCT yct.MaNguoiDung FROM YeuCauThamGia yct INNER JOIN SuKien s ON yct.MaSuKien = s.MaSuKien WHERE s.TenSuKien = @TenSuKien " +
                                   $"UNION SELECT DISTINCT mts.MaNguoiDung FROM MoiThamGiaSuKien mts INNER JOIN SuKien s ON mts.MaSuKien = s.MaSuKien WHERE s.TenSuKien = @TenSuKien) " +
                                   $"SELECT n.TenDangNhap AS TenNguoiDung FROM NguoiDung n LEFT JOIN EventUsers ON n.MaNguoiDung = EventUsers.MaNguoiDung WHERE EventUsers.MaNguoiDung IS NULL;";
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);
                            int SLND = dataSet.Tables[0].Rows.Count;
                            await SendMessage(stream, SLND.ToString());
                            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                            {
                                await SendMessage(stream, dataSet.Tables[0].Rows[i][0].ToString());
                            }
                        }
                    }
                }
                if (Data_QL.Trim() == "GuiLoiMoi")
                {
                    string Data_SLGui = await ReadStringFromStream(stream);
                    int SLGui = int.Parse(Data_SLGui.Trim());
                    string[] Query = new string[SLGui];
                    for (int i = 0; i < SLGui; i++)
                    {
                        Query[i] = await ReadStringFromStream(stream);
                    }
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();
                        for (int i = 0; i < SLGui; i++)
                        {
                            using (SqlCommand command = new SqlCommand(Query[i], connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                        await SendMessage(stream, "true");
                    }
                }
            }
        }

        private async Task HandleDanhSachMoi(NetworkStream stream)
        {
            string Data_Username = await ReadStringFromStream(stream);
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT sk.TenSuKien FROM SuKien sk JOIN NguoiDung nd ON sk.NguoiTao = nd.MaNguoiDung WHERE nd.TenDangNhap = @username;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", Data_Username.Trim());
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataSet dataSet1 = new DataSet();
                    dataAdapter.Fill(dataSet1);
                    int SLSK = dataSet1.Tables[0].Rows.Count;
                    await SendMessage(stream, SLSK.ToString());
                    for (int i = 0; i < dataSet1.Tables[0].Rows.Count; i++)
                    {
                        await SendMessage(stream, dataSet1.Tables[0].Rows[i][0].ToString());
                    }
                }
            }
            while (true)
            {
                string Data_NameSK = await ReadStringFromStream(stream);
                string query_TTSK = "";
                if (Data_NameSK.Trim() == "Done")
                {
                    string Data_Query = await ReadStringFromStream(stream);
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(Data_Query, connection))
                            {
                                command.ExecuteNonQuery();
                                await SendMessage(stream, "true");
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                using (SqlConnection connection_IDSK = new SqlConnection(connString))
                {
                    connection_IDSK.Open();
                    string query_IDSK = "SELECT MaSuKien FROM SuKien WHERE TenSuKien = @NameSK;";
                    using (SqlCommand command_IDSK = new SqlCommand(query_IDSK, connection_IDSK))
                    {
                        command_IDSK.Parameters.AddWithValue("@NameSK", Data_NameSK.Trim());
                        SqlDataAdapter dataAdapter_IDSK = new SqlDataAdapter(command_IDSK);
                        DataSet dataSet_IDSK = new DataSet();
                        dataAdapter_IDSK.Fill(dataSet_IDSK);
                        query_TTSK = $"SELECT nd.TenDangNhap, sk.TenSuKien, yctg.TrangThai FROM NguoiDung nd JOIN YeuCauThamGia yctg ON nd.MaNguoiDung = yctg.MaNguoiDung JOIN SuKien sk ON yctg.MaSuKien = sk.MaSuKien WHERE sk.MaSuKien = {int.Parse(dataSet_IDSK.Tables[0].Rows[0][0].ToString())} AND yctg.TrangThai = N'Đang chờ';";
                    }
                }
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command_TTSK = new SqlCommand(query_TTSK, connection))
                    {
                        SqlDataAdapter dataAdapter_TTSK = new SqlDataAdapter(command_TTSK);
                        DataSet dataSet_TTSK = new DataSet();
                        dataAdapter_TTSK.Fill(dataSet_TTSK);
                        int SLYC = dataSet_TTSK.Tables[0].Rows.Count;
                        await SendMessage(stream, SLYC.ToString());
                        for (int i = 0; i < SLYC; i++)
                        {
                            await SendMessage(stream, dataSet_TTSK.Tables[0].Rows[i][0].ToString());
                            await SendMessage(stream, dataSet_TTSK.Tables[0].Rows[i][1].ToString());
                            await SendMessage(stream, dataSet_TTSK.Tables[0].Rows[i][2].ToString());
                        }
                    }
                }
            }
        }

        private async Task HandleMoiThamGiaSK(NetworkStream stream)
        {
            string Data_NameUS = await ReadStringFromStream(stream);
            string query = $"SELECT s.TenSuKien, s.ThoiDiem, s.DiaDiem, s.MoTa, t.TenDangNhap AS TenNguoiTao FROM SuKien s JOIN MoiThamGiaSuKien m ON s.MaSuKien = m.MaSuKien JOIN NguoiDung n ON m.MaNguoiDung = n.MaNguoiDung LEFT JOIN NguoiDung t ON s.NguoiTao = t.MaNguoiDung WHERE n.TenDangNhap = N'{Data_NameUS.Trim()}' AND m.TrangThai = N'Đang chờ';";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    int SLKS = dataSet.Tables[0].Rows.Count;
                    await SendMessage(stream, SLKS.ToString());
                    for (int i = 0; i < SLKS; i++)
                    {
                        await SendMessage(stream, dataSet.Tables[0].Rows[i][0].ToString());
                        await SendMessage(stream, dataSet.Tables[0].Rows[i][1].ToString());
                        await SendMessage(stream, dataSet.Tables[0].Rows[i][2].ToString());
                        await SendMessage(stream, dataSet.Tables[0].Rows[i][3].ToString());
                        await SendMessage(stream, dataSet.Tables[0].Rows[i][4].ToString());
                    }
                }
            }
            while (true)
            {
                string Data_KQ = await ReadStringFromStream(stream);
                if (Data_KQ.Trim() == "dongy" || Data_KQ.Trim() == "tuchoi")
                {
                    string Data_Query = await ReadStringFromStream(stream);
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(Data_Query, connection))
                            {
                                command.ExecuteNonQuery();
                                await SendMessage(stream, "true");
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private async Task HandleQuanLyNTG(NetworkStream stream)
        {
            string Data_Username = await ReadStringFromStream(stream);
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT sk.TenSuKien FROM SuKien sk JOIN NguoiDung nd ON sk.NguoiTao = nd.MaNguoiDung WHERE nd.TenDangNhap = @username;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", Data_Username.Trim());
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataSet dataSet1 = new DataSet();
                    dataAdapter.Fill(dataSet1);
                    int SLSK = dataSet1.Tables[0].Rows.Count;
                    await SendMessage(stream, SLSK.ToString());
                    for (int i = 0; i < dataSet1.Tables[0].Rows.Count; i++)
                    {
                        await SendMessage(stream, dataSet1.Tables[0].Rows[i][0].ToString());
                    }
                }
            }
            while (true)
            {
                string Data_NameSK = await ReadStringFromStream(stream);
                using (SqlConnection connection_IDSK = new SqlConnection(connString))
                {
                    connection_IDSK.Open();
                    string query_IDSK = $"SELECT DISTINCT n.TenDangNhap AS TenNguoiThamGia FROM NguoiDung n JOIN (SELECT m.MaNguoiDung FROM MoiThamGiaSuKien m WHERE m.MaSuKien = (SELECT MaSuKien FROM SuKien WHERE TenSuKien = N'{Data_NameSK.Trim()}') AND m.TrangThai = N'Đã chấp nhận' UNION SELECT y.MaNguoiDung FROM YeuCauThamGia y WHERE y.MaSuKien = (SELECT MaSuKien FROM SuKien WHERE TenSuKien = N'{Data_NameSK.Trim()}') AND y.TrangThai = N'Đã chấp nhận') AS tmp ON n.MaNguoiDung = tmp.MaNguoiDung;";
                    using (SqlCommand command_IDSK = new SqlCommand(query_IDSK, connection_IDSK))
                    {
                        SqlDataAdapter dataAdapter_IDSK = new SqlDataAdapter(command_IDSK);
                        DataSet dataSet_IDSK = new DataSet();
                        dataAdapter_IDSK.Fill(dataSet_IDSK);
                        int SLYC = dataSet_IDSK.Tables[0].Rows.Count;
                        await SendMessage(stream, SLYC.ToString());
                        for (int i = 0; i < dataSet_IDSK.Tables[0].Rows.Count; i++)
                        {
                            await SendMessage(stream, dataSet_IDSK.Tables[0].Rows[i][0].ToString());
                        }
                    }
                }
            }
        }

        private async Task<string> ReadStringFromStream(NetworkStream stream)
        {
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytesRead);
        }

        private async Task SendMessage(NetworkStream stream, string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message + Environment.NewLine);
            await stream.WriteAsync(buffer, 0, buffer.Length);
        }

        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(this, message);
        }
    }
}