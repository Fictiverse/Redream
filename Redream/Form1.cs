using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Redream.Properties;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;


namespace Redream
{


    public partial class Form1 : Form
    {
        public string url_API = "127.0.0.1:7860";


        List<Button> buttonList = new List<Button>();
        List<string> favPromptList = new List<string>();
        List<string> favNPromptList = new List<string>();
        string FramesPath = Application.StartupPath + "Frames";

        public userControl_Settings control_Settings = new userControl_Settings();
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(FramesPath);

            buttonList.Add(button1);
            buttonList.Add(button2);
            buttonList.Add(button3);
            buttonList.Add(button4);
            buttonList.Add(button5);
            buttonList.Add(button6);
            buttonList.Add(button7);
            buttonList.Add(button8);
            buttonList.Add(button9);
            buttonList.Add(button10);



            IniFile iniFile = new IniFile("fav.ini");
            favPromptList.Add(iniFile.Read("P1"));
            favPromptList.Add(iniFile.Read("P2"));
            favPromptList.Add(iniFile.Read("P3"));
            favPromptList.Add(iniFile.Read("P4"));
            favPromptList.Add(iniFile.Read("P5"));
            favPromptList.Add(iniFile.Read("P6"));
            favPromptList.Add(iniFile.Read("P7"));
            favPromptList.Add(iniFile.Read("P8"));
            favPromptList.Add(iniFile.Read("P9"));
            favPromptList.Add(iniFile.Read("P10"));




            favNPromptList.Add(iniFile.Read("N1"));
            favNPromptList.Add(iniFile.Read("N2"));
            favNPromptList.Add(iniFile.Read("N3"));
            favNPromptList.Add(iniFile.Read("N4"));
            favNPromptList.Add(iniFile.Read("N5"));
            favNPromptList.Add(iniFile.Read("N6"));
            favNPromptList.Add(iniFile.Read("N7"));
            favNPromptList.Add(iniFile.Read("N8"));
            favNPromptList.Add(iniFile.Read("N9"));
            favNPromptList.Add(iniFile.Read("N10"));


            for (int i = 0; i < buttonList.Count; i++)
            {
                if (favPromptList[i] != "")
                    toolTip1.SetToolTip(buttonList[i], favPromptList[i]);
                else
                    toolTip1.SetToolTip(buttonList[i], "Slot " + (i + 1));
            }

            InitFavColor();
            buttonShape.MouseWheel += new MouseEventHandler(buttonShape_MouseWheel);
            buttonSeed.MouseWheel += new MouseEventHandler(buttonSeed_MouseWheel);
            buttonSteps.MouseWheel += new MouseEventHandler(buttonSteps_MouseWheel);
            buttonStrength.MouseWheel += new MouseEventHandler(buttonStrength_MouseWheel);
            buttonCFGScale.MouseWheel += new MouseEventHandler(buttonCFGScale_MouseWheel);
            buttonSampler.MouseWheel += new MouseEventHandler(buttonSampler_MouseWheel);


            control_Settings.MainForm = this;
            control_Settings.Visible = false;
            control_Settings.Dock = DockStyle.Fill;
            panelImage.Controls.Add(control_Settings);


        }



        public void SetInitImage(Bitmap img)
        {
            //img.Save(applicationPath + "Data\\initimage.png");
            //tabImage.LoadInitImage();
        }


        FormScreenShot formSC = null;
        bool isSCOpen = false;
        private void buttonScreenshot_Click(object sender, EventArgs e)
        {
            //buttonScreenshot.Enabled = false;

            ToggleScreenshot();


        }

        private void ToggleScreenshot()
        {
            if (formSC == null || formSC.IsDisposed)
            {
                formSC = new FormScreenShot(false);
                formSC.ParentForm = this;
                formSC.IsMaskEnabled = isMaskEnabled;
                //formSC.Owner = this;
                formSC.Location = new Point(10000, 10000);
                formSC.ChangeRatio(ratioX, ratioY);
            }


            isSCOpen = !isSCOpen;
            if (isSCOpen)
            {
                buttonScreenshot.BackColor = Color.FromArgb(25, 85, 35);
                formSC.Show();
            }
            else
            {
                buttonScreenshot.BackColor = Color.FromArgb(80, 60, 20);
                formSC.Hide();
                //Stop();
            }
        }

