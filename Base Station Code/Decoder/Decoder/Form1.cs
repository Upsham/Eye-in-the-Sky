using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework;
using System.IO.Ports;
namespace Decoder
{
    public partial class Form1 : Form
    {
        List<GMap.NET.PointLatLng> lister = new List<GMap.NET.PointLatLng>();
        
        System.IO.StreamReader file4 = new System.IO.StreamReader("gps.txt");
        bool firstcoor = true, firstcoor2 = true;
        float StartPositionlat, StartPositionlong, camera = 5135, camerabuf = 5135;
        int latbuf, longbuf, buttonbuf = 48, muxbuf = 49;
        int hmc = -1;
        //char[] bytes = new char[22];
        public Form1()
        {
            InitializeComponent();
            
            /*lister.Add(new GMap.NET.PointLatLng(40.4281, -86.9121));
            lister.Add(new GMap.NET.PointLatLng(40.4278, -86.9120));
            lister.Add(new GMap.NET.PointLatLng(40.4276, -86.9120));
            GMap.NET.WindowsForms.GMapRoute router = new GMap.NET.WindowsForms.GMapRoute(lister,"router");
            GMap.NET.WindowsForms.GMapOverlay overlayone= new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "overlayone");
            overlayone.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new GMap.NET.PointLatLng(40.4281, -86.9121)));
            overlayone.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(new GMap.NET.PointLatLng(40.4276, -86.9120)));*/
            SuspendLayout();
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;//GoogleMapProvider.Instance;// GoogleSatelliteMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(40.4279, -86.9120);
            //overlayone.Routes.Add(router);
            gMapControl1.MaxZoom = 17;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom = 3;
            speedControl1.Speed = 0;
            speedometer1.Speed = 0;
            //gMapControl1.Overlays.Add(overlayone);
            
            //gMapControl1.Overlays.
            
            //Uncomment for Xbee
            
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.DataReceived += serialPort1_DataReceived;
            ResumeLayout(true);
        }
        System.IO.StreamWriter file3 = new System.IO.StreamWriter("bmp.txt");

        public void UpdateController()
        {
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);
            int buttonpress = 48, changemux = 48;
            int x,x2;
            int y;
            float  trig2;
            float trig1;
            string tryer, tryer2, tryer3, camerastr;
            if (currentState.Buttons.B == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                buttonpress = 49;
                //this.Hide();
                label1.Show();
                pictureBox2.Show();
                Application.DoEvents();
                //pictureBox2.Show();
            }
            trig1=(float)currentState.Triggers.Left;
            trig2=(float)currentState.Triggers.Right;
            if (currentState.Buttons.RightShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                camera = (float)(camera - 5);
            }
            else if (currentState.Buttons.LeftShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                camera = (float)(camera + 5);
            }
            else if (currentState.Buttons.Start == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                camera = 5135;
            }
            if (camera > 5235)
            {
                camera = 5235;
            }
            else if (camera < 5035)
            {
                camera = 5035;
            }
            if (currentState.Buttons.Y == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                changemux = 49;
            }

            label7.Text = ((int)camera).ToString();
            loadCamera21.Speed = (int)(5235 - camera);
            //GamePad.SetVibration(PlayerIndex.One,currentState.Triggers.Right,currentState.Triggers.Right);;pp-
            // Process input only if connected and button A is pressed.
            x = (5225 - (int)((currentState.ThumbSticks.Left.X + 1) * 100));
            x2 = ((int)((currentState.ThumbSticks.Right.X ) * 125) + 5125);
            y = (5125 - (int)((currentState.ThumbSticks.Right.Y ) * 125) );
            if (x2 > 5225)
            {
                x2 = 5225;
            }
            if (x2 < 5025)
            {
                x2 = 5025;
            }
            if (y > 5225)
            {
                y = 5225;
            }
            if (y < 5025)
            {
                y = 5025;
            }
            throttle = throttle + (trig1/4) - (trig2/4);
            /*if (trig1 > trig1buf && throttle > 2307)
            {
                throttle = throttle - (int)trig1;
            }
            if (trig2 > trig2buf && throttle < 2352)
            {
                throttle = throttle + (int)trig2;
            }*/
            if (throttle < 5025)
            {
                throttle = 5025;
            }
            if (throttle > 5225)
            {
                throttle = 5225;
            }

