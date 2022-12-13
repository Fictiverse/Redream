using Newtonsoft.Json;
using Redream.Properties;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Redream
{
    public partial class Form1 : Form
    {
        List<Button> buttonList = new List<Button>();
        List<string> favPromptList = new List<string>();
        List<string> favNPromptList = new List<string>();
        string FramesPath = Application.StartupPath + "Frames";

        string negativePrompt = "";
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

            InitFavColor();

            buttonSeed.MouseWheel += new MouseEventHandler(buttonSeed_MouseWheel);
            buttonSteps.MouseWheel += new MouseEventHandler(buttonSteps_MouseWheel);
            buttonStrength.MouseWheel += new MouseEventHandler(buttonStrength_MouseWheel);
            buttonCFGScale.MouseWheel += new MouseEventHandler(buttonCFGScale_MouseWheel);
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
            buttonScreenshot.BackColor = Color.FromArgb(25, 85, 35);

            buttonScreenshot.Enabled = false;


            if (formSC == null || formSC.IsDisposed)
            {
                formSC = new FormScreenShot(false);
                formSC.Location = new Point(10000, 10000);
                formSC.ChangeRatio(ratioX, ratioY);
            }


            isSCOpen = !isSCOpen;
            if (isSCOpen)
                formSC.Show(this);
            else
                formSC.Close();
        }

        bool isStarted;
        Bitmap CurrentCapture = new Bitmap(512,512);
        private async void buttonStart_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                if (formSC != null && !formSC.IsDisposed)
                {
                    timerFadeOut.Enabled = true;
                    isStarted = true;
                    buttonStart.BackColor = Color.FromArgb(25, 85, 35);
                    buttonStart.Image = Resources.pause_button;

                    while (isStarted)
                    {
                        Bitmap bmp = formSC.TakeScreeenShot();
                        CurrentCapture = bmp;
                        await AutomaticAsync(seed, bmp);
                    }

                }
            }
            else
            {
                timerFadeOut.Enabled = false;
                isStarted = false;
                await AutomaticInterrupt();

                buttonStart.BackColor = Color.FromArgb(85, 35, 25);
                buttonStart.Image = Resources.play;
            }


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
            public string denoising_strength = "0.6";
            public string inpainting_fill = "0";
            public string mask_blur = "4";
            public string mask = null;
            public string prompt = "";
            public string negative_prompt = "";
            public string seed = "-1";
            public string n_iter = "1";
            public string batch_size = "1";
            public string steps = "20";
            public string cfg_scale = "7.5";
            public string width = "512";
            public string height = "512";
            public string restore_faces = "false";
            public string sampler_index = "Euler"; // Euler a, Euler, LMS, Heun, DPM2, DPM2 a, DPM++ 2S a, DPM++ 2M, DPM fast, DPM adaptive, LMS Karras, DPM2 Karras, DPM2 a Karras, DMP++ 2S a Karras, DMP++ 2M Karras, DDIM, PLMS
        }

        private async Task AutomaticAsync(int seed = -1, Image initimage = null)
        {

            List<string> init_images = new List<string>();

            string script = "http://127.0.0.1:7860/sdapi/v1/img2img";
            string base64Image = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(initimage));
            init_images.Add(base64Image);


            var automaticJson = new AutomaticJson
            {
                prompt = textBoxPrompt.Text,
                negative_prompt = negativePrompt,

                init_images = init_images,
                denoising_strength = strength.ToString("0.00").Replace(",","."),

                seed = seed.ToString(),
                steps = steps.ToString(),
                cfg_scale = cfgScale.ToString("0.00").Replace(",", "."),

                width = formSC.Width.ToString(),
                height = formSC.Height.ToString(),
            };

            string a = "{\"prompt\": \"maltese puppy\",\"steps\": 5}";
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

                string imagename = DateTime.Now.ToFileTime().ToString().Substring(0, 12) + ".png";

                oldimage = newImage;
                newImage = bmp;
                opacity = 0;

                if (isSaveFramesEnabled)
                {
                    string name = DateTime.Now.ToFileTime().ToString() + ".png";
                    bmp.Save(FramesPath + "\\" + name);
                }
                //pictureBox1.Image = MergeImages(initimage, bmp, 5);

            }
            catch
            {
               // SetConsoleMessage("Cannot catch the API : Image");
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
            shape++;

            if (shape == 1)
            {
                ratioX = 16;
                ratioY = 9;
                buttonShape.Image = Resources.rounded_rectangleV;

            }
            else if (shape == 2)
            {
                ratioX = 9;
                ratioY = 16;
                buttonShape.Image = Resources.rounded_rectangleH;
            }
            else
            {
                shape = 0;
                ratioX = 16;
                ratioY = 16;
                buttonShape.Image = Resources.rounded_black_square_shapeS_;
            }
            if (formSC != null)
                formSC.ChangeRatio(ratioX, ratioY);


        }
        bool dragging;
        private Point startPoint;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Location = new Point(0,0);
            }
        }

        private void panelImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Location = new Point(0, 0);
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                pictureBox1.Location = new Point(pictureBox1.Left + e.Location.X - startPoint.X, pictureBox1.Top + e.Location.Y - startPoint.Y);
                this.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        float opacity = 0;
        Bitmap oldimage = new Bitmap(512,512);
        Bitmap newImage = new Bitmap(512,512);

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (opacity < 1)
            {
                Image img = LerpImages(oldimage, newImage, opacity);
                pictureBox1.Image = img;
                opacity = opacity + 0.03f;
            }
            else
            {
                opacity = 0;
                oldimage = new Bitmap(newImage.Width, newImage.Height);
                oldimage = (Bitmap)newImage.Clone();
                pictureBox1.Image = oldimage;

            }
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

            using (Graphics g = Graphics.FromImage(img1))
                g.DrawImage(bmp, 0, 0, img2.Width, img2.Height);
            return img1;
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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", FramesPath);
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
                buttonFav.BackColor = Color.FromArgb(25, 65, 85);

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

        private void buttonM_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (isFaving)
            {
                IniFile iniFile = new IniFile("fav.ini");
                iniFile.Write("P" + btn.Text, textBoxPrompt.Text);
                favPromptList[int.Parse(btn.Text)-1] = textBoxPrompt.Text;

                InitFavColor();
            }
            else
            {
                textBoxPrompt.Text = favPromptList[int.Parse(btn.Text) - 1];
                negativePrompt = favNPromptList[int.Parse(btn.Text) - 1];
            }

        }


        int steps = 16;
        private void buttonSteps_Click(object sender, EventArgs e)
        {
            steps = steps + 8;
            if (steps > 48)
                steps = 8;

            steps = Math.Clamp(steps, 8, 48);

            if (steps < 16)
                buttonSteps.Image = Resources.level1;
            else if (steps < 32)
                buttonSteps.Image = Resources.level2;
            else
                buttonSteps.Image = Resources.level3;

            buttonSteps.Text = steps.ToString();

        }

        private void buttonSteps_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                steps = steps + 4;
            else if (e.Delta < 0)
                steps = steps - 4;

            steps = Math.Clamp(steps, 4, 48);

            if (steps < 16)
                buttonSteps.Image = Resources.level1;
            else if (steps < 32)
                buttonSteps.Image = Resources.level2;
            else
                buttonSteps.Image = Resources.level3;

            buttonSteps.Text = steps.ToString();

        }


        float strength = 0.5f;
        private void buttonStrength_Click(object sender, EventArgs e)
        {

            strength = strength + 0.1f;
            if (strength > 1)
                strength = 0.1f;

            strength = Math.Clamp(strength, 0.05f, 0.95f);
            buttonStrength.Text = strength.ToString("0.00");
        }

        private void buttonStrength_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                strength = strength + 0.05f;
            else if (e.Delta < 0)
                strength = strength - 0.05f;

            strength = Math.Clamp(strength, 0.05f, 0.95f);
            buttonStrength.Text = strength.ToString("0.00");

        }

        int seed = -1;
        private void buttonSeed_Click(object sender, EventArgs e)
        {
            Random r = new Random();


            if (seed == -1)
                seed = r.Next(999);
            else
                seed = -1;

            buttonSeed.Text = seed.ToString();
        }

        private void buttonSeed_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                seed = seed + 9;
            else if (e.Delta < 0)
                seed = seed - 9;

            seed = Math.Clamp(seed, -1, 999);


            buttonSeed.Text = seed.ToString();

        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 0);
            this.Size = new Size(pictureBox1.Width + 103, pictureBox1.Height + 128);
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
            } catch{}


        }

        float cfgScale = 7.5f;
        private void buttonCFGScale_Click(object sender, EventArgs e)
        {
            cfgScale = cfgScale + 4;
            if (cfgScale > 16)
                cfgScale = 4;

            cfgScale = Math.Clamp(cfgScale, 1, 16);
            buttonCFGScale.Text = cfgScale.ToString("0.0");
        }

        private void buttonCFGScale_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                cfgScale = cfgScale + 0.5f;
            else if (e.Delta < 0)
                cfgScale = cfgScale - 0.5f;

            cfgScale = Math.Clamp(cfgScale, 0.5f, 16);
            buttonCFGScale.Text = cfgScale.ToString("0.0");

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
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y -downPoint.Y);
        }

        private void buttonResize_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void buttonDiscord_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.UseShellExecute = true;
            pr.StartInfo.FileName = "https://discord.gg/faje9TJM";
            pr.Start();

        }
    }
}