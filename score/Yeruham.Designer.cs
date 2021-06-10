
namespace score
{
    partial class Yeruham
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
            this.ScorePictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScorePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ScorePictureBox
            // 
            this.ScorePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ScorePictureBox.Image = global::score.Properties.Resources._00;
            this.ScorePictureBox.Location = new System.Drawing.Point(517, 388);
            this.ScorePictureBox.Name = "ScorePictureBox";
            this.ScorePictureBox.Size = new System.Drawing.Size(274, 258);
            this.ScorePictureBox.TabIndex = 0;
            this.ScorePictureBox.TabStop = false;
            this.ScorePictureBox.Click += new System.EventHandler(this.ScorePictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
            this.label2.Font = new System.Drawing.Font("MV Boli", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(10)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1305, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = "זמן לסיום";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
            this.label3.Font = new System.Drawing.Font("MV Boli", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(10)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1305, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 65);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
            this.stopButton.Image = global::score.Properties.Resources.redStop;
            this.stopButton.Location = new System.Drawing.Point(359, 359);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(83, 62);
            this.stopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopButton.TabIndex = 9;
            this.stopButton.TabStop = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
            this.StartButton.Image = global::score.Properties.Resources.iconstart;
            this.StartButton.Location = new System.Drawing.Point(1255, 349);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(337, 81);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartButton.TabIndex = 10;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // Yeruham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::score.Properties.Resources.ניקוד_ירוחם;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScorePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Yeruham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Yeruham_FormClosing);
            this.Load += new System.EventHandler(this.Yeruham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScorePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ScorePictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox stopButton;
        private System.Windows.Forms.PictureBox StartButton;
    }
}