            tryer = x.ToString().PadLeft(4,'0');
            tryer2 = y.ToString().PadLeft(4, '0');
            tryer3 = x2.ToString().PadLeft(4, '0');
            camerastr = ((int)camera).ToString();
            string throttlestr = ((int)throttle).ToString();
            //Uncomment for Xbee
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            /*bytes[0] = (('x'));
             * 
            for (int j = 1; j < 5; j++)
            {
                bytes[j] = (char)(((tryer[j-1])+48));
            }
            for (int j = 5; j < 9; j++)
            {
                bytes[j] = (char)((tryer[j - 5] + 48) + 48);
            }
            for (int j = 9; j < 13; j++)
            {
                bytes[j] = (char)((tryer2[j - 9] + 48));
            }
            for (int j = 13; j < 17; j++)
            {
                bytes[j] = (char)((throttlestr[j - 13] + 48));
            }
            for (int j = 17; j < 21; j++)
            {
                bytes[j] = (char)((tryer[j - 17] + 48));
            }
            bytes[21] = (('y'));*/
            Byte[] bytes = { (Convert.ToByte('x')), (Convert.ToByte(tryer3[0])), (Convert.ToByte(tryer3[1])), (Convert.ToByte(tryer3[2])), (Convert.ToByte(tryer3[3])), (Convert.ToByte(tryer[0])), (Convert.ToByte(tryer[1])), (Convert.ToByte(tryer[2])), (Convert.ToByte(tryer[3])), (Convert.ToByte(tryer2[0])), (Convert.ToByte(tryer2[1])), (Convert.ToByte(tryer2[2])), (Convert.ToByte(tryer[3])),  (Convert.ToByte(camerastr[0])), (Convert.ToByte(camerastr[1])), (Convert.ToByte(camerastr[2])), (Convert.ToByte(camerastr[3])) ,(Convert.ToByte(throttlestr[0])), (Convert.ToByte(throttlestr[1])), (Convert.ToByte(throttlestr[2])), (Convert.ToByte(throttlestr[3])), (Convert.ToByte(buttonpress)), (Convert.ToByte(buttonpress)), (Convert.ToByte(buttonpress)), (Convert.ToByte(buttonpress)), (Convert.ToByte(changemux)), (Convert.ToByte(changemux)), (Convert.ToByte(changemux)), (Convert.ToByte(changemux)), (Convert.ToByte('y')) };
            while (counter < 30 && (x!=xbuf || x2!=x2buf ||y!=ybuf || trig1!=trig1buf || trig2!=trig2buf ||camera!=camerabuf || (buttonpress!=buttonbuf) || (changemux!=muxbuf)))
            {
                    /*Timer timer = new Timer();
                    timer.Interval = 100;
                    timer.Tick += delegate
                    {
                        // This will be executed on a single (UI) thread, so lock is not necessary
                        // but multiple ticks may have been queued, so check for enabled.
                        if (timer.Enabled)
                        {
                            timer.Stop();

                            serialPort1.Write(bytes, counter, 1);
                            counter++;
                            if (counter == 22)
                            {
                                timer.Dispose();
                            }
                        }
                    };
                    try
                    {
                        timer.Start();
                    }
                    catch (Exception e)
                    {
                    }
                    finally
                    {
                        timer.Dispose();
                    }*/
                //Working Timer!!
                //file3.WriteLine("Shifting " + counter + " data out - "+ Convert.ToInt32(bytes[counter]));
                serialPort1.Write(bytes, counter, 1);
                if (counter == 29 && bytes[24] == 49 && bytes[23] == 49)
                {
                    //pictureBox2.Show();

                    //System.Threading.Thread.Sleep(3000);
                    TimeSpan timey = new TimeSpan(0, 0, 0, 7, 500);
                    DateTime end = DateTime.Now.Add(timey);
                    while (DateTime.Now < end)
                    {
                        ;
                    }
                    //pictureBox2.Hide();
                    label19.Text = ((Int32.Parse(label19.Text)) + 1).ToString();
                }
                else
                {
                    TimeSpan timey = new TimeSpan(1000);
                    DateTime end = DateTime.Now.Add(timey);
                    while (DateTime.Now < end)
                    {
                        ;
                    }
                }
                counter++;
            }

