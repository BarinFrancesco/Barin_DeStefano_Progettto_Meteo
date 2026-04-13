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
            lbl_Temperature = new Label();
            lbl_City = new Label();
            panel1 = new Panel();
            termometerbar = new Panel();
            label10 = new Label();
            panel14 = new Panel();
            label11 = new Label();
            panel13 = new Panel();
            label12 = new Label();
            panel12 = new Panel();
            label7 = new Label();
            panel11 = new Panel();
            label8 = new Label();
            panel10 = new Panel();
            label9 = new Label();
            panel9 = new Panel();
            label6 = new Label();
            panel8 = new Panel();
            label5 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CityList
            // 
            CityList.CausesValidation = false;
            CityList.DropDownStyle = ComboBoxStyle.DropDownList;
            CityList.FormattingEnabled = true;
            CityList.Location = new Point(543, 16);
            CityList.Margin = new Padding(3, 4, 3, 4);
            CityList.Name = "CityList";
            CityList.Size = new Size(140, 28);
            CityList.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(543, 52);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(140, 28);
            button1.TabIndex = 1;
            button1.Text = "Cerca";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Chart_Temperature
            // 
            Chart_Temperature.BackColor = Color.Transparent;
            Chart_Temperature.Location = new Point(115, 183);
            Chart_Temperature.Name = "Chart_Temperature";
            Chart_Temperature.Size = new Size(320, 200);
            Chart_Temperature.TabIndex = 5;
            // 
            // lbl_Temperature
            // 
            lbl_Temperature.BackColor = Color.Transparent;
            lbl_Temperature.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Temperature.ForeColor = Color.WhiteSmoke;
            lbl_Temperature.Location = new Point(133, 25);
            lbl_Temperature.Name = "lbl_Temperature";
            lbl_Temperature.Size = new Size(308, 77);
            lbl_Temperature.TabIndex = 4;
            lbl_Temperature.Text = "xx";
            lbl_Temperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_City
            // 
            lbl_City.BackColor = Color.Transparent;
            lbl_City.Font = new Font("Microsoft Sans Serif", 7.8F);
            lbl_City.ForeColor = Color.WhiteSmoke;
            lbl_City.Location = new Point(133, 87);
            lbl_City.Name = "lbl_City";
            lbl_City.Size = new Size(308, 25);
            lbl_City.TabIndex = 3;
            lbl_City.Text = "xx";
            lbl_City.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(termometerbar);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(161, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 50);
            panel1.TabIndex = 6;
            // 
            // termometerbar
            // 
            termometerbar.BackColor = Color.PowderBlue;
            termometerbar.Location = new Point(58, 10);
            termometerbar.Name = "termometerbar";
            termometerbar.Size = new Size(185, 20);
            termometerbar.TabIndex = 7;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 5F);
            label10.Location = new Point(230, 35);
            label10.Name = "label10";
            label10.Size = new Size(22, 10);
            label10.TabIndex = 18;
            label10.Text = "45°";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.ActiveCaptionText;
            panel14.Location = new Point(240, 5);
            panel14.Name = "panel14";
            panel14.Size = new Size(2, 30);
            panel14.TabIndex = 5;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 5F);
            label11.Location = new Point(210, 35);
            label11.Name = "label11";
            label11.Size = new Size(22, 10);
            label11.TabIndex = 17;
            label11.Text = "40°";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ActiveCaptionText;
            panel13.Location = new Point(220, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(2, 30);
            panel13.TabIndex = 4;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 5F);
            label12.Location = new Point(190, 35);
            label12.Name = "label12";
            label12.Size = new Size(22, 10);
            label12.TabIndex = 16;
            label12.Text = "35°";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ActiveCaptionText;
            panel12.Location = new Point(160, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(2, 30);
            panel12.TabIndex = 4;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 5F);
            label7.Location = new Point(170, 35);
            label7.Name = "label7";
            label7.Size = new Size(22, 10);
            label7.TabIndex = 15;
            label7.Text = "30°";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ActiveCaptionText;
            panel11.Location = new Point(200, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(2, 30);
            panel11.TabIndex = 4;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 5F);
            label8.Location = new Point(150, 35);
            label8.Name = "label8";
            label8.Size = new Size(22, 10);
            label8.TabIndex = 14;
            label8.Text = "25°";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveCaptionText;
            panel10.Location = new Point(180, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(2, 30);
            panel10.TabIndex = 4;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 5F);
            label9.Location = new Point(130, 35);
            label9.Name = "label9";
            label9.Size = new Size(22, 10);
            label9.TabIndex = 13;
            label9.Text = "20°";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaptionText;
            panel9.Location = new Point(140, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(2, 30);
            panel9.TabIndex = 3;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 5F);
            label6.Location = new Point(110, 35);
            label6.Name = "label6";
            label6.Size = new Size(22, 10);
            label6.TabIndex = 12;
            label6.Text = "15°";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(20, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(2, 30);
            panel8.TabIndex = 4;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 5F);
            label5.Location = new Point(90, 35);
            label5.Name = "label5";
            label5.Size = new Size(22, 10);
            label5.TabIndex = 11;
            label5.Text = "10°";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(100, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(2, 30);
            panel7.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 5F);
            label4.Location = new Point(70, 35);
            label4.Name = "label4";
            label4.Size = new Size(22, 10);
            label4.TabIndex = 10;
            label4.Text = "5°";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(60, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(2, 30);
            panel6.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 5F);
            label3.Location = new Point(50, 35);
            label3.Name = "label3";
            label3.Size = new Size(22, 10);
            label3.TabIndex = 9;
            label3.Text = "0°";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(120, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 30);
            panel5.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 5F);
            label2.Location = new Point(30, 35);
            label2.Name = "label2";
            label2.Size = new Size(22, 10);
            label2.TabIndex = 8;
            label2.Text = "-5°";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(40, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 30);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 5F);
            label1.Location = new Point(7, 35);
            label1.Name = "label1";
            label1.Size = new Size(22, 10);
            label1.TabIndex = 7;
            label1.Text = "-10°";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(80, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 30);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(15, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 3);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cloud_background_ticebm8qasr73gt1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 417);
            Controls.Add(panel1);
            Controls.Add(lbl_City);
            Controls.Add(Chart_Temperature);
            Controls.Add(lbl_Temperature);
            Controls.Add(button1);
            Controls.Add(CityList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CityList;
        private Button button1;
        private ScottPlot.WinForms.FormsPlot Chart_Temperature;
        private Label lbl_Temperature;
        private Label lbl_City;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel2;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel14;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel termometerbar;
    }
}
