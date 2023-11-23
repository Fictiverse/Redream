using Emgu.CV;
using Emgu.CV.Reg;
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
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using static Redream.MyFunctions;
using static Redream.API;
using System.Collections.Specialized;
using Emgu.CV.Dai;
using Emgu.CV.OCR;

namespace Redream
{
    public enum DeviceType
    {
        Screenshot,
        Webcam
    }

    public partial class Form1 : Form
    {
        public string version = "1.16";

        List<Button> buttonList = new List<Button>();
        List<string> favPromptList = new List<string>();
        List<string> favNPromptList = new List<string>();
        string FramesPath = Application.StartupPath + "Frames";

        public userControl_Settings control_Settings = new userControl_Settings();

        FormScreenShot formSC = null;
        bool isSCOpen = false;

        bool isStarted;
        Bitmap CurrentCapture = new Bitmap(512, 512);

        List<Bitmap> frames = new List<Bitmap>();

        int shape = 0;
        int ratioX = 16;
        int ratioY = 16;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Fictiverse : Redream " + version;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }


        private void SaveSettings()
        {
            var json = JsonConvert.SerializeObject(new
            {
                isMaskEnabled = isMaskEnabled,
                shape = shape,
                isNormSize = isNormSize,

                seed = seed,
                steps = steps,
                strength = strength,
                cfgScale = cfgScale,
                samplerIndex = samplerIndex,
                faceDetection = control_Settings.FaceDetection,
                fitSize = control_Settings.FitSize,
                IP = control_Settings.textBoxIP.Text

            }); ;
            File.WriteAllText("Settings.json", json);
        }
        private void LoadSettings()
        {
            try
            {
                string json = File.ReadAllText("Settings.json");

                dynamic data = JObject.Parse(json);

                isMaskEnabled = data.isMaskEnabled;
                SwitchMaskButton(isMaskEnabled);

                shape = data.shape;
                SwitchShape(shape);

                isNormSize = data.isNormSize;
                SwitchNormSize(isNormSize);

                seed = data.seed;
                buttonSeed.Text = seed.ToString();
                control_Settings.Seed = seed.ToString();

                steps = data.steps;
                buttonSteps.Text = steps.ToString();
                control_Settings.Steps = steps.ToString();
                if (steps < 16)
                    buttonSteps.Image = Resources.level1;
                else if (steps < 32)
                    buttonSteps.Image = Resources.level2;
                else
                    buttonSteps.Image = Resources.level3;

                strength = data.strength;
                buttonStrength.Text = strength.ToString("0.00");
                control_Settings.Strength = strength;


                cfgScale = data.cfgScale;
                buttonCFGScale.Text = cfgScale.ToString("0.0");
                control_Settings.CFGScale = cfgScale.ToString("0.0");

                samplerIndex = data.samplerIndex;
                toolTip1.SetToolTip(buttonSampler, samplers[samplerIndex]);
                control_Settings.Sampler = samplers[samplerIndex];

                control_Settings.FaceDetection = data.faceDetection;
                control_Settings.FitSize = data.fitSize;
                control_Settings.textBoxIP.Text = data.IP;
            }
            catch (Exception ex) { };
        }

        private void buttonScreenshot_Click(object sender, EventArgs e)
        {
            ToggleScreenshot();
        }

