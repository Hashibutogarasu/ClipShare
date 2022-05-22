using ClipShare.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipShare {
    public partial class ClipShare : Form {

        public static string recieved_text = "";
        private string ipaddress;
        private int Port = 810;
        private string Password_Guid = Guid.NewGuid().ToString().Replace("-","");
        private string Password = Properties.Settings.Default.Password;
        private bool Server_running = false;
        private TCPLocalServer server;
        private string pass = "";

        public ClipShare() {
            InitializeComponent();

            ServerNoticeIcon.Visible = true;

            ipaddress = GetIpAddress();
            ServerIPBox.Text = $"{ipaddress}:{Port}";

            PasswordCheck.Checked = Properties.Settings.Default.ResetPassword;
            
            if (PasswordCheck.Checked) {
                PasswordBox.Text = Password;
                pass = Password;
            }
            else {
                PasswordBox.Text = Password_Guid;
                pass = Password_Guid;
                Properties.Settings.Default.Password = Password_Guid;
                Properties.Settings.Default.Save();
            }

            Action task = async()=> {
                await Start();
            };

            Action formUpdate = async () => {
                await FormUpdate();
            };

            Task.Run(task);
            Task.Run(formUpdate);
        }

        public async Task Start() {

            try {
                server = TCPLocalServer.RunServer(ipaddress, Port, pass.ToString().Replace("-", ""));
                Server_running = true;
            }
            catch {
                Server_running = false;
            }

            await Task.CompletedTask;
        }

        public async Task FormUpdate() {

            while (true) {
                try {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NowClipBox.Text = Clipboard.GetText();
                        RecievedClipBox.Text = recieved_text;

                        if (Server_running) {
                            StatusLabel.ForeColor = Color.Green;
                            StatusLabel.Text = "起動中";
                            ServerOnOffButton.Text = "サーバーを停止する";
                        }
                        else {
                            StatusLabel.ForeColor = Color.Red;
                            StatusLabel.Text = "未起動";
                            ServerOnOffButton.Text = "サーバーを起動する";
                        }
                    }));

                    await Task.Delay(100);
                }
                catch {

                }
                
            }
        }

        private void RecievedClipBox_TextChanged(object sender, EventArgs e) {
            Clipboard.SetText(RecievedClipBox.Text);
        }

        private void ServerOnOffButton_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            try {
                if (button.Text == "サーバーを起動する" && server != null) {
                    Task.Run(() => server = TCPLocalServer.RunServer(ipaddress, Port, pass.ToString().Replace("-", "")));
                    button.Text = "サーバーを停止する";
                    Server_running = true;
                }
                else if (button.Text == "サーバーを停止する" && server != null) {
                    button.Text = "サーバーを起動する";
                    server.StopServer();
                    Server_running = false;
                }
            }
            catch {

            }
        }

        private string GetIpAddress() {
            //IPアドレス
            string addr_ip;

            try {
                //ホスト名を取得
                string hostname = System.Net.Dns.GetHostName();

                //ホスト名からIPアドレスを取得
                System.Net.IPAddress[] addr_arr = System.Net.Dns.GetHostAddresses(hostname);

                //探す
                addr_ip = "";
                foreach (System.Net.IPAddress addr in addr_arr) {
                    string addr_str = addr.ToString();

                    //IPv4 && localhostでない
                    if (addr_str.IndexOf(".") > 0 && !addr_str.StartsWith("172.")) {
                        addr_ip = addr_str;
                        break;
                    }
                }
            }
            catch (Exception) {
                addr_ip = "";
            }

            return addr_ip;
        }

        private void PasswordCheck_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkbox = (CheckBox)sender;

            Properties.Settings.Default.ResetPassword = checkbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void ClopShareClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void ShowItem_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Normal;
            this.Visible = true;
            this.ShowInTaskbar = true;
        }

        private void CloseItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
