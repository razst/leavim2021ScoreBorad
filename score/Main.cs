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
        public Main()
        {
            InitializeComponent();
            if (Global.whoPlay[0])
                Husidman.Enabled = false;
            if (Global.whoPlay[1])
                Yeruham.Enabled = false;
            if (Global.whoPlay[2])
                OrtBraudeKarmiel.Enabled = false;
        }
        private void changeFormTo(Form f)
        {
<<<<<<< HEAD
            this.Hide();
            f.ShowDialog();
            this.Close();
=======
            //this.Hide();
            f.ShowDialog();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = f.Location; // TODO  did you mean = this.Location ?
            f.Size = f.Size;
            //this.Close();
>>>>>>> parent of e6c1cc5 (fix logic and more)
        }

        private void Husidman_Click(object sender, EventArgs e)
        {
            changeFormTo(new ScoreUpdate(0)); // 0 mean the index of the team 0 = Husidman
        }

        private void Yeruham_Click(object sender, EventArgs e)
        {
            changeFormTo(new ScoreUpdate(1)); // 1 = Yeruham
        }


        private void OrtBraudeKarmiel_Click(object sender, EventArgs e)
        {
            changeFormTo(new ScoreUpdate(2)); // 2 = OrtBraudeKarmiel
        }
    }
}