        private void ToggleScreenshot()
        {
            if (formSC == null || formSC.IsDisposed)
            {
                formSC = new FormScreenShot(false);
                formSC.ParentForm = this;
                formSC.IsMaskEnabled = isMaskEnabled;
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
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {

            if (formSC != null && !formSC.IsDisposed)
            {
                isStarted = !isStarted;
                panelPlayer.Enabled = !isStarted;
                ClearMemory();
                TogglePlayer(false);
                SaveSettings();
                formSC.IsStarted = isStarted;

                if (isStarted)
                {
                    frames.Clear();
                    //timerFadeOut.Enabled = true;
                    last64Image = null;
                    buttonStart.BackColor = Color.FromArgb(25, 85, 35);
                    buttonStart.Image = Resources.pause_button;

                    while (isStarted && formSC != null)
                    {
                        await AutomaticAsync();
                    }
                }
                else
                    Stop();
            }
            else
                ToggleScreenshot();
        }

        public async void Stop()
        {
            timerFadeOut.Enabled = false;
            isStarted = false;
            if (formSC != null && !formSC.IsDisposed)
                formSC.IsStarted = false;

            await AutomaticInterrupt(control_Settings.textBoxIP.Text);

            buttonStart.BackColor = Color.FromArgb(85, 35, 25);
            buttonStart.Image = Resources.play;
            UpdatePlayer();
        }

        string last64Image = null;
        private async Task AutomaticAsync()
        {
            Image initimage = null;

            if (control_Settings.CaptureDevice == DeviceType.Webcam)
                initimage = await formSC.CaptureWebcam();
            else
                initimage = await formSC.TakeScreeenShot();

            CurrentCapture = (Bitmap)initimage;

            if (initimage != null)
            {
                string script = "http://" + control_Settings.textBoxIP.Text + "/sdapi/v1/img2img";


                Bitmap msk = formSC.Mask;

                Size size = initimage.Size;
                size.Width = size.Width / 8 * 8;
                size.Height = size.Height / 8 * 8;


                if (isNormSize)
                    size = NormalizeSize(size, control_Settings.FitSize);

                initimage = ResizeImage((Bitmap)initimage.Clone(), size);
                msk = ResizeImage((Bitmap)msk.Clone(), size);

                string base64Image = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(initimage));

                if (last64Image == null)
                    last64Image = base64Image;

                List<string> init_images = new List<string> { base64Image };

                string base64Mask = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(msk));

                int inpainting_fill = strength >= 0.98 ? 3 : 1;

                var requestBody = new Dictionary<string, object>
            {
                { "init_images", init_images },
                { "mask", base64Mask },
                { "mask_blur", 3 },
                { "inpainting_fill", inpainting_fill },
                { "denoising_strength", strength },
                { "prompt", textBoxPrompt.Text },
                { "negative_prompt", textBoxPromptN.Text },
                { "seed", buttonSeed.Text },
                { "steps", steps },
                { "cfg_scale", cfgScale },
                { "batch_size", 1 },
                { "n_iter", 1 },
                { "width", size.Width },
                { "height", size.Height },
                { "sampler_index", samplers[samplerIndex] }
            };

                string module = control_Settings.SelectedControlNetPreprossessor;
                string model = control_Settings.SelectedControlNetModel;

                if (module.ToLower() != "none" || model.ToLower() != "none")
                {
                    var alwaysonScripts = new Dictionary<string, object>
                {
                    {
                        "controlnet", new Dictionary<string, object>
                        {
                            {
                                "args", new []
                                {
                                    new Dictionary<string, object>
                                    {
                                        { "image", init_images[0] },
                                        { "module", module },
                                        { "model", model },
                                        { "weight", 0.7f },       // Set weight as float (0.7f)
                                        { "guidance", 1.0f },      // Set guidance as float (1.0f)
                                        { "processor_res", 512 },
                                    },
                                    /*
                                    new Dictionary<string, object>
                                    {
                                        { "image", last64Image },
                                        { "module", "none" },
                                        { "model", "diff_control_sd15_temporalnet_fp16 [adc6bd97]" },
                                        { "weight", 0.7f },       // Set weight as float (0.7f)
                                        { "guidance", 1.0f }      // Set guidance as float (1.0f)
                                    }
                                    */
                                }
                            }
                        }
                    }
                };
                    requestBody.Add("alwayson_scripts", alwaysonScripts);
                }

                try
                {
                    string json = JsonConvert.SerializeObject(requestBody);
                    var client = new HttpClient();
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var request = new HttpRequestMessage
                    {
                        RequestUri = new Uri(script),
                        Method = HttpMethod.Post,
                        Content = content
                    };
                    var response = await client.SendAsync(request);
                    dynamic AutomaticResponse = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());

                    string imgStr = AutomaticResponse.images[0].ToString();
                    var imgB64 = Convert.FromBase64String(imgStr);
                    Bitmap bmp;
                    using (var ms = new MemoryStream(imgB64))
                        bmp = new Bitmap(Bitmap.FromStream(ms));

                    last64Image = base64Image;
                    ProcessResult(bmp);
                }
                catch (HttpRequestException ex)
                {
                    Stop();
                    MessageBox.Show("HttpRequestException occurred: " + ex.Message);
                    API_failRoutine();
                    // Handle the exception caused by network or HTTP-related issues
                }
                catch (UriFormatException ex)
                {
                    Stop();
                    MessageBox.Show("UriFormatException occurred: " + ex.Message);
                    API_failRoutine();
                    // Handle the exception caused by an invalid URL format
                }
                catch (Exception ex)
                {
                    Stop();
                    //MessageBox.Show("Other exception occurred: " + ex.Message);
                    // Handle other types of exceptions
                }
            }
        }

