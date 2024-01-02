using System.IO.Ports;

namespace BTArduino
{
    public partial class Form1 : Form
    {
        static bool _continue = false;
        public string puerto = "COM3";
        static SerialPort _puertoserie;
        Thread readThread;
        Thread loopThread;
        // string messageIn = "";
        string messageOut = "";
        bool mouseDown = false;

        StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        string[] comandosSP = { "", "home", "jump", "walk", "turn", "bend", "shakeLeg", "updown", "swing", "tiptoeSwing", "jitter", "ascendingTurn", "moonwalker", "crusaito", "flapping", "1", "2", "3" };
        string[] comandosMW = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "T", "W", "S" };
        List<string> grabado = new List<string>();

        public Form1()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                int o = 0;
                if (c is Button)
                    if ((int.TryParse((string)c.Tag, out o) ? o : 0) > 1)
                    {
                        c.Text = comandosSP[o];
                        c.Click += BtnSendMessage;
                    }
            }
        }
        private void BtnConectar(object sender, EventArgs e)
        {

            _puertoserie = new SerialPort(textBox1.Text, 9600);
            // Set the read/write timeouts

            _puertoserie.ReadTimeout = 500;
            _puertoserie.WriteTimeout = 500;
            _puertoserie.NewLine = "\n";
            readThread = new Thread(Read);
            loopThread = new Thread(loop);
            _puertoserie.Open();
            label2.BackColor = Color.Green;
            label2.Text = "Conectado";
            loopThread.Start();
        }

        public void loop()
        {
            readThread.Start();
            _continue = true;
            while (_continue)
            {
                if (messageOut != "")
                {
                    if (stringComparer.Equals("quit", messageOut))
                    {
                        _continue = false;
                    }
                    else
                    {
                        //_puertoserie.Write(messageOut + "\n");//                            String.Format("{0}", message));
                        _puertoserie.Write(messageOut);//                            String.Format("{0}", message));
                    }
                    if (!mouseDown) messageOut = "";
                }
                Thread.Sleep(10);
            }
            readThread.Join();
            _puertoserie.Close();
        }

        public void Read()
        {
            while (_continue)
            {
                try
                {
                    string messagein = _puertoserie.ReadExisting();
                    if (messagein != "")
                    {
                        AppendTextBox(messagein);
                    }
                    Thread.Sleep(10);
                }
                /*catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }*/
                catch (TimeoutException) { }
            }
        }

        private void BtnCommand(object sender, EventArgs e)
        {
            messageOut = "command";
        }

        private void BtnQuit(object sender, EventArgs e)
        {
            messageOut = "quit";
            label2.BackColor = Color.Red;
            label2.Text = "Desconectado";
        }

        private void BtnSendMessage(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int o = 0;
            if ((int.TryParse((string)b.Tag, out o) ? o : 0) > 1)
            {
                messageOut = comandosSP[o];
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            textBox2.Text += value + "\n";
        }

        private void BtnSendTextBox(object sender, EventArgs e)
        {
            messageOut = textBox3.Text;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar track = (TrackBar)sender;
            messageOut = $"site {track.Tag} {track.Value.ToString()}";
            label1.Text = $"S0: {trackBar1.Value} S1:{trackBar3.Value} S2:{trackBar4.Value} S3:{trackBar2.Value}";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                messageOut = textBox3.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            grabado = new List<string>();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            messageOut = $"sites {trackBar1.Value} {trackBar3.Value} {trackBar4.Value} {trackBar2.Value}";
            grabado.Add(messageOut);
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            _puertoserie.Write("A");
        }

        private void BtnSendMW(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            messageOut = $"%{(string)b.Tag}#";
        }

        private void button25_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            messageOut = $"%{(string)b.Tag}#";
            mouseDown = true;
        }

        private void button25_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}