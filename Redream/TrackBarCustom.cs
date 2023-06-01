using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Redream
{
    #region Enums
    public enum CornerStyles
    {
        Rounded,
        Square
    }
    public enum Orientations
    {
        Vertical,
        Horizontal
    }
    public enum Poles
    {
        Left,
        Right,
        Top,
        Bottom
    }

    #endregion

    /// <summary>
    /// Summary description for UserControl1.
    /// </summary>
    [Description("Color Track Bar")]
    [ToolboxBitmap(typeof(TrackBar))]
    [Designer(typeof(ColorTrackBarDesigner))]
    public class ColorTrackBar : System.Windows.Forms.Control
    {
        /// <summary>
        /// Required designer variable.TODO
        /// </summary>
        #region Private Properties
        private int trackSize = 25;
        private Poles maxSide = Poles.Right;
        private CornerStyles cornerStyle = CornerStyles.Square;
        private Orientations barOrientation = Orientations.Horizontal;
        private Rectangle trackRect = Rectangle.Empty;
        private int mousestartPos = -1;
        private bool leftbuttonDown = false;
        private Color barborderColor = Color.Black;
        private Color barColor = Color.White;
        private Color trackborderColor = Color.Black;
        private Color trackColor = Color.Red;
        private int borderWidth = 1;
        private int trackerValue = 25;
        private int barMinimum = 0;
        private int barMaximum = 100;
        private System.ComponentModel.Container components = null;
        #endregion

        #region Public Properites
        /// <summary>
        /// Set Trackerbar size
        /// </summary>
        [Description("Set Trackbar size")]
        [Category("ColorTrackBar")]
        public int TrackerSize
        {
            get
            {
                return trackSize;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("value must be greater then zero");
                //cannot set TrackerSize for rounded corners
                if (cornerStyle == CornerStyles.Rounded)
                {
                    switch (barOrientation)
                    {
                        case Orientations.Horizontal:
                            value = this.Height;
                            break;
                        case Orientations.Vertical:
                            value = this.Width;
                            break;
                    }
                }
                switch (barOrientation)
                {
                    case Orientations.Horizontal:
                        if (value > ClientRectangle.Width / 2)
                            value = ClientRectangle.Width / 2;
                        break;
                    case Orientations.Vertical:
                        if (value > ClientRectangle.Height / 2)
                            value = ClientRectangle.Height / 2;
                        break;
                }
                trackSize = value;
                trackRect = Rectangle.Empty;
                this.Invalidate();
            }
        }
        /// <summary>
        /// Set Trackerbar minimum value
        /// </summary>
        [Description("Set Minimum value of the Track bar")]
        [Category("ColorTrackBar")]
        [RefreshProperties(RefreshProperties.All)]
        public int Minimum
        {
            set
            {
                if (value >= barMaximum)
                {
                    throw new ArgumentException("'" + value + "' is not a valid value for 'Mimimum'.\n" +
                        "'Minimum' must be less than 'Maximum'.");
                }
                this.barMinimum = value;
                if (this.trackerValue < this.barMinimum)
                    this.trackerValue = value;
                trackRect = Rectangle.Empty;
                this.Invalidate();
            }
            get { return this.barMinimum; }
        }
        /// <summary>
        /// Set TrackerBar maximum value
        /// </summary>
        [Description("Set Maximum value of the Track bar")]
        [Category("ColorTrackBar")]
        [RefreshProperties(RefreshProperties.All)]
        public int Maximum
        {
            set
            {
                if (value <= barMinimum)
                {
                    throw new ArgumentException("'" + value + "' is not a valid value for 'Maximum'.\n" +
                        "'Maximum' must be greater than 'Minimum'.");
                }
                if (this.trackerValue > value)
                    this.trackerValue = value;
                this.barMaximum = value;
                trackRect = Rectangle.Empty;
                this.Invalidate();
            }
            get { return this.barMaximum; }
        }

        /// <summary>
        /// Set the poles of the trackbar
        /// </summary>
        [Description("Select the side of the control to represent the maximum range value")]
        [Category("ColorTrackBar")]
        public Poles MaximumValueSide
        {
            get
            {
                return maxSide;
            }
            set
            {
                switch (barOrientation)
                {
                    case Orientations.Horizontal:
                        if (value == Poles.Top || value == Poles.Bottom)
                        {
                            throw new ArgumentException("Since your Orientation is set to Horizontal, you can only select" +
                                " Left or Right for this property");
                        }
                        break;
                    case Orientations.Vertical:
                        if (value == Poles.Left || value == Poles.Right)
                        {
                            throw new ArgumentException("Since your Orientation is set to Vertical, you can only select" +
                                " Top or Bottom for this property");
                        }
                        break;
                }
                maxSide = value;
                trackRect = Rectangle.Empty;
                this.Invalidate();
            }
        }
        /// <summary>
        /// Set tracker bar orientation
        /// </summary>
        [Description("Set whether the bar will be Veirtically or Horizontally oriented")]
        [Category("ColorTrackBar")]
        [RefreshProperties(RefreshProperties.All)]
        public Orientations BarOrientation
        {
            set
            {
                //check old value//set new size 
                if (this.barOrientation == Orientations.Horizontal)
                    base.Size = new Size(base.Size.Height, base.Size.Width);
                else
                    base.Size = new Size(base.Size.Height, base.Size.Width);
                this.barOrientation = value;
                if (value == Orientations.Vertical &&
                    (this.maxSide != Poles.Bottom && this.maxSide != Poles.Top))
                    this.MaximumValueSide = Poles.Bottom;
                if (value == Orientations.Horizontal &&
                    (this.maxSide != Poles.Left && this.maxSide != Poles.Right))
                    this.MaximumValueSide = Poles.Right;
                trackRect = Rectangle.Empty;
                this.Invalidate();
            }
            get { return this.barOrientation; }
        }

        /// <summary>
        /// Background Bar Border Color
        /// </summary>
        [Description("Bar border color")]
        [Category("ColorTrackBar")]
        public Color BarBorderColor
        {
            set { this.barborderColor = value; this.Invalidate(); }
            get { return this.barborderColor; }
        }
        /// <summary>
        /// Background bar Color
        /// </summary>
        [Description("Bar color")]
        [Category("ColorTrackBar")]
        public Color BarColor
        {
            set { this.barColor = value; this.Invalidate(); }
            get { return this.barColor; }
        }
        /// <summary>
        /// Set control corner style
        /// </summary>
        [Description("Set the shape of the control's corners")]
        [Category("ColorTrackBar")]
        [RefreshProperties(RefreshProperties.All)]
        public CornerStyles ControlCornerStyle
        {
            set
            {
                switch (barOrientation)
                {
                    case Orientations.Horizontal:
                        if (value == CornerStyles.Rounded)
                        {
                            if (this.Width < this.Height)
                                this.Width = this.Height;
                            this.trackSize = this.Height;
                        }
                        break;
                    case Orientations.Vertical:
                        if (value == CornerStyles.Rounded)
                        {
                            if (this.Height < this.Width)
                                this.Height = this.Width;
                            this.trackSize = this.Width;
                        }
                        break;
                    default:
                        break;
                }
                this.cornerStyle = value;
                trackRect = Rectangle.Empty;
                this.Invalidate();
            }
            get { return this.cornerStyle; }
        }
        /// <summary>
        /// Set Trakcer border color
        /// </summary>
        [Description("Tracker border color")]
        [Category("ColorTrackBar")]
        public Color TrackerBorderColor
        {
            set { this.trackborderColor = value; this.Invalidate(); }
            get { return this.trackborderColor; }
        }
        /// <summary>
        /// Tracker bar COlor
        /// </summary>
        [Description("Tracker color")]
        [Category("ColorTrackBar")]
        public Color TrackerColor
        {
            set { this.trackColor = value; this.Invalidate(); }
            get { return this.trackColor; }
        }
        /// <summary>
        /// Setr Tracker var current value
        /// </summary>
        [Description("Set or get the Tracker position")]
        [Category("ColorTrackBar")]
        public int Value
        {
            set
            {
                if (value <= barMinimum)
                    value = barMinimum;
                if (value >= barMaximum)
                    value = barMaximum;
                trackerValue = value;
                trackRect = Rectangle.Empty;
                this.Invalidate();
            }
            get { return trackerValue; }
        }
        #endregion

        #region Position Macros
        public static ushort LowWord(uint value)
        {
            return (ushort)(value & 0xFFFF);
        }
        public static ushort HighWord(uint value)
        {
            return (ushort)(value >> 16);
        }
        #endregion

        #region Event Delegates
        public delegate void ScrollEventHandler(object sender, EventArgs e);
        public delegate void ValueChangedEventHandler(object sender, EventArgs e);
        #endregion

        #region Events
        /// <summary>
        /// Fires when track bar posotion has changed
        /// </summary>
        [Description("Event fires when the Value property changes")]
        [Category("Action")]
        public event ValueChangedEventHandler ValueChanged;
        /// <summary>
        /// Fires when track bar changes positions
        /// </summary>
        [Description("Event fires when the Trackbar position is changed")]
        [Category("Behavior")]
        public event ScrollEventHandler Scroll;
        #endregion

        #region Public Methods
        protected virtual void OnScroll()
        {
            try
            {
                if (Scroll != null)
                    Scroll(this, new EventArgs());
            }
            catch (Exception Err)
            {
                MessageBox.Show("OnScroll Exception: " + Err.Message);
            }
        }
        protected virtual void OnValueChanged()
        {
            try
            {
                if (ValueChanged != null)
                    ValueChanged(this, new EventArgs());
            }
            catch (Exception Err)
            {
                MessageBox.Show("OnValueChanged Exception: " + Err.Message);
            }
        }
        #endregion

        #region WndProc
        protected override void WndProc(ref Message m)
        {
            //WM_LBUTTONDOWN
            #region WM_LBUTTONDOWN
            if (m.Msg == 0x0201)
            {
                leftbuttonDown = true;
                Point CurPoint = new Point(LowWord((uint)m.LParam), HighWord((uint)m.LParam));
                if (trackRect.Contains(CurPoint))
                {
                    if (!leftbuttonDown)
                    {
                        leftbuttonDown = true;
                        switch (this.barOrientation)
                        {
                            case Orientations.Horizontal:
                                mousestartPos = CurPoint.X - trackRect.X;
                                break;
                            case Orientations.Vertical:
                                mousestartPos = CurPoint.Y - trackRect.Y;
                                break;
                        }
                    }
                }
                else
                {
                    int OffSet = 0;
                    switch (this.barOrientation)
                    {
                        case Orientations.Horizontal:
                            if (trackRect.Right + (CurPoint.X - trackRect.X - (trackRect.Width / 2)) >= this.Width)
                                OffSet = this.Width - trackRect.Right - 1;
                            else if (trackRect.Left + (CurPoint.X - trackRect.X - (trackRect.Width / 2)) <= 0)
                                OffSet = (trackRect.Left - 1) * -1;
                            else
                                OffSet = CurPoint.X - trackRect.X - (trackRect.Width / 2);
                            trackRect.Offset(OffSet, 0);
                            trackerValue = (int)(((trackRect.X - 1) * (barMaximum - barMinimum)) / (this.Width - trackSize - 2));
                            if (maxSide == Poles.Left)
                                trackerValue = (trackerValue - (barMaximum - barMinimum)) * -1;
                            break;
                        case Orientations.Vertical:
                            if (trackRect.Bottom + (CurPoint.Y - trackRect.Y - (trackRect.Height / 2)) >= this.Height)
                                OffSet = this.Height - trackRect.Bottom - 1;
                            else if (trackRect.Top + (CurPoint.Y - trackRect.Y - (trackRect.Height / 2)) <= 0)
                                OffSet = (trackRect.Top - 1) * -1;
                            else
                                OffSet = CurPoint.Y - trackRect.Y - (trackRect.Height / 2);
                            trackRect.Offset(0, OffSet);
                            trackerValue = (int)(((trackRect.Y - 1) * (barMaximum - barMinimum)) / (this.Height - trackSize - 2));
                            if (maxSide == Poles.Top)
                                trackerValue = (trackerValue - (barMaximum - barMinimum)) * -1;
                            break;
                        default:
                            break;
                    }
                    trackerValue += barMinimum;
                    this.Invalidate();
                    if (OffSet != 0)
                    {
                        OnScroll();
                        OnValueChanged();
                    }
                }
                this.Focus();
            }
            #endregion

            #region WM_LBUTTONUP
            if (m.Msg == 0x0202)
            {
                leftbuttonDown = false;
            }
            #endregion

            #region WM_MOUSEMOVE
            //WM_MOUSEMOVE
            if (m.Msg == 0x0200)
            {
                int OldValue = trackerValue;
                Point CurPoint = new Point(LowWord((uint)m.LParam), HighWord((uint)m.LParam));
                if (leftbuttonDown && ClientRectangle.Contains(CurPoint))
                {
                    int OffSet = 0;
                    try
                    {
                        switch (this.barOrientation)
                        {
                            case Orientations.Horizontal:
                                if (trackRect.Right + (CurPoint.X - trackRect.X - (trackRect.Width / 2)) >= this.Width)
                                    OffSet = this.Width - trackRect.Right - 1;
                                else if (trackRect.Left + (CurPoint.X - trackRect.X - (trackRect.Width / 2)) <= 0)
                                    OffSet = (trackRect.Left - 1) * -1;
                                else
                                    OffSet = CurPoint.X - trackRect.X - (trackRect.Width / 2);
                                trackRect.Offset(OffSet, 0);
                                trackerValue = (int)(((trackRect.X - 1) * (barMaximum - barMinimum)) / (this.Width - trackSize - 2));
                                if (maxSide == Poles.Left)
                                    trackerValue = (trackerValue - (barMaximum - barMinimum)) * -1;
                                break;
                            case Orientations.Vertical:
                                if (trackRect.Bottom + (CurPoint.Y - trackRect.Y - mousestartPos) >= this.Height)
                                    OffSet = this.Height - trackRect.Bottom - 1;
                                else if (trackRect.Top + (CurPoint.Y - trackRect.Y - mousestartPos) <= 0)
                                    OffSet = (trackRect.Top - 1) * -1;
                                else
                                    OffSet = CurPoint.Y - trackRect.Y - mousestartPos;
                                trackRect.Offset(0, OffSet);
                                trackerValue = (int)(((trackRect.Y - 1) * (barMaximum - barMinimum)) / (this.Height - trackSize - 2));
                                if (maxSide == Poles.Top)
                                    trackerValue = (trackerValue - (barMaximum - barMinimum)) * -1;
                                break;
                        }

                    }
                    catch (Exception) { }
                    finally
                    {
                        //force redraw
                        trackerValue += barMinimum;
                        this.Invalidate();
                        if (OffSet != 0)
                        {
                            OnScroll();
                            OnValueChanged();
                        }
                    }
                }
            }
            #endregion
            base.WndProc(ref m);
        }
        #endregion

        #region Class Consruct and Dispose
        public ColorTrackBar()
        {
            //set initla size
            base.Size = new Size(150, 25);
            //set styles
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            //set cursor
            this.Cursor = Cursors.Hand;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Overrides
        protected override void OnSizeChanged(EventArgs e)
        {
            trackRect = Rectangle.Empty;
            base.OnSizeChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //clear rectangle
            SolidBrush ControlBrush = null;
            if (this.barColor != Color.Empty)
                ControlBrush = new SolidBrush(this.barColor);
            else
                ControlBrush = new SolidBrush(Color.FromName("Control"));
            DrawControl(e.Graphics);
            base.OnPaint(e);
        }
        #endregion

        #region Drawing GDI+
        protected void DrawControl(Graphics g)
        {
            bool NewRect = false;
            if (trackRect == Rectangle.Empty)
                NewRect = true;
            try
            {
                //get parent color
                Color ParentColor = Color.FromName("Control");
                if (this.Parent != null)
                    ParentColor = this.Parent.BackColor;
                switch (barOrientation)
                {
                    case Orientations.Horizontal:
                        if (trackRect == Rectangle.Empty)
                        {
                            int TrackX = (int)(((trackerValue - barMinimum) * (ClientRectangle.Width - trackSize)) / (barMaximum - barMinimum));
                            //don't go past the borders
                            if (TrackX == 0)
                                TrackX++;
                            if (TrackX + trackSize == ClientRectangle.Width)
                                TrackX--;
                            if (maxSide != Poles.Right)
                                TrackX = (TrackX - ClientRectangle.Width + trackSize) * -1;
                            trackRect = new Rectangle(TrackX, 1, trackSize, ClientRectangle.Height - 2);
                        }
                        break;

                    case Orientations.Vertical:
                        if (trackRect == Rectangle.Empty)
                        {
                            int TrackY = (int)(((trackerValue - barMinimum) * (ClientRectangle.Height - trackSize)) / (barMaximum - barMinimum));
                            //don't go past the borders
                            if (TrackY == 0)
                                TrackY++;
                            if (TrackY + ClientRectangle.Width == ClientRectangle.Height)
                                TrackY--;
                            if (maxSide != Poles.Bottom)
                                TrackY = (TrackY - ClientRectangle.Height + trackSize) * -1;
                            trackRect = new Rectangle(1, TrackY, ClientRectangle.Width - 2, trackSize);
                        }
                        break;
                    default:
                        break;
                }
                Region TrackRegion = null;
                Region BarRegion = null;
                switch (cornerStyle)
                {
                    case CornerStyles.Square:
                        PaintRectangle(ClientRectangle, barColor, barborderColor, g);
                        BarRegion = new Region(ClientRectangle);
                        TrackRegion = new Region(trackRect);
                        PaintRectangle(trackRect, trackColor, trackborderColor, g);
                        break;
                    case CornerStyles.Rounded:
                        //first draw bar
                        GraphicsPath BarPath = DrawRoundedCorners(ClientRectangle, barborderColor, g);
                        BarRegion = new Region(BarPath);
                        PaintPath(BarPath, barColor, g);
                        //check if tracker size is correct
                        if (trackRect.Width != trackRect.Height)
                        {
                            if (barOrientation == Orientations.Horizontal)
                            {
                                trackRect = new Rectangle(trackRect.Location,
                                    new Size(ClientRectangle.Height, ClientRectangle.Height - 2));
                            }
                            else
                            {
                                trackRect = new Rectangle(trackRect.Location,
                                    new Size(ClientRectangle.Width - 2, ClientRectangle.Width));
                            }
                        }
                        //now draw Tracker
                        GraphicsPath TrackPath = DrawRoundedCorners(trackRect, trackborderColor, g);
                        TrackRegion = new Region(TrackPath);
                        PaintPath(TrackPath, trackColor, g);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception Err)
            {
                throw new Exception("DrawBackGround Error: " + Err.Message);
            }
            finally
            {
                if (NewRect)
                {
                    OnScroll();
                    OnValueChanged();
                }
            }
        }

        protected void PaintRectangle(Rectangle Rect, Color RectColor, Color RectBorderColor, Graphics g )
        {
            Color RectColor2 = ControlPaint.Dark(RectColor);
            RectColor2 = RectColor;
            //draw rectangle
            Pen LinePen = new Pen(RectBorderColor, borderWidth);
            g.DrawRectangle(LinePen, new Rectangle(Rect.X, Rect.Y, Rect.Width - 1, Rect.Height - 1));
            LinePen.Dispose();
            Rect = new Rectangle(Rect.X + 1, Rect.Y + 1, Rect.Width - 2, Rect.Height - 2);
            //
            // Fill background
            //
            SolidBrush bgBrush = new SolidBrush(RectColor);
            g.FillRectangle(bgBrush, Rect);
            bgBrush.Dispose();

            //
            // The gradient brush
            //
            /*
            LinearGradientBrush brush;
            Rectangle FirstRect, SecondRect;
            switch (barOrientation)
            {
                case Orientations.Horizontal:
                    FirstRect = new Rectangle(Rect.X, Rect.Y, Rect.Width, Rect.Height / 2);
                    SecondRect = new Rectangle(Rect.X, Rect.Height / 2, Rect.Width, Rect.Height / 2);
                    // Paint upper half
                    brush = new LinearGradientBrush(
                        new Point(FirstRect.Width / 2, FirstRect.Top),
                        new Point(FirstRect.Width / 2, FirstRect.Bottom),
                        ControlPaint.Dark(RectColor),
                        RectColor);
                    g.FillRectangle(brush, FirstRect);
                    brush.Dispose();
                    // Paint lower half
                    // (SecondRect.Y - 1 because there would be a dark line in the middle of the bar)
                    brush = new LinearGradientBrush(
                        new Point(SecondRect.Width / 2, SecondRect.Top - 1),
                        new Point(SecondRect.Width / 2, SecondRect.Bottom),
                        RectColor,
                        RectColor2);
                    g.FillRectangle(brush, SecondRect);
                    brush.Dispose();

                    break;
                case Orientations.Vertical:
                    FirstRect = new Rectangle(Rect.X, Rect.Y, Rect.Width / 2, Rect.Height);
                    SecondRect = new Rectangle(Rect.Width / 2, Rect.Y, Rect.Width / 2, Rect.Height);
                    // Paint left half
                    brush = new LinearGradientBrush(
                        new Point(FirstRect.Left, FirstRect.Height / 2),
                        new Point(FirstRect.Right, FirstRect.Height / 2),
                        RectColor2,
                        RectColor);
                    g.FillRectangle(brush, FirstRect);
                    brush.Dispose();
                    // Paint right half
                    // (SecondRect.X - 1 because there would be a dark line in the middle of the bar)
                    brush = new LinearGradientBrush(
                        new Point(SecondRect.Left - 1, SecondRect.Height / 2),
                        new Point(SecondRect.Right, SecondRect.Height / 2),
                        RectColor,
                        RectColor2);
                    g.FillRectangle(brush, SecondRect);
                    brush.Dispose();
                    break;
                default:
                    break;
            }
            */
        }
        protected void PaintPath(GraphicsPath PaintPath, Color PathColor, Graphics g)
        {
            Color PathColor2 = ControlPaint.Dark(PathColor);
            PathColor2 = PathColor;
            Region FirstRegion, SecondRegion;
            FirstRegion = new Region(PaintPath);
            SecondRegion = new Region(PaintPath);
            //
            // Fill background
            //
            SolidBrush bgBrush = new SolidBrush(ControlPaint.Dark(PathColor));
            g.FillRegion(bgBrush, new Region(PaintPath));
            bgBrush.Dispose();

            //
            // The gradient brush
            //
            LinearGradientBrush brush;
            Rectangle FirstRect, SecondRect;
            Rectangle RegionRect = Rectangle.Truncate(PaintPath.GetBounds());
            switch (barOrientation)
            {
                case Orientations.Horizontal:
                    FirstRect = new Rectangle(RegionRect.X, RegionRect.Y, RegionRect.Width, RegionRect.Height / 2);
                    SecondRect = new Rectangle(RegionRect.X, RegionRect.Height / 2, RegionRect.Width, RegionRect.Height / 2);
                    //only get the bar region
                    FirstRegion.Intersect(FirstRect);
                    SecondRegion.Intersect(SecondRect);
                    // Paint upper half
                    brush = new LinearGradientBrush(
                        new Point(FirstRect.Width / 2, FirstRect.Top),
                        new Point(FirstRect.Width / 2, FirstRect.Bottom),
                        PathColor2,
                        PathColor);
                    g.FillRegion(brush, FirstRegion);
                    brush.Dispose();
                    // Paint lower half
                    // (SecondRect.Y - 1 because there would be a dark line in the middle of the bar)
                    brush = new LinearGradientBrush(
                        new Point(SecondRect.Width / 2, SecondRect.Top - 1),
                        new Point(SecondRect.Width / 2, SecondRect.Bottom),
                        PathColor,
                        PathColor2);
                    g.FillRegion(brush, SecondRegion);
                    brush.Dispose();

                    break;
                case Orientations.Vertical:
                    FirstRect = new Rectangle(RegionRect.X, RegionRect.Y, RegionRect.Width / 2, RegionRect.Height);
                    SecondRect = new Rectangle(RegionRect.Width / 2, RegionRect.Y, RegionRect.Width / 2, RegionRect.Height);
                    //only get the bar region
                    FirstRegion.Intersect(FirstRect);
                    SecondRegion.Intersect(SecondRect);
                    // Paint left half
                    brush = new LinearGradientBrush(
                        new Point(FirstRect.Left, FirstRect.Height / 2),
                        new Point(FirstRect.Right, FirstRect.Height / 2),
                        PathColor2,
                        PathColor);
                    g.FillRegion(brush, FirstRegion);
                    brush.Dispose();
                    // Paint right half
                    // (SecondRect.X - 1 because there would be a dark line in the middle of the bar)
                    brush = new LinearGradientBrush(
                        new Point(SecondRect.Left - 1, SecondRect.Height / 2),
                        new Point(SecondRect.Right, SecondRect.Height / 2),
                        PathColor,
                        PathColor2);
                    g.FillRegion(brush, SecondRegion);
                    brush.Dispose();
                    break;
                default:
                    break;
            }
        }
        protected GraphicsPath DrawRoundedCorners(Rectangle Rect, Color BorderColor, Graphics g)
        {
            GraphicsPath gPath = new GraphicsPath();
            try
            {
                Pen LinePen = new Pen(BorderColor, borderWidth + 1);
                switch (barOrientation)
                {
                    case Orientations.Horizontal:
                        Rectangle LeftRect, RightRect;
                        LeftRect = new Rectangle(Rect.X, Rect.Y + 1, Rect.Height - 1, Rect.Height - 2);
                        RightRect = new Rectangle(Rect.X + (Rect.Width - Rect.Height), Rect.Y + 1, Rect.Height - 1, Rect.Height - 2);
                        //build shape

                        gPath.AddArc(LeftRect, 90, 180);
                        gPath.AddLine(
                            LeftRect.X + LeftRect.Width / 2 + 2, LeftRect.Top + 1,
                            RightRect.X + (RightRect.Width / 2) - 1, RightRect.Top + 1);
                        gPath.AddArc(RightRect, 270, 180);
                        gPath.AddLine(RightRect.X + (RightRect.Width / 2), RightRect.Bottom, LeftRect.X + (LeftRect.Width / 2), LeftRect.Bottom);

                        gPath.CloseFigure();
                        g.DrawPath(LinePen, gPath);
                        break;
                    case Orientations.Vertical:
                        Rectangle TopRect, BotRect;
                        TopRect = new Rectangle(Rect.X + 1, Rect.Y, Rect.Width - 2, Rect.Width - 1);
                        BotRect = new Rectangle(Rect.X + 1, Rect.Y + (Rect.Height - Rect.Width), Rect.Width - 2, Rect.Width - 1);
                        //build shape
                        gPath.AddArc(TopRect, 180, 180);
                        gPath.AddLine(TopRect.Right, TopRect.Y + TopRect.Height / 2, BotRect.Right, BotRect.Y + BotRect.Height / 2 + 1);
                        gPath.AddArc(BotRect, 0, 180);
                        gPath.AddLine(BotRect.Left + 1, BotRect.Y + BotRect.Height / 2 - 1,
                            TopRect.Left + 1, TopRect.Y + TopRect.Height / 2 + 2);
                        gPath.CloseFigure();
                        g.DrawPath(LinePen, gPath);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception Err)
            {
                throw new Exception("DrawRoundedCornersException: " + Err.Message);
            }
            return gPath;

        }
        #endregion
    }
}
