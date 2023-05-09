using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Redream.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Redream.API;
using static Redream.MyFunctions;
namespace Redream
{
    public partial class userControl_Settings : UserControl
    {
        public userControl_Settings()
        {
            InitializeComponent();
        }


        public string Shape
        {
            set { buttonShape.Text = value; }
        }

        public string Seed
        {
            set { buttonSeed.Text = value; }
        }
        public string Steps
        {
            set { buttonSteps.Text = value; }
        }
        public string Strength
        {
            set { buttonStrength.Text = value; }
        }
        public string CFGScale
        {
            set { buttonCFGScale.Text = value; }
        }


        public string Sampler
        {
            set { buttonSampler.Text = value; }
        }








        private void userControl_Settings_Load(object sender, EventArgs e)
        {
            buttonShape.MouseWheel += new MouseEventHandler(buttonShape_MouseWheel);
            buttonSeed.MouseWheel += new MouseEventHandler(buttonSeed_MouseWheel);
            buttonSteps.MouseWheel += new MouseEventHandler(buttonSteps_MouseWheel);
            buttonStrength.MouseWheel += new MouseEventHandler(buttonStrength_MouseWheel);
            buttonCFGScale.MouseWheel += new MouseEventHandler(buttonCFGScale_MouseWheel);
            buttonSampler.MouseWheel += new MouseEventHandler(buttonSampler_MouseWheel);
        }



        private async void InitModel()
        {

            await API_RefreshModels(MainForm.url_API);
            JArray jArray = await API_GetModels(MainForm.url_API);

            if (jArray == null)
                return;

            currentModelName = await API_GetCurrentModel(MainForm.url_API);
            previousModelName = currentModelName;
            int modelIndex = -1;
            if (jArray != null)
            {
                dataModels.Rows.Clear();
                foreach (JObject obj in jArray)
                {
                    var title = (string)obj["title"];
                    var model_name = (string)obj["model_name"];
                    var hash = (string)obj["hash"];
                    var filename = (string)obj["filename"];
                    var config = (string)obj["config"];
                    int i = title.LastIndexOf('\\');

                    string folder = " ";
                    if (i > -1)
                        folder = title.Substring(0, i);

                    model_name = Path.GetFileNameWithoutExtension(title.Substring(i + 1));

                    string filePath = iconsPath + model_name + ".png";
                    Bitmap icon = null;
                    if (System.IO.File.Exists(filePath))
                        icon = OpenImage(filePath);

                    dataModels.Rows.Add(folder, model_name, icon, title, "");

                    if (title == currentModelName)
                        modelIndex = dataModels.Rows.Count - 1;
                }

                Color[] colors = { Color.FromArgb(25, 35, 55), Color.FromArgb(30, 30, 50), Color.FromArgb(27, 40, 55) };
                int colorIndex = 0;
                for (int i = 0; i < dataModels.Rows.Count; i++)
                {
                    if (i == 0 || dataModels.Rows[i].Cells[0].Value.ToString() != dataModels.Rows[i - 1].Cells[0].Value.ToString())
                        colorIndex = (colorIndex + 1) % colors.Length;

                    Color c1 = colors[colorIndex];
                    Color c2 = Color.FromArgb(colors[colorIndex].R + 10, colors[colorIndex].G + 10, colors[colorIndex].B + 10);

                    dataModels.Rows[i].Cells[0].Style.BackColor = c1;
                    dataModels.Rows[i].Cells[1].Style.BackColor = c2;
                }

            }
            dataModels.ClearSelection();
            if (modelIndex > -1)
            {
                dataModels.Rows[modelIndex].Selected = true;
                dataModels.FirstDisplayedScrollingRowIndex = modelIndex;
            }


            //currentModelName = LoadSelectedModel();
            //SelectModel(currentModelName);
        }



        public Form1 MainForm { get; set; }


        string FramesPath = Application.StartupPath + "Frames";

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", FramesPath);
        }