            xbuf = x;
            x2buf = x2;
            ybuf = y;
            trig1buf = trig1;
            trig2buf = trig2;
            camerabuf = camera;
            buttonbuf = buttonpress;
            muxbuf = changemux;
            counter = 0;
            //serialPort1.Close();
            
            label4.Text = "Thumbstick X: " + tryer3;// x.ToString("X");
            label5.Text = "Thumbstick Y: " + tryer2;
            speedometer1.Speed = (int)Math.Round((5225 - throttle));
            label14.Text = throttlestr;
            if (currentState.IsConnected && currentState.Buttons.A ==
                Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                // Button A is currently being pressed; add vibration.
                vibrationAmount =
                    MathHelper.Clamp(vibrationAmount + 0.03f, 0.0f, 1.0f);
                if (GamePad.SetVibration(PlayerIndex.One,
                    vibrationAmount, vibrationAmount))
                {
                    //label2.Show();
                }
            }
            
            else
            {
                //label2.Hide();
                // Button A is not being pressed; subtract some vibration.
                vibrationAmount =
                    MathHelper.Clamp(vibrationAmount - 0.05f, 0.0f, 1.0f);
                GamePad.SetVibration(PlayerIndex.One,
                    vibrationAmount, vibrationAmount);
            }
            if (buttonpress == 49)
            {
                label1.Hide();
                //this.Show();
                pictureBox2.Hide();
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string stinger = serialPort1.ReadLine();

                file3.WriteLine(stinger);
                AddTextToListBox(stinger);
            }
            catch(Exception except)
            {
//                this.Close();
                file3.Close();
            }
        }

