﻿using Microsoft.VisualBasic;
using NAudio.Wave;
using Simple_Screen_Recorder.AudioComp;
using Simple_Screen_Recorder.Langs;
using Simple_Screen_Recorder.Properties;
using Simple_Screen_Recorder.ScreenRecorderWin;
using Simple_Screen_Recorder.UI;
using SocketIOClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;

using System.Text;
using Windows.ApplicationModel.Appointments;
using Windows.Media.Protection.PlayReady;
using Quobject.SocketIoClientDotNet.Client;

using Application = System.Windows.Forms.Application;
using Socket = Quobject.SocketIoClientDotNet.Client.Socket;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Simple_Screen_Recorder
{
    public partial class RecorderScreenMainWindow
    {
        private const string DateFormat = "MM-dd-yyyy.HH.mm.ss";
        private DateTime TimeRec = DateTime.MinValue;
        private string VideoName = "";
        private Boolean login = false;
        public int ProcessId { get; private set; }
        public static int user_id { get; internal set; }
        public static Socket socket = IO.Socket("https://nodetoolapi.adayroi.online");
        public static string ResourcePath = Path.Combine(Directory.GetCurrentDirectory(), @"FFmpegResources\ffmpeg");

        public RecorderScreenMainWindow()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                dynamic dataPost = new JObject();
                dataPost.user_id = user_id;
                socket.Emit("staff-app-win-user-online", dataPost);
            });

            socket.On("hi", (data) =>
            {
                Console.WriteLine(data);
                socket.Disconnect();
            });
            Console.ReadLine();



            this.KeyPreview = true;

            GetTextsMain();

            ScreenAudioMic.OpenComp();
            ComboBoxMicrophone.DataSource = ScreenAudioMic.cboDIspositivos.DataSource;
            ScreenAudioDesktop.OpenComp();
            ComboBoxSpeaker.DataSource = ScreenAudioDesktop.cboDIspositivos.DataSource;

            comboBoxCodec.Items.AddRange(new[] { "MPEG-4", "H264 NVENC (Nvidia Graphics Cards)", "H264 AMF (AMD Graphics Cards)" });
            comboBoxCodec.SelectedIndex = 0;

            comboBoxFps.Items.AddRange(new[] { "30", "60" });
            comboBoxFps.SelectedIndex = 1;

            ComboBoxFormat.Items.AddRange(new[] { ".avi", ".mkv" });
            ComboBoxFormat.SelectedIndex = 0;

            CheckMonitors();

        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            var format = ComboBoxFormat.SelectedItem.ToString();
            VideoName = $"Video.{DateTime.Now.ToString(DateFormat)}.{format.TrimStart('.')}";
            LbTimer.ForeColor = Color.IndianRed;
            TimeRec = DateTime.Now;
            CountRecVideo.Enabled = true;

            if (RadioTwoTrack.Checked == true)
            {
                //RecMic();
                RecSpeaker();
            }
            else if (RadioDesktop.Checked == true)
            {
                RecSpeaker();
            }
            else
            {
                //RecMic();
            }

            VideoCodecs();
        }

        private void CheckMonitors()
        {
            var monitorNames = Screen.AllScreens.Select((screen, index) =>
            {
                var prefix = screen.Primary ? "Main monitor" : $"Monitor {index + 1}";
                return $"{prefix} ({screen.Bounds.Width}x{screen.Bounds.Height})";
            }).ToArray();

            comboBoxMonitors.DataSource = monitorNames;
            comboBoxMonitors.SelectedIndex = 0;
        }

        private void RefreshMonitors_Click(object sender, EventArgs e)
        {
            CheckMonitors();
        }

        private void VideoCodecs()
        {
            if (CheckBoxAllMonitors.Checked == true)
            {
                switch (comboBoxCodec.SelectedItem)
                {
                    case "MPEG-4":
                        {
                            int fps = int.Parse((string)comboBoxFps.SelectedItem);
                            ProcessStartInfo ProcessId = new("cmd.exe", $"/c {ResourcePath} -f gdigrab -framerate " + fps + " -show_region 1 -i desktop -c:v mpeg4 -b:v 10000k Recordings/" + VideoName + "");
                            ProcessId.WindowStyle = ProcessWindowStyle.Hidden;
                            ProcessId.CreateNoWindow = true;
                            ProcessId.RedirectStandardOutput = true;
                            Process.Start(ProcessId);

                            DisableElementsVideoRecordings();
                            break;
                        }

                    case "H264 NVENC (Nvidia Graphics Cards)":
                        {
                            int fps = int.Parse((string)comboBoxFps.SelectedItem);
                            ProcessStartInfo ProcessId = new("cmd.exe", $"/c {ResourcePath} -f gdigrab -framerate " + fps + " -show_region 1 -i desktop -c:v h264_nvenc -qp 0 Recordings/" + VideoName + "");
                            ProcessId.WindowStyle = ProcessWindowStyle.Hidden;
                            ProcessId.CreateNoWindow = true;
                            ProcessId.RedirectStandardOutput = true;
                            Process.Start(ProcessId);

                            DisableElementsVideoRecordings();
                            break;
                        }

                    case "H264 AMF (AMD Graphics Cards)":
                        {
                            int fps = int.Parse((string)comboBoxFps.SelectedItem);
                            ProcessStartInfo ProcessId = new("cmd.exe", $"/c {ResourcePath} -f gdigrab -framerate " + fps + " -show_region 1 -i desktop -c:v h264_amf -qp 0 Recordings/" + VideoName + "");
                            ProcessId.WindowStyle = ProcessWindowStyle.Hidden;
                            ProcessId.CreateNoWindow = true;
                            ProcessId.RedirectStandardOutput = true;
                            Process.Start(ProcessId);

                            DisableElementsVideoRecordings();
                            break;
                        }
                }

            }
            else
            {
                switch (comboBoxCodec.SelectedItem)
                {
                    case "MPEG-4":
                        {
                            Screen selectedScreen = Screen.AllScreens[comboBoxMonitors.SelectedIndex];
                            Rectangle bounds = selectedScreen.Bounds;
                            string getScreen = string.Format("-f gdigrab -framerate {0} -offset_x {1} -offset_y {2} -video_size {3}x{4} -show_region 1 -i desktop -c:v mpeg4 -b:v 10000k Recordings/{5}", comboBoxFps.SelectedItem, bounds.Left, bounds.Top, bounds.Width, bounds.Height, VideoName);
                            ProcessStartInfo ProcessId = new("cmd.exe", $"/c {ResourcePath} " + getScreen);
                            ProcessId.WindowStyle = ProcessWindowStyle.Hidden;
                            ProcessId.CreateNoWindow = true;
                            ProcessId.RedirectStandardOutput = true;
                            Process.Start(ProcessId);

                            DisableElementsVideoRecordings();
                            break;
                        }

                    case "H264 NVENC (Nvidia Graphics Cards)":
                        {
                            Screen selectedScreen = Screen.AllScreens[comboBoxMonitors.SelectedIndex];
                            Rectangle bounds = selectedScreen.Bounds;
                            string getScreen = string.Format("-f gdigrab -framerate {0} -offset_x {1} -offset_y {2} -video_size {3}x{4} -show_region 1 -i desktop -c:v h264_nvenc -qp 0 Recordings/{5}", comboBoxFps.SelectedItem, bounds.Left, bounds.Top, bounds.Width, bounds.Height, VideoName);
                            ProcessStartInfo ProcessId = new("cmd.exe", $"/c {ResourcePath} " + getScreen);
                            ProcessId.WindowStyle = ProcessWindowStyle.Hidden;
                            ProcessId.CreateNoWindow = true;
                            ProcessId.RedirectStandardOutput = true;
                            Process.Start(ProcessId);

                            DisableElementsVideoRecordings();
                            break;
                        }

                    case "H264 AMF (AMD Graphics Cards)":
                        {
                            Screen selectedScreen = Screen.AllScreens[comboBoxMonitors.SelectedIndex];
                            Rectangle bounds = selectedScreen.Bounds;
                            string getScreen = string.Format("-f gdigrab -framerate {0} -offset_x {1} -offset_y {2} -video_size {3}x{4} -show_region 1 -i desktop -c:v h264_amf -qp 0 Recordings/{5}", comboBoxFps.SelectedItem, bounds.Left, bounds.Top, bounds.Width, bounds.Height, VideoName);
                            ProcessStartInfo ProcessId = new("cmd.exe", $"/c {ResourcePath} " + getScreen);
                            ProcessId.WindowStyle = ProcessWindowStyle.Hidden;
                            ProcessId.CreateNoWindow = true;
                            ProcessId.RedirectStandardOutput = true;
                            Process.Start(ProcessId);

                            DisableElementsVideoRecordings();
                            break;
                        }
                }
            }

        }

        private void DisableElementsVideoRecordings()
        {
            comboBoxMonitors.Enabled = false;
            btnStartRecording.Enabled = false;
            ComboBoxMicrophone.Enabled = false;
            ComboBoxSpeaker.Enabled = false;
            comboBoxCodec.Enabled = false;
            comboBoxFps.Enabled = false;
            RadioTwoTrack.Enabled = false;
            RadioDesktop.Enabled = false;
            radioMicrophone.Enabled = false;
            CheckBoxAllMonitors.Enabled = false;
            ComboBoxFormat.Enabled = false;
            RefreshMonitors.Enabled = false;
            menuStrip1.Enabled = false;
        }

        private void StopRec()
        {
            btnStartRecording.Enabled = true;
            comboBoxCodec.Enabled = true;
            ComboBoxMicrophone.Enabled = true;
            ComboBoxSpeaker.Enabled = true;
            comboBoxMonitors.Enabled = true;
            RadioTwoTrack.Enabled = true;
            RadioDesktop.Enabled = true;
            radioMicrophone.Enabled = true;
            comboBoxFps.Enabled = true;
            CheckBoxAllMonitors.Enabled = true;
            ComboBoxFormat.Enabled = true;
            RefreshMonitors.Enabled = true;
            menuStrip1.Enabled = true;

            if (RadioTwoTrack.Checked == true)
            {
                if (ScreenAudioMic.waveIn is object)
                {
                    ScreenAudioMic.waveIn.StopRecording();
                }

                if (ScreenAudioDesktop.waveIn is object)
                {
                    ScreenAudioDesktop.waveIn.StopRecording();
                }
            }
            else if (ScreenAudioDesktop.waveIn is object)
            {
                ScreenAudioDesktop.waveIn.StopRecording();
            }
            else if (ScreenAudioMic.waveIn is object)
            {
                ScreenAudioMic.waveIn.StopRecording();
            }

            var soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.Stop();

            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == "ffmpeg")
                {
                    proceso.Kill();
                }
            }

            Process proc = Process.GetProcessById(ProcessId);
            proc.Kill();
        }

        private static void RecMic()
        {
            ScreenAudioMic.Cleanup();
            ScreenAudioMic.CreateWaveInDevice();
            ScreenAudioMic.outputFilename = "MicrophoneAudio." + Strings.Format(DateTime.Now, "MM-dd-yyyy.HH.mm.ss") + ".wav";
            ScreenAudioMic.writer = new WaveFileWriter(Path.Combine(ScreenAudioMic.outputFolder, ScreenAudioMic.outputFilename), ScreenAudioMic.waveIn.WaveFormat);
            ScreenAudioMic.waveIn.StartRecording();
        }

        private static void RecSpeaker()
        {
            ScreenAudioDesktop.Cleanup();
            ScreenAudioDesktop.CreateWaveInDevice();

            var soundPlayer = new System.Media.SoundPlayer(Properties.Resources.Background);
            soundPlayer.PlayLooping();

            ScreenAudioDesktop.outputFilename = "SystemAudio." + Strings.Format(DateTime.Now, "MM-dd-yyyy.HH.mm.ss") + ".wav";
            ScreenAudioDesktop.writer = new WaveFileWriter(Path.Combine(ScreenAudioDesktop.outputFolder, ScreenAudioDesktop.outputFilename), ScreenAudioDesktop.waveIn.WaveFormat);
            ScreenAudioDesktop.waveIn.StartRecording();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                LbTimer.ForeColor = Color.White;
                LbTimer.Text = "00:00:00";
                CountRecVideo.Enabled = false;
                StopRec();

            }
            catch (Exception)
            {
                return;
            }

        }

        private void mergeVideoDesktopAndMicAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MergeAllForm NewMergeVDM = new();
            NewMergeVDM.Show();
        }

        private void mergeVideoAndDesktopAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MergeVideoAudioForm NewMergeVD = new();
            NewMergeVD.Show();
        }

        private void audioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AudioRecorderMainWindow NewAudioRecording = new();
            NewAudioRecording.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm NewAbout = new();
            NewAbout.ShowDialog();
        }

        private void RecorderScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void btnOutputRecordings_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "Recordings");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (btnStartRecording.Enabled == false)
            {
                System.Windows.MessageBox.Show(StringsEN.message2, "Error");
            }
            else
            {
                Application.Exit();
            }
        }

        #region TranslationCode

        private void GetTextsMain()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Languages);
            aboutToolStripMenuItem.Text = StringsEN.aboutToolStripMenuItem;
            BtnExit.Text = StringsEN.BtnExit;
            btnStartRecording.Text = StringsEN.btnStartRecording;
            BtnStop.Text = StringsEN.BtnStop;
            Label4.Text = StringsEN.Label4;
            Label5.Text = StringsEN.Label5;
            label6.Text = StringsEN.Label6;
            label7.Text = StringsEN.Label7;
            languagesToolStripMenuItem.Text = StringsEN.languagesToolStripMenuItem;
            mergeVideoAndDesktopAudioToolStripMenuItem.Text = StringsEN.mergeVideoAndDesktopAudioToolStripMenuItem;
            mergeVideoDesktopAndMicAudioToolStripMenuItem.Text = StringsEN.mergeVideoDesktopAndMicAudioToolStripMenuItem;
            RadioDesktop.Text = StringsEN.RadioDesktop;
            RadioTwoTrack.Text = StringsEN.RadioTwoTrack;
            remuxToolStripMenuItem.Text = StringsEN.remuxToolStripMenuItem;
            btnOutputRecordings.Text = StringsEN.btnOutputRecordings;
            labelCodec.Text = StringsEN.labelCodec;
            crownGroupBox1.Text = StringsEN.crownGroupBox1;
            crownGroupBox2.Text = StringsEN.crownGroupBox2;
            crownGroupBox3.Text = StringsEN.crownGroupBox3;
            audioToolStripMenuItem.Text = StringsEN.audioToolStripMenuItem;
            radioMicrophone.Text = StringsEN.radioMicrophone;
            labelFps.Text = StringsEN.labelFps;
            CheckBoxAllMonitors.Text = StringsEN.CheckBoxAllMonitors;
            labelFormat.Text = StringsEN.labelFormat;
            labelMonitorSelector.Text = StringsEN.labelMonitorSelector;
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Languages = "es-ES";
            GetTextsMain();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Languages = "en-US";
            GetTextsMain();
        }

        private void 中文简体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Languages = "zh-CN";
            GetTextsMain();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings.Default.Languages = "pt-BR";
            GetTextsMain();
        }

        private void italianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Languages = "it-IT";
            GetTextsMain();
        }

        private void ukranianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Languages = "uk-UA";
            GetTextsMain();
        }

        private void 日本語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Languages = "ja-JP";
            GetTextsMain();
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Languages = "de-DE";
            GetTextsMain();
        }

        #endregion

        private void RecorderScreenMainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnStartRecording.Enabled == true && e.KeyCode == Keys.F9)
            {
                btnStartRecording.PerformClick();
            }
            else if (e.KeyCode == Keys.F9)
            {
                BtnStop.PerformClick();
            }

            if (e.KeyCode == Keys.F10)
            {
                btnOutputRecordings.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                BtnExit.PerformClick();
            }

        }

        private void CheckBoxAllMonitors_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAllMonitors.Checked)
            {
                comboBoxMonitors.Enabled = false;
            }
            else
            {
                comboBoxMonitors.Enabled = true;
            }
        }

        private void CountRecVideo_Tick(object sender, EventArgs e)
        {
            var Difference = DateTime.Now.Subtract(TimeRec);
            LbTimer.Text = "Rec: " + Difference.Hours.ToString().PadLeft(2, '0') + ":" + Difference.Minutes.ToString().PadLeft(2, '0') + ":" + Difference.Seconds.ToString().PadLeft(2, '0');
        }

        private void btn_test_send_Click(object sender, EventArgs e)
        {
        }
    }
}