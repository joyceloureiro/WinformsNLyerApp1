namespace WindowsForms
{
    partial class SplashScreen
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
            progressBar1 = new ProgressBar();
            lblLoding = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.Location = new Point(125, 270);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(549, 23);
            progressBar1.TabIndex = 0;
            // 
            // lblLoding
            // 
            lblLoding.AutoSize = true;
            lblLoding.BackColor = Color.FromArgb(224, 224, 224);
            lblLoding.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoding.Location = new Point(347, 305);
            lblLoding.Name = "lblLoding";
            lblLoding.Size = new Size(86, 21);
            lblLoding.TabIndex = 1;
            lblLoding.Text = "LOADING...";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.splash_screen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoding);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Shown += SplashScreen_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblLoding;
    }
}