        public void API_failRoutine()
        {
            Stop();
            SwitchSettings(true);
            control_Settings.textBoxIP.Focus();
            control_Settings.textBoxIP.Select();
        }

        public void ProcessResult(Bitmap bmp)
        {
            frames.Add(bmp);
            string imagename = DateTime.Now.ToFileTime().ToString().Substring(0, 12) + ".png";

            oldimage = (Bitmap)newImage.Clone();
            newImage = bmp;
            opacity = 0;
            pictureBox1.Image = bmp;
            if (formSC != null)
                formSC.SetImage(bmp);

            if (isSaveFramesEnabled)
            {
                string name = DateTime.Now.ToFileTime().ToString() + ".png";
                bmp.Save(FramesPath + "\\" + name);
            }
            UpdatePlayer();
        }

        private void UpdatePlayer()
        {
            colorTrackBarPlayer.Maximum = Math.Max(frames.Count, 1);
            colorTrackBarPlayer.Value = 0;
        }

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



        bool isSaveFramesEnabled = false;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            isSaveFramesEnabled = !isSaveFramesEnabled;

            if (isSaveFramesEnabled)
                buttonSave.BackColor = Color.FromArgb(25, 85, 35);
            else
                buttonSave.BackColor = Color.FromArgb(85, 35, 25);
        }



        /// <summary>
        /// Fav
        /// </summary>
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
                iniFile.Write("N" + btn.Text, textBoxPromptN.Text);
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
                    previousClickedButton.BackColor = Color.FromArgb(25, 85, 65);

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
            SwitchStrength(0.1f, false);
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
            control_Settings.Strength = strength;
        }


        float cfgScale = 7.5f;
        private void buttonCFGScale_Click(object sender, EventArgs e)
        {
            SwitchCFGScale(4.0f, true);
        }

        private void buttonCFGScale_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SwitchCFGScale(0.1f);
            else if (e.Delta < 0)
                SwitchCFGScale(-0.1f);
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
            string text = await AutomaticInterrogate(control_Settings.textBoxIP.Text, CurrentCapture);
            if (text != null)
                textBoxPrompt.Text = text;
            buttonInterrogate.Image = Resources.text;
            buttonInterrogate.BackColor = Color.FromArgb(40, 30, 50);
            buttonInterrogate.Enabled = true;
        }

        int samplerIndex = 0;
        string[] samplers = new string[] {
          "Euler a",
          "Euler",
          "LCM",
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
        private void buttonMask_Click(object sender, EventArgs e)
        {
            SwitchMaskButton(!isMaskEnabled);
        }
        private void SwitchMaskButton(bool value)
        {
            isMaskEnabled = value;

            if (isMaskEnabled)
                buttonMask.BackColor = Color.FromArgb(25, 85, 35);
            else
                buttonMask.BackColor = Color.FromArgb(85, 35, 25);

            if (formSC != null)
                formSC.IsMaskEnabled = isMaskEnabled;
        }


        bool isMenuSettingsOpen = false;
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SwitchSettings(!isMenuSettingsOpen);
        }

        private void SwitchSettings(bool value)
        {
            isMenuSettingsOpen = value;
            control_Settings.Visible = isMenuSettingsOpen;
            control_Settings.BringToFront();
            control_Settings.InitModel();
            control_Settings.GetControletModels();
            if (isMenuSettingsOpen)
                buttonSettings.BackColor = Color.FromArgb(25, 85, 35);
            else
                buttonSettings.BackColor = Color.FromArgb(13, 13, 13);
        }


        bool isNormSize = false;
        private void buttonNormSize_Click(object sender, EventArgs e)
        {
            SwitchNormSize(!isNormSize);
        }
        private void SwitchNormSize(bool value)
        {
            isNormSize = value;
            if (isNormSize)
                buttonNormSize.BackColor = Color.FromArgb(25, 85, 35);
            else
                buttonNormSize.BackColor = Color.FromArgb(85, 35, 25);
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
                currentFrame = Math.Clamp(colorTrackBarPlayer.Value, 0, frames.Count);
                if (frames.Count > 0 && currentFrame < frames.Count && currentFrame >= 0)
                    pictureBox1.Image = frames[colorTrackBarPlayer.Value];
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





        bool isPlaying;
        int currentFrame = 0;
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (!isStarted && !isPlaying && frames.Count > 1)
                TogglePlayer(true);
            else
                TogglePlayer(false);
        }
        private void TogglePlayer(bool toggle)
        {
            isPlaying = toggle;
            if (toggle)
            {
                buttonPlay.BackColor = Color.FromArgb(25, 85, 35);
                buttonPlay.Image = Resources.pause_button;
                currentFrame = colorTrackBarPlayer.Value;
                timerPlayer.Start();
            }
            else
            {
                buttonPlay.BackColor = Color.FromArgb(85, 35, 25);
                buttonPlay.Image = Resources.play;
                timerPlayer.Stop();
            }
        }
        private async void timerPlayer_Tick(object sender, EventArgs e)
        {
            if (!isStarted && isPlaying)
            {
                if (currentFrame < frames.Count)
                {
                    pictureBox1.Image = frames[currentFrame];
                    currentFrame++;
                }
                else
                {
                    currentFrame = 0;
                }
                colorTrackBarPlayer.Value = currentFrame;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!isStarted && !isPlaying && frames.Count > 0)
            {
                currentFrame = Math.Clamp(currentFrame, 0, frames.Count - 1);
                frames.RemoveAt(currentFrame);
                pictureBox1.Image = null;
                UpdatePlayer();
                currentFrame = Math.Clamp(currentFrame - 1, 0, frames.Count);
                colorTrackBarPlayer.Value = currentFrame;
            }
        }

        private async void buttonSaveFrames_Click(object sender, EventArgs e)
        {
            buttonSaveFrames.Image = Resources.hourglass24;
            if (frames.Count > 0)
            {
                // Create and configure the FolderBrowserDialog
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select Saving Path";

                // Show the dialog and check if the user selected a folder
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string savingPath = folderBrowserDialog.SelectedPath;
                    string folderName = "Redream_" + DateTime.Now.ToFileTime().ToString().Substring(0, 12);
                    // Create the folder if it doesn't exist
                    string folderPath = Path.Combine(savingPath, folderName);
                    Directory.CreateDirectory(folderPath);

                    await SaveFrames(folderPath);

                    Process.Start("explorer.exe", folderPath);
                }
            }
            buttonSaveFrames.Image = Resources.save1;
        }

        private Task SaveFrames(string path)
        {
            for (int i = 0; i < frames.Count; i++)
            {
                string fileName = (i + 1).ToString("0000") + ".jpg";
                string filePath = Path.Combine(path, fileName);
                frames[i].Save(filePath);
            }
            return Task.CompletedTask;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", FramesPath);
        }

        bool isWebcamEnabled;
        public void ToggleDevice(DeviceType value)
        {
            //isWebcamEnabled = value;
            if (value == DeviceType.Screenshot)
            {
                buttonScreenshot.Image = Resources.selection;
            }
            else
            {
                buttonScreenshot.Image = Resources.webcam;
                SwitchMaskButton(true);
            }

        }


    }
}