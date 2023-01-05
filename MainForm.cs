

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using NReco.VideoConverter;
using Tulpep.NotificationWindow;
using YoutubeExtractor;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;




namespace azul100
{



    public partial class MainForm : Form
    {
        private String[] imageToConvertPath;
        private string srcFile, destFile;
        bool success = false;
        private String[] Mp3;
        private string flv, dtFile;
        
       
        string musicFolderPath, musicName, musicFileName;
        string[] videoPaths, videoNames;
        List<string> musicNames = new List<string>();

        // Completed task number
        int counter = 0;

        // Original size of the components
        Size formSize;
        Size pictureSize;
        Point pictureLocation;

        // Frame Counter
        float frameNumber = 0f;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectSrc_Click(object sender, EventArgs e)
        {
            if (ofdSrcFile.ShowDialog() != DialogResult.OK)
                return;

            srcFile = ofdSrcFile.FileName;
            txbxSrcFile.Text = srcFile;

            txbxDestFile.Text =
                Path.GetDirectoryName(srcFile) + "\\" +
                Path.GetFileNameWithoutExtension(srcFile) + ".pdf";
            dtFile = txbxDestFile.Text;   
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            if (sfdDestFile.ShowDialog() != DialogResult.OK)
                return;

            dtFile = sfdDestFile.FileName;
            txbxDestFile.Text = dtFile;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            errProv.Clear();

            if (txbxSrcFile.Text.Length == 0)
            {
                errProv.SetError(txbxSrcFile, "Please point source file.");
                return;
            }
            else if (txbxDestFile.Text.Length == 0)
            {
                errProv.SetError(txbxDestFile, "Please point destination file.");
                return;
            }


            success = false;
            bw.RunWorkerAsync(new string[2] { srcFile, dtFile });            
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string source = (e.Argument as string[])[0];
                string destinaton = (e.Argument as string[])[1];

                PdfDocument doc = new PdfDocument();
                doc.Pages.Add(new PdfPage());
                XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]);
                XImage img = XImage.FromFile(source);

                xgr.DrawImage(img, 0, 0);
                doc.Save(destinaton);
                doc.Close();
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
            toolStripProgressBar1.Value = 0;

            if (success)
                MessageBox.Show("The converion ended successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void convert()
        {
            if (imageToConvertPath != null)
            {
                Bitmap thumb = (Bitmap)Image.FromFile(imageToConvertPath[0]);
                int w;
                int h;
                if (tbHeight1.Text != "" && tbWidth1.Text != "")
                {
                    w = Int32.Parse(tbWidth1.Text);
                    h = Int32.Parse(tbHeight1.Text);
                    thumb = ResizeImage(thumb, w, h);

                }
                else
                {
                    w = thumb.Width;
                    h = thumb.Height;
                }
                thumb.MakeTransparent();

                Graphics g = Graphics.FromImage(thumb); // allow drawing to it
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic; // make the image shrink nicely by using HighQualityBicubic mode
                g.DrawImage(thumb, 0, 0, w, h);
                g.Flush();

                //Generate save file dialog
                SaveFileDialog sfd = new SaveFileDialog();
                //Set dialog filter
                sfd.Filter = "Icon (*.ico)|*.ico|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream IconStream = System.IO.File.Create(sfd.FileName);

                    //DEPRECATED DUE TO LOW QUALITY ICON
                    /*Icon icon = Icon.FromHandle(thumb.GetHicon());
                    icon.Save(IconStream);
                    IconStream.Close();*/

                    Icon icon = ImageHelper.Convert(thumb, new Size(w, h));
                    this.Icon = icon;
                    this.Icon.Save(IconStream);
                    IconStream.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an image by dragging it into the window or by clicking 'Browse...'");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            errProv.Clear();

            if (rbSrc.Checked && txbxSrcFile.Text.Length == 0)
            {
                errProv.SetError(txbxSrcFile, "Please point source file.");
                return;
            }
            else if (rbDest.Checked && txbxDestFile.Text.Length == 0)
            {
                errProv.SetError(txbxDestFile, "Please point destination file.");
                return;
            }

            try
            {
                if (rbSrc.Checked)
                    Process.Start(srcFile);
                else if (rbDest.Checked)
                    Process.Start(dtFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }

            
            



        }
       

        //Handles cursor effects when dragging over data
        private void panel5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        //Handles what to do when data is dropped. Bitmap var is assigned the image.
        private void panel5_DragDrop(object sender, DragEventArgs e)
        {
            imageToConvertPath = (String[])e.Data.GetData(DataFormats.FileDrop);
            //MessageBox.Show(imageToConvertPath[0]);
            pictureBox1.BackgroundImage = Image.FromFile(imageToConvertPath[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            convert();
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void tbWidth_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#3E7EF8");
            panel4.BackColor = Color.DarkGray;
        }

        private void tbHeight_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.DarkGray;
            panel4.BackColor = ColorTranslator.FromHtml("#3E7EF8");
        }

      

        private void panel5_Click(object sender, EventArgs e)
        {
            //Allow user to click on upload area to select file
            // button1_Click(this, new EventArgs());
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            resolutionCombobox.SelectedIndex = 0;
            tabControl.SelectedIndex = 0;
            previewCheckBox.CheckStateChanged += previewCheckBox_CheckedChanged;
            // Initialize the value
            formSize = this.Size;
            pictureSize = pictureBox1.Size;
            pictureLocation = pictureBox1.Location;
            webBrowser1.Navigate("https://zouggaghhamid.com/https://zouggaghhamid.com/dz");
            webBrowser2.Navigate("https://zouggaghhamid.com");
        }

       

        private void button44_Click(object sender, EventArgs e)
        {
            convert();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://zouggaghhamid.com/https://zouggaghhamid.com/dz");
            webBrowser2.Navigate("https://zouggaghhamid.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.BackgroundImage = Image.FromFile(ofd.FileName);
                }
                catch (Exception i)
                {
                    MessageBox.Show("Invalid image file. Please select a valid file. Exception: " + i.Message);
                }


                imageToConvertPath = new String[1]; //Must instantiate array to prevent null reference exception
                imageToConvertPath[0] = ofd.FileName;
            }


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel2.Location.X + linkLabel2.Width < 0)
            {
                linkLabel2.Location = new Point(this.Width, linkLabel2.Location.Y);
        }
        else {
            linkLabel2.Location = new Point(linkLabel2.Location.X - 3, linkLabel2.Location.Y);
        }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://zouggaghhamid.com/https://zouggaghhamid.com/dz");
            webBrowser2.Navigate("https://zouggaghhamid.com");
        }
      
      
       

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            background backgroundt = new background();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

       

      

       

        

        

    

        

       

         private void listBoxPaths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                yinare_ad_forare.Items.Remove(yinare_ad_forare.SelectedItem);
            }
        }

       

