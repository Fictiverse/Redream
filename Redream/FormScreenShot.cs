using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Redream;

namespace Redream
{
    public partial class FormScreenShot : Form
    {


        /// <summary>
        /// Struct representing a point.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {

            POINT lpPoint;
            GetCursorPos(out lpPoint);
            // NOTE: If you need error handling
            // bool success = GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }


        bool isSingleFrame = false;
        public FormScreenShot(bool IsSingleFrame = true)
        {
            InitializeComponent();
            this.TopMost = true;

            isSingleFrame = IsSingleFrame;
            // mousewheel events
            this.MouseWheel += new MouseEventHandler(form_MouseWheel);
            this.MouseMove += new MouseEventHandler(form_MouseWheel);

            label1.MouseClick -= new MouseEventHandler(FormScreenShot_MouseClick);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(OnTick);
            timer.Start();
            label1.MouseClick += new MouseEventHandler(FormScreenShot_MouseClick);

        }

        bool isClicked = false;

        void OnTick(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                Point point = GetCursorPosition();

                point.X = point.X - this.Width / 2;
                point.Y = point.Y - this.Height / 2;

                this.Location = point;
            }

        }

        int formSize = 32;
        int ratioX = 16;
        int ratioY = 16;
        // change brush size
        private void form_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!isClicked)
            {
                if (e.Delta != 0)
                {
                    //MessageBox.Show("f");
                    if (e.Delta > 0)
                    {
                        formSize = formSize + 2;
                    }
                    else
                    {
                        formSize = formSize - 2;
                        if (formSize < 2)
                        { formSize = 2; }
                    }
                }

                float w = formSize * ratioX;
                float h = formSize * ratioY;
                this.Size = new Size((int)w, (int)h);

                label1.Text = Size.Width.ToString() + "x" + Size.Height.ToString();
            }

        }



        private void FormScreenShot_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isSingleFrame)
                {
                    TakeScreeenShot();
                    this.Close();
                }
                else
                {
                    isClicked = !isClicked;
                    if (isClicked)
                        this.BackColor = Color.White;
                    else
                        this.BackColor = Color.Red;
                }

            }

        }

        public Bitmap TakeScreeenShot()
        {

            Bitmap bmpScreenshot = new Bitmap(this.Width, this.Height);

            Graphics g = Graphics.FromImage(bmpScreenshot);
            using (Brush brush = new SolidBrush(Color.Black))
                g.FillRectangle(brush, 0, 0, bmpScreenshot.Width, bmpScreenshot.Height);

            this.Opacity = 0;
            g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, new Size(this.Width, this.Height));
            this.Opacity = 0.2;
            return bmpScreenshot;
            //Bitmap resized = ResizeImage(bmpScreenshot, new Size(512, 512));
            //Form1 parent = (Form1)this.Owner;
            //parent.SetInitImage(bmpScreenshot);
            // Clipboard.SetImage(bmpScreenshot);

        }

        public void ChangeRatio(int rX, int rY)
        {
            ratioX = rX;
            ratioY = rY;
            float w = formSize * ratioX;
            float h = formSize * ratioY;
            this.Size = new Size((int)w, (int)h);

            label1.Text = Size.Width.ToString() + "x" + Size.Height.ToString();
        }
    }
}