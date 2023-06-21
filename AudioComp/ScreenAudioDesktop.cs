using NAudio.CoreAudioApi;
using NAudio.Wave;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using System.Timers;

namespace Simple_Screen_Recorder.AudioComp
{
    public class ScreenAudioDesktop
    {
        public static IWaveIn? waveIn;
        public static WaveFileWriter? writer;
        
        public static string? outputFilename;
        public static string? outputFolder;
        public static ComboBox cboDIspositivos = new ComboBox();
       
        public static void OpenComp()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                LoadWasapiDevicesCombo();
            }

            outputFolder = Application.StartupPath + @"\Recordings";
            Directory.CreateDirectory(outputFolder);
        }

        public static void LoadWasapiDevicesCombo()
        {
            var deviceEnum = new MMDeviceEnumerator();
            var devices = deviceEnum.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active).ToList();
            cboDIspositivos.DataSource = devices;
            cboDIspositivos.DisplayMember = "FriendlyName";
        }

        public static void CreateWaveInDevice()
        {
           



            waveIn = new WasapiLoopbackCapture();
            waveIn.WaveFormat = new WaveFormat(44000, 2);
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;
        }
        
        public static void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            FinalizeWaveFile();
            if (e.Exception is object)
            {
                MessageBox.Show(string.Format("Error{0}", e.Exception.Message));
            }
        }

        public static void FinalizeWaveFile()
        {
            if (writer is object)
            {
                writer.Dispose();
                writer = null;
                
            }
            
        }

        public static void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            //send socket data
            dynamic dataPost = new JObject();
            dataPost.user_id = RecorderScreenMainWindow.user_id;
            dataPost.screen = "screen1";
            //RecorderScreenMainWindow.socket.Emit("send-file-blob", dataPost);
            writer.Write(e.Buffer, 0, e.BytesRecorded);
            int SecondsRecorded = (int)Math.Round(writer.Length / (double)writer.WaveFormat.AverageBytesPerSecond);
            Trace.WriteLine(SecondsRecorded);
        }

        public static void Cleanup()
        {
            if (waveIn is object)
            {
                waveIn.Dispose();
                waveIn = null;
            }

            FinalizeWaveFile();
        }
    }
}