        private void AddTextToListBox(string line2)
        {
            
                BeginInvoke((MethodInvoker)delegate
                {
                    //label2.Show();
                    //label2.Text = line2;
                    float first, second, lat, longi;
                    int correct, correct2, i = 0;
                    //file3.WriteLine(text);
                    if (line2 != null)
                    {
                        if (line2.Contains("ss"))
                        {
                            label16.Text = "Controlled by Spektrum Controller";
                            Application.DoEvents();
                        }
                        else if (line2.Contains("xx"))
                        {
                            label16.Text = "Controlled by Xbox 360 Controller";
                            Application.DoEvents();
                        }
                        //label3.Text = "outside while";
                        if (System.Text.RegularExpressions.Regex.IsMatch(line2, "^HMC1") && line2.Length == 13 && (hmc == -1))
                        {
                            char[] MyChar = { 'H', 'M', 'C','1'};
                            hmc = Int32.Parse(line2.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                            //double num2 = hmc / 10.0;
                            //speedControl1.Speed = num;
                        }
                        else if (System.Text.RegularExpressions.Regex.IsMatch(line2, "^HMC2") && line2.Length == 13 && (hmc != -1))
                        {
                            char[] MyChar = { 'H', 'M', 'C', '2' };
                            int num = Int32.Parse(line2.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                            hmc = (hmc * 256) + num;
                            double num2 = hmc / 10.0;
                            label13.Text = num2.ToString();
                            file3.WriteLine("Compass value: "+num2.ToString());
                            speedControl1.Speed = num2+180;
                            hmc = -1;
                            //file3.WriteLine("Writing to serial NOW! ");
                            //serialPort1.Write(bytes, 0, 22);
                        }
                        else if (System.Text.RegularExpressions.Regex.IsMatch(line2, "^UT1") && line2.Length == 12)
                        {
                            
                            char[] MyChar = { 'U', 'T', '1' };
                            
                            Int32 temp1 = Int32.Parse(line2.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                            
                            up = temp1;
                            uptemp = 1;
                            uttemp = -1;

                        }
                        else if (System.Text.RegularExpressions.Regex.IsMatch(line2, "^UT2") && line2.Length == 12 && uptemp==1)
                        {
                            
                            char[] MyChar = { 'U', 'T', '2' };
                            Int32 temp1 = Int32.Parse(line2.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                           
                            up = (256*up) + temp1;
                        }
                        else if (System.Text.RegularExpressions.Regex.IsMatch(line2, "^UP1") && line2.Length == 12 && uttemp == -1 && uptemp == 1)
                        {
                            
                            char[] MyChar = { 'U', 'P', '1' };
                            Int32 temp2 = Int32.Parse(line2.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                            ut = temp2;
                            uttemp = 1;
                            
                        }
                        
                        else if (System.Text.RegularExpressions.Regex.IsMatch(line2, "^UP2") && line2.Length == 12 && uttemp == 1 && uptemp == 1)
                        {

                            char[] MyChar = { 'U', 'P', '2' };
                            Int32 temp2 = Int32.Parse(line2.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                            ut = (ut * 256) + temp2;
                            int bmp = BMP085(up, ut);
                            //bmp = bmp + 28000;
                            string bmpdat = (bmp).ToString();
                            file3.WriteLine("UP: " + ut.ToString() + " UT: " + up.ToString());
                            float tvalvar = (float)(tval / 10.0);
                            file3.WriteLine("Temp: " + tvalvar.ToString() + " Pressure: " + bmpdat);
                            label_press.Text = bmpdat + " Pascal";
                            double altitude = 44330 * (1- Math.Pow((((double)bmp / 101325.00)), 0.19029));
                            label12.Text = ((int)altitude).ToString()+" metres";
                            label_temp.Text = tvalvar.ToString() + " degree Celcius";
                            uttemp = -1;
                            uptemp = -1;
                        }

                        else if (line2.Length > 3 && line2.Contains("in main"))
                        {
                            string[] splitter = new string[50];
                            bool wrong = false;
                            splitter = line2.Split(',');
                            try
                            {
                                while (i < (splitter.Length - 2))
                                {
                                    //label3.Text = "inside while";
                                    if ((splitter[i].Equals("N") || splitter[i].Equals("S")) && (splitter[i + 2].Equals("W") || splitter[i + 2].Equals("E")))
                                    {
                                        first = float.Parse(splitter[i - 1]);
                                        correct = (int)first / 100;
                                        first = first - (correct * 100);
                                        first = first / 60;
                                        lat = correct + first;
                                        if (splitter[i] == "S")
                                        {
                                            lat = -lat;
                                        }
                                        second = float.Parse(splitter[i + 1]);
                                        correct2 = (int)second / 100;
                                        if (firstcoor2 == true)
                                        {
                                            latbuf = correct;
                                            longbuf = correct2;
                                            firstcoor2 = false;
                                        }
                                        else
                                        {
                                            if (latbuf != correct || longbuf != correct2)
                                            {
                                                wrong = true;
                                            }
                                            else
                                            {
                                                wrong = false;
                                            }
                                        }
                                        second = second - (correct2 * 100);
                                        second = second / 60;

                                        longi = correct2 + second;
                                        if (splitter[i + 2] == "W")
                                        {
                                            longi = -longi;
                                        }
                                        if (wrong == false)
                                        {
                                            lister.Add(new GMap.NET.PointLatLng(lat, longi));
                                            //label3.Show();
                                            //label3.Text = lat.ToString() + " " + longi.ToString();
                                            GMap.NET.WindowsForms.GMapRoute router = new GMap.NET.WindowsForms.GMapRoute(lister, "router");
                                            GMap.NET.WindowsForms.GMapOverlay overlayone = new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "overlayone");
                                            overlayone.Routes.Add(router);

                                            if (firstcoor == true)
                                            {
                                                overlayone.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new GMap.NET.PointLatLng(lat, longi)));
                                                StartPositionlat = lat;
                                                StartPositionlong = longi;
                                                firstcoor = false;
                                                gMapControl1.Overlays.Clear();
                                                gMapControl1.Overlays.Add(overlayone);
                                                gMapControl1.ZoomAndCenterMarkers("overlayone");
                                            }
                                            else
                                            {
                                                //overlayone.Markers.Clear();
                                                overlayone.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new GMap.NET.PointLatLng(StartPositionlat, StartPositionlong)));
                                                overlayone.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(new GMap.NET.PointLatLng(lat, longi)));
                                                gMapControl1.Overlays.Clear();
                                                gMapControl1.Overlays.Add(overlayone);
                                                gMapControl1.ZoomAndCenterRoute(router);
                                            }

                                            //gMapControl1.UpdateRouteLocalPosition(router);
                                            gMapControl1.Update();
                                            file3.WriteLine("Lattitude: " + lat + " Longitude: " + longi);
                                            i = i + 2;
                                        }
                                    }
                                    i++;
                                }
                            }
                            catch (FormatException f)
                            {

                            }
                            catch (IndexOutOfRangeException ft)
                            {
                            }

                        }

                    }
                });  
                
 
        }
        Int16 ac1, ac2, ac3, b1, b2, mc, md;
        UInt16 ac4, ac5, ac6;
        Int32 checker,uttemp=-1,uptemp=-1,bmp=-1, tval,counter=0, countey=0;
        Int32 ut =0 , up =0;
        Int32 xbuf = 5125, ybuf = 5125, x2buf = 5125;
        float trig1buf = 0, trig2buf = 0, throttle = 5225;
        StringBuilder sb = new StringBuilder();
   
