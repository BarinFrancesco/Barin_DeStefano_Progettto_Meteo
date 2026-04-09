namespace Barin_DeStefano_Weather
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
            CityList = new ComboBox();
            button1 = new Button();
            Chart_Temperature = new ScottPlot.WinForms.FormsPlot();
            progressBarTemp = new ProgressBar();
            lbl_Temperature = new Label();
            lbl_City = new Label();
            Chart_AirQuality = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // CityList
            // 
            CityList.CausesValidation = false;
            CityList.DropDownStyle = ComboBoxStyle.DropDownList;
            CityList.FormattingEnabled = true;
            CityList.Location = new Point(703, 25);
            CityList.Margin = new Padding(3, 4, 3, 4);
            CityList.Name = "CityList";
            CityList.Size = new Size(140, 28);
            CityList.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(703, 61);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(140, 28);
            button1.TabIndex = 1;
            button1.Text = "btn_Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Chart_Temperature
            // 
            Chart_Temperature.BackColor = Color.Transparent;
            Chart_Temperature.Location = new Point(343, 233);
            Chart_Temperature.Name = "Chart_Temperature";
            Chart_Temperature.Size = new Size(220, 98);
            Chart_Temperature.TabIndex = 5;
            // 
            // progressBarTemp
            // 
            progressBarTemp.Location = new Point(343, 191);
            progressBarTemp.MarqueeAnimationSpeed = 1;
            progressBarTemp.Maximum = 50;
            progressBarTemp.Name = "progressBarTemp";
            progressBarTemp.Size = new Size(224, 36);
            progressBarTemp.TabIndex = 2;
            // 
            // lbl_Temperature
            // 
            lbl_Temperature.BackColor = Color.Transparent;
            lbl_Temperature.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Temperature.ForeColor = Color.WhiteSmoke;
            lbl_Temperature.Location = new Point(293, 34);
            lbl_Temperature.Name = "lbl_Temperature";
            lbl_Temperature.Size = new Size(308, 77);
            lbl_Temperature.TabIndex = 4;
            lbl_Temperature.Text = "xx";
            lbl_Temperature.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Temperature.Click += lbl_Temperature_Click;
            // 
            // lbl_City
            // 
            lbl_City.BackColor = Color.Transparent;
            lbl_City.Font = new Font("Microsoft Sans Serif", 7.8F);
            lbl_City.ForeColor = Color.WhiteSmoke;
            lbl_City.Location = new Point(293, 96);
            lbl_City.Name = "lbl_City";
            lbl_City.Size = new Size(308, 25);
            lbl_City.TabIndex = 3;
            lbl_City.Text = "xx";
            lbl_City.TextAlign = ContentAlignment.MiddleCenter;
            lbl_City.Click += lbl_City_Click;
            // 
            // Chart_AirQuality
            // 
            Chart_AirQuality.BackColor = Color.Transparent;
            Chart_AirQuality.Location = new Point(343, 414);
            Chart_AirQuality.Name = "Chart_AirQuality";
            Chart_AirQuality.Size = new Size(220, 98);
            Chart_AirQuality.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cloud_background_ticebm8qasr73gt1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(Chart_AirQuality);
            Controls.Add(lbl_City);
            Controls.Add(Chart_Temperature);
            Controls.Add(lbl_Temperature);
            Controls.Add(progressBarTemp);
            Controls.Add(button1);
            Controls.Add(CityList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CityList;
        private Button button1;
        private ScottPlot.WinForms.FormsPlot Chart_Temperature;
        private ProgressBar progressBarTemp;
        private Label lbl_Temperature;
        private Label lbl_City;
        private ScottPlot.WinForms.FormsPlot Chart_AirQuality;
    }
}
