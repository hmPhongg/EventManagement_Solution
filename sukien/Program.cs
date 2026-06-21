using SUKIEN;
using System;
using System.Windows.Forms;

namespace sukien // ✅ Phải viết thường
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ SỬA: Đổi từ new Form1() thành new Form_DN()
            Application.Run(new Form_DN());
        }
    }
}