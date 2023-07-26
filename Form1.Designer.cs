namespace Weather_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_close = new System.Windows.Forms.Button();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_condtion = new System.Windows.Forms.Label();
            this.lab_detail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.labTemperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labActivity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_close.Location = new System.Drawing.Point(1549, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 55);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "x";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(341, 54);
            this.TBCity.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(487, 42);
            this.TBCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "City: ";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(844, 51);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(173, 48);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_condtion
            // 
            this.lab_condtion.AutoSize = true;
            this.lab_condtion.BackColor = System.Drawing.Color.Transparent;
            this.lab_condtion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_condtion.ForeColor = System.Drawing.Color.White;
            this.lab_condtion.Location = new System.Drawing.Point(215, 259);
            this.lab_condtion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_condtion.Name = "lab_condtion";
            this.lab_condtion.Size = new System.Drawing.Size(147, 35);
            this.lab_condtion.TabIndex = 4;
            this.lab_condtion.Text = "Conditions:";
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.BackColor = System.Drawing.Color.Transparent;
            this.lab_detail.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_detail.ForeColor = System.Drawing.Color.White;
            this.lab_detail.Location = new System.Drawing.Point(215, 346);
            this.lab_detail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(85, 35);
            this.lab_detail.TabIndex = 5;
            this.lab_detail.Text = "Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sunrise: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(215, 461);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sunset: ";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrise.ForeColor = System.Drawing.Color.White;
            this.lab_sunrise.Location = new System.Drawing.Point(374, 404);
            this.lab_sunrise.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(68, 29);
            this.lab_sunrise.TabIndex = 8;
            this.lab_sunrise.Text = "N/A";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunset.ForeColor = System.Drawing.Color.White;
            this.lab_sunset.Location = new System.Drawing.Point(374, 461);
            this.lab_sunset.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(68, 29);
            this.lab_sunset.TabIndex = 9;
            this.lab_sunset.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(603, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 35);
            this.label8.TabIndex = 10;
            this.label8.Text = "Wind speed:  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(603, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 35);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pressure: ";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.BackColor = System.Drawing.Color.Transparent;
            this.lab_windspeed.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_windspeed.ForeColor = System.Drawing.Color.White;
            this.lab_windspeed.Location = new System.Drawing.Point(813, 261);
            this.lab_windspeed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(68, 29);
            this.lab_windspeed.TabIndex = 12;
            this.lab_windspeed.Text = "N/A";
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pressure.ForeColor = System.Drawing.Color.White;
            this.lab_pressure.Location = new System.Drawing.Point(813, 346);
            this.lab_pressure.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(68, 29);
            this.lab_pressure.TabIndex = 13;
            this.lab_pressure.Text = "N/A";
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.Location = new System.Drawing.Point(223, 126);
            this.pic_icon.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(200, 112);
            this.pic_icon.TabIndex = 14;
            this.pic_icon.TabStop = false;
            // 
            // labTemperature
            // 
            this.labTemperature.AutoSize = true;
            this.labTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemperature.ForeColor = System.Drawing.Color.White;
            this.labTemperature.Location = new System.Drawing.Point(813, 404);
            this.labTemperature.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.Size = new System.Drawing.Size(68, 29);
            this.labTemperature.TabIndex = 16;
            this.labTemperature.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(603, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Temperature";
            // 
            // FLP
            // 
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.ForeColor = System.Drawing.Color.Black;
            this.FLP.Location = new System.Drawing.Point(135, 523);
            this.FLP.Margin = new System.Windows.Forms.Padding(4);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(1126, 125);
            this.FLP.TabIndex = 17;
            this.FLP.Paint += new System.Windows.Forms.PaintEventHandler(this.FLP_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(603, 461);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Activity Type";
            // 
            // labActivity
            // 
            this.labActivity.AutoSize = true;
            this.labActivity.BackColor = System.Drawing.Color.Transparent;
            this.labActivity.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labActivity.ForeColor = System.Drawing.Color.White;
            this.labActivity.Location = new System.Drawing.Point(813, 463);
            this.labActivity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labActivity.Name = "labActivity";
            this.labActivity.Size = new System.Drawing.Size(68, 29);
            this.labActivity.TabIndex = 19;
            this.labActivity.Text = "N/A";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 895);
            this.Controls.Add(this.labActivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.labTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.lab_windspeed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_detail);
            this.Controls.Add(this.lab_condtion);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.btn_close);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lab_condtion;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label labTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labActivity;
    }
}