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


namespace score
{
    public partial class Scoreboard : Form
    {
        PictureBox[] pictureBoxes = new PictureBox[3];
        public Scoreboard()
        {
            InitializeComponent();
            pictureBoxes[0] = pictureBoxHusidman;
            pictureBoxes[1] = pictureBoxYeruham;
            pictureBoxes[2] = pictureBoxOrt;
            if (Global.whoPlay[0] && Global.whoPlay[1] && Global.whoPlay[2])
            {
                this.BackgroundImage = score.Properties.Resources.ניקוד_סופי;
                BackButton.Hide();
            }
            showScore();
        }


        private void changeFormTo(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Close();
        }


        private void showScore()
        {
            for (int i = 0; i < 3; i++) 
            {
                switch (Global.scoreArr[i])
                {
                    case 10:
                        pictureBoxes[i].Image = score.Properties.Resources._10_white; // replace image in imagebox
                        break;
                    case 20:
                        pictureBoxes[i].Image = score.Properties.Resources._20_white; // replace image in imagebox
                        break;
                    case 30:
                        pictureBoxes[i].Image = score.Properties.Resources._30_white; // replace image in imagebox
                        break;
                    case 40:
                        pictureBoxes[i].Image = score.Properties.Resources._40_white; // replace image in imagebox
                        break;
                    case 50:
                        pictureBoxes[i].Image = score.Properties.Resources._50_white; // replace image in imagebox
                        break;
                    case 60:
                        pictureBoxes[i].Image = score.Properties.Resources._60_white; // replace image in imagebox
                        break;
                    case 70:
                        pictureBoxes[i].Image = score.Properties.Resources._70_white; // replace image in imagebox
                        break;
                    case 80:
                        pictureBoxes[i].Image = score.Properties.Resources._80_white; // replace image in imagebox
                        break;
                    case 90:
                        pictureBoxes[i].Image = score.Properties.Resources._90_white; // replace image in imagebox
                        break;
                    case 100:
                        pictureBoxes[i].Image = score.Properties.Resources._100_white; // replace image in imagebox
                        break;
                    default:
                        break;
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            changeFormTo(new Main());
        }
    }
}
