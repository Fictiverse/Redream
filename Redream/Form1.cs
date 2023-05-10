using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Redream.Properties;
using System.Diagnostics;
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

        userControl_Settings control_Settings = new userControl_Settings();
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
        Bitmap CurrentCapture = new Bitmap(512, 512);
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
                        await ControlNet_Txt2Img(url_API, bmp, control_Settings.SelectedControlNetPreprossessor, control_Settings.SelectedControlNetModel);
                        // await AutomaticAsync(seed, bmp);
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
            public string prompt = "";
            public string negative_prompt = "";
            public string seed = "-1";
            public string n_iter = "1";
            public string batch_size = "1";
            public string steps = "20";
            public string cfg_scale = "7.5";
            public string width = "512";
            public string height = "512";
            //public string restore_faces = "false";
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
                negative_prompt = textBoxPromptN.Text,

                init_images = init_images,
                denoising_strength = strength.ToString("0.00").Replace(",", "."),

                seed = buttonSeed.Text,
                steps = steps.ToString(),
                cfg_scale = cfgScale.ToString("0.00").Replace(",", "."),

                width = formSC.Width.ToString(),
                height = formSC.Height.ToString(),

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


        public void ProcessResult(Bitmap bmp)
        {
            string imagename = DateTime.Now.ToFileTime().ToString().Substring(0, 12) + ".png";

            oldimage = newImage;
            newImage = bmp;
            opacity = 0;

            if (isSaveFramesEnabled)
            {
                string name = DateTime.Now.ToFileTime().ToString() + ".png";
                bmp.Save(FramesPath + "\\" + name);
            }
        }




        public class json_ControlNet
        {
            public List<string> images { get; set; }
            public string info { get; set; }
        }


        private async Task ControlNet_Txt2Img(string IP, Bitmap initimage, string module, string model, float guidanceStart = 0, float guidanceEnd = 1)
        {
            using var client = new HttpClient();
            var url = $"http://{IP}/controlnet/img2img";
            string base64Image = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(initimage));

            List<string> init_images = new List<string> { base64Image };
            string mask = null;
            // Set request body


            if (module == null)
                module = "none";
            if (model == null)
                model = "none";

            var requestBody = new
            {
                enable_hr = false,
                init_images = init_images,
                mask = mask,
                denoising_strength = strength.ToString("0.00").Replace(",", "."),
                hr_scale = 2,
                prompt = textBoxPrompt.Text,
                negative_prompt = textBoxPromptN.Text,
                seed = buttonSeed.Text,
                steps = steps.ToString(),
                cfg_scale = cfgScale.ToString("0.00").Replace(",", "."),
                batch_size = 1,
                n_iter = 1,
                width = formSC.Width.ToString(),
                height = formSC.Height.ToString(),
                sampler_index = samplers[samplerIndex],
                tiling = false,
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
                        processor_res = 512,
                        threshold_a = 64,
                        threshold_b = 64,
                        guessmode = false
                    }
                }
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
                MessageBox.Show("Error: " + response.ReasonPhrase);
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
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Location = new Point(0, 0);
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
        Bitmap oldimage = new Bitmap(512, 512);
        Bitmap newImage = new Bitmap(512, 512);

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (opacity < 1)
            {
                Image img = LerpImages(oldimage, newImage, opacity);
                pictureBox1.Image = img;
                opacity += 0.05f;
            }
            else
            {
                opacity = 0;
                oldimage?.Dispose();
                oldimage = (Bitmap)newImage.Clone();
                pictureBox1.Image = oldimage;
            }
        }




        private Image LerpImages(Image image1, Image image2, float t)
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
                favPromptList[int.Parse(btn.Text) - 1] = textBoxPrompt.Text;
                favNPromptList[int.Parse(btn.Text) - 1] = textBoxPromptN.Text;
                toolTip1.SetToolTip(btn, textBoxPrompt.Text);
                InitFavColor();
            }
            else
            {
                textBoxPrompt.Text = favPromptList[int.Parse(btn.Text) - 1];
                textBoxPromptN.Text = favNPromptList[int.Parse(btn.Text) - 1];
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
                if (strength > 0.98f)
                    strength = 0.02f;
                else if (strength < 0.02f)
                    strength = 0.98f;
            }
            strength = Math.Clamp(strength, 0.02f, 0.98f);
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
            pictureBox1.Location = new Point(0, 0);
            this.Size = new Size(pictureBox1.Width + 100, pictureBox1.Height + 145);
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
          "PLMS"
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

        private void buttonDiscord_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.UseShellExecute = true;
            pr.StartInfo.FileName = "https://discord.gg/d5WzbctxuP";
            pr.Start();

        }

        private void buttonClearPrompt_Click(object sender, EventArgs e)
        {
            textBoxPrompt.Text = "";
        }

        private void buttonClearPromptN_Click(object sender, EventArgs e)
        {
            textBoxPromptN.Text = "";
        }


        bool isDefaultSettings = false;
        private void buttonDefaultSettings_Click(object sender, EventArgs e)
        {
            isDefaultSettings = !isDefaultSettings;

            Color disabledColor = Color.FromArgb(40, 20, 40);
            if (isDefaultSettings)
            {
                buttonDefaultSettings.BackColor = Color.FromArgb(25, 85, 35);
                buttonSeed.Enabled = false;
                buttonSteps.Enabled = false;
                buttonStrength.Enabled = false;
                buttonCFGScale.Enabled = false;

                buttonSeed.BackColor = disabledColor;
                buttonSteps.BackColor = disabledColor;
                buttonStrength.BackColor = disabledColor;
                buttonCFGScale.BackColor = disabledColor;
            }
            else
            {
                buttonDefaultSettings.BackColor = Color.FromArgb(85, 35, 25);
                buttonSeed.Enabled = true;
                buttonSteps.Enabled = true;
                buttonStrength.Enabled = true;
                buttonCFGScale.Enabled = true;

                buttonSeed.BackColor = Color.FromArgb(60, 30, 60);
                buttonSteps.BackColor = Color.FromArgb(60, 30, 60);
                buttonStrength.BackColor = Color.FromArgb(60, 30, 60);
                buttonCFGScale.BackColor = Color.FromArgb(60, 30, 60);
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











































    }
}