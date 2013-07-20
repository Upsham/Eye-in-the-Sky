namespace Decoder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_press = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedControl1 = new Decoder.SpeedControl();
            this.speedometer1 = new Speedometer();
            this.loadCamera21 = new LoadCamera2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.WriteBufferSize = 1024;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yes it\'s there, Decode!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thumbstick X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thumbstick Y:";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(679, 30);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(735, 397);
            this.gMapControl1.TabIndex = 6;
            this.gMapControl1.Zoom = 0D;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Video Camera:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Throttle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(740, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Altitude:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(740, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Compass:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(745, 572);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "Roll:";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(910, 513);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(910, 546);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "0";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(910, 581);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "0";
            this.label14.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 439);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1004, 509);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(320, 26);
            this.label15.TabIndex = 20;
            this.label15.Text = "Number of Photos Taken: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(837, 616);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(455, 26);
            this.label16.TabIndex = 21;
            this.label16.Text = "Controlled by Xbox 360 Controller";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1004, 542);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(182, 26);
            this.label17.TabIndex = 22;
            this.label17.Text = "Temperature:";
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Location = new System.Drawing.Point(1317, 551);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(121, 17);
            this.label_temp.TabIndex = 23;
            this.label_temp.Text = "0 degrees Celcius";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(740, 537);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 26);
            this.label18.TabIndex = 24;
            this.label18.Text = "Pressure:";
            // 
            // label_press
            // 
            this.label_press.AutoSize = true;
            this.label_press.Location = new System.Drawing.Point(910, 546);
            this.label_press.Name = "label_press";
            this.label_press.Size = new System.Drawing.Size(16, 17);
            this.label_press.TabIndex = 25;
            this.label_press.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 22);
            this.button2.TabIndex = 26;
            this.button2.Text = "Exit Cleanly!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1317, 517);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 27;
            this.label19.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(279, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Debug Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baveuse", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 49);
            this.label1.TabIndex = 30;
            this.label1.Text = "Taking Photo : Please Wait.....";
            this.label1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1445, 685);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(928, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baveuse", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1311, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Right";
            // 
            // speedControl1
            // 
            this.speedControl1.Location = new System.Drawing.Point(358, 12);
            this.speedControl1.Name = "speedControl1";
            this.speedControl1.Size = new System.Drawing.Size(248, 221);
            this.speedControl1.Speed = 0D;
            this.speedControl1.TabIndex = 9;
            // 
            // speedometer1
            // 
            this.speedometer1.Location = new System.Drawing.Point(94, 12);
            this.speedometer1.Name = "speedometer1";
            this.speedometer1.Size = new System.Drawing.Size(205, 212);
            this.speedometer1.TabIndex = 8;
            this.speedometer1.Text = "speedometer1";
            this.speedometer1.Click += new System.EventHandler(this.speedometer1_Click);
            // 
            // loadCamera21
            // 
            this.loadCamera21.Location = new System.Drawing.Point(958, 457);
            this.loadCamera21.Name = "loadCamera21";
            this.loadCamera21.Size = new System.Drawing.Size(389, 44);
            this.loadCamera21.Speed = 100D;
            this.loadCamera21.TabIndex = 32;
            this.loadCamera21.Text = "loadCamera21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label_press);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.speedControl1);
            this.Controls.Add(this.speedometer1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadCamera21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Eye in the Sky";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Speedometer speedometer1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private SpeedControl speedControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_press;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private LoadCamera2 loadCamera21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

