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
    public partial class ScoreUpdate : Form
    {
        private string indata = "";
        private SerialPort mySerialPort = null;
        private int _whoPlaying = -1;
        private int timePerGame = 10000; // 10 sec

        public ScoreUpdate(int whoPlaying)
        {
            InitializeComponent();
            _whoPlaying = whoPlaying;
            if (_whoPlaying == 0)
                this.BackgroundImage = score.Properties.Resources.חוסידמן_ניקוד;
            else if(_whoPlaying == 1)
                this.BackgroundImage = score.Properties.Resources.ניקוד_ירוחם;
            else
                this.BackgroundImage = score.Properties.Resources.אורט_בראודה_ניקוד;
        }

        private void changeFormTo(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void updateScore()
        {
            StartButton.Hide();
            switch (Global.scoreArr[_whoPlaying])
            {
                case 10:
                    ScorePictureBox.Image = score.Properties.Resources._10; // replace image in imagebox
                    break;
                case 20:
                    ScorePictureBox.Image = score.Properties.Resources._20; // replace image in imagebox
                    break;
                case 30:
                    ScorePictureBox.Image = score.Properties.Resources._30; // replace image in imagebox
                    break;
                case 40:
                    ScorePictureBox.Image = score.Properties.Resources._40; // replace image in imagebox
                    break;
                case 50:
                    ScorePictureBox.Image = score.Properties.Resources._50; // replace image in imagebox
                    break;
                case 60:
                    ScorePictureBox.Image = score.Properties.Resources._60; // replace image in imagebox
                    break;
                case 70:
                    ScorePictureBox.Image = score.Properties.Resources._70; // replace image in imagebox
                    break;
                case 80:
                    ScorePictureBox.Image = score.Properties.Resources._80; // replace image in imagebox
                    break;
                case 90:
                    ScorePictureBox.Image = score.Properties.Resources._90; // replace image in imagebox
                    break;
                case 100:
                    ScorePictureBox.Image = score.Properties.Resources._100; // replace image in imagebox
                    break;
                default:
                    break;
            }
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
                //label1.Text = indata;
                string[] splitData = indata.Split(',');
                int result = 0;
                if (Global.scoreArr[_whoPlaying] < 100)
                {
                    Global.scoreArr[_whoPlaying] = int.Parse(splitData[1]);
                }
                updateScore();
                if(int.TryParse(splitData[0],out result))
                {
                    label1.Text = result.ToString();
                    if (result >= timePerGame)
                    {
                        stopGame();
                        changeFormTo(new Scoreboard());
                    }
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
                mySerialPort.DiscardInBuffer(); // clear the output that the arduino give
            }
            catch
            {
                MessageBox.Show("unable to connect to temp sensor, check COM number in settings", "error");
            }
            Global.whoPlay[_whoPlaying] = true; // use this array to check who play
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
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
    }
}