        private void listBoxPaths_SelectedValueChanged(object sender, EventArgs e)
        {
            if (previewCheckBox.Enabled == false && yinare_ad_forare.SelectedItem != null)
            {
                previewCheckBox.Enabled = true;
            }

            if (previewCheckBox.Checked == true)
                getPreview();
        }

       


       

        private void previewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (previewCheckBox.Checked == true)
            {
               // this.nextFrameButton.Visible = true;
               // this.previousFrameButton.Visible = true;
                this.Size = new Size(921, 344);
                pictureBox1.Location = new Point(535, 63);
                pictureBox1.Size = new Size(360, 240);

                getPreview();


            }
            if (previewCheckBox.Checked == false)
            {
                pictureBox1.Image = null;
                pictureBox1.Size = pictureSize;
                pictureBox1.Location = pictureLocation;
                this.Size = formSize;
            }
        }

        private void previousFrameButton_Click(object sender, EventArgs e)
        {
            frameNumber -= 1f;
            getPreview();
        }

        private void nextFrameButton_Click(object sender, EventArgs e)
        {
            frameNumber += 1f;
            getPreview();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadProgressBar.Minimum = 0;
            downloadProgressBar.Maximum = 100;
            var videos = DownloadUrlResolver.GetDownloadUrls(youtubePathTextbox.Text);
            var video = videos.First(q => q.VideoType == VideoType.Mp4 && q.Resolution == Convert.ToInt32(resolutionCombobox.Text));
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader videoDownloader = new VideoDownloader(video, @"C:\Users\Selectra\Desktop\MP4-to-MP3-Converter-master");
            videoDownloader.DownloadProgressChanged += VideoDownloader_DownloadProgressChanged;
            Thread thread = new Thread(() => { videoDownloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void VideoDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate()
            {
                downloadProgressBar.Value = (int)e.ProgressPercentage;
                downloadProgressLabel.Text = "{string.Format({0:0.##}, e.ProgressPercentage)}";
                downloadProgressBar.Update();
            }));
        }

        #region Get Preview
        /// <summary>
        /// Gets the preview of selected list item
        /// </summary>
        private void getPreview()
        {
            if (yinare_ad_forare.SelectedItem != null)
            {
                FFMpegConverter fFMpeg = new FFMpegConverter();

                System.IO.Stream stream = new System.IO.MemoryStream();
                fFMpeg.GetVideoThumbnail((string)yinare_ad_forare.SelectedItem, stream, frameNumber);
                Image img = Image.FromStream(stream);

               // img = ResizeImage(img, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = img;
            }
        }
        #endregion

        #region Popup Notifier

        // Popup notifier class
        private void notifier()
        {
            PopupNotifier notifier = new PopupNotifier()
            {
                TitleText = "FINISHED",
                ContentText = "Process has been completed",
                ShowCloseButton = true,
                ShowOptionsButton = false,
                TitleFont = new Font("Arial", 26f, FontStyle.Bold, GraphicsUnit.Point),
                TitlePadding = new Padding(100, 0, 0, 0),
                TitleColor = Color.DarkBlue,
                ContentFont = new Font("Bell MT", 15f, FontStyle.Regular, GraphicsUnit.Point),
                ContentColor = Color.Black,
                ContentHoverColor = Color.Red,
                BorderColor = Color.Cornsilk,
                AnimationDuration = 300,
            };
            notifier.Popup();
        }

        #endregion

        #region Resize Image
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap sizezImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        #endregion

        private static string LoadJson(string url)
        {
            //System.IO.Stream stream2 = new System.IO.MemoryStream();
            //TextWriter textWriter = new StreamWriter(@"C:\Users\Selectra\Desktop\");
            //Newtonsoft.Json.JsonTextWriter jsonTextWriter = new Newtonsoft.Json.JsonTextWriter(textWriter);
            //jsonTextWriter.WriteComment("Hey it's me");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie(@"SID", @"SID GOES HERE") { Domain = "youtube.com" });
            request.CookieContainer.Add(new Cookie(@"SSID", @"SSID GOES HERE") { Domain = "youtube.com" });
            var response = (HttpWebResponse)request.GetResponse();

            string pageSource;

            using (var stream = new StreamReader(response.GetResponseStream()))
                pageSource = stream.ReadToEnd();

            return pageSource;
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPaths = openFileDialog.FileNames;
                videoNames = openFileDialog.SafeFileNames;
            }
            foreach (var path in videoPaths)
            {
                yinare_ad_forare.Items.Add(path);
            }
            completedTasksLabel.Text = videoPaths.Length.ToString() + " task(s) added";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                musicFolderPath = folderBrowserDialog.SelectedPath;

                foreach (var videoName in videoNames)
                {
                    musicName = videoName.Substring(0, videoName.Length - 4);
                    musicFileName = musicFolderPath + "\\" + musicName + ".mp3";
                    musicNames.Add(musicFileName);
                }
            }
            savePathBox.Text = musicFolderPath;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (yinare_ad_forare.SelectedItems.Count == 0)
            {
                MessageBox.Show("There is no selected item for queue", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (savePathBox.Text == "")
            {
                MessageBox.Show("There is no selected save path", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (yinare_ad_forare.SelectedItems.Count != 0 && savePathBox.Text != "")
                {
                    completedTasksLabel.Text = videoPaths.Length.ToString() + " task(s) has started";

                    // Construct an instance of FFMpegConverter
                    var convert = new FFMpegConverter();

                    // Zip two list to one list
                    var pathandFiles = yinare_ad_forare.SelectedItems.Cast<string>().Zip(musicNames, (p, n) => new { Path = p, Name = n });

                    foreach (var pn in pathandFiles)
                    {
                        // Convert video to mp3 audio format
                        convert.ConvertMedia(pn.Path.Trim(), pn.Name.Trim(), "mp3");
                        counter += 1;
                        completedTasksLabel.Text = counter.ToString() + " of " + videoPaths.Count().ToString() + " task(s) completed";
                    }
                    // Call the notifier
                    notifier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            downloadProgressBar.Minimum = 0;
            downloadProgressBar.Maximum = 100;
            var videos = DownloadUrlResolver.GetDownloadUrls(youtubePathTextbox.Text);
            var video = videos.First(q => q.VideoType == VideoType.Mp4 && q.Resolution == Convert.ToInt32(resolutionCombobox.Text));
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader videoDownloader = new VideoDownloader(video, @"C:\Users\Selectra\Desktop\MP4-to-MP3-Converter-master");
            videoDownloader.DownloadProgressChanged += VideoDownloader_DownloadProgressChanged;
            Thread thread = new Thread(() => { videoDownloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.BackgroundImage = Image.FromFile(ofd.FileName);
                }
                catch (Exception i)
                {
                    MessageBox.Show("Invalid image file. Please select a valid file. Exception: " + i.Message);
                }


                imageToConvertPath = new String[1]; //Must instantiate array to prevent null reference exception
                imageToConvertPath[0] = ofd.FileName;
            }
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            convert();
        }
    }
}


       

          
        
        
       

       
   
      

      

       
            
      