        string previousModelName = "";
        string currentModelName = "";
        string selectedModel = "";
        private async void dataModels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
                OpenFileDialogModelIcon(e.RowIndex);
            else if (dataModels.SelectedRows.Count > 0 && dataModels.SelectedRows[0].Cells[3].Value != null)
            {
                if (currentModelName != previousModelName)
                    previousModelName = currentModelName;
                selectedModel = dataModels.SelectedRows[0].Cells[3].Value.ToString();
                currentModelName = dataModels.SelectedRows[0].Cells[1].Value.ToString();

                await API_SetModel(MainForm.url_API, selectedModel);
            }
        }

        string iconsPath = Application.StartupPath + "Data\\Icons\\Models\\";

        private void OpenFileDialogModelIcon(int index)
        {
            var fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;...";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(iconsPath);

                using (Bitmap bm = (Bitmap)FixedSize(OpenImage(fd.FileName), 64, 64))
                {
                    bm.Save(iconsPath + dataModels.Rows[index].Cells[0].Value.ToString().Replace(" ", "_") + ".png");
                    //dataPresets.Rows[index].Cells[1].Value = bm;
                }

                Bitmap bmp = OpenImage(iconsPath + dataModels.Rows[index].Cells[0].Value.ToString().Replace(" ", "_") + ".png");
                dataModels.Rows[index].Cells[1].Value = bmp;


            }
            // prevent heavy Ram usage;
            ClearMemory();
        }


        public static Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = Width / (float)sourceWidth;
            nPercentH = Height / (float)sourceHeight;
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = Convert.ToInt16((Width -
                              sourceWidth * nPercent) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = Convert.ToInt16((Height -
                              sourceHeight * nPercent) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Transparent);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        public static Bitmap OpenImage(string path)
        {
            Bitmap img = new Bitmap(512, 512);
            try
            {
                FileStream bmp = new FileStream(path, FileMode.Open, FileAccess.Read);
                img = new Bitmap(bmp);
                bmp.Close();
            }
            catch { };


            return img;
        }
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


        private void buttonShape_Click(object sender, EventArgs e)
        {
            MainForm.SwitchShape(1);
        }

        private void buttonShape_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                MainForm.SwitchShape(1);
            else if (e.Delta < 0)
                MainForm.SwitchShape(-1);
        }



        private void buttonSeed_Click(object sender, EventArgs e)
        {
            MainForm.SwitchSeed(true);
        }
        private void buttonSeed_MouseWheel(object? sender, MouseEventArgs e)
        {
            MainForm.SwitchSeed(true);
        }

        private void buttonSteps_Click(object sender, EventArgs e)
        {
            MainForm.SwitchSteps(5);
        }

        private void buttonSteps_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                MainForm.SwitchSteps(1);
            else if (e.Delta < 0)
                MainForm.SwitchSteps(-1);
        }

        private void buttonStrength_Click(object sender, EventArgs e)
        {
            MainForm.SwitchStrength(0.1f);
        }

        private void buttonStrength_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                MainForm.SwitchStrength(0.02f);
            else if (e.Delta < 0)
                MainForm.SwitchStrength(-0.02f);
        }

        private void buttonCFGScale_Click(object sender, EventArgs e)
        {
            MainForm.SwitchCFGScale(4.0f);
        }

        private void buttonCFGScale_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                MainForm.SwitchCFGScale(0.5f);
            else if (e.Delta < 0)
                MainForm.SwitchCFGScale(-0.5f);
        }

        private void buttonSampler_Click(object sender, EventArgs e)
        {
            MainForm.SwitchSampler(false);
        }

        private void buttonSampler_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                MainForm.SwitchSampler(false);
            else if (e.Delta < 0)
                MainForm.SwitchSampler(true);
        }

        private async void buttonRefreshModels_Click(object sender, EventArgs e)
        {
            InitModel();
            //await AutomaticModels();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            SelectModel(previousModelName);
        }

        private void SelectModel(string modelname)
        {
            int index = SearchValueInDatagridView(dataModels, modelname, 1);
            dataModels.ClearSelection();
            if (index > -1)
            {
                previousModelName = currentModelName;
                currentModelName = dataModels.Rows[index].Cells[3].Value.ToString();
                dataModels.Rows[index].Selected = true;
                dataModels.FirstDisplayedScrollingRowIndex = index;
            }
        }
    }
}
