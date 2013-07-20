using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class LoadCamera2 : Control
{
    private const double cMaxSpeed = 200;
    private const int cThickness = 20;
    private double mSpeed;

    public LoadCamera2()
    {
        DoubleBuffered = true;
    }

    [DefaultValue(0.0)]
    public double Speed
    {
        get { return mSpeed; }
        set { mSpeed = value; Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        int size = Math.Min(this.ClientSize.Width, this.ClientSize.Height) - cThickness;
        //if (size <= cThickness) return;
        float startpoint = (float)(((mSpeed-5)*this.ClientSize.Width)/cMaxSpeed);
        startpoint = Math.Max(0,Math.Min(startpoint,this.ClientSize.Width));
        float endpoint = (float)(((mSpeed+5)*this.ClientSize.Width)/cMaxSpeed);
        endpoint = Math.Max(0,Math.Min(endpoint,this.ClientSize.Width));
        float angle = (float)(270 * mSpeed / cMaxSpeed);
        angle = Math.Max(0, Math.Min(270, angle));
        float angle1 = (float)(270 * 20 / cMaxSpeed);
        angle1 = Math.Max(0, Math.Min(270, angle1));
        float angle2 = (float)(270 * 180 / cMaxSpeed);
        angle2 = Math.Max(0, Math.Min(270, angle2));
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using (Pen p = new Pen(Color.White, cThickness))
        {
            e.Graphics.DrawLine(p, 0, this.ClientSize.Height/2, this.ClientSize.Width, this.ClientSize.Height/2);
            //e.Graphics.DrawRectangle(p, cThickness / 2, cThickness / 2, size, size);
            //e.Graphics.DrawArc(p, cThickness / 2, cThickness / 2, size, size, 135, 270);
        }
        using (Pen p = new Pen(Color.DarkRed, cThickness))
        {
            p.Alignment = PenAlignment.Inset;
            e.Graphics.DrawLine(p, startpoint, this.ClientSize.Height / 2, endpoint, this.ClientSize.Height / 2);
        }
        using (Pen p = new Pen(Color.Black, cThickness))
        {
            e.Graphics.DrawLine(p, 0, ((this.ClientSize.Height / 2) - cThickness) - 3, 3, ((this.ClientSize.Height / 2) - cThickness) - 3);
            e.Graphics.DrawLine(p, this.ClientSize.Width-3, ((this.ClientSize.Height / 2) - cThickness) - 3, this.ClientSize.Width, ((this.ClientSize.Height / 2) - cThickness) - 3);
        }
        /*if (mSpeed < 180 && mSpeed > 20)
        {
            using (Pen p = new Pen(Color.SeaGreen, cThickness))
            {
                p.Alignment = PenAlignment.Inset;
                e.Graphics.DrawArc(p, cThickness / 2, cThickness / 2, size, size, 135, angle);
            }
            using (Pen p = new Pen(Color.DarkSlateGray, cThickness))
            {
                p.Alignment = PenAlignment.Inset;
                e.Graphics.DrawArc(p, cThickness / 2, cThickness / 2, size, size, 135, angle1);
            }
        }
        else if (mSpeed <= 20)
        {
            using (Pen p = new Pen(Color.DarkSlateGray, cThickness))
            {
                p.Alignment = PenAlignment.Inset;
                e.Graphics.DrawArc(p, cThickness / 2, cThickness / 2, size, size, 135, angle);
            }

        }
        else
        {
            using (Pen p = new Pen(Color.Red, cThickness))
            {
                p.Alignment = PenAlignment.Inset;
                e.Graphics.DrawArc(p, cThickness / 2, cThickness / 2, size, size, 135, angle);
            }
            using (Pen p = new Pen(Color.SeaGreen, cThickness))
            {
                p.Alignment = PenAlignment.Inset;
                e.Graphics.DrawArc(p, cThickness / 2, cThickness / 2, size, size, 135, angle2);
            }
            using (Pen p = new Pen(Color.DarkSlateGray, cThickness))
            {
                p.Alignment = PenAlignment.Inset;
                e.Graphics.DrawArc(p, cThickness / 2, cThickness / 2, size, size, 135, angle1);
            }
        }*/
        base.OnPaint(e);
    }
}