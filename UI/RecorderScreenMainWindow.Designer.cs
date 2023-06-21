using Timer = System.Windows.Forms.Timer;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Screen_Recorder
{
    [DesignerGenerated()]
    public partial class RecorderScreenMainWindow : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecorderScreenMainWindow));
            BtnStop = new Button();
            btnStartRecording = new Button();
            LbTimer = new Label();
            Label5 = new Label();
            Label4 = new Label();
            CountRecVideo = new Timer(components);
            label6 = new Label();
            label7 = new Label();
            BtnExit = new Button();
            menuStrip1 = new MenuStrip();
            remuxToolStripMenuItem = new ToolStripMenuItem();
            mergeVideoDesktopAndMicAudioToolStripMenuItem = new ToolStripMenuItem();
            mergeVideoAndDesktopAudioToolStripMenuItem = new ToolStripMenuItem();
            audioToolStripMenuItem = new ToolStripMenuItem();
            languagesToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            españolToolStripMenuItem = new ToolStripMenuItem();
            italianoToolStripMenuItem = new ToolStripMenuItem();
            deutschToolStripMenuItem = new ToolStripMenuItem();
            ukranianToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            中文简体ToolStripMenuItem = new ToolStripMenuItem();
            日本語ToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            btnOutputRecordings = new Button();
            labelCodec = new Label();
            comboBoxCodec = new ReaLTaiizor.Controls.CrownComboBox();
            RadioTwoTrack = new RadioButton();
            RadioDesktop = new RadioButton();
            crownGroupBox1 = new ReaLTaiizor.Controls.CrownGroupBox();
            RefreshMonitors = new ReaLTaiizor.Controls.CrownButton();
            labelMonitorSelector = new Label();
            comboBoxMonitors = new ReaLTaiizor.Controls.CrownComboBox();
            labelFormat = new Label();
            ComboBoxFormat = new ReaLTaiizor.Controls.CrownComboBox();
            CheckBoxAllMonitors = new ReaLTaiizor.Controls.CrownCheckBox();
            comboBoxFps = new ReaLTaiizor.Controls.CrownComboBox();
            labelFps = new Label();
            crownGroupBox2 = new ReaLTaiizor.Controls.CrownGroupBox();
            ComboBoxMicrophone = new ReaLTaiizor.Controls.CrownComboBox();
            ComboBoxSpeaker = new ReaLTaiizor.Controls.CrownComboBox();
            radioMicrophone = new RadioButton();
            crownGroupBox3 = new ReaLTaiizor.Controls.CrownGroupBox();
            btn_test_send = new Button();
            menuStrip1.SuspendLayout();
            crownGroupBox1.SuspendLayout();
            crownGroupBox2.SuspendLayout();
            crownGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // BtnStop
            // 
            BtnStop.BackColor = Color.FromArgb(64, 64, 64);
            BtnStop.FlatAppearance.BorderSize = 2;
            BtnStop.FlatAppearance.MouseDownBackColor = Color.DarkViolet;
            BtnStop.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
            BtnStop.FlatStyle = FlatStyle.Flat;
            BtnStop.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnStop.ForeColor = Color.Transparent;
            BtnStop.Image = Properties.Resources.stop_original;
            BtnStop.ImageAlign = ContentAlignment.MiddleLeft;
            BtnStop.Location = new Point(32, 147);
            BtnStop.Margin = new Padding(7, 6, 7, 6);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(760, 85);
            BtnStop.TabIndex = 2;
            BtnStop.Text = "Stop Recording";
            BtnStop.UseVisualStyleBackColor = false;
            BtnStop.Click += BtnStop_Click;
            // 
            // btnStartRecording
            // 
            btnStartRecording.BackColor = Color.FromArgb(64, 64, 64);
            btnStartRecording.FlatAppearance.BorderSize = 2;
            btnStartRecording.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnStartRecording.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnStartRecording.FlatStyle = FlatStyle.Flat;
            btnStartRecording.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartRecording.ForeColor = Color.Transparent;
            btnStartRecording.Image = Properties.Resources.record_button;
            btnStartRecording.ImageAlign = ContentAlignment.MiddleLeft;
            btnStartRecording.Location = new Point(32, 51);
            btnStartRecording.Margin = new Padding(7, 6, 7, 6);
            btnStartRecording.Name = "btnStartRecording";
            btnStartRecording.RightToLeft = RightToLeft.No;
            btnStartRecording.Size = new Size(371, 85);
            btnStartRecording.TabIndex = 1;
            btnStartRecording.Text = "Start Recording";
            btnStartRecording.UseVisualStyleBackColor = false;
            btnStartRecording.Click += btnStartRecording_Click;
            // 
            // LbTimer
            // 
            LbTimer.AutoSize = true;
            LbTimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbTimer.ForeColor = Color.White;
            LbTimer.Location = new Point(26, 1344);
            LbTimer.Margin = new Padding(7, 0, 7, 0);
            LbTimer.Name = "LbTimer";
            LbTimer.Size = new Size(146, 45);
            LbTimer.TabIndex = 29;
            LbTimer.Text = "00:00:00";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = SystemColors.Control;
            Label5.Location = new Point(30, 311);
            Label5.Margin = new Padding(7, 0, 7, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(428, 41);
            Label5.TabIndex = 6;
            Label5.Text = "System sound (Desktop Audio)";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = SystemColors.Control;
            Label4.Location = new Point(30, 420);
            Label4.Margin = new Padding(7, 0, 7, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(316, 41);
            Label4.TabIndex = 38;
            Label4.Text = "Microphone (Mic/Aux)";
            // 
            // CountRecVideo
            // 
            CountRecVideo.Tick += CountRecVideo_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(28, 47);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(366, 41);
            label6.TabIndex = 40;
            label6.Text = "Audio recording method";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(28, 265);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(214, 41);
            label7.TabIndex = 41;
            label7.Text = "Audio devices";
            // 
            // BtnExit
            // 
            BtnExit.FlatAppearance.BorderSize = 2;
            BtnExit.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.Transparent;
            BtnExit.Image = Properties.Resources.log_out_button;
            BtnExit.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExit.Location = new Point(605, 1327);
            BtnExit.Margin = new Padding(7, 6, 7, 6);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(251, 83);
            BtnExit.TabIndex = 11;
            BtnExit.Text = "    Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.WindowFrame;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { remuxToolStripMenuItem, audioToolStripMenuItem, languagesToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(888, 42);
            menuStrip1.TabIndex = 43;
            menuStrip1.Text = "menuStrip1";
            // 
            // remuxToolStripMenuItem
            // 
            remuxToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mergeVideoDesktopAndMicAudioToolStripMenuItem, mergeVideoAndDesktopAudioToolStripMenuItem });
            remuxToolStripMenuItem.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            remuxToolStripMenuItem.ForeColor = SystemColors.Control;
            remuxToolStripMenuItem.Name = "remuxToolStripMenuItem";
            remuxToolStripMenuItem.Size = new Size(211, 34);
            remuxToolStripMenuItem.Text = "Media merge tool";
            // 
            // mergeVideoDesktopAndMicAudioToolStripMenuItem
            // 
            mergeVideoDesktopAndMicAudioToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            mergeVideoDesktopAndMicAudioToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            mergeVideoDesktopAndMicAudioToolStripMenuItem.ForeColor = Color.Black;
            mergeVideoDesktopAndMicAudioToolStripMenuItem.Name = "mergeVideoDesktopAndMicAudioToolStripMenuItem";
            mergeVideoDesktopAndMicAudioToolStripMenuItem.Size = new Size(497, 44);
            mergeVideoDesktopAndMicAudioToolStripMenuItem.Text = "Merge all media";
            mergeVideoDesktopAndMicAudioToolStripMenuItem.Click += mergeVideoDesktopAndMicAudioToolStripMenuItem_Click;
            // 
            // mergeVideoAndDesktopAudioToolStripMenuItem
            // 
            mergeVideoAndDesktopAudioToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            mergeVideoAndDesktopAudioToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            mergeVideoAndDesktopAudioToolStripMenuItem.ForeColor = Color.Black;
            mergeVideoAndDesktopAudioToolStripMenuItem.Name = "mergeVideoAndDesktopAudioToolStripMenuItem";
            mergeVideoAndDesktopAudioToolStripMenuItem.Size = new Size(497, 44);
            mergeVideoAndDesktopAudioToolStripMenuItem.Text = "Merge video and only one audio file";
            mergeVideoAndDesktopAudioToolStripMenuItem.Click += mergeVideoAndDesktopAudioToolStripMenuItem_Click;
            // 
            // audioToolStripMenuItem
            // 
            audioToolStripMenuItem.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            audioToolStripMenuItem.ForeColor = SystemColors.Control;
            audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            audioToolStripMenuItem.Size = new Size(183, 34);
            audioToolStripMenuItem.Text = "Audio recorder";
            audioToolStripMenuItem.Click += audioToolStripMenuItem_Click;
            // 
            // languagesToolStripMenuItem
            // 
            languagesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, españolToolStripMenuItem, italianoToolStripMenuItem, deutschToolStripMenuItem, ukranianToolStripMenuItem, toolStripMenuItem1, 中文简体ToolStripMenuItem, 日本語ToolStripMenuItem });
            languagesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            languagesToolStripMenuItem.ForeColor = SystemColors.Control;
            languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            languagesToolStripMenuItem.Size = new Size(139, 34);
            languagesToolStripMenuItem.Text = "Languages";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            englishToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            englishToolStripMenuItem.ForeColor = SystemColors.Control;
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(331, 44);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // españolToolStripMenuItem
            // 
            españolToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            españolToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            españolToolStripMenuItem.ForeColor = SystemColors.Control;
            españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            españolToolStripMenuItem.Size = new Size(331, 44);
            españolToolStripMenuItem.Text = "Español";
            españolToolStripMenuItem.Click += españolToolStripMenuItem_Click;
            // 
            // italianoToolStripMenuItem
            // 
            italianoToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            italianoToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            italianoToolStripMenuItem.ForeColor = SystemColors.Control;
            italianoToolStripMenuItem.Name = "italianoToolStripMenuItem";
            italianoToolStripMenuItem.Size = new Size(331, 44);
            italianoToolStripMenuItem.Text = "Italiano";
            italianoToolStripMenuItem.Click += italianoToolStripMenuItem_Click;
            // 
            // deutschToolStripMenuItem
            // 
            deutschToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            deutschToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            deutschToolStripMenuItem.ForeColor = SystemColors.Control;
            deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            deutschToolStripMenuItem.Size = new Size(331, 44);
            deutschToolStripMenuItem.Text = "Deutsch";
            deutschToolStripMenuItem.Click += deutschToolStripMenuItem_Click;
            // 
            // ukranianToolStripMenuItem
            // 
            ukranianToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            ukranianToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ukranianToolStripMenuItem.ForeColor = SystemColors.Control;
            ukranianToolStripMenuItem.Name = "ukranianToolStripMenuItem";
            ukranianToolStripMenuItem.Size = new Size(331, 44);
            ukranianToolStripMenuItem.Text = "Українська";
            ukranianToolStripMenuItem.Click += ukranianToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = SystemColors.WindowFrame;
            toolStripMenuItem1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.ForeColor = SystemColors.Control;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(331, 44);
            toolStripMenuItem1.Text = "Português do Brasil";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // 中文简体ToolStripMenuItem
            // 
            中文简体ToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            中文简体ToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            中文简体ToolStripMenuItem.ForeColor = SystemColors.Control;
            中文简体ToolStripMenuItem.Name = "中文简体ToolStripMenuItem";
            中文简体ToolStripMenuItem.Size = new Size(331, 44);
            中文简体ToolStripMenuItem.Text = "中文(简体)";
            中文简体ToolStripMenuItem.Click += 中文简体ToolStripMenuItem_Click;
            // 
            // 日本語ToolStripMenuItem
            // 
            日本語ToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            日本語ToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            日本語ToolStripMenuItem.ForeColor = SystemColors.Control;
            日本語ToolStripMenuItem.Name = "日本語ToolStripMenuItem";
            日本語ToolStripMenuItem.Size = new Size(331, 44);
            日本語ToolStripMenuItem.Text = "日本語";
            日本語ToolStripMenuItem.Click += 日本語ToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            aboutToolStripMenuItem.ForeColor = SystemColors.Control;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(95, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // btnOutputRecordings
            // 
            btnOutputRecordings.BackColor = Color.FromArgb(64, 64, 64);
            btnOutputRecordings.FlatAppearance.BorderSize = 2;
            btnOutputRecordings.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnOutputRecordings.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnOutputRecordings.FlatStyle = FlatStyle.Flat;
            btnOutputRecordings.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOutputRecordings.ForeColor = Color.Transparent;
            btnOutputRecordings.Image = Properties.Resources.folder_button;
            btnOutputRecordings.ImageAlign = ContentAlignment.MiddleLeft;
            btnOutputRecordings.Location = new Point(32, 243);
            btnOutputRecordings.Margin = new Padding(7, 6, 7, 6);
            btnOutputRecordings.Name = "btnOutputRecordings";
            btnOutputRecordings.Size = new Size(760, 85);
            btnOutputRecordings.TabIndex = 10;
            btnOutputRecordings.Text = " Open Recordings Folder";
            btnOutputRecordings.UseVisualStyleBackColor = false;
            btnOutputRecordings.Click += btnOutputRecordings_Click;
            // 
            // labelCodec
            // 
            labelCodec.AutoSize = true;
            labelCodec.BackColor = Color.Transparent;
            labelCodec.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodec.ForeColor = Color.Crimson;
            labelCodec.Location = new Point(414, 162);
            labelCodec.Margin = new Padding(7, 0, 7, 0);
            labelCodec.Name = "labelCodec";
            labelCodec.Size = new Size(131, 41);
            labelCodec.TabIndex = 46;
            labelCodec.Text = "Encoder";
            // 
            // comboBoxCodec
            // 
            comboBoxCodec.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxCodec.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCodec.FormattingEnabled = true;
            comboBoxCodec.Location = new Point(420, 211);
            comboBoxCodec.Margin = new Padding(6, 6, 6, 6);
            comboBoxCodec.Name = "comboBoxCodec";
            comboBoxCodec.Size = new Size(368, 40);
            comboBoxCodec.TabIndex = 4;
            // 
            // RadioTwoTrack
            // 
            RadioTwoTrack.AutoSize = true;
            RadioTwoTrack.BackColor = Color.Transparent;
            RadioTwoTrack.Checked = true;
            RadioTwoTrack.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadioTwoTrack.ForeColor = SystemColors.Control;
            RadioTwoTrack.Location = new Point(46, 96);
            RadioTwoTrack.Margin = new Padding(7, 6, 7, 6);
            RadioTwoTrack.Name = "RadioTwoTrack";
            RadioTwoTrack.Size = new Size(558, 45);
            RadioTwoTrack.TabIndex = 7;
            RadioTwoTrack.TabStop = true;
            RadioTwoTrack.Text = "System sounds and microphone audio";
            RadioTwoTrack.UseVisualStyleBackColor = false;
            // 
            // RadioDesktop
            // 
            RadioDesktop.AutoSize = true;
            RadioDesktop.BackColor = Color.Transparent;
            RadioDesktop.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadioDesktop.ForeColor = SystemColors.Control;
            RadioDesktop.Location = new Point(46, 149);
            RadioDesktop.Margin = new Padding(7, 6, 7, 6);
            RadioDesktop.Name = "RadioDesktop";
            RadioDesktop.Size = new Size(516, 45);
            RadioDesktop.TabIndex = 53;
            RadioDesktop.TabStop = true;
            RadioDesktop.Text = "System audio only (Desktop Audio)";
            RadioDesktop.UseVisualStyleBackColor = false;
            // 
            // crownGroupBox1
            // 
            crownGroupBox1.BorderColor = Color.Gray;
            crownGroupBox1.Controls.Add(RefreshMonitors);
            crownGroupBox1.Controls.Add(labelMonitorSelector);
            crownGroupBox1.Controls.Add(comboBoxMonitors);
            crownGroupBox1.Controls.Add(labelFormat);
            crownGroupBox1.Controls.Add(ComboBoxFormat);
            crownGroupBox1.Controls.Add(CheckBoxAllMonitors);
            crownGroupBox1.Controls.Add(comboBoxFps);
            crownGroupBox1.Controls.Add(labelFps);
            crownGroupBox1.Controls.Add(labelCodec);
            crownGroupBox1.Controls.Add(comboBoxCodec);
            crownGroupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            crownGroupBox1.Location = new Point(30, 410);
            crownGroupBox1.Margin = new Padding(6, 6, 6, 6);
            crownGroupBox1.Name = "crownGroupBox1";
            crownGroupBox1.Padding = new Padding(6, 6, 6, 6);
            crownGroupBox1.Size = new Size(826, 352);
            crownGroupBox1.TabIndex = 55;
            crownGroupBox1.TabStop = false;
            crownGroupBox1.Text = "Video settings";
            // 
            // RefreshMonitors
            // 
            RefreshMonitors.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshMonitors.Image = Properties.Resources.refresh;
            RefreshMonitors.Location = new Point(358, 96);
            RefreshMonitors.Margin = new Padding(6, 6, 6, 6);
            RefreshMonitors.Name = "RefreshMonitors";
            RefreshMonitors.Padding = new Padding(9, 11, 9, 11);
            RefreshMonitors.Size = new Size(45, 51);
            RefreshMonitors.TabIndex = 13;
            RefreshMonitors.Click += RefreshMonitors_Click;
            // 
            // labelMonitorSelector
            // 
            labelMonitorSelector.AutoSize = true;
            labelMonitorSelector.BackColor = Color.Transparent;
            labelMonitorSelector.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonitorSelector.ForeColor = Color.Crimson;
            labelMonitorSelector.Location = new Point(28, 47);
            labelMonitorSelector.Margin = new Padding(7, 0, 7, 0);
            labelMonitorSelector.Name = "labelMonitorSelector";
            labelMonitorSelector.Size = new Size(252, 41);
            labelMonitorSelector.TabIndex = 54;
            labelMonitorSelector.Text = "Monitor selector";
            // 
            // comboBoxMonitors
            // 
            comboBoxMonitors.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxMonitors.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMonitors.FormattingEnabled = true;
            comboBoxMonitors.Location = new Point(32, 96);
            comboBoxMonitors.Margin = new Padding(6, 6, 6, 6);
            comboBoxMonitors.Name = "comboBoxMonitors";
            comboBoxMonitors.Size = new Size(314, 40);
            comboBoxMonitors.TabIndex = 3;
            // 
            // labelFormat
            // 
            labelFormat.AutoSize = true;
            labelFormat.BackColor = Color.Transparent;
            labelFormat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFormat.ForeColor = Color.Crimson;
            labelFormat.Location = new Point(414, 47);
            labelFormat.Margin = new Padding(7, 0, 7, 0);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new Size(173, 41);
            labelFormat.TabIndex = 52;
            labelFormat.Text = "File format";
            // 
            // ComboBoxFormat
            // 
            ComboBoxFormat.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxFormat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxFormat.FormattingEnabled = true;
            ComboBoxFormat.Location = new Point(420, 96);
            ComboBoxFormat.Margin = new Padding(6, 6, 6, 6);
            ComboBoxFormat.Name = "ComboBoxFormat";
            ComboBoxFormat.Size = new Size(368, 40);
            ComboBoxFormat.TabIndex = 5;
            // 
            // CheckBoxAllMonitors
            // 
            CheckBoxAllMonitors.AutoSize = true;
            CheckBoxAllMonitors.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBoxAllMonitors.Location = new Point(35, 282);
            CheckBoxAllMonitors.Margin = new Padding(6, 6, 6, 6);
            CheckBoxAllMonitors.Name = "CheckBoxAllMonitors";
            CheckBoxAllMonitors.Size = new Size(319, 45);
            CheckBoxAllMonitors.TabIndex = 6;
            CheckBoxAllMonitors.Text = "Capture all monitors";
            CheckBoxAllMonitors.CheckedChanged += CheckBoxAllMonitors_CheckedChanged;
            // 
            // comboBoxFps
            // 
            comboBoxFps.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxFps.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFps.FormattingEnabled = true;
            comboBoxFps.Location = new Point(32, 211);
            comboBoxFps.Margin = new Padding(6, 6, 6, 6);
            comboBoxFps.Name = "comboBoxFps";
            comboBoxFps.Size = new Size(368, 40);
            comboBoxFps.TabIndex = 6;
            // 
            // labelFps
            // 
            labelFps.AutoSize = true;
            labelFps.BackColor = Color.Transparent;
            labelFps.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFps.ForeColor = Color.Crimson;
            labelFps.Location = new Point(26, 162);
            labelFps.Margin = new Padding(7, 0, 7, 0);
            labelFps.Name = "labelFps";
            labelFps.Size = new Size(247, 41);
            labelFps.TabIndex = 50;
            labelFps.Text = "Video framerate";
            // 
            // crownGroupBox2
            // 
            crownGroupBox2.BorderColor = Color.Gray;
            crownGroupBox2.Controls.Add(ComboBoxMicrophone);
            crownGroupBox2.Controls.Add(ComboBoxSpeaker);
            crownGroupBox2.Controls.Add(radioMicrophone);
            crownGroupBox2.Controls.Add(label6);
            crownGroupBox2.Controls.Add(Label4);
            crownGroupBox2.Controls.Add(RadioTwoTrack);
            crownGroupBox2.Controls.Add(Label5);
            crownGroupBox2.Controls.Add(RadioDesktop);
            crownGroupBox2.Controls.Add(label7);
            crownGroupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            crownGroupBox2.Location = new Point(30, 764);
            crownGroupBox2.Margin = new Padding(6, 6, 6, 6);
            crownGroupBox2.Name = "crownGroupBox2";
            crownGroupBox2.Padding = new Padding(6, 6, 6, 6);
            crownGroupBox2.Size = new Size(826, 550);
            crownGroupBox2.TabIndex = 56;
            crownGroupBox2.TabStop = false;
            crownGroupBox2.Text = "Audio settings";
            // 
            // ComboBoxMicrophone
            // 
            ComboBoxMicrophone.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxMicrophone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxMicrophone.FormattingEnabled = true;
            ComboBoxMicrophone.Location = new Point(33, 469);
            ComboBoxMicrophone.Margin = new Padding(6, 6, 6, 6);
            ComboBoxMicrophone.Name = "ComboBoxMicrophone";
            ComboBoxMicrophone.Size = new Size(756, 40);
            ComboBoxMicrophone.TabIndex = 6;
            // 
            // ComboBoxSpeaker
            // 
            ComboBoxSpeaker.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxSpeaker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxSpeaker.FormattingEnabled = true;
            ComboBoxSpeaker.Location = new Point(33, 361);
            ComboBoxSpeaker.Margin = new Padding(6, 6, 6, 6);
            ComboBoxSpeaker.Name = "ComboBoxSpeaker";
            ComboBoxSpeaker.Size = new Size(756, 40);
            ComboBoxSpeaker.TabIndex = 5;
            // 
            // radioMicrophone
            // 
            radioMicrophone.AutoSize = true;
            radioMicrophone.BackColor = Color.Transparent;
            radioMicrophone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioMicrophone.ForeColor = SystemColors.Control;
            radioMicrophone.Location = new Point(46, 205);
            radioMicrophone.Margin = new Padding(7, 6, 7, 6);
            radioMicrophone.Name = "radioMicrophone";
            radioMicrophone.Size = new Size(359, 45);
            radioMicrophone.TabIndex = 55;
            radioMicrophone.TabStop = true;
            radioMicrophone.Text = "Microphone audio only";
            radioMicrophone.UseVisualStyleBackColor = false;
            // 
            // crownGroupBox3
            // 
            crownGroupBox3.BorderColor = Color.Gray;
            crownGroupBox3.Controls.Add(btn_test_send);
            crownGroupBox3.Controls.Add(btnOutputRecordings);
            crownGroupBox3.Controls.Add(btnStartRecording);
            crownGroupBox3.Controls.Add(BtnStop);
            crownGroupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            crownGroupBox3.Location = new Point(30, 55);
            crownGroupBox3.Margin = new Padding(6, 6, 6, 6);
            crownGroupBox3.Name = "crownGroupBox3";
            crownGroupBox3.Padding = new Padding(6, 6, 6, 6);
            crownGroupBox3.Size = new Size(826, 350);
            crownGroupBox3.TabIndex = 56;
            crownGroupBox3.TabStop = false;
            crownGroupBox3.Text = "Controls";
            // 
            // btn_test_send
            // 
            btn_test_send.Location = new Point(435, 51);
            btn_test_send.Margin = new Padding(6, 6, 6, 6);
            btn_test_send.Name = "btn_test_send";
            btn_test_send.Size = new Size(175, 83);
            btn_test_send.TabIndex = 11;
            btn_test_send.Text = "Test send";
            btn_test_send.UseVisualStyleBackColor = true;
            btn_test_send.Click += btn_test_send_Click;
            // 
            // RecorderScreenMainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(888, 1425);
            Controls.Add(crownGroupBox3);
            Controls.Add(crownGroupBox2);
            Controls.Add(crownGroupBox1);
            Controls.Add(BtnExit);
            Controls.Add(LbTimer);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "RecorderScreenMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Screen Recorder";
            FormClosed += RecorderScreenForm_FormClosed;
            Load += Form1_Load;
            KeyDown += RecorderScreenMainWindow_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            crownGroupBox1.ResumeLayout(false);
            crownGroupBox1.PerformLayout();
            crownGroupBox2.ResumeLayout(false);
            crownGroupBox2.PerformLayout();
            crownGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button BtnStop;
        internal Button btnStartRecording;
        internal Label LbTimer;
        internal Label Label5;
        internal Label Label4;
        internal Timer CountRecVideo;
        internal Label label6;
        internal Label label7;
        internal Button BtnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem remuxToolStripMenuItem;
        private ToolStripMenuItem mergeVideoAndDesktopAudioToolStripMenuItem;
        private ToolStripMenuItem mergeVideoDesktopAndMicAudioToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem languagesToolStripMenuItem;
        private ToolStripMenuItem españolToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem 中文简体ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem italianoToolStripMenuItem;
        internal Button btnOutputRecordings;
        internal Label labelCodec;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxCodec;
        internal RadioButton RadioTwoTrack;
        internal RadioButton RadioDesktop;
        private ReaLTaiizor.Controls.CrownGroupBox crownGroupBox1;
        private ReaLTaiizor.Controls.CrownGroupBox crownGroupBox2;
        private ReaLTaiizor.Controls.CrownGroupBox crownGroupBox3;
        private ToolStripMenuItem audioToolStripMenuItem;
        internal RadioButton radioMicrophone;
        private ToolStripMenuItem ukranianToolStripMenuItem;
        internal Label labelFps;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxFps;
        private ReaLTaiizor.Controls.CrownCheckBox CheckBoxAllMonitors;
        private ReaLTaiizor.Controls.CrownComboBox ComboBoxFormat;
        internal Label labelFormat;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxMonitors;
        internal Label labelMonitorSelector;
        private ToolStripMenuItem 日本語ToolStripMenuItem;
        private ToolStripMenuItem deutschToolStripMenuItem;
        private ReaLTaiizor.Controls.CrownButton RefreshMonitors;
        private ReaLTaiizor.Controls.CrownComboBox ComboBoxMicrophone;
        private ReaLTaiizor.Controls.CrownComboBox ComboBoxSpeaker;
        private Button btn_test_send;
    }
}