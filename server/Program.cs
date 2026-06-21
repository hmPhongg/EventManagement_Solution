using System;
using System.Windows.Forms;

namespace server
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // ✅ Đảm bảo tên Form ở đây khớp với tên class trong Form1.cs
            Application.Run(new Form1());
        }
    }
}