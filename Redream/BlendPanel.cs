using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

public class BlendPanel : Panel
{
    private Image mImg1;
    private Image mImg2;
    private float mBlend;
    public BlendPanel()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }
    public Image Image1
    {
        get { return mImg1; }
        set { mImg1 = value; Invalidate(); }
    }
    public Image Image2
    {
        get { return mImg2; }
        set { mImg2 = value; Invalidate(); }
    }
    public float Blend
    {
        get { return mBlend; }
        set { mBlend = value; Invalidate(); }
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        if (mImg1 == null || mImg2 == null)
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(0, 0, this.Width, this.Height));
        else
        {
            Rectangle rc = new Rectangle(0, 0, this.Width, this.Height);
            ColorMatrix cm = new ColorMatrix();
            ImageAttributes ia = new ImageAttributes();
            cm.Matrix33 = mBlend;
            ia.SetColorMatrix(cm);
            e.Graphics.DrawImage(mImg2, rc, 0, 0, mImg2.Width, mImg2.Height, GraphicsUnit.Pixel, ia);
            cm.Matrix33 = 1F - mBlend;
            ia.SetColorMatrix(cm);
            e.Graphics.DrawImage(mImg1, rc, 0, 0, mImg1.Width, mImg1.Height, GraphicsUnit.Pixel, ia);
        }
        base.OnPaint(e);
    }
}