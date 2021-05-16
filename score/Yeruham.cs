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
            StartButton.Hide();
            Thread.Sleep(5000);
            ScorePictureBox.Image = score.Properties.Resources._10; // replace image in imagebox
            ScorePictureBox.BackColor = Color.Transparent; // change the background color to Transparent
        }

        private void DataReceivedHandler(
                                object sender,
                                SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            try
            {
                indata = sp.ReadLine();

                this.BeginInvoke(new EventHandler(displayDataEvent));

            }
            catch (System.IO.IOException) 
            {
                
            }

        }


        private void displayDataEvent(object sender, EventArgs e)
        {
          
            if (indata.Contains(','))
            {
                label1.Text = indata;
                string[] splitData = indata.Split(',');
            }
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            stopGame();
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
                //StartButton.Hide();
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
            stopGame();
        }


        private void stopGame() 
        {
            if (mySerialPort != null)
            {
                mySerialPort.WriteLine("E");
                mySerialPort.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
                mySerialPort.Close();
                mySerialPort = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopGame();
        }
    }
}
