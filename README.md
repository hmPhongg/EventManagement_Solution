# 📅 Event Management System

## 📖 Giới thiệu
Ứng dụng quản lý sự kiện được xây dựng theo mô hình **Client-Server** sử dụng giao thức **TCP/IP** và **Windows Sockets (Winsock)** trong ngôn ngữ **C#** với **Windows Forms**.

Ứng dụng cho phép người dùng:
- Đăng ký và đăng nhập tài khoản
- Tạo, quản lý sự kiện
- Gửi lời mời tham gia sự kiện
- Quản lý yêu cầu tham gia
- Theo dõi danh sách người tham gia

## ✨ Tính năng chính

### 👤 Client
- **Đăng nhập / Đăng ký**: Xác thực người dùng với kiểm tra ký tự tiếng Việt
- **Xem sự kiện**: Danh sách tất cả sự kiện có sẵn
- **Tạo sự kiện**: Tạo sự kiện mới với thời gian, địa điểm, mô tả
- **Tham gia sự kiện**: Gửi yêu cầu tham gia sự kiện
- **Quản lý sự kiện**: Sửa, xóa sự kiện đã tạo
- **Quản lý lời mời**: Chấp nhận/từ chối lời mời tham gia
- **Quản lý đơn yêu cầu**: Duyệt yêu cầu tham gia của người khác
- **Quản lý người tham gia**: Xem danh sách người tham gia sự kiện

### 🖥️ Server
- **TCP Listener**: Lắng nghe kết nối từ nhiều client cùng lúc
- **Xử lý bất đồng bộ**: Sử dụng `async/await` để xử lý đa luồng
- **Quản lý database**: Thực hiện các thao tác CRUD với SQL Server
- **Logging**: Ghi lại nhật ký kết nối và yêu cầu từ client

## ️ Công nghệ sử dụng

- **Ngôn ngữ**: C# (.NET Framework 4.7.2)
- **Giao diện**: Windows Forms (WinForms)
- **Mạng**: TCP/IP Sockets (`System.Net.Sockets`)
- **Database**: SQL Server (LocalDB)
- **IDE**: Visual Studio 2022
- **Kiến trúc**: Client-Server, Multi-threading

## 📂 Cấu trúc dự án
EventManagement_Solution/
├── server/ # Project Server
│ ├── Form1.cs # Giao diện Server
│ ├── Form1.Designer.cs
│ └── Server.cs # Logic TCP Listener & Database
├── client/ # Project Client
│ ├── Client.cs # Class kết nối TCP Client
│ ├── Form_DN.cs # Form đăng nhập
│ ├── Form_DK.cs # Form đăng ký
│ ├── Form_TrangChu.cs # Form trang chủ
│ ├── Form_TaoSuKien.cs # Form tạo sự kiện
│ ├── Form_QLSuKien.cs # Form quản lý sự kiện
│ ├── Form_DonYeuCau.cs # Form đơn yêu cầu
│ ├── Form_Loi_moi.cs # Form lời mời
│ ├── Form_QLNTG.cs # Form quản lý người tham gia
│ └── SUKIEN.cs # Data models
├── database/
│ └── init.sql # Script khởi tạo database
├── .gitignore
└── README.md

## 🚀 Hướng dẫn cài đặt và chạy

### Yêu cầu
- Visual Studio 2022 (với workload .NET desktop development)
- SQL Server (hoặc SQL Server LocalDB)

### Các bước thực hiện

#### 1. Khởi tạo Database
1. Mở **SQL Server Management Studio** hoặc **SQL Server Object Explorer** trong Visual Studio
2. Tạo database mới tên `QuanLySuKien`
3. Chạy file `database/init.sql` để tạo các bảng

#### 2. Cấu hình Connection String
Mở file `server/Server.cs`, sửa dòng connection string:
```csharp
public string connString = @"Data Source=TÊN_MÁY_CỦA_BẠN;Initial Catalog=QuanLySuKien;User Id=sa;Password=123456;TrustServerCertificate=True";
```

4. Nhấn **Ctrl + S** để lưu.

---

## 🔧 BƯỚC 3: Cài đặt Git (nếu chưa có)

1. Tải Git từ: https://git-scm.com/download/win
2. Cài đặt với các tùy chọn mặc định
3. Khởi động lại Visual Studio

---

## 📤 BƯỚC 4: Tạo repository trên GitHub

1. Truy cập: https://github.com
2. Đăng nhập tài khoản
3. Click nút **New** (hoặc dấu **+** ở góc trên phải → **New repository**)
4. Điền thông tin:
   - **Repository name**: `EventManagement-System` (hoặc tên bạn muốn)
   - **Description**: `Ứng dụng quản lý sự kiện - Client/Server TCP/IP`
   - Chọn **Public** (để mọi người xem được)
   - **KHÔNG** tick vào "Add a README file" (vì bạn đã có README.md rồi)
5. Nhấn **Create repository**
6. **Copy URL** của repository (ví dụ: `https://github.com/username/EventManagement-System.git`)

---

## 💻 BƯỚC 5: Đẩy code lên GitHub

### Cách 1: Dùng Visual Studio (Dễ nhất)

1. Trong Visual Studio, nhìn góc dưới bên phải, click vào **Add to Source Control** → **Git...**
2. Chọn **Create Git Repository**
3. Chọn **GitHub** ở phần Remote
4. Đăng nhập GitHub nếu được yêu cầu
5. Dán URL repository bạn vừa tạo
6. Nhấn **Create and Push**

### Cách 2: Dùng Git Bash (Khuyên dùng)

1. Mở **Git Bash** (hoặc Terminal trong Visual Studio)
2. Điều hướng đến thư mục dự án:
   ```bash
   cd "C:\Users\Admin\Desktop\Baitap Kythuatdohoamaytinh\EventManagement_Solution"

   # Khởi tạo git repository
git init

# Thêm tất cả file (trừ những file trong .gitignore)
git add .

# Commit lần đầu
git commit -m "Initial commit: Event Management System"

# Kết nối với GitHub repository
git remote add origin https://github.com/USERNAME/EventManagement-System.git

# Đẩy code lên GitHub
git push -u origin master