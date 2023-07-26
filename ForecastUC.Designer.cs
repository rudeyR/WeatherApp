namespace Weather_Application
{
    partial class ForecastUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labDT = new System.Windows.Forms.Label();
            this.labMainWeather = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(3, 3);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(98, 86);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            this.picWeatherIcon.Click += new System.EventHandler(this.picWeatherIcon_Click);
            // 
            // labDT
            // 
            this.labDT.AutoSize = true;
            this.labDT.Location = new System.Drawing.Point(107, 3);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(74, 20);
            this.labDT.TabIndex = 1;
            this.labDT.Text = "Thursday";
            this.labDT.Click += new System.EventHandler(this.label1_Click);
            // 
            // labMainWeather
            // 
            this.labMainWeather.AutoSize = true;
            this.labMainWeather.Location = new System.Drawing.Point(108, 35);
            this.labMainWeather.Name = "labMainWeather";
            this.labMainWeather.Size = new System.Drawing.Size(46, 20);
            this.labMainWeather.TabIndex = 2;
            this.labMainWeather.Text = "Clear";
            this.labMainWeather.Click += new System.EventHandler(this.labMainWeather_Click);
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Location = new System.Drawing.Point(110, 63);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(89, 20);
            this.labWeatherDescription.TabIndex = 3;
            this.labWeatherDescription.Text = "Description";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labMainWeather);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.picWeatherIcon);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(506, 99);
            this.Load += new System.EventHandler(this.ForecastUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labDT;
        public System.Windows.Forms.Label labMainWeather;
        public System.Windows.Forms.Label labWeatherDescription;
    }
}
