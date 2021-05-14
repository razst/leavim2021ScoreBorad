using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace score
{
    public partial class Form1 : Form
    {
        private SerialPort mySerialPort;
        private string indata = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void DataReceivedHandler(
                                object sender,
                                SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            indata = sp.ReadLine();

            this.Invoke(new EventHandler(displayDataEvent));

        }
        private async void TestModeData()
        {    
            this.Invoke(new EventHandler(displayDataEvent));
        }
        private async void displayDataEvent(object sender, EventArgs e)
        {
            MessageBox.Show(indata);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.TestMode)
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
                }
                catch
                {
                    MessageBox.Show("unable to connect to temp sensor, check COM number in settings", "error");
                }


                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            else
            {
                TestModeData();
            }
        }
    }
}
