namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flappyBird = new PictureBox();
            Zemin = new PictureBox();
            BoruAlt = new PictureBox();
            BoruUst = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruUst).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(59, 326);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(103, 77);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // Zemin
            // 
            Zemin.Image = (Image)resources.GetObject("Zemin.Image");
            Zemin.Location = new Point(-26, 609);
            Zemin.Name = "Zemin";
            Zemin.Size = new Size(745, 137);
            Zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            Zemin.TabIndex = 0;
            Zemin.TabStop = false;
            Zemin.Click += pictureBox2_Click;
            // 
            // BoruAlt
            // 
            BoruAlt.Image = (Image)resources.GetObject("BoruAlt.Image");
            BoruAlt.Location = new Point(436, 445);
            BoruAlt.Name = "BoruAlt";
            BoruAlt.Size = new Size(152, 167);
            BoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruAlt.TabIndex = 0;
            BoruAlt.TabStop = false;
            // 
            // BoruUst
            // 
            BoruUst.Image = (Image)resources.GetObject("BoruUst.Image");
            BoruUst.Location = new Point(436, -12);
            BoruUst.Name = "BoruUst";
            BoruUst.Size = new Size(152, 238);
            BoruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruUst.TabIndex = 1;
            BoruUst.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scoreText.Location = new Point(12, 9);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(141, 38);
            scoreText.TabIndex = 2;
            scoreText.Text = "Score = 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(653, 700);
            Controls.Add(flappyBird);
            Controls.Add(scoreText);
            Controls.Add(BoruUst);
            Controls.Add(BoruAlt);
            Controls.Add(Zemin);
            Name = "Form1";
            Text = " Flappy Bird Game";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruUst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox Zemin;
        private PictureBox BoruAlt;
        private PictureBox BoruUst;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
