using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;


namespace score
{
    public partial class Yeruham : Form
    {
        private SerialPort _SerialPort;
        private string indata = "";
        private SerialPort mySerialPort = null;

        public Yeruham(SerialPort Serial)
        {
            InitializeComponent();
            _SerialPort = Serial; 
        }

        private void updateScore()
        {
          //  StartButton.Hide();
            Thread.Sleep(5000);
            ScorePictureBox.Image = score.Properties.Resources._10; // replace image in imagebox
            ScorePictureBox.BackColor = Color.Transparent; // change the background color to Transparent
        }

        private void DataReceivedHandler(
                                object sender,
                                SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            indata = sp.ReadLine();

            this.Invoke(new EventHandler(displayDataEvent));

        }


        private void displayDataEvent(object sender, EventArgs e)
        {
            
            if (indata.Contains(','))
            {
               // label1.Text = indata;
                string[] splitData = indata.Split(',');

                double timeToEnd = double.Parse(splitData[0]);
                string score = splitData[1];

                if (timeToEnd > 10)
                {
                  //  double ticks = timeToEnd / 1000;
                    TimeSpan time = TimeSpan.FromMilliseconds(timeToEnd);
                    String timeToEndDisplay = time.Minutes.ToString() + ":" + time.Seconds.ToString();
                    label3.Text = timeToEndDisplay;
                   // label3.Text = (timeToEnd / 1000).ToString();
                }

                
                string imageSrc = "C:\\dev\\leavim2021ScoreBorad\\score\\Resources/";
                switch (score.Trim())
                {
                    case "10":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "10.png");
                        break;
                    case "20":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "20.png");
                        break;
                    case "30":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "30.png");
                        break;
                    case "40":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "40.png");
                        break;
                    case "50":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "50.png");
                        break;
                    case "60":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "60.png");
                        break;
                    case "70":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "70.png");
                        break;
                    case "80":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "80.png");
                        break;
                    case "90":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "90.png");
                        break;
                    case "100":
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "100.png");
                        break;
                    default:
                        ScorePictureBox.Image = Image.FromFile(imageSrc + "00.png");
                        break;
                }
            }
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            mySerialPort = new SerialPort(Properties.Settings.Default.port);

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            try
            {
                mySerialPort.Open();
                mySerialPort.WriteLine("S");
                StartButton.Hide();
            }
            catch
            {
                MessageBox.Show("unable to connect to temp sensor, check COM number in settings", "error");
            }


            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);




            //updateScore();
        }

        private void Yeruham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mySerialPort != null)
                mySerialPort.Close();
<<<<<<< HEAD
        }

        private void ScorePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Yeruham_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StartButton_Click(sender, e);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopGame();
=======
>>>>>>> parent of e6c1cc5 (fix logic and more)
        }

        private void StartButton1_Click(object sender, EventArgs e)
        {
            StartButton_Click(sender, e);

        }
    }
}
