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
    public partial class Main : Form
    {
        private SerialPort _SerialPort;
        public Main()
        {
            InitializeComponent();
            //_SerialPort = new SerialPort(Properties.Settings.Default.port, Properties.Settings.Default.BaudRate);
            //try
           // {
             //   _SerialPort.Open();
           // }
            //catch
            //{
              //  MessageBox.Show("check COM number in settings", "error");
            //}
        }
        private void changeFormTo(Form f)
        {
            //this.Hide();
            f.ShowDialog();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = f.Location; // TODO  did you mean = this.Location ?
            f.Size = f.Size;
            //this.Close();
        }

        private void Yeruham_Click(object sender, EventArgs e)
        {
            changeFormTo(new Yeruham(_SerialPort));
        }

        private void Husidman_Click(object sender, EventArgs e)
        {
            changeFormTo(new Husidman(_SerialPort));
        }

        private void OrtBraudeKarmiel_Click(object sender, EventArgs e)
        {
            changeFormTo(new OrtBraudeKarmiel(_SerialPort));
        }
    }
}