        float vibrationAmount = 0.0f;
        void BMP085Calibrate()
        {
            ac1 = 7452;// 408;// 7452;
            ac2 = -1042;// -72;// -1042;
            ac3 = -14424;// -14383;//-14424;
            ac4 = 33005;// 32741;// 33005;
            ac5 = 25060;// 32757;// 25060;
            ac6 = 21876;// 23153;// 21876;
            b1 = 5498;// 6190;// 5498;
            b2 = 54;// 4;//54;
            //mb = -32768;
            mc = -11075;// -8711;//-11075;
            md = 2432;// 2868;// 2432;
        }
        public Int32 BMP085(Int32 ut, Int32 up)
        {
            Int32 pval;
            Int32 x1, x2, x3, b3, b5, b6, p;
            UInt32 b4, b7;

            BMP085Calibrate();


            x1 = (ut - ac6) * ac5 >> 15;
            
            x2 = ((Int32)mc << 11) / (x1 + md);
            b5 = x1 + x2;
            tval = (b5 + 8) >> 4;
            

            b6 = b5 - 4000;
            x1 = (b2 * (b6 * b6 >> 12)) >> 11;
            x2 = ac2 * b6 >> 11;
            x3 = x1 + x2;
            
            b3 = (((Int32)ac1 * 4 + x3) + 2)/4;
           
            x1 = ac3 * b6 >> 13;
            x2 = (b1 * (b6 * b6 >> 12)) >> 16;
            x3 = ((x1 + x2) + 2) >> 2;
            b4 = (ac4 * (UInt32)(x3 + 32768)) >> 15;
            b7 = (UInt32)((UInt32)up - b3) * (50000 >> 0);
            
            p = (Int32)(b7 < 0x80000000 ? (b7 * 2) / b4 : (b7 / b4) * 2);

            x1 = (p >> 8) * (p >> 8);
            x1 = (x1 * 3038) >> 16;
            x2 = (-7357 * p) >> 16;
            pval = p + ((x1 + x2 + 3791) >> 4);
            return pval;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //label2.Hide();
           // label2.Show();
            //label3.Show();
            
            float first, second, lat, longi;
            int correct, i = 0;
            string line2 = file4.ReadLine();
            //label3.Text = "outside if";
            
            if (line2 != null)
            {
                //label3.Text = "outside while";
                if (System.Text.RegularExpressions.Regex.IsMatch(line2, "^HMC"))
                {
                    char[] MyChar = { 'H', 'M', 'C' };
                    int num = Int32.Parse(line2.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                    double num2 = num / 10.0;
                    speedControl1.Speed = num;
                }
                else
                {
                    string[] splitter = new string[50];
                    splitter = line2.Split(',');
                    try
                    {
                        while (i < (splitter.Length - 2))
                        {
                            //label3.Text = "inside while";
                            if ((splitter[i].Equals("N") || splitter[i].Equals("S")) && (splitter[i + 2].Equals("W") || splitter[i + 2].Equals("E")))
                            {
                                first = float.Parse(splitter[i - 1]);
                                correct = (int)first / 100;
                                first = first - (correct * 100);
                                first = first / 60;
                                lat = correct + first;
                                if (splitter[i] == "S")
                                {
                                    lat = -lat;
                                }
                                second = float.Parse(splitter[i + 1]);
                                correct = (int)second / 100;
                                second = second - (correct * 100);
                                second = second / 60;
                                longi = correct + second;
                                if (splitter[i + 2] == "W")
                                {
                                    longi = -longi;
                                }
                                lister.Add(new GMap.NET.PointLatLng(lat, longi));
                                //label3.Show();
                                //label3.Text = lat.ToString() + " " + longi.ToString();
                                GMap.NET.WindowsForms.GMapRoute router = new GMap.NET.WindowsForms.GMapRoute(lister, "router");

                                GMap.NET.WindowsForms.GMapOverlay overlayone = new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "overlayone");
                                overlayone.Routes.Add(router);
                                if (firstcoor == true)
                                {
                                    overlayone.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new GMap.NET.PointLatLng(lat, longi)));
                                    StartPositionlat = lat;
                                    StartPositionlong = longi;
                                    firstcoor = false;
                                    gMapControl1.Overlays.Clear();
                                    gMapControl1.Overlays.Add(overlayone);
                                    gMapControl1.ZoomAndCenterMarkers("overlayone");
                                }
                                else
                                {
                                    //overlayone.Markers.Clear();
                                    overlayone.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new GMap.NET.PointLatLng(StartPositionlat, StartPositionlong)));
                                    overlayone.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(new GMap.NET.PointLatLng(lat, longi)));
                                    gMapControl1.Overlays.Clear();
                                    gMapControl1.Overlays.Add(overlayone);
                                    gMapControl1.ZoomAndCenterRoute(router);
                                }

                                //gMapControl1.UpdateRouteLocalPosition(router);
                                gMapControl1.Update();
                                i = i + 3;
                            }
                            i++;
                        }
                    }
                    catch (FormatException f)
                    {

                    }
                    catch (IndexOutOfRangeException ft)
                    {
                    }

                }
                
            }
            
            /*char[] chararr = {'t','r','y','\n','\r'};
            Byte[] bytes = { (Convert.ToByte(chararr[0])), (Convert.ToByte(chararr[1])), (Convert.ToByte(chararr[2])),(Convert.ToByte(chararr[3])), (Convert.ToByte(chararr[4])) };
            if (countey < 5)
            {
                serialPort1.Write(bytes, countey, 1);
                //label2.Show();
                label2.Text = countey.ToString();
                countey++;
            }
            else
            {
                countey = 0;
            }*/
            //serialPort1.Write(bytes,0,1);
            //serialPort1.wr
            //serialPort1.WriteLine("0A00FFFFBC08CCCCAAAA\r");*/

            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("log.txt");
                System.IO.StreamWriter file2 = new System.IO.StreamWriter("result.txt");

                while ((line = file.ReadLine()) != null)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(line, "^HMC"))
                    {
                        char[] MyChar = { 'H', 'M', 'C'};
                        int num = Int32.Parse(line.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                        double num2 = num / 10.0;
                        file2.WriteLine("HMC Reading Follows:");
                        file2.WriteLine(num2.ToString());
                    }
                    if (System.Text.RegularExpressions.Regex.IsMatch(line, "^BMP"))
                    {
                        char[] MyChar = { 'B', 'M', 'P' };
                        int num = Int32.Parse(line.TrimStart(MyChar), System.Globalization.NumberStyles.HexNumber);
                        if (checker == 0)
                        {
                            checker = 1;
                            up = num;
                        }
                        else
                        {
                            checker = 0;
                            ut = num;
                            file2.WriteLine("Pressure Reading Follows:");
                            file2.WriteLine(BMP085(up, ut).ToString());
                            file2.WriteLine("Temperature Reading Follows:");
                            file2.WriteLine(tval.ToString());
                        }
                    }
                }
                file.Close();
                file2.Close();
                //file4.Close();
                //label3.Show();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("The file log.txt was not found in the current directory. Please place the file there and try again!","Error");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void speedometer1_Click(object sender, EventArgs e)
        {
            file4.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                   
            serialPort1.Close();
            file3.Close();
            this.Close();         

        
        }
    }
}
