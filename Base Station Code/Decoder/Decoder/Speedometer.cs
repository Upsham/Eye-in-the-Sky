using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class Speedometer : Control {
  private const double cMaxSpeed = 200;
  private const int cThickness = 20;
  private double mSpeed;

  public Speedometer() {
    DoubleBuffered = true;
  }

  [DefaultValue(0.0)]
  public double Speed {
    get { return mSpeed; }
    set { mSpeed = value; Invalidate(); }
  }

  protected override void OnPaint(PaintEventArgs e) {
    int size = Math.Min(this.ClientSize.Width, this.ClientSize.Height) - cThickness;
    if (size <= cThickness) return;
    float angle = (float)(270 * mSpeed / cMaxSpeed);
    angle = Math.Max(0, Math.Min(270, angle));
    float angle1 = (float)(270 * 25 / cMaxSpeed);
    angle1 = Math.Max(0, Math.Min(270, angle1));
    float angle2 = (float)(270 * 185 / cMaxSpeed);
    angle2 = Math.Max(0, Math.Min(270, angle2));
    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
    using (Pen p = new Pen(Color.White, cThickness)) {
      e.Graphics.DrawArc(p, cThickness/2, cThickness/2, size, size, 135, 270);
    }
    if (mSpeed < 185 && mSpeed > 25)
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
    else if(mSpeed <= 25)
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
    }
    base.OnPaint(e);
  }
}