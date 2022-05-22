using ClipShare.JsonModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ClipShare.Server {
    class TCPLocalServer {
        private static TcpListener tcpListener;
        public bool IsRunning { get; set; }

        private TCPLocalServer() {

        }

        public static TCPLocalServer RunServer(string IpAdress, int Port, string pass) {

            TCPLocalServer tcplocalserver = new TCPLocalServer();

            tcpListener = new TcpListener(IPAddress.Parse(IpAdress), Port);
            tcpListener.Start();

            tcplocalserver.IsRunning = true;

            Trace.WriteLine($"{IpAdress}:{Port} Password : {pass} でサーバーを開始しました");

            Task.Run(async () => {
                while (true) {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    await Task.Run(async () => {
                        using (NetworkStream stream = tcpClient.GetStream())
                        using (StreamReader reader = new StreamReader(stream))
                        using (StreamWriter writer = new StreamWriter(stream)) {

                            List<string> requestHeaders = new List<string>();

                            while (true) {
                                string line = await reader.ReadLineAsync();
                                if (String.IsNullOrWhiteSpace(line)) {
                                    break;
                                }
                                requestHeaders.Add(line);
                            }

                            string requestLine = requestHeaders.FirstOrDefault();
                            string[] requestParts = requestLine?.Split(new[] { ' ' }, 3);
                            if (!requestHeaders.Any() || requestParts.Length != 3) {
                                await writer.WriteLineAsync("HTTP/1.0 400 Bad Request");
                                await writer.WriteLineAsync("Content-Type: text/plain; charset=UTF-8");
                                await writer.WriteLineAsync();
                                await writer.WriteLineAsync("Bad Request");
                                return;
                            }

                            string path = requestParts[1];

                            string decoded_path = HttpUtility.UrlDecode(path, Encoding.GetEncoding("UTF-8"));
                            string decoded_requestLine = HttpUtility.UrlDecode(requestLine, Encoding.GetEncoding("UTF-8"));

                            Uri uri = new Uri($"http://{IpAdress}:{Port}{decoded_path}");

                            string Password = HttpUtility.ParseQueryString(uri.Query).Get("Password");
                            string Text = HttpUtility.ParseQueryString(uri.Query).Get("Text");

                            Trace.WriteLine(uri);

                            Trace.WriteLine($"Password:{Password}\nText:{Text}");

                            if (Password == pass) {

                                Trace.WriteLine("Password OK.");

                                ClipShare.recieved_text = Text;

                                await writer.WriteLineAsync("HTTP/1.0 200 OK");
                                await writer.WriteLineAsync("Content-Type: text/plain; charset=UTF-8");
                                await writer.WriteLineAsync();
                                await writer.WriteLineAsync($"OK : {Text}");

                                return;
                            }
                            else {

                                Trace.WriteLine("Password NG.");

                                await writer.WriteLineAsync("HTTP/1.0 400 Bad Request");
                                await writer.WriteLineAsync("Content-Type: text/plain; charset=UTF-8");
                                await writer.WriteLineAsync();
                                await writer.WriteLineAsync("Bad Request");
                            }

                            return;
                        }
                    });
                }
            });
            
            return tcplocalserver;
        }

        public void StopServer() {
            if(tcpListener != null) {
                tcpListener.Stop();
            }
        }
    }
}
