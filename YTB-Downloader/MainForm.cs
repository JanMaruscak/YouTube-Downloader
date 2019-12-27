using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTB_Downloader
{
    // key = AIzaSyB9cFP7RXIkOLsKIeRVUH01N7rmvF6tn60 
    public partial class MainForm : Form
    {
        public bool VideoExists = false;
        public string LastVideoInfoUrl = "";
        string ProgramDirectory = Path.GetPathRoot(Environment.SystemDirectory) + "YTB-Downloader";
        string DownloadPath = Path.GetPathRoot(Environment.SystemDirectory) + "YTB-Downloader";
        public static Manager Manager = new Manager();
        public MainForm()
        {
            InitializeComponent();
            quality_cmbBox.SelectedIndex = 1;
            format_cmbBox.SelectedIndex = 0;
            exit_pBox.Image = Image.FromFile($"{Directory.GetCurrentDirectory()}\\Icons\\cross white.png");
            programTitle_label.MouseDown += navbar_panel_MouseDown;

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = $"/c cd {ProgramDirectory} & youtube-dl --update";
            p.Start();

            Methods.Load();
            if (!string.IsNullOrWhiteSpace(Manager.Directory) && Directory.Exists(Manager.Directory))
            {
                DownloadPath = Manager.Directory;
                downloadPath_label.Text = Manager.Directory;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void download_btn_Click(object sender, EventArgs ea)
        {
            download_btn.Enabled = false;

            log_txt.Text = "Download started";
            download_progBar.Value = 0;
            Thread thread = new Thread(DownloadThread);
            thread.Start();
        }
        public void DownloadThread(Object stateInfo)
        {
            if (string.IsNullOrWhiteSpace(userLink_txt.Text))
            {
                return;
            }
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = $"/c cd {ProgramDirectory} & youtube-dl "; // youtube-dl init
            p.StartInfo.Arguments += $"-o {DownloadPath}/%(title)s.%(ext)s "; // output path; + title and extension in file name
            string qualityArg = "";

            string qualityText = "";
            quality_cmbBox.Invoke((MethodInvoker)delegate
            {
                qualityText = quality_cmbBox.SelectedItem.ToString();
            });
            switch (qualityText)
            {
                case "Best Possible":
                    qualityArg = "-f bestvideo+bestaudio";
                    break;
                case "1080p":
                    qualityArg = "-f \"bestvideo[height<=1080]+bestaudio/best[height<=1080]\"";
                    break;
                case "720p":
                    qualityArg = "-f \"bestvideo[height<=720]+bestaudio/best[height<=720]\"";
                    break;
                case "480p":
                    qualityArg = "-f \"bestvideo[height<=480]+bestaudio/best[height<=480]\"";
                    break;
                case "360p":
                    qualityArg = "-f \"bestvideo[height<=360]+bestaudio/best[height<=360]\"";
                    break;
                case "240p":
                    qualityArg = "-f \"bestvideo[height<=240]+bestaudio/best[height<=240]\"";
                    break;
                case "144p":
                    qualityArg = "-f \"bestvideo[height<=144]+bestaudio/best[height<=144]\"";
                    break;
                case "Audio only":
                    break;
                case "4k":
                    qualityArg = "-f \"bestvideo[height<=2160]+bestaudio/best[height<=2160]\"";
                    break;
                case "2k":
                    qualityArg = "-f \"bestvideo[height<=1440]+bestaudio/best[height<=1440]\"";
                    break;
                default:
                    qualityArg = "";
                    break;
            }
            p.StartInfo.Arguments += qualityArg + " "; // video and audio quality
            //////if (format_cmbBox.SelectedItem.ToString() != "Default")
            //////{
            //////    p.StartInfo.Arguments += $"--recode-video {format_cmbBox.SelectedItem.ToString()}";
            //////}
            p.StartInfo.Arguments += " " + userLink_txt.Text; // finally adding users video link


            p.Start();
            p.BeginOutputReadLine();

            int usedLines = 0;
            string lastInput = null;
            List<string> wholeCMDOutput = new List<string>();
            string[] lines;
            float percentageMax = 25;
            float percentageUsed = 0;

            p.OutputDataReceived += new DataReceivedEventHandler(
                (s, e) =>
                {
                    string currentInput = e.Data;
                    if (e.Data != null && e.Data.Contains("[download] Destination"))
                    {
                        percentageMax = 50;
                           currentInput = currentInput.Replace("[download] Destination: ", "");

                        log_txt.Invoke((MethodInvoker)delegate
                        {
                            if (usedLines != 0)
                                log_txt.Text += Environment.NewLine;
                            log_txt.Text += Environment.NewLine;
                            lines = log_txt.Lines;
                            lines[lines.Length - 1] = currentInput;
                            log_txt.Lines = lines;
                        });
                        lastInput = e.Data;
                    }
                    else if (e.Data != null && e.Data.Contains("[download] "))
                    {
                        percentageMax = 70;
                        if (usedLines != 0)
                        {
                            currentInput = currentInput.Replace("[download] ", "");

                            log_txt.Invoke((MethodInvoker)delegate
                            {
                                if (lastInput != null && lastInput.Contains("[download] Destination"))
                                    log_txt.Text += Environment.NewLine;
                                lines = log_txt.Lines;
                                if (lines.Length > 0)
                                    lines[lines.Length - 1] = currentInput;
                                if (lines != null && lines.Length != 0)
                                    log_txt.Lines = lines;
                            });
                        }

                        lastInput = e.Data;
                    }
                    else if(e.Data != null && e.Data.Contains("[ffmpeg] "))
                    {
                        percentageMax = 100;
                           currentInput = currentInput.Replace("[ffmpeg] ", "");

                        log_txt.Invoke((MethodInvoker)delegate
                        {
                            if (usedLines != 0)
                                log_txt.Text += Environment.NewLine;
                            log_txt.Text += Environment.NewLine;
                            lines = log_txt.Lines;
                            lines[lines.Length - 1] = currentInput;
                            log_txt.Lines = lines;
                        });
                        lastInput = e.Data;
                    }

                    if(percentageUsed <= percentageMax)
                    {
                        percentageUsed += 2;
                        download_progBar.Invoke((MethodInvoker)delegate
                        {
                            download_progBar.Value = (int)percentageUsed;
                        });
                    }
                    usedLines++;

                });

            p.WaitForExit();

            download_progBar.Invoke((MethodInvoker)delegate
            {
                download_progBar.Value = 100;
            });

            log_txt.Invoke((MethodInvoker)delegate
            {
                log_txt.Text += Environment.NewLine + Environment.NewLine + "DONE";
                download_btn.Enabled = true;
            });
        }

        private void install_btn_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(ProgramDirectory);
            Process.Start(ProgramDirectory);

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://youtube-dl.org/downloads/latest/youtube-dl.exe", ProgramDirectory + "\\youtube-dl.exe");
                wc.DownloadFile("https://ffmpeg.zeranoe.com/builds/win64/static/ffmpeg-20191223-5b42d33-win64-static.zip", ProgramDirectory + "\\FFmpeg.zip");
            }

            if (!Directory.Exists(ProgramDirectory + "\\FFmpeg"))
            {
                ZipFile.ExtractToDirectory(ProgramDirectory + "\\FFmpeg.zip", ProgramDirectory + "\\FFmpeg");
            }
            File.Delete(ProgramDirectory + "\\FFmpeg.zip");

            Process p = new Process();
            p.StartInfo.UseShellExecute = true; // prej true nevim
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = $"/c setx /M PATH \"{ProgramDirectory}\\FFmpeg\\ffmpeg-20191223-5b42d33-win64-static\\bin;%PATH%\"";
            p.StartInfo.Verb = "runas";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
        }

        private void getInfo_btn_Click(object sender, EventArgs e) 
        {
            SetInfo();
        }

        private void userLink_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SetInfo();
            }
        }
        public bool SetInfo()
        {
            try
            {
                string url = userLink_txt.Text.Split('=')[1];
                var result = Youtube.GetVideoInfo(url).Result;
                title_label.Text = result.items[0].snippet.title;
                author_label.Text = result.items[0].snippet.channelTitle;
                thumbnail_pBox.ImageLocation = (result.items[0].snippet.thumbnails.high.url);

                Thread thread = new Thread(SetQualities);
                thread.Start();

                VideoExists = true;
                LastVideoInfoUrl = userLink_txt.Text;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void thumbnail_pBox_Click(object sender, EventArgs e)
        {
            if (VideoExists && !string.IsNullOrWhiteSpace(LastVideoInfoUrl))
            {
                Process.Start(LastVideoInfoUrl);
            }
        }

        private void downloadPath_btn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = ProgramDirectory;
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    DownloadPath = fbd.SelectedPath;
                    Manager.Directory = DownloadPath;
                    Methods.Save();
                    downloadPath_label.Text = DownloadPath;
                }
            }
        }

        private void quality_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Focus();
        }
        List<string> LastOutput = new List<string>();
        public void SetQualities()
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = $"/c cd {ProgramDirectory} & youtube-dl -F {userLink_txt.Text} ";

            p.StartInfo.RedirectStandardOutput = true;

            LastOutput.Clear();

            p.Start();
            //p.BeginOutputReadLine();


            //p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            //{
            //    LastOutput.Add(e.Data);
            //    log_txt.Invoke((MethodInvoker)delegate {
            //        log_txt.Text += Environment.NewLine + e.Data;
            //    });
            //});
            //p.WaitForExit();

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void navbar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Drag formy
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exit_pBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void downloadPath_label_Click(object sender, EventArgs e)
        {
            Process.Start(downloadPath_label.Text);
        }
    }
}
