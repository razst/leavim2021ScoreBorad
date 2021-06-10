
namespace score
{
    partial class ScoreUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreUpdate));
            this.ScorePictureBox = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.TimerVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.ScorePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // ScorePictureBox
            // 
            this.ScorePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ScorePictureBox.Image = global::score.Properties.Resources._00;
            this.ScorePictureBox.Location = new System.Drawing.Point(832, 515);
            this.ScorePictureBox.Name = "ScorePictureBox";
            this.ScorePictureBox.Size = new System.Drawing.Size(274, 258);
            this.ScorePictureBox.TabIndex = 0;
            this.ScorePictureBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(894, 384);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(131, 55);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TimerVideo
            // 
            this.TimerVideo.Enabled = true;
            this.TimerVideo.Location = new System.Drawing.Point(1489, 809);
            this.TimerVideo.Name = "TimerVideo";
            this.TimerVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("TimerVideo.OcxState")));
            this.TimerVideo.Size = new System.Drawing.Size(366, 206);
            this.TimerVideo.TabIndex = 3;
            // 
            // ScoreUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::score.Properties.Resources.ניקוד_ירוחם;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.TimerVideo);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ScorePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScoreUpdate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ScorePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ScorePictureBox;
        private System.Windows.Forms.Button StartButton;
        private AxWMPLib.AxWindowsMediaPlayer TimerVideo;
    }
}