using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Redream;
using static Redream.MyFunctions;

namespace Redream
{
    public partial class FormScreenShot : Form
    {
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
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////
        /// </summary>



        int formSize = 32;
        int ratioX = 16;
        int ratioY = 16;

        bool isClicked = false;
        Point mouseLocation = new Point(0, 0);
        bool isMouseInside = false;
        bool isStarted = false;

        float defaultOpacity = 0.25f;
        float opacity = 0.25f;

        private bool isDrawing;
        private Point previousPoint;



        public bool IsStarted
        {
            get
            {
                return isStarted;
            }
            set
            {
                isStarted = value;
            }
        }

        bool isMaskEnabled = true;
        public bool IsMaskEnabled
        {
            get { return isMaskEnabled; }
            set { ToggleMask(value); }
        }
        public bool IsMaskInit { get; set; }
        Color colorMaskB = Color.White;
        Color colorMaskF = Color.Black;

        public Form1 ParentForm { get; set; }

        public FormScreenShot(bool IsSingleFrame = true)
        {
            InitializeComponent();
            mask = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            this.TopMost = true;
            // mousewheel events
            pictureBox1.MouseWheel += new MouseEventHandler(pictureBox1_MouseWheel);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseWheel);

            opacity = defaultOpacity;
            this.opacity = defaultOpacity;

            ToggleMask(isMaskEnabled);
            //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            //timer.Interval = 10;
            //timer.Tick += new EventHandler(OnTick);
            //timer.Start();

        }



        public static Point GetCursorPosition()
        {

            POINT lpPoint;
            GetCursorPos(out lpPoint);
            // NOTE: If you need error handling
            // bool success = GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }



        void OnTick(object sender, EventArgs e)
        {
            mouseLocation = GetCursorPosition();
            if (isGrabbing)
            {


                mouseLocation.X = mouseLocation.X - this.Width / 2;
                mouseLocation.Y = mouseLocation.Y - this.Height / 2;

                this.Location = mouseLocation;
            }


            isMouseInside = IsMouseInsideForm(mouseLocation, this);
            if (isGrabbing && isStarted)
            {
                // DisplayImage(isMouseInside);
            }

        }



        // change brush size
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {


            if (e.Delta != 0)
            {
                int previousSizeX = this.Size.Width;
                int previousSizeY = this.Size.Height;
                //MessageBox.Show("f");
                if (e.Delta > 0)
                {
                    if (!isGrabbing)
                        drawSize = Math.Clamp(drawSize + 8, 8, 512);
                    else if (isGrabbing)
                        formSize = formSize + 2;
                }
                else
                {
                    if (!isGrabbing)
                        drawSize = Math.Clamp(drawSize - 8, 8, 512);
                    else if (isGrabbing)
                    {
                        formSize = formSize - 2;
                        if (formSize < 2)
                        { formSize = 2; }
                    }

                }

                if (isGrabbing)
                {
                    float w = formSize * ratioX;
                    float h = formSize * ratioY;
                    this.Size = new Size((int)w, (int)h);
                    int x = e.Location.X;
                    int y = e.Location.Y;


                    int newSizeDifferenceX = this.Size.Width - previousSizeX;
                    int newSizeDifferenceY = this.Size.Height - previousSizeY;

                    //this.Location = new Point(x - newSizeDifferenceX / 2, y - newSizeDifferenceY / 2);

                    //this.Location = new Point(this.Location.X - newSizeDifferenceX / 2, this.Location.Y - newSizeDifferenceY / 2);

                    label1.Text = Size.Width.ToString() + "x" + Size.Height.ToString();
                    img = null;
                    //CreateMaskBitmap();
                }

            }
            pictureBox1.Refresh();


        }




        public Task<Bitmap> TakeScreeenShot()
        {
            defaultOpacity = 0.25f;
            //pictureBox1.Image = null;
            Bitmap bmpScreenshot = new Bitmap(this.Width, this.Height);

            Graphics g = Graphics.FromImage(bmpScreenshot);
            using (Brush brush = new SolidBrush(Color.Black))
                g.FillRectangle(brush, 0, 0, bmpScreenshot.Width, bmpScreenshot.Height);

            this.Opacity = 0.01;
            g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, new Size(this.Width, this.Height));
            this.Opacity = opacity;


            if (ParentForm.control_Settings.FaceDetection)
            {
                Rectangle[] faces = MyFunctions.DetectAndApplyMask(bmpScreenshot);
                if (faces.Length > 0)
                {
                    using (Graphics graphics = Graphics.FromImage(mask))
                    {
                        graphics.FillRectangle(new SolidBrush(colorMaskB), 0, 0, mask.Width, mask.Height);
                        foreach (Rectangle face in faces)
                        {

                            Rectangle rec = new Rectangle(face.X, face.Y - face.Width / 4, face.Height, face.Height + face.Height / 3);

                            graphics.FillEllipse(new SolidBrush(colorMaskF), rec);


                        }
                   
                    }

                }

            }

            pictureBox1.Refresh();

            return Task.FromResult(bmpScreenshot);
        }