        bool isStarted;
        Bitmap CurrentCapture = new Bitmap(512, 512);
        private async void buttonStart_Click(object sender, EventArgs e)
        {

            if (formSC != null && !formSC.IsDisposed)
            {

                isStarted = !isStarted;
                formSC.IsStarted = isStarted;
                //formSC.DisplayImage(false);
                if (isStarted)
                {
                    frames.Clear();
                    //timerFadeOut.Enabled = true;

                    buttonStart.BackColor = Color.FromArgb(25, 85, 35);
                    buttonStart.Image = Resources.pause_button;

                    while (isStarted && formSC != null)
                    {
                        Bitmap bmp = formSC.TakeScreeenShot();
                        CurrentCapture = bmp;
                        string pre = control_Settings.SelectedControlNetPreprossessor;
                        string post = control_Settings.SelectedControlNetModel;

                        if (pre.ToLower() != "none" && post.ToLower() != "none")
                            await ControlNet_Txt2Img(url_API, bmp, pre, post);
                        else
                            await AutomaticAsync(seed, bmp);
                    }


                }
                else
                {
                    Stop();
                }
            }
            else
            {
                ToggleScreenshot();
            }

        }

        public async void Stop()
        {

            timerFadeOut.Enabled = false;
            isStarted = false;
            if (formSC != null && !formSC.IsDisposed)
                formSC.IsStarted = false;

            await AutomaticInterrupt();

            buttonStart.BackColor = Color.FromArgb(85, 35, 25);
            buttonStart.Image = Resources.play;
            UpdatePlayer();
        }



        public static byte[] ImageToBytes(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        class AutomaticJson
        {
            public List<string> init_images = new List<string>();
            public string mask = "";
            public string denoising_strength = "0.6";
            public string mask_blur = "8";
            public int inpainting_fill = 3;
            public string prompt = "";
            public string negative_prompt = "";
            public string seed = "-1";
            public string n_iter = "1";
            public string batch_size = "1";
            public string steps = "20";
            public string cfg_scale = "7.5";
            public int width = 512;
            public int height = 512;
            //public string restore_faces = "false";
            public string sampler_index = "Euler"; // Euler a, Euler, LMS, Heun, DPM2, DPM2 a, DPM++ 2S a, DPM++ 2M, DPM fast, DPM adaptive, LMS Karras, DPM2 Karras, DPM2 a Karras, DMP++ 2S a Karras, DMP++ 2M Karras, DDIM, PLMS
        }


        private async Task AutomaticAsync(int seed = -1, Image initimage = null)
        {

            List<string> init_images = new List<string>();


            string script = "http://127.0.0.1:7860/sdapi/v1/img2img";

            Size size = formSC.Size;
            Bitmap msk = formSC.Mask;
            if (isNormSize)
            {
                size = NormalizeSize(size, control_Settings.FitSize);
                initimage = ResizeImage((Bitmap)initimage.Clone(), size);
                msk = ResizeImage((Bitmap)msk.Clone(), size);
            }


            string base64Image = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(initimage));



            init_images.Add(base64Image);

            //Bitmap msk = GenerateGradientMask(size, 40);
            //msk.Save("mask.jpg");





            string base64Mask = null;
            if (isMaskEnabled)
            {
                //  base64Mask = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(msk));
                //denoising_strength = "1";

            }
            //MessageBox.Show(width.ToString());



            base64Mask = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(msk));




            int inpainting_fill = 1;
            if (strength == 1)
                inpainting_fill = 3;

            string denoising_strength = strength.ToString("0.00").Replace(",", ".");



            var automaticJson = new AutomaticJson
            {
                prompt = textBoxPrompt.Text,
                negative_prompt = textBoxPromptN.Text,

                init_images = init_images,
                mask = base64Mask,
                inpainting_fill = inpainting_fill,
                denoising_strength = denoising_strength,

                seed = buttonSeed.Text,
                steps = steps.ToString(),
                cfg_scale = cfgScale.ToString("0.00").Replace(",", "."),

                width = size.Width,
                height = size.Height,

                sampler_index = samplers[samplerIndex]
            };
            string json = JsonConvert.SerializeObject(automaticJson);


