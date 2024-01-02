namespace BTArduino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            textBox3 = new TextBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            label1 = new Label();
            trackBar5 = new TrackBar();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            imageList1 = new ImageList(components);
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            button34 = new Button();
            button36 = new Button();
            button37 = new Button();
            button38 = new Button();
            button39 = new Button();
            button40 = new Button();
            button35 = new Button();
            button41 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 27);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 40);
            button1.TabIndex = 0;
            button1.Text = "Conectar Serie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnConectar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 30);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(81, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "COM3";
            // 
            // button2
            // 
            button2.Location = new Point(266, 26);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 2;
            button2.Text = "Desconectar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnQuit;
            // 
            // button3
            // 
            button3.Location = new Point(37, 75);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 27);
            button3.TabIndex = 3;
            button3.Text = "Help";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnQuit;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 417);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(851, 207);
            textBox2.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(155, 75);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(88, 27);
            button4.TabIndex = 5;
            button4.Text = "Command";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(37, 108);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(88, 27);
            button5.TabIndex = 6;
            button5.Tag = "1";
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(155, 108);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(88, 27);
            button6.TabIndex = 7;
            button6.Tag = "2";
            button6.Text = "Jump";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(266, 108);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(88, 27);
            button7.TabIndex = 8;
            button7.Tag = "3";
            button7.Text = "Walk";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(384, 108);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(88, 27);
            button8.TabIndex = 9;
            button8.Tag = "4";
            button8.Text = "Turn";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(498, 108);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(88, 27);
            button9.TabIndex = 10;
            button9.Tag = "5";
            button9.Text = "Bend";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(498, 141);
            button10.Margin = new Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new Size(88, 27);
            button10.TabIndex = 15;
            button10.Tag = "10";
            button10.Text = "ShakeLeg";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(384, 141);
            button11.Margin = new Padding(4, 3, 4, 3);
            button11.Name = "button11";
            button11.Size = new Size(88, 27);
            button11.TabIndex = 14;
            button11.Tag = "9";
            button11.Text = "ShakeLeg";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(266, 141);
            button12.Margin = new Padding(4, 3, 4, 3);
            button12.Name = "button12";
            button12.Size = new Size(88, 27);
            button12.TabIndex = 13;
            button12.Tag = "8";
            button12.Text = "ShakeLeg";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(155, 141);
            button13.Margin = new Padding(4, 3, 4, 3);
            button13.Name = "button13";
            button13.Size = new Size(88, 27);
            button13.TabIndex = 12;
            button13.Tag = "7";
            button13.Text = "ShakeLeg";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(37, 141);
            button14.Margin = new Padding(4, 3, 4, 3);
            button14.Name = "button14";
            button14.Size = new Size(88, 27);
            button14.TabIndex = 11;
            button14.Tag = "6";
            button14.Text = "ShakeLeg";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(498, 174);
            button15.Margin = new Padding(4, 3, 4, 3);
            button15.Name = "button15";
            button15.Size = new Size(88, 27);
            button15.TabIndex = 20;
            button15.Tag = "15";
            button15.Text = "ShakeLeg";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(384, 174);
            button16.Margin = new Padding(4, 3, 4, 3);
            button16.Name = "button16";
            button16.Size = new Size(88, 27);
            button16.TabIndex = 19;
            button16.Tag = "14";
            button16.Text = "ShakeLeg";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(266, 174);
            button17.Margin = new Padding(4, 3, 4, 3);
            button17.Name = "button17";
            button17.Size = new Size(88, 27);
            button17.TabIndex = 18;
            button17.Tag = "13";
            button17.Text = "ShakeLeg";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(155, 174);
            button18.Margin = new Padding(4, 3, 4, 3);
            button18.Name = "button18";
            button18.Size = new Size(88, 27);
            button18.TabIndex = 17;
            button18.Tag = "12";
            button18.Text = "ShakeLeg";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(37, 174);
            button19.Margin = new Padding(4, 3, 4, 3);
            button19.Name = "button19";
            button19.Size = new Size(88, 27);
            button19.TabIndex = 16;
            button19.Tag = "11";
            button19.Text = "ShakeLeg";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(802, 75);
            button20.Margin = new Padding(4, 3, 4, 3);
            button20.Name = "button20";
            button20.Size = new Size(88, 27);
            button20.TabIndex = 21;
            button20.Tag = "";
            button20.Text = "Enviar";
            button20.UseVisualStyleBackColor = true;
            button20.Click += BtnSendTextBox;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(628, 45);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 23);
            textBox3.TabIndex = 22;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(37, 208);
            trackBar1.Margin = new Padding(4, 3, 4, 3);
            trackBar1.Maximum = 1000;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(852, 45);
            trackBar1.TabIndex = 23;
            trackBar1.Tag = "0";
            trackBar1.Value = 200;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(38, 363);
            trackBar2.Margin = new Padding(4, 3, 4, 3);
            trackBar2.Maximum = 1000;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(852, 45);
            trackBar2.TabIndex = 24;
            trackBar2.Tag = "3";
            trackBar2.Value = 200;
            trackBar2.Scroll += trackBar1_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(38, 260);
            trackBar3.Margin = new Padding(4, 3, 4, 3);
            trackBar3.Maximum = 1000;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(852, 45);
            trackBar3.TabIndex = 25;
            trackBar3.Tag = "1";
            trackBar3.Value = 200;
            trackBar3.Scroll += trackBar1_Scroll;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(38, 312);
            trackBar4.Margin = new Padding(4, 3, 4, 3);
            trackBar4.Maximum = 1000;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(852, 45);
            trackBar4.TabIndex = 26;
            trackBar4.Tag = "2";
            trackBar4.Value = 200;
            trackBar4.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 157);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 27;
            label1.Text = "label1";
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(37, 654);
            trackBar5.Margin = new Padding(4, 3, 4, 3);
            trackBar5.Maximum = 1000;
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(852, 45);
            trackBar5.TabIndex = 28;
            trackBar5.Tag = "3";
            trackBar5.Value = 200;
            // 
            // button21
            // 
            button21.Location = new Point(946, 42);
            button21.Margin = new Padding(4, 3, 4, 3);
            button21.Name = "button21";
            button21.Size = new Size(88, 27);
            button21.TabIndex = 29;
            button21.Tag = "";
            button21.Text = "Grabar";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // button22
            // 
            button22.Location = new Point(1042, 42);
            button22.Margin = new Padding(4, 3, 4, 3);
            button22.Name = "button22";
            button22.Size = new Size(88, 25);
            button22.TabIndex = 30;
            button22.Tag = "";
            button22.Text = "Limpiar";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.Location = new Point(1150, 42);
            button23.Margin = new Padding(4, 3, 4, 3);
            button23.Name = "button23";
            button23.Size = new Size(88, 25);
            button23.TabIndex = 31;
            button23.Tag = "";
            button23.Text = "Reproducir";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // button24
            // 
            button24.ImageIndex = 9;
            button24.ImageList = imageList1;
            button24.Location = new Point(1048, 141);
            button24.Name = "button24";
            button24.Size = new Size(48, 48);
            button24.TabIndex = 32;
            button24.Tag = "G";
            button24.UseVisualStyleBackColor = true;
            button24.MouseDown += button25_MouseDown;
            button24.MouseUp += button25_MouseUp;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "donwn.png");
            imageList1.Images.SetKeyName(1, "DownLeft.png");
            imageList1.Images.SetKeyName(2, "DownRight.png");
            imageList1.Images.SetKeyName(3, "left.png");
            imageList1.Images.SetKeyName(4, "Right.png");
            imageList1.Images.SetKeyName(5, "stop.png");
            imageList1.Images.SetKeyName(6, "TurnLeft.png");
            imageList1.Images.SetKeyName(7, "TurnRight.png");
            imageList1.Images.SetKeyName(8, "up.png");
            imageList1.Images.SetKeyName(9, "UpLeft.png");
            imageList1.Images.SetKeyName(10, "UpRight.png");
            // 
            // button25
            // 
            button25.ImageIndex = 8;
            button25.ImageList = imageList1;
            button25.Location = new Point(1102, 141);
            button25.Name = "button25";
            button25.Size = new Size(48, 48);
            button25.TabIndex = 33;
            button25.Tag = "A";
            button25.UseVisualStyleBackColor = true;
            button25.MouseDown += button25_MouseDown;
            button25.MouseUp += button25_MouseUp;
            // 
            // button26
            // 
            button26.ImageIndex = 10;
            button26.ImageList = imageList1;
            button26.Location = new Point(1156, 141);
            button26.Name = "button26";
            button26.Size = new Size(48, 48);
            button26.TabIndex = 34;
            button26.Tag = "H";
            button26.UseVisualStyleBackColor = true;
            button26.MouseDown += button25_MouseDown;
            button26.MouseUp += button25_MouseUp;
            // 
            // button27
            // 
            button27.ImageIndex = 4;
            button27.ImageList = imageList1;
            button27.Location = new Point(1156, 199);
            button27.Name = "button27";
            button27.Size = new Size(48, 48);
            button27.TabIndex = 37;
            button27.Tag = "D";
            button27.UseVisualStyleBackColor = true;
            button27.MouseDown += button25_MouseDown;
            button27.MouseUp += button25_MouseUp;
            // 
            // button28
            // 
            button28.ImageKey = "stop.png";
            button28.ImageList = imageList1;
            button28.Location = new Point(1102, 199);
            button28.Name = "button28";
            button28.Size = new Size(48, 48);
            button28.TabIndex = 36;
            button28.Tag = "S";
            button28.UseVisualStyleBackColor = true;
            button28.Click += BtnSendMW;
            // 
            // button29
            // 
            button29.ImageIndex = 3;
            button29.ImageList = imageList1;
            button29.Location = new Point(1048, 199);
            button29.Name = "button29";
            button29.Size = new Size(48, 48);
            button29.TabIndex = 35;
            button29.Tag = "C";
            button29.UseVisualStyleBackColor = true;
            button29.MouseDown += button25_MouseDown;
            button29.MouseUp += button25_MouseUp;
            // 
            // button30
            // 
            button30.ImageIndex = 2;
            button30.ImageList = imageList1;
            button30.Location = new Point(1156, 260);
            button30.Name = "button30";
            button30.Size = new Size(48, 48);
            button30.TabIndex = 40;
            button30.Tag = "J";
            button30.UseVisualStyleBackColor = true;
            button30.MouseDown += button25_MouseDown;
            button30.MouseUp += button25_MouseUp;
            // 
            // button31
            // 
            button31.ImageIndex = 0;
            button31.ImageList = imageList1;
            button31.Location = new Point(1102, 260);
            button31.Name = "button31";
            button31.Size = new Size(48, 48);
            button31.TabIndex = 39;
            button31.Tag = "B";
            button31.UseVisualStyleBackColor = true;
            button31.MouseDown += button25_MouseDown;
            button31.MouseUp += button25_MouseUp;
            // 
            // button32
            // 
            button32.ImageIndex = 1;
            button32.ImageList = imageList1;
            button32.Location = new Point(1048, 260);
            button32.Name = "button32";
            button32.Size = new Size(48, 48);
            button32.TabIndex = 38;
            button32.Tag = "I";
            button32.UseVisualStyleBackColor = true;
            button32.MouseDown += button25_MouseDown;
            button32.MouseUp += button25_MouseUp;
            // 
            // button33
            // 
            button33.ImageIndex = 7;
            button33.ImageList = imageList1;
            button33.Location = new Point(1156, 316);
            button33.Name = "button33";
            button33.Size = new Size(48, 48);
            button33.TabIndex = 42;
            button33.Tag = "F";
            button33.UseVisualStyleBackColor = true;
            button33.MouseDown += button25_MouseDown;
            button33.MouseUp += button25_MouseUp;
            // 
            // button34
            // 
            button34.ImageIndex = 6;
            button34.ImageList = imageList1;
            button34.Location = new Point(1048, 316);
            button34.Name = "button34";
            button34.Size = new Size(48, 48);
            button34.TabIndex = 41;
            button34.Tag = "E";
            button34.UseVisualStyleBackColor = true;
            button34.MouseDown += button25_MouseDown;
            button34.MouseUp += button25_MouseUp;
            // 
            // button36
            // 
            button36.Location = new Point(715, 129);
            button36.Margin = new Padding(4, 3, 4, 3);
            button36.Name = "button36";
            button36.Size = new Size(88, 27);
            button36.TabIndex = 44;
            button36.Tag = "15";
            button36.Text = "envía 1";
            button36.UseVisualStyleBackColor = true;
            button36.Click += button36_Click;
            // 
            // button37
            // 
            button37.Location = new Point(1048, 417);
            button37.Margin = new Padding(4, 3, 4, 3);
            button37.Name = "button37";
            button37.Size = new Size(88, 59);
            button37.TabIndex = 45;
            button37.Tag = "T";
            button37.Text = "Modo Evitar colisiones";
            button37.UseVisualStyleBackColor = true;
            button37.Click += BtnSendMW;
            // 
            // button38
            // 
            button38.Location = new Point(1150, 417);
            button38.Margin = new Padding(4, 3, 4, 3);
            button38.Name = "button38";
            button38.Size = new Size(88, 59);
            button38.TabIndex = 46;
            button38.Tag = "W";
            button38.Text = "Modo Seguimiento";
            button38.UseVisualStyleBackColor = true;
            button38.Click += BtnSendMW;
            // 
            // button39
            // 
            button39.Location = new Point(1048, 498);
            button39.Margin = new Padding(4, 3, 4, 3);
            button39.Name = "button39";
            button39.Size = new Size(88, 59);
            button39.TabIndex = 47;
            button39.Tag = "Y";
            button39.Text = "Subir Velocidad";
            button39.UseVisualStyleBackColor = true;
            button39.Click += BtnSendMW;
            // 
            // button40
            // 
            button40.Location = new Point(1150, 498);
            button40.Margin = new Padding(4, 3, 4, 3);
            button40.Name = "button40";
            button40.Size = new Size(88, 59);
            button40.TabIndex = 48;
            button40.Tag = "Z";
            button40.Text = "Bajar Velocidad";
            button40.UseVisualStyleBackColor = true;
            button40.Click += BtnSendMW;
            // 
            // button35
            // 
            button35.ImageIndex = 7;
            button35.ImageList = imageList1;
            button35.Location = new Point(1290, 260);
            button35.Name = "button35";
            button35.Size = new Size(48, 48);
            button35.TabIndex = 50;
            button35.Tag = "L";
            button35.UseVisualStyleBackColor = true;
            button35.MouseDown += button25_MouseDown;
            button35.MouseUp += button25_MouseUp;
            // 
            // button41
            // 
            button41.ImageIndex = 2;
            button41.ImageList = imageList1;
            button41.Location = new Point(1236, 260);
            button41.Name = "button41";
            button41.Size = new Size(48, 48);
            button41.TabIndex = 49;
            button41.Tag = "K";
            button41.UseVisualStyleBackColor = true;
            button41.MouseDown += button25_MouseDown;
            button41.MouseUp += button25_MouseUp;
            // 
            // label2
            // 
            label2.BackColor = Color.Red;
            label2.Location = new Point(389, 23);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 51;
            label2.Text = "Desconectado";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 745);
            Controls.Add(label2);
            Controls.Add(button35);
            Controls.Add(button41);
            Controls.Add(button40);
            Controls.Add(button39);
            Controls.Add(button38);
            Controls.Add(button37);
            Controls.Add(button36);
            Controls.Add(button33);
            Controls.Add(button34);
            Controls.Add(button30);
            Controls.Add(button31);
            Controls.Add(button32);
            Controls.Add(button27);
            Controls.Add(button28);
            Controls.Add(button29);
            Controls.Add(button26);
            Controls.Add(button25);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(trackBar5);
            Controls.Add(label1);
            Controls.Add(trackBar4);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(textBox3);
            Controls.Add(button20);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private TextBox textBox3;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private Label label1;
        private TrackBar trackBar5;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button33;
        private Button button34;
        private ImageList imageList1;
        private Button button36;
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
        private Button button35;
        private Button button41;
        private Label label2;
    }
}