using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;
namespace Decoder
{
    /// <summary>
    /// Summary description for UserControl1.
    /// </summary>
    public class SpeedControl : System.Windows.Forms.UserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private double angle = 225;
        private double speed = 0;
        //public event System.EventHandler speedChanged;

        public SpeedControl()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);


            // TODO: Add any initialization after the InitForm call

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SpeedControl
            // 
            this.Name = "SpeedControl";
            this.Size = new System.Drawing.Size(248, 224);
            this.Load += new System.EventHandler(this.SpeedControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            this.ResumeLayout(false);

        }
        #endregion

        private void UserControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;



            //g.FillRectangle(Brushes.White,this.ClientRectangle);
            Font f = new Font("Times New Roman", 12, System.Drawing.FontStyle.Bold);

            g.TranslateTransform(this.Width / 2, this.Height / 2);
            g.FillEllipse(Brushes.White, this.Height / -2, this.Height / -2, this.Height, this.Height);

            g.DrawString("COMPASS", f, Brushes.Green, -50, this.Height / -4);


            //g.TranslateTransform(this.Width /2,this.Height/2);
            g.RotateTransform(225);
            for (int x = 0; x < 100; x++)
            {
                g.FillRectangle(Brushes.Green, -2, (this.Height / 2 - 2) * -1, 3, 15);
                g.RotateTransform(5);
            }
            g.ResetTransform();

            g.TranslateTransform(this.Width / 2, this.Height / 2);
            g.RotateTransform(225);
            g.ResetTransform();
            g.TranslateTransform(this.Width / 2, 20);
            //int sp = 0;
            g.DrawString("N", f, Brushes.Blue, -10, 0);
            /*for(int x = 0; x<7;x++)
            {
                g.FillRectangle(Brushes.Red,-3,(this.Height/2 -2)* -1,6,25);
                g.DrawString(sp.ToString(),f,Brushes.Azure,(sp.ToString().Length)*(-6),(this.Height/-2) + 25);
                g.RotateTransform(45);
                sp += 20;
            }*/
            g.ResetTransform();
            g.TranslateTransform(35, (this.Height / 2) - 13);
            g.DrawString("W", f, Brushes.Blue, 0, 0);
            g.ResetTransform();
            g.TranslateTransform(this.Width - 60, (this.Height / 2) - 13);
            g.DrawString("E", f, Brushes.Blue, 0, 0);
            g.ResetTransform();
            g.TranslateTransform(this.Width / 2, this.Height - 45);
            g.DrawString("S", f, Brushes.Blue, -10, 0);
            g.ResetTransform();
            g.TranslateTransform(this.Width / 2, this.Height / 2);

            g.RotateTransform((float)angle);

            Pen P = new Pen(Brushes.Black, 10);
            P.EndCap = LineCap.ArrowAnchor;
            P.StartCap = LineCap.RoundAnchor;


            /*Point point1 = new Point(this.Width/2 -13, 0);
            Point point2 = new Point(this.Width/2 -10, this.Height - 45);
            Point point3 = new Point((this.Width/2) -40, (this.Height/2)-13);
            Point point4 = new Point((this.Width/2) +40, (this.Height/2)-13);
            Point [] pointarr = {point1, point3, point2, point4};
            g.DrawPolygon(P,pointarr);*/
            g.DrawLine(P, 0, 0, 0, (-1) * (this.Height / 2.75F));
            //P.Width = 16;
            //g.DrawLine(P,0,0,0,(-1)*(this.Height/2.75F));


            g.ResetTransform();

            g.TranslateTransform(this.Width / 2, this.Height / 2);

            g.FillEllipse(Brushes.Black, -6, -9, 12, 12);
            g.FillEllipse(Brushes.Red, -6, -6, 12, 12);

            P.Width = 4;
            P.Color = Color.Black;
            P.EndCap = LineCap.Round;
            P.StartCap = LineCap.Flat;
            //g.DrawLine(P,this.Height/15.75F,this.Height/3.95F,this.Height/10.75F,this.Height/5.2F);

            P.Color = Color.Red;
            //g.DrawLine(P,this.Height/15.75F,this.Height/3.95F,this.Height/15.75F,this.Height/4.6F);

            P.Dispose();
        }
        public double Speed
        {
            set
            {
                //if(value>131)
                //	value = 131;
                this.angle = value;
                this.Invalidate();
            }
            get
            {
                return this.speed;
            }
        }

        private void SpeedControl_Load(object sender, EventArgs e)
        {

        }

    }
}
