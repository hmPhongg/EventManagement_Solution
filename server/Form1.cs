using System;
using System.Windows.Forms;

namespace server
{
    public partial class Form1 : Form
    {
        private server Server;
        private bool IsServerRunning = false;

        public Form1()
        {
            InitializeComponent();
            Server = new server(System.Net.IPAddress.Any.ToString());
            if (!IsServerRunning)
            {
                try
                {
                    _ = Server.Start();
                    Server.MessageReceived += Server_MessageReceived;
                    IsServerRunning = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Server_MessageReceived(object sender, string message)
        {
            richTextBox1.Invoke((MethodInvoker)(() =>
            {
                richTextBox1.AppendText(message + Environment.NewLine);
            }));
        }
    }
}