            var client = new HttpClient();
            var content = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(script),
                Method = HttpMethod.Post,
                Content = content
            };

            try
            {
                var response = await client.SendAsync(request);
                dynamic AutomaticResponse = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());

                string imgStr = AutomaticResponse.images[0].ToString();
                var imgB64 = Convert.FromBase64String(imgStr);
                Bitmap bmp;
                using (var ms = new MemoryStream(imgB64))
                    bmp = new Bitmap(Bitmap.FromStream(ms));

                ProcessResult(bmp);
                //pictureBox1.Image = MergeImages(initimage, bmp, 5);

            }
            catch
            {
                // SetConsoleMessage("Cannot catch the API : Image");
            }


        }


        public static Size NormalizeSize2(Size size, int maxSize)
        {
            int width = size.Width;
            int height = size.Height;

            // Calculate the total number of pixels
            int totalPixels = width * height;

            // Check if the image exceeds the maximum total pixels
            if (totalPixels > (maxSize * maxSize))
            {
                // Calculate the aspect ratio
                double aspectRatio = (double)width / height;

                // Calculate the new width and height while maintaining the aspect ratio and limiting the total pixels
                double scaleFactor = Math.Sqrt((double)(maxSize * maxSize) / totalPixels);
                width = (int)(width * scaleFactor);
                height = (int)(height * scaleFactor);
            }

            // Adjust the size to be a multiple of 8
            width = (width / 8) * 8;
            height = (height / 8) * 8;

            return new Size(width, height);
        }
        public static Size NormalizeSize(Size size, int maxSize)
        {
            int width = size.Width;
            int height = size.Height;

            // Calculate the aspect ratio of the original image
            float aspectRatio = (float)width / height;

            // Calculate the new width and height based on the maximum size and aspect ratio
            int newWidth, newHeight;
            if (width > height)
            {
                newWidth = maxSize;
                newHeight = (int)(maxSize / aspectRatio);
            }
            else
            {
                newHeight = maxSize;
                newWidth = (int)(maxSize * aspectRatio);
            }
            // Adjust the size to be a multiple of 8
            newWidth = (newWidth / 8) * 8;
            newHeight = (newHeight / 8) * 8;

            // Return the new size as a Size object
            return new Size(newWidth, newHeight);
        }



        public static Bitmap GenerateGradientMask(Size size, int fillPercentage)
        {
            int width = size.Width;
            int height = size.Height;

            Bitmap gradientMask = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(gradientMask))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, width, height);
                int fillHeight = height * fillPercentage / 100;
                graphics.FillRectangle(Brushes.Black, 0, 0, width, fillHeight);
            }

            return gradientMask;
        }


        List<Bitmap> frames = new List<Bitmap>();
        public void ProcessResult(Bitmap bmp)
        {
            frames.Add(bmp);
            string imagename = DateTime.Now.ToFileTime().ToString().Substring(0, 12) + ".png";

            oldimage = (Bitmap)newImage.Clone();
            newImage = bmp;
            opacity = 0;
            pictureBox1.Image = bmp;
            if (formSC != null)
            {
                formSC.SetImage(bmp);
            }

            //formSC.DisplayImage(isStarted);
            if (isSaveFramesEnabled)
            {
                string name = DateTime.Now.ToFileTime().ToString() + ".png";
                bmp.Save(FramesPath + "\\" + name);
            }

        }


        private void UpdatePlayer()
        {
            if (frames.Count > 0)
            {
                int max = frames.Count;
                colorTrackBarPlayer.Maximum = max;
                colorTrackBarPlayer.Value = 0;
            }


        }


        public static Bitmap ResizeImage(Image image, Size size)
        {
            // Create a new Bitmap with the desired width and height
            Bitmap resizedImage = new Bitmap(size.Width, size.Height);

            // Create a Graphics object from the resized image
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.None;
                graphics.PixelOffsetMode = PixelOffsetMode.None;

                // Draw the original image onto the resized image
                graphics.DrawImage(image, 0, 0, size.Width, size.Height);
            }

            return resizedImage;
        }

        public class json_ControlNet
        {
            public List<string> images { get; set; }
            public string info { get; set; }
        }


        private async Task ControlNet_Txt2Img(string IP, Bitmap initimage, string module, string model, float guidanceStart = 0, float guidanceEnd = 1)
        {
            using var client = new HttpClient();
            var url = $"http://{IP}/sdapi/v1/img2img";

            List<string> init_images = new List<string>();

            Size size = formSC.Size;
            Bitmap msk = formSC.Mask;
            if (isNormSize)
            {
                size = NormalizeSize(size, control_Settings.FitSize);
                initimage = ResizeImage((Bitmap)initimage.Clone(), size);
                msk = ResizeImage((Bitmap)msk.Clone(), size);
            }


            string base64Image = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(initimage));
            init_images.Add(base64Image);

            //Bitmap msk = GenerateGradientMask(size, 40);
            //msk.Save("mask.jpg");


            string denoising_strength = strength.ToString("0.00").Replace(",", ".");


            string base64Mask = null;
            if (isMaskEnabled)
            {
                base64Mask = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(msk));
                //denoising_strength = "1";
            }




            if (module == null)
                module = "none";
            if (model == null)
                model = "none";

            var requestBody = new
            {
                init_images = init_images,
                mask = base64Mask,
                mask_blur = 6,
                inpainting_fill = 3,
                denoising_strength = denoising_strength,
                prompt = textBoxPrompt.Text,
                negative_prompt = textBoxPromptN.Text,
                seed = buttonSeed.Text,
                steps = steps.ToString(),
                cfg_scale = cfgScale.ToString("0.00").Replace(",", "."),
                batch_size = 1,
                n_iter = 1,
                width = size.Width,
                height = size.Height,
                sampler_index = samplers[samplerIndex],
                alwayson_scripts = new
                {
                    controlnet = new
                    {
                        args = new[]
            {
                new
                {
                    module = module,
                    model = model,
                    control_mode = "ControlNet is more important"
                }
            }
                    }
                },
                /*
                controlnet_units = new[] {
                    new {
                        input_image = init_images[0],
                        module = module,
                        model = model,
                        weight = 1,
                        //resize_mode = "Scale to Fit (Inner Fit)",
                        guidance_start = guidanceStart,
                        guidance_end = guidanceEnd,
                        resize_mode = "Envelope (Outer Fit)",
                        lowvram = false,
                        processor_res = 320,
                        threshold_a = 64,
                        threshold_b = 64,
                        guessmode = false
                    }
                }
                */
            };
            var requestBodyString = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);


            var content = new StringContent(requestBodyString, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);


            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var json_ControlNet = JsonConvert.DeserializeObject<json_ControlNet>(responseContent);

                var bitmapList = new List<Bitmap>();
                foreach (var imageString in json_ControlNet.images)
                {
                    var imageData = Convert.FromBase64String(imageString);
                    using (var memoryStream = new MemoryStream(imageData))
                        bitmapList.Add((Bitmap)Image.FromStream(memoryStream));
                }

                if (bitmapList.Count > 0)
                    ProcessResult(bitmapList[0]);
            }
            else
            {
                MessageBox.Show("Error: " + response.Content);
            }

        }




        private async Task AutomaticInterrupt()
        {

            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://127.0.0.1:7860/sdapi/v1/interrupt"),
                Method = HttpMethod.Post,
                Content = content
            };

            try
            {
                var response = await client.SendAsync(request);
            }
            catch { }

        }


        private async Task AutomaticModels()
        {
            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://127.0.0.1:7860/sdapi/v1/sd-models"),
                Method = HttpMethod.Get,
                Content = content
            };

            try
            {
                var response = await client.SendAsync(request);
                dynamic responseD = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                MessageBox.Show(responseD.toString());
            }
            catch
            {
                //SetConsoleMessage("Waiting for automatic : Models");
            }
        }
        private Bitmap MergeImages(Image image1, Image image2, int space)
        {
            Bitmap bitmap = new Bitmap(image1.Width + image2.Width + space, Math.Max(image1.Height, image2.Height));
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Black);
                g.DrawImage(image1, 0, 0);
                g.DrawImage(image2, image1.Width + space, 0);
            }
            return bitmap;
        }

        int shape = 0;
        int ratioX = 16;
        int ratioY = 16;
        private void buttonShape_Click(object sender, EventArgs e)
        {
            SwitchShape(1);
        }

        private void buttonShape_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SwitchShape(1);
            else if (e.Delta < 0)
                SwitchShape(-1);
        }

        public void SwitchShape(int value)
        {
            shape = shape + value;
            if (shape < 0)
                shape = 4;

            switch (shape)
            {
                case 1:
                    ratioX = 16;
                    ratioY = 12;
                    buttonShape.Image = Resources.shape_4_3;
                    toolTip1.SetToolTip(buttonShape, "4 / 3");
                    control_Settings.Shape = "4 / 3";
                    break;
                case 2:
                    ratioX = 16;
                    ratioY = 9;
                    buttonShape.Image = Resources.rounded_rectangleV;
                    toolTip1.SetToolTip(buttonShape, "16 / 9");
                    control_Settings.Shape = "16 / 9";
                    break;
                case 3:
                    ratioX = 12;
                    ratioY = 16;
                    buttonShape.Image = Resources.shape_3_4;
                    toolTip1.SetToolTip(buttonShape, "3 / 4");
                    control_Settings.Shape = "3 / 4";
                    break;
                case 4:
                    ratioX = 9;
                    ratioY = 16;
                    buttonShape.Image = Resources.rounded_rectangleH;
                    toolTip1.SetToolTip(buttonShape, "9 / 16");
                    control_Settings.Shape = "9 / 16";
                    break;
                default:
                    shape = 0;
                    ratioX = 16;
                    ratioY = 16;
                    buttonShape.Image = Resources.rounded_black_square_shapeS_;
                    toolTip1.SetToolTip(buttonShape, "1 / 1");
                    control_Settings.Shape = "1 / 1";
                    break;
            }
            if (formSC != null)
                formSC.ChangeRatio(ratioX, ratioY);
        }


        bool dragging;
        private Point startPoint;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Location = new Point((panelImage.Width - pictureBox1.Width) / 2, (panelImage.Height - pictureBox1.Height) / 2);
                //pictureBox1.Location = new Point(0, 0);
            }
            */
        }

        private void panelImage_MouseDown(object sender, MouseEventArgs e)
        { /*
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Location = new Point((panelImage.Width - pictureBox1.Width) / 2, (panelImage.Height - pictureBox1.Height) / 2);
                //pictureBox1.Location = new Point(0, 0);
            }*/
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        { /*
            if (dragging)
            {
                pictureBox1.Location = new Point(pictureBox1.Left + e.Location.X - startPoint.X, pictureBox1.Top + e.Location.Y - startPoint.Y);
                this.Refresh();
            }*/
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        { /*
            dragging = false;*/
        }


        float opacity = 0;
        Bitmap oldimage = new Bitmap(512, 512);
        Bitmap newImage = new Bitmap(512, 512);

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {

            if (opacity < 1)
            {
                //Image img = LerpImages(oldimage, newImage, opacity);
                pictureBox1.Image = newImage;
                opacity += 0.25f;
            }
            else
            {
                opacity = 0;
                oldimage?.Dispose();
                oldimage = (Bitmap)newImage.Clone();
                pictureBox1.Image = oldimage;
            }

        }




        private Image LerpImages2(Image image1, Image image2, float t)
        {
            int width = image1.Width;
            int height = image1.Height;

            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

                // Calculate the opacity values for each image
                int opacity1 = (int)Math.Round(255 * (1 - t));
                int opacity2 = (int)Math.Round(255 * t);

                // Create image attributes for applying opacity
                ColorMatrix matrix1 = new ColorMatrix { Matrix33 = opacity1 / 255f };
                ColorMatrix matrix2 = new ColorMatrix { Matrix33 = opacity2 / 255f };
                ImageAttributes attributes1 = new ImageAttributes();
                ImageAttributes attributes2 = new ImageAttributes();
                attributes1.SetColorMatrix(matrix1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                attributes2.SetColorMatrix(matrix2, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Draw the first image with the adjusted opacity
                Rectangle rect1 = new Rectangle(0, 0, width, height);
                g.DrawImage(image1, rect1, 0, 0, width, height, GraphicsUnit.Pixel, attributes1);

                // Draw the second image with the adjusted opacity
                Rectangle rect2 = new Rectangle(0, 0, width, height);
                g.DrawImage(image2, rect2, 0, 0, width, height, GraphicsUnit.Pixel, attributes2);
            }

            return bmp;
        }

        private Image LerpImages(Image img1, Image img2, float opacity)
        {
            Bitmap bmp = new Bitmap(img2.Width, img2.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(img2, new Rectangle(0, 0, img2.Width, img2.Height), 0, 0, img2.Width, img2.Height, GraphicsUnit.Pixel, attributes);
            }

            Bitmap img = (Bitmap)img1.Clone();
            using (Graphics g = Graphics.FromImage(img))
            {
                g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
            }

            // Dispose of the Graphics objects
            bmp.Dispose();

            return img;
        }



        bool isSaveFramesEnabled = false;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            isSaveFramesEnabled = !isSaveFramesEnabled;

            if (isSaveFramesEnabled)
            {
                buttonSave.BackColor = Color.FromArgb(25, 85, 35);
            }
            else
            {
                buttonSave.BackColor = Color.FromArgb(85, 35, 25);
            }
        }





        bool isFaving = false;
        private void buttonFav_Click(object sender, EventArgs e)
        {
            isFaving = !isFaving;
            InitFavColor(isFaving);

        }



        bool blinkUp;
        private void timerBlink_Tick(object sender, EventArgs e)
        {
            blinkUp = !blinkUp;

            Color c = Color.FromArgb(30, 50, 60);
            if (blinkUp)
                c = Color.FromArgb(25, 65, 85);

            foreach (Button btn in buttonList)
                btn.BackColor = c;
        }


        private void InitFavColor(bool enabled = false)
        {
            isFaving = enabled;
            timerBlink.Enabled = enabled;

            buttonFav.BackColor = Color.FromArgb(85, 35, 25);
            if (enabled)
                buttonFav.BackColor = Color.FromArgb(65, 45, 85);

            Color c = Color.FromArgb(30, 50, 60);
            foreach (Button btn in buttonList)
                btn.BackColor = c;


            for (int i = 0; i < favPromptList.Count; i++)
            {
                if (favPromptList[i] != "")
                {
                    buttonList[i].BackColor = Color.FromArgb(25, 85, 65);
                }
            }


        }

        Button previousClickedButton = null;
        private void buttonM_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (isFaving)
            {
                IniFile iniFile = new IniFile("fav.ini");
                iniFile.Write("P" + btn.Text, textBoxPrompt.Text);
                favPromptList[int.Parse(btn.Text) - 1] = textBoxPrompt.Text;
                favNPromptList[int.Parse(btn.Text) - 1] = textBoxPromptN.Text;
                toolTip1.SetToolTip(btn, textBoxPrompt.Text);
                InitFavColor();
            }
            else
            {
                textBoxPrompt.Text = favPromptList[int.Parse(btn.Text) - 1];
                textBoxPromptN.Text = favNPromptList[int.Parse(btn.Text) - 1];

                btn.BackColor = Color.FromArgb(45, 65, 85);
                if (previousClickedButton != null && previousClickedButton != btn)
                {
                    previousClickedButton.BackColor = Color.FromArgb(25, 85, 65);
                }
                previousClickedButton = btn;
            }

        }


        int steps = 16;
        private void buttonSteps_Click(object sender, EventArgs e)
        {
            SwitchSteps(5, true);
        }

        private void buttonSteps_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SwitchSteps(1);
            else if (e.Delta < 0)
                SwitchSteps(-1);
        }

        public void SwitchSteps(int value, bool loop = false)
        {
            steps = steps + value;

            if (loop)
            {
                if (steps > 50)
                    steps = 1;
                if (steps < 1)
                    steps = 50;
            }
            steps = Math.Clamp(steps, 1, 50);

            if (steps < 16)
                buttonSteps.Image = Resources.level1;
            else if (steps < 32)
                buttonSteps.Image = Resources.level2;
            else
                buttonSteps.Image = Resources.level3;

            buttonSteps.Text = steps.ToString();
            control_Settings.Steps = steps.ToString();
        }

        float strength = 0.5f;
        private void buttonStrength_Click(object sender, EventArgs e)
        {
            SwitchStrength(0.1f, true);
        }

        private void buttonStrength_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SwitchStrength(0.02f);
            else if (e.Delta < 0)
                SwitchStrength(-0.02f);
        }

        public void SwitchStrength(float value, bool loop = false)
        {
            strength = strength + value;

            if (loop)
            {
                if (strength > 1.00f)
                    strength = 0.02f;
                else if (strength < 0.02f)
                    strength = 1.00f;
            }
            strength = Math.Clamp(strength, 0.02f, 1.00f);
            buttonStrength.Text = strength.ToString("0.00");
            control_Settings.Strength = strength.ToString("0.00");
        }

        float cfgScale = 7.5f;
        private void buttonCFGScale_Click(object sender, EventArgs e)
        {
            SwitchCFGScale(4.0f, true);
        }

        private void buttonCFGScale_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SwitchCFGScale(0.5f);
            else if (e.Delta < 0)
                SwitchCFGScale(-0.5f);
        }

        public void SwitchCFGScale(float value, bool loop = false)
        {
            cfgScale = cfgScale + value;

            if (loop)
            {
                if (cfgScale > 32.0f)
                    cfgScale = 0.5f;
                else if (cfgScale < 0.5f)
                    cfgScale = 32.0f;
            }


            cfgScale = Math.Clamp(cfgScale, 0.5f, 32.0f);
            buttonCFGScale.Text = cfgScale.ToString("0.0");
            control_Settings.CFGScale = cfgScale.ToString("0.0");
        }


        string[] primeNumbers = new string[] { "2", "3", "5", "7", "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47", "53", "59", "61", "67", "71", "73", "79", "83", "89", "97", "101", "103", "107", "109", "113", "127", "131", "137", "139", "149", "151", "157", "163", "167", "173", "179", "181", "191", "193", "197", "199", "211", "223", "227", "229", "233", "239", "241", "251", "257", "263", "269", "271", "277", "281", "283", "293", "307", "311", "313", "317", "331", "337", "347", "349", "353", "359", "367", "373", "379", "383", "389", "397", "401", "409", "419", "421", "431", "433", "439", "443", "449", "457", "461", "463", "467", "479", "487", "491", "499", "503", "509", "521", "523", "541", "547", "557", "563", "569", "571", "577", "587", "593", "599", "601", "607", "613", "617", "619", "631", "641", "643", "647", "653", "659", "661", "673", "677", "683", "691", "701", "709", "733", "739", "743", "751", "757", "761", "769", "773", "787", "797", "809", "811", "821", "823", "827", "829", "839", "853", "857", "859", "863", "877", "881", "883", "887", "907", "911", "919", "929", "937", "941", "947", "953", "967", "971", "977", "983", "991", "997" };
        int seed = -1;
        private void buttonSeed_Click(object sender, EventArgs e)
        {
            if (seed == -1)
                SwitchSeed(true);
            else
                SwitchSeed(false);

        }

        private void buttonSeed_MouseWheel(object? sender, MouseEventArgs e)
        {
            SwitchSeed(true);

        }

        public void SwitchSeed(bool isRandom)
        {
            seed = -1;
            if (isRandom)
            {
                Random r = new Random();
                seed = r.Next(primeNumbers.Length);
                buttonSeed.Text = primeNumbers[seed];
                control_Settings.Seed = primeNumbers[seed];
            }
            else
            {
                buttonSeed.Text = "-1";
                control_Settings.Seed = "-1";
            }

        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(0, 0);
            Size size = new Size(512, 512);
            if (pictureBox1.Image != null)
                size = pictureBox1.Image.Size;
            this.Size = new Size(size.Width + 80, size.Height + 160);
        }

        private async void buttonInterrogate_Click(object sender, EventArgs e)
        {
            buttonInterrogate.Image = Resources.hourglass24;
            buttonInterrogate.BackColor = Color.FromArgb(50, 30, 40);
            buttonInterrogate.Enabled = false;
            await AutomaticInterrogate();
            buttonInterrogate.Image = Resources.text;
            buttonInterrogate.BackColor = Color.FromArgb(40, 30, 50);
            buttonInterrogate.Enabled = true;
        }
        class AutomaticInterrogateStruct
        {
            public string image = "";
            public string model = "clip";
        }

        private async Task AutomaticInterrogate()
        {

            string base64Image = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(CurrentCapture));
            var struc = new AutomaticInterrogateStruct
            {
                image = base64Image
            };
            string json = JsonConvert.SerializeObject(struc);
            var client = new HttpClient();
            var content = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://127.0.0.1:7860/sdapi/v1/interrogate"),
                Method = HttpMethod.Post,
                Content = content
            };

            try
            {
                var response = await client.SendAsync(request);
                dynamic responseD = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                textBoxPrompt.Text = responseD.caption.ToString();
            }
            catch { }


        }



        int samplerIndex = 0;

        string[] samplers = new string[] {
          "Euler a",
          "Euler",
          "LMS",
          "Heun",
          "DPM2",
          "DPM2 a",
          "DPM++ 2S a",
          "DPM++ 2M",
          "DPM++ SDE",
          "DPM fast",
          "DPM adaptive",
          "LMS Karras",
          "DPM2 Karras",
          "DPM2 a Karras",
          "DPM++ 2S a Karras",
          "DPM++ 2M Karras",
          "DPM++ SDE Karras",
          "DDIM",
          //"PLMS",
          //"UniPC"
        };
        private void buttonSampler_Click(object sender, EventArgs e)
        {
            SwitchSampler(false);
        }

        private void buttonSampler_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SwitchSampler(false);
            else if (e.Delta < 0)
                SwitchSampler(true);
        }

        public void SwitchSampler(bool previous)
        {
            if (previous)
                samplerIndex--;
            else
                samplerIndex++;


            if (samplerIndex >= samplers.Length)
                samplerIndex = 0;
            if (samplerIndex < 0)
                samplerIndex = samplers.Length - 1;

            toolTip1.SetToolTip(buttonSampler, "Sampler : " + samplers[samplerIndex]);
            toolTip1.Active = true;
            control_Settings.Sampler = samplers[samplerIndex];
        }



        public Point downPoint = Point.Empty;
        private void buttonResize_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);

        }

        private void buttonResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }

        private void buttonResize_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }



        private void buttonClearPrompt_Click(object sender, EventArgs e)
        {
            textBoxPrompt.Text = "";
        }

        private void buttonClearPromptN_Click(object sender, EventArgs e)
        {
            textBoxPromptN.Text = "";
        }

        bool isMaskEnabled = true;
        int maskPercentage = 40;
        private void buttonDefaultSettings_Click(object sender, EventArgs e)
        {

            isMaskEnabled = !isMaskEnabled;

            Color disabledColor = Color.FromArgb(40, 20, 40);

            if (isMaskEnabled)
                buttonDefaultSettings.BackColor = Color.FromArgb(25, 85, 35);
            else
                buttonDefaultSettings.BackColor = Color.FromArgb(85, 35, 25);


            if (formSC != null)
            {
                if (isMaskEnabled)
                    formSC.IsMaskEnabled = true;

                else
                    formSC.IsMaskEnabled = false;
            }

        }
        bool isMenuSettingsOpen = false;

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            isMenuSettingsOpen = !isMenuSettingsOpen;
            //pictureBox1.Visible = !isMenuSettingsOpen;
            control_Settings.Visible = isMenuSettingsOpen;
            control_Settings.BringToFront();
            control_Settings.InitModel();
            control_Settings.GetControletModels();
            if (isMenuSettingsOpen)
            {
                buttonSettings.BackColor = Color.FromArgb(25, 85, 35);
            }
            else
            {
                buttonSettings.BackColor = Color.FromArgb(13, 13, 13);
            }
        }

        bool isNormSize = false;
        private void buttonNormSize_Click(object sender, EventArgs e)
        {
            isNormSize = !isNormSize;

            Color disabledColor = Color.FromArgb(40, 20, 40);

            if (isNormSize)
            {
                buttonNormSize.BackColor = Color.FromArgb(25, 85, 35);

            }
            else
            {
                buttonNormSize.BackColor = Color.FromArgb(85, 35, 25);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                Clipboard.SetImage(pictureBox1.Image);

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //   pictureBox1.Location = new Point((panelImage.Width - pictureBox1.Width) / 2, (panelImage.Height - pictureBox1.Height) / 2);
        }

        private void colorTrackBarPlayer_ValueChanged(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                int value = colorTrackBarPlayer.Value;
                if (frames.Count > 0 && value < frames.Count && value >= 0)
                    pictureBox1.Image = frames[colorTrackBarPlayer.Value];
            }

        }

        internal void FitSizeChanged(int fitSize)
        {
            if (formSC != null)
            {

            }

        }

        bool maxedOut = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            maxedOut = !maxedOut;

            panelLeft.Visible = !maxedOut;
            panelRight.Visible = !maxedOut;
            panelBottom.Visible = !maxedOut;
            panelTop.Visible = !maxedOut;

            if (maxedOut)
            {
                panelMain.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 0);
                panelMain.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 0);

                panelMain.RowStyles[0] = new RowStyle(SizeType.Absolute, 0);
                panelMain.RowStyles[2] = new RowStyle(SizeType.Absolute, 0);
            }
            else
            {
                panelMain.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 40);
                panelMain.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 40);

                panelMain.RowStyles[0] = new RowStyle(SizeType.Absolute, 80);
                panelMain.RowStyles[2] = new RowStyle(SizeType.Absolute, 80);
            }


        }
    }
}