        public void ChangeRatio(int rX, int rY)
        {
            ratioX = rX;
            ratioY = rY;
            float w = formSize * ratioX;
            float h = formSize * ratioY;
            this.Size = new Size((int)w, (int)h);

            label1.Text = Size.Width.ToString() + "x" + Size.Height.ToString();
            img = null;
            CreateMaskBitmap();

        }


        private void panelMask_Paint(object sender, PaintEventArgs e)
        {
            /*
            Point l = new Point(-10, 0);
            Rectangle r = new Rectangle(l, new Size(5000, 5000));
            Pen p = new Pen(Color.Black);
            e.Graphics.DrawRectangle(p, r);
            ControlPaint.DrawBorder(e.Graphics, r, Color.Red, ButtonBorderStyle.Dotted);
            */

        }

        public void ToggleMask(bool isEnabled)
        {
            DisplayImage(false);
            isMaskEnabled = isEnabled;


            if (isMaskEnabled)
            {
                colorMaskB = Color.White;
                colorMaskF = Color.Black;
            }
            else
            {
                colorMaskB = Color.Black;
                colorMaskF = Color.White;
            }


            if (isMaskEnabled)
            {
                pictureBox1.BackColor = Color.FromArgb(85, 35, 25);
                CreateMaskBitmap();

                //panelMask.BackColor = pictureBox1.BackColor;
            }
            else
            {
                CreateMaskBitmap();
                pictureBox1.BackColor = Color.FromArgb(50, 50, 50);
                // panelMask.BackColor = Color.FromArgb(120, 40, 20);
            }


            //int fillHeight = this.Size.Height - (this.Size.Height * percentage / 100);

            //panelMask.Size = new Size(this.Size.Width, fillHeight);
            //panelMask.Refresh();

        }

        Bitmap img = null;
        internal void SetImage(Bitmap bmp)
        {
            img = bmp;
        }


        internal void DisplayImage(bool enable = true)
        {

            if (enable && img != null)
            {
                pictureBox1.Image = img;
                opacity = 1;
                this.Opacity = opacity;

            }
            else
            {
                pictureBox1.Image = mask;
                opacity = defaultOpacity;
                this.Opacity = opacity;
            }
        }

        private void FormScreenShot_SizeChanged(object sender, EventArgs e)
        {
            drawSize = this.Size.Width / 8;
            ToggleMask(isMaskEnabled);
        }

        private void FormScreenShot_LocationChanged(object sender, EventArgs e)
        {
            img = null;
            DisplayImage(false);
        }



        private bool IsMouseInsideForm(Point mouseLocation, Form form)
        {
            // Get the bounds of the form
            Rectangle formBounds = form.Bounds;

            // Check if the mouse location is inside the form bounds
            if (formBounds.Contains(mouseLocation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public Point downPoint = Point.Empty;
        private Color drawColor = Color.White;
        private int drawSize = 32;


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isMouseInsideinitImage)
            {
                Point local = pictureBox1.PointToClient(Cursor.Position);
                int x = local.X;
                int y = local.Y;

                Rectangle bounds = new Rectangle(x - drawSize / 2, y - drawSize / 2, drawSize, drawSize);
                e.Graphics.SmoothingMode = SmoothingMode.None;

                int radius = (int)Math.Ceiling(drawSize / 2.0);

                using (Pen p = new Pen(Color.Green))
                {
                    p.Width = 2;
                    e.Graphics.DrawEllipse(p, bounds);
                }
            }

        }

        bool isGrabbing;
        private void FormScreenShot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                drawColor = colorMaskF;
                if (e.Button == MouseButtons.Middle)
                    drawColor = colorMaskB;


                isDrawing = true;
                isGrabbing = false;
                previousPoint = e.Location;
                using (Graphics maskGraphics = Graphics.FromImage(mask))
                {
                    using (Pen pen = new Pen(drawColor, drawSize))
                    {
                        int radius = (int)Math.Ceiling(drawSize / 2.0);
                        int x = e.Location.X - radius;
                        int y = e.Location.Y - radius;
                        Rectangle circleBounds = new Rectangle(x, y, drawSize, drawSize);
                        maskGraphics.DrawLine(pen, previousPoint, e.Location);
                        maskGraphics.FillEllipse(pen.Brush, circleBounds);

                    }
                }

                IsMaskInit = false;

            }
            else
            {
                downPoint = e.Location;
                isDrawing = false;
                isGrabbing = true;
            }


        }


        private void FormScreenShot_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && previousPoint != null)
            {
                using (Graphics maskGraphics = Graphics.FromImage(mask))
                {
                    using (Pen pen = new Pen(drawColor, drawSize))
                    {
                        int radius = (int)Math.Ceiling(drawSize / 2.0);
                        int x = e.Location.X - radius;
                        int y = e.Location.Y - radius;
                        Rectangle circleBounds = new Rectangle(x, y, drawSize, drawSize);
                        maskGraphics.DrawLine(pen, previousPoint, e.Location);
                        maskGraphics.FillEllipse(pen.Brush, circleBounds);

                    }
                }

                previousPoint = e.Location;
                pictureBox1.Image = mask;
            }

            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);

            pictureBox1.Refresh();
        }

        private void FormScreenShot_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics maskGraphics = Graphics.FromImage(mask))
                {
                    using (Pen pen = new Pen(drawColor, drawSize))
                    {
                        int radius = (int)Math.Ceiling(drawSize / 2.0);
                        int x = e.Location.X - radius;
                        int y = e.Location.Y - radius;
                        Rectangle circleBounds = new Rectangle(x, y, drawSize, drawSize);
                        maskGraphics.DrawLine(pen, previousPoint, e.Location);
                        maskGraphics.FillEllipse(pen.Brush, circleBounds);

                    }
                }


            }
            else
            {
                this.BackColor = Color.Green;
                downPoint = Point.Empty;
            }
            isDrawing = false;
            isGrabbing = false;
            previousPoint = Point.Empty;
        }



        Bitmap mask = new Bitmap(512, 512);
        public Bitmap Mask
        {
            get
            {
                return mask;
            }
            set
            {
                mask = value;
            }
        }


        private void CreateMaskBitmap()
        {


            mask = new Bitmap(this.Width, this.Height);

            using (Graphics g = Graphics.FromImage(mask))
            {
                Brush brush = new SolidBrush(colorMaskB);
                g.Clear(colorMaskB);
                //g.FillRectangle(brush, 0,0, mask.Width, mask.Height);

                if (!isMaskEnabled)
                {
                    brush = new SolidBrush(Color.White);
                    g.FillRectangle(brush, 0, 0, 4, 8);
                }


            }

            IsMaskInit = true;
            pictureBox1.Image = mask;

        }

        bool isMouseInsideinitImage = false;

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            isMouseInsideinitImage = true;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            isMouseInsideinitImage = false;
            pictureBox1.Refresh();
        }

        private VideoCapture _capture = new VideoCapture(); // Create a new VideoCapture instance

        public async Task<Bitmap> CaptureWebcam()
        {
            Mat frame = new Mat();
            _capture.Read(frame);
            pictureBox1.Image = frame.ToBitmap();
            this.Size = pictureBox1.Image.Size;
            defaultOpacity = 1;
            label1.Text = Size.Width.ToString() + "x" + Size.Height.ToString();
            return (Bitmap)pictureBox1.Image;
        }

    }
}