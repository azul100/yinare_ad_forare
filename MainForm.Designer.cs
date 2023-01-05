using System;
using System.Threading;
using YoutubeExtractor;
namespace azul100
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelectSrc = new System.Windows.Forms.Button();
            this.txbxSrcFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxDestFile = new System.Windows.Forms.TextBox();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnConvert = new System.Windows.Forms.Button();
            this.ofdSrcFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdDestFile = new System.Windows.Forms.SaveFileDialog();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.f33 = new System.Windows.Forms.Button();
            this.rbSrc = new System.Windows.Forms.RadioButton();
            this.rbDest = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.convertTab = new MetroFramework.Controls.MetroTabPage();
            this.previewCheckBox = new System.Windows.Forms.CheckBox();
            this.completedTasksLabel = new System.Windows.Forms.Label();
            this.yinare_ad_forare = new System.Windows.Forms.ListBox();
            this.savePathBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.downloaderTab = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.downloadProgressLabel = new MetroFramework.Controls.MetroLabel();
            this.resolutionCombobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.downloadProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.downloadButton = new MetroFramework.Controls.MetroButton();
            this.youtubePathTextbox = new MetroFramework.Controls.MetroTextBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.TextBlock11 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Converter = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button44 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbHeight1 = new System.Windows.Forms.TextBox();
            this.tbWidth1 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.convertTab.SuspendLayout();
            this.downloaderTab.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectSrc
            // 
            this.btnSelectSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectSrc.ForeColor = System.Drawing.Color.Yellow;
            this.btnSelectSrc.Location = new System.Drawing.Point(297, 44);
            this.btnSelectSrc.Name = "btnSelectSrc";
            this.btnSelectSrc.Size = new System.Drawing.Size(51, 23);
            this.btnSelectSrc.TabIndex = 0;
            this.btnSelectSrc.Text = "............";
            this.btnSelectSrc.UseVisualStyleBackColor = true;
            this.btnSelectSrc.Click += new System.EventHandler(this.btnSelectSrc_Click);
            // 
            // txbxSrcFile
            // 
            this.txbxSrcFile.Location = new System.Drawing.Point(13, 47);
            this.txbxSrcFile.Name = "txbxSrcFile";
            this.txbxSrcFile.Size = new System.Drawing.Size(278, 20);
            this.txbxSrcFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source File: jpg png gift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination File: pdf";
            // 
            // txbxDestFile
            // 
            this.txbxDestFile.Location = new System.Drawing.Point(13, 101);
            this.txbxDestFile.Name = "txbxDestFile";
            this.txbxDestFile.Size = new System.Drawing.Size(278, 20);
            this.txbxDestFile.TabIndex = 4;
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectDest.ForeColor = System.Drawing.Color.Yellow;
            this.btnSelectDest.Location = new System.Drawing.Point(297, 101);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(51, 23);
            this.btnSelectDest.TabIndex = 3;
            this.btnSelectDest.Text = "............";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            this.btnSelectDest.Click += new System.EventHandler(this.btnSelectDest_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(241, 130);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(107, 42);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert Now";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ofdSrcFile
            // 
            this.ofdSrcFile.FileName = "openFileDialog1";
            this.ofdSrcFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.TIF;*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIF;*" +
    ".TIFF|All files (*.*)|*.*";
            this.ofdSrcFile.Title = "Choose source image file";
            // 
            // sfdDestFile
            // 
            this.sfdDestFile.Title = "Choose save location of PDF file";
            // 
            // errProv
            // 
            this.errProv.ContainerControl = this;
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // f33
            // 
            this.f33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.f33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f33.ForeColor = System.Drawing.Color.White;
            this.f33.Location = new System.Drawing.Point(13, 127);
            this.f33.Name = "f33";
            this.f33.Size = new System.Drawing.Size(62, 23);
            this.f33.TabIndex = 8;
            this.f33.Text = "View File";
            this.f33.UseVisualStyleBackColor = true;
            this.f33.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSrc
            // 
            this.rbSrc.AutoSize = true;
            this.rbSrc.Checked = true;
            this.rbSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSrc.ForeColor = System.Drawing.Color.White;
            this.rbSrc.Location = new System.Drawing.Point(13, 162);
            this.rbSrc.Name = "rbSrc";
            this.rbSrc.Size = new System.Drawing.Size(58, 17);
            this.rbSrc.TabIndex = 9;
            this.rbSrc.TabStop = true;
            this.rbSrc.Text = "Source";
            this.rbSrc.UseVisualStyleBackColor = true;
            // 
            // rbDest
            // 
            this.rbDest.AutoSize = true;
            this.rbDest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDest.ForeColor = System.Drawing.Color.White;
            this.rbDest.Location = new System.Drawing.Point(103, 162);
            this.rbDest.Name = "rbDest";
            this.rbDest.Size = new System.Drawing.Size(77, 17);
            this.rbDest.TabIndex = 10;
            this.rbDest.Text = "Destination";
            this.rbDest.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 554);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(12, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 1);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(12, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 1);
            this.panel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 554);
            this.panel1.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.AllowDrop = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.tabControl);
            this.panel5.Controls.Add(this.linkLabel3);
            this.panel5.Controls.Add(this.TextBlock11);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.webBrowser1);
            this.panel5.Controls.Add(this.webBrowser2);
            this.panel5.Controls.Add(this.linkLabel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(812, 554);
            this.panel5.TabIndex = 13;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.convertTab);
            this.tabControl.Controls.Add(this.downloaderTab);
            this.tabControl.Location = new System.Drawing.Point(-2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(673, 278);
            this.tabControl.TabIndex = 10;
            this.tabControl.UseSelectable = true;
            // 
            // convertTab
            // 
            this.convertTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.convertTab.BackgroundImage = global::azul100.Properties.Resources.DSCN9897;
            this.convertTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convertTab.Controls.Add(this.previewCheckBox);
            this.convertTab.Controls.Add(this.completedTasksLabel);
            this.convertTab.Controls.Add(this.yinare_ad_forare);
            this.convertTab.Controls.Add(this.savePathBox);
            this.convertTab.Controls.Add(this.metroButton1);
            this.convertTab.Controls.Add(this.metroLabel2);
            this.convertTab.Controls.Add(this.btnSave);
            this.convertTab.Controls.Add(this.btnOpen);
            this.convertTab.Controls.Add(this.metroLabel1);
            this.convertTab.HorizontalScrollbarBarColor = true;
            this.convertTab.HorizontalScrollbarHighlightOnWheel = false;
            this.convertTab.HorizontalScrollbarSize = 10;
            this.convertTab.Location = new System.Drawing.Point(4, 38);
            this.convertTab.Name = "convertTab";
            this.convertTab.Size = new System.Drawing.Size(665, 236);
            this.convertTab.TabIndex = 0;
            this.convertTab.Text = "Convert";
            this.convertTab.VerticalScrollbarBarColor = true;
            this.convertTab.VerticalScrollbarHighlightOnWheel = false;
            this.convertTab.VerticalScrollbarSize = 10;
            // 
            // previewCheckBox
            // 
            this.previewCheckBox.Location = new System.Drawing.Point(384, 174);
            this.previewCheckBox.Name = "previewCheckBox";
            this.previewCheckBox.Size = new System.Drawing.Size(104, 24);
            this.previewCheckBox.TabIndex = 2;
            this.previewCheckBox.CheckedChanged += new System.EventHandler(this.previewCheckBox_CheckedChanged);
            // 
            // completedTasksLabel
            // 
            this.completedTasksLabel.AutoSize = true;
            this.completedTasksLabel.Location = new System.Drawing.Point(194, 210);
            this.completedTasksLabel.Name = "completedTasksLabel";
            this.completedTasksLabel.Size = new System.Drawing.Size(116, 13);
            this.completedTasksLabel.TabIndex = 11;
            this.completedTasksLabel.Text = "There is no task added";
            // 
            // yinare_ad_forare
            // 
            this.yinare_ad_forare.FormattingEnabled = true;
            this.yinare_ad_forare.HorizontalScrollbar = true;
            this.yinare_ad_forare.Location = new System.Drawing.Point(93, 15);
            this.yinare_ad_forare.Name = "yinare_ad_forare";
            this.yinare_ad_forare.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.yinare_ad_forare.Size = new System.Drawing.Size(293, 95);
            this.yinare_ad_forare.TabIndex = 8;
            // 
            // savePathBox
            // 
            // 
            // 
            // 
            this.savePathBox.CustomButton.Image = null;
            this.savePathBox.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.savePathBox.CustomButton.Name = "";
            this.savePathBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.savePathBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.savePathBox.CustomButton.TabIndex = 1;
            this.savePathBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.savePathBox.CustomButton.UseSelectable = true;
            this.savePathBox.CustomButton.Visible = false;
            this.savePathBox.Lines = new string[0];
            this.savePathBox.Location = new System.Drawing.Point(89, 123);
            this.savePathBox.MaxLength = 32767;
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.PasswordChar = '\0';
            this.savePathBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.savePathBox.SelectedText = "";
            this.savePathBox.SelectionLength = 0;
            this.savePathBox.SelectionStart = 0;
            this.savePathBox.ShortcutsEnabled = true;
            this.savePathBox.Size = new System.Drawing.Size(297, 23);
            this.savePathBox.TabIndex = 6;
            this.savePathBox.UseSelectable = true;
            this.savePathBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.savePathBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 169);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(378, 29);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Convert";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Save to:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(392, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseSelectable = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 19);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Videos paths:";
            // 
            // downloaderTab
            // 
            this.downloaderTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.downloaderTab.BackgroundImage = global::azul100.Properties.Resources.DSCN9897;
            this.downloaderTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloaderTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.downloaderTab.Controls.Add(this.metroButton2);
            this.downloaderTab.Controls.Add(this.downloadProgressLabel);
            this.downloaderTab.Controls.Add(this.resolutionCombobox);
            this.downloaderTab.Controls.Add(this.metroLabel3);
            this.downloaderTab.Controls.Add(this.metroProgressSpinner1);
            this.downloaderTab.Controls.Add(this.downloadProgressBar);
            this.downloaderTab.Controls.Add(this.downloadButton);
            this.downloaderTab.Controls.Add(this.youtubePathTextbox);
            this.downloaderTab.HorizontalScrollbarBarColor = true;
            this.downloaderTab.HorizontalScrollbarHighlightOnWheel = false;
            this.downloaderTab.HorizontalScrollbarSize = 10;
            this.downloaderTab.Location = new System.Drawing.Point(4, 38);
            this.downloaderTab.Name = "downloaderTab";
            this.downloaderTab.Size = new System.Drawing.Size(665, 236);
            this.downloaderTab.TabIndex = 1;
            this.downloaderTab.Text = "Downloader";
            this.downloaderTab.ToolTipText = "Download video from youtube";
            this.downloaderTab.VerticalScrollbarBarColor = true;
            this.downloaderTab.VerticalScrollbarHighlightOnWheel = false;
            this.downloaderTab.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(292, 97);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Download";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // downloadProgressLabel
            // 
            this.downloadProgressLabel.AutoSize = true;
            this.downloadProgressLabel.Location = new System.Drawing.Point(376, 152);
            this.downloadProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            this.downloadProgressLabel.Size = new System.Drawing.Size(27, 19);
            this.downloadProgressLabel.TabIndex = 8;
            this.downloadProgressLabel.Text = "%0";
            // 
            // resolutionCombobox
            // 
            this.resolutionCombobox.FormattingEnabled = true;
            this.resolutionCombobox.ItemHeight = 23;
            this.resolutionCombobox.Items.AddRange(new object[] {
            "360",
            "480",
            "720",
            "1080"});
            this.resolutionCombobox.Location = new System.Drawing.Point(149, 91);
            this.resolutionCombobox.Name = "resolutionCombobox";
            this.resolutionCombobox.Size = new System.Drawing.Size(121, 29);
            this.resolutionCombobox.TabIndex = 7;
            this.resolutionCombobox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 40);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Videos link:";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(396, 43);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinner1.TabIndex = 5;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(149, 152);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(220, 23);
            this.downloadProgressBar.TabIndex = 4;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.White;
            this.downloadButton.Location = new System.Drawing.Point(4, 13);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 9;
            this.downloadButton.UseSelectable = true;
            // 
            // youtubePathTextbox
            // 
            // 
            // 
            // 
            this.youtubePathTextbox.CustomButton.Image = null;
            this.youtubePathTextbox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.youtubePathTextbox.CustomButton.Name = "";
            this.youtubePathTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.youtubePathTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.youtubePathTextbox.CustomButton.TabIndex = 1;
            this.youtubePathTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.youtubePathTextbox.CustomButton.UseSelectable = true;
            this.youtubePathTextbox.CustomButton.Visible = false;
            this.youtubePathTextbox.Lines = new string[0];
            this.youtubePathTextbox.Location = new System.Drawing.Point(149, 40);
            this.youtubePathTextbox.MaxLength = 32767;
            this.youtubePathTextbox.Name = "youtubePathTextbox";
            this.youtubePathTextbox.PasswordChar = '\0';
            this.youtubePathTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.youtubePathTextbox.SelectedText = "";
            this.youtubePathTextbox.SelectionLength = 0;
            this.youtubePathTextbox.SelectionStart = 0;
            this.youtubePathTextbox.ShortcutsEnabled = true;
            this.youtubePathTextbox.Size = new System.Drawing.Size(212, 23);
            this.youtubePathTextbox.TabIndex = 2;
            this.youtubePathTextbox.UseSelectable = true;
            this.youtubePathTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.youtubePathTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel3.Location = new System.Drawing.Point(54, 506);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(225, 13);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://zouggaghhamid.com/yinare_ad_forare";
            // 
            // TextBlock11
            // 
            this.TextBlock11.Location = new System.Drawing.Point(105, 531);
            this.TextBlock11.Name = "TextBlock11";
            this.TextBlock11.Size = new System.Drawing.Size(707, 20);
            this.TextBlock11.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::azul100.Properties.Resources.DSCN9965;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(677, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 49);
            this.button2.TabIndex = 2;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rbSrc);
            this.panel6.Controls.Add(this.rbDest);
            this.panel6.Controls.Add(this.Converter);
            this.panel6.Controls.Add(this.txbxSrcFile);
            this.panel6.Controls.Add(this.btnConvert);
            this.panel6.Controls.Add(this.f33);
            this.panel6.Controls.Add(this.btnSelectDest);
            this.panel6.Controls.Add(this.txbxDestFile);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnSelectSrc);
            this.panel6.Controls.Add(this.label1);
            this.panel6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(408, 305);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 182);
            this.panel6.TabIndex = 0;
            // 
            // Converter
            // 
            this.Converter.AutoSize = true;
            this.Converter.LinkColor = System.Drawing.Color.White;
            this.Converter.Location = new System.Drawing.Point(153, 10);
            this.Converter.Name = "Converter";
            this.Converter.Size = new System.Drawing.Size(129, 13);
            this.Converter.TabIndex = 1;
            this.Converter.TabStop = true;
            this.Converter.Text = "Converter   Image  To Pdf";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::azul100.Properties.Resources.DSCN9897;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(677, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 278);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(677, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(135, 136);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("https://zouggaghhamid.com", System.UriKind.Absolute);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(677, 142);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(130, 124);
            this.webBrowser2.TabIndex = 7;
            this.webBrowser2.Url = new System.Uri("https://zouggaghhamid.com", System.UriKind.Absolute);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Location = new System.Drawing.Point(3, 281);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(86, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "yinare_ad_forare";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbWidth1);
            this.panel7.Controls.Add(this.tbHeight1);
            this.panel7.Controls.Add(this.linkLabel1);
            this.panel7.Controls.Add(this.button44);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(6, 305);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(382, 184);
            this.panel7.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(147, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Converter   ImageTo  Icon";
            // 
            // button44
            // 
            this.button44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button44.FlatAppearance.BorderSize = 0;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.ForeColor = System.Drawing.Color.Black;
            this.button44.Location = new System.Drawing.Point(274, 138);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(90, 36);
            this.button44.TabIndex = 1;
            this.button44.Text = "Convert";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(169, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(326, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 85);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // tbHeight1
            // 
            this.tbHeight1.Location = new System.Drawing.Point(51, 101);
            this.tbHeight1.Name = "tbHeight1";
            this.tbHeight1.Size = new System.Drawing.Size(269, 20);
            this.tbHeight1.TabIndex = 10;
            // 
            // tbWidth1
            // 
            this.tbWidth1.Location = new System.Drawing.Point(51, 47);
            this.tbWidth1.Name = "tbWidth1";
            this.tbWidth1.Size = new System.Drawing.Size(269, 20);
            this.tbWidth1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "                                                                             Conv" +
    "ert Now FreeVideo  Image => PDF =>Icon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.convertTab.ResumeLayout(false);
            this.convertTab.PerformLayout();
            this.downloaderTab.ResumeLayout(false);
            this.downloaderTab.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
      
        

        #endregion

        private System.Windows.Forms.Button btnSelectSrc;
        private System.Windows.Forms.TextBox txbxSrcFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxDestFile;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog ofdSrcFile;
        private System.Windows.Forms.SaveFileDialog sfdDestFile;
        private System.Windows.Forms.ErrorProvider errProv;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Button f33;
        private System.Windows.Forms.RadioButton rbDest;
        private System.Windows.Forms.RadioButton rbSrc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private wmgCMS.WaterMarkTextBox tbHeight;
        private System.Windows.Forms.Panel panel3;
        private wmgCMS.WaterMarkTextBox tbWidth;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel Converter;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox TextBlock11;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Timer _timer;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage convertTab;
        private System.Windows.Forms.CheckBox previewCheckBox;
        private System.Windows.Forms.Label completedTasksLabel;
        private System.Windows.Forms.ListBox yinare_ad_forare;
        private MetroFramework.Controls.MetroTextBox savePathBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage downloaderTab;
        private MetroFramework.Controls.MetroLabel downloadProgressLabel;
        private MetroFramework.Controls.MetroComboBox resolutionCombobox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressBar downloadProgressBar;
        private MetroFramework.Controls.MetroButton downloadButton;
        private MetroFramework.Controls.MetroTextBox youtubePathTextbox;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbWidth1;
        private System.Windows.Forms.TextBox tbHeight1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

