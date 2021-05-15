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

        private void StartButton_Click(object sender, EventArgs e)
        {
            updateScore();
        }
    }
}
