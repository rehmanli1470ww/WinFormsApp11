namespace WinFormsApp11
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
            SerchTb = new TextBox();
            LoadButton = new Button();
            label1 = new Label();
            nameTb = new TextBox();
            SurnameTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            FnameTb = new TextBox();
            label4 = new Label();
            CountryTb = new TextBox();
            label5 = new Label();
            cityTb = new TextBox();
            label6 = new Label();
            PhoneTb = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Date = new Label();
            label8 = new Label();
            menRb = new RadioButton();
            womenRb = new RadioButton();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // SerchTb
            // 
            SerchTb.Location = new Point(94, 15);
            SerchTb.Name = "SerchTb";
            SerchTb.Size = new Size(187, 27);
            SerchTb.TabIndex = 0;
            SerchTb.TextChanged += SerchTb_TextChanged;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoadButton.Location = new Point(300, 12);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(118, 30);
            LoadButton.TabIndex = 1;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2, 77);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(94, 77);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(324, 27);
            nameTb.TabIndex = 3;
            nameTb.TextChanged += nameTb_TextChanged;
            // 
            // SurnameTb
            // 
            SurnameTb.Location = new Point(94, 137);
            SurnameTb.Name = "SurnameTb";
            SurnameTb.Size = new Size(324, 27);
            SurnameTb.TabIndex = 4;
            SurnameTb.TextChanged += SurnameTb_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(2, 137);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 5;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 200);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 6;
            label3.Text = "F name";
            // 
            // FnameTb
            // 
            FnameTb.Location = new Point(94, 200);
            FnameTb.Name = "FnameTb";
            FnameTb.Size = new Size(324, 27);
            FnameTb.TabIndex = 7;
            FnameTb.TextChanged += FnameTb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(2, 265);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 8;
            label4.Text = "Country";
            // 
            // CountryTb
            // 
            CountryTb.Location = new Point(94, 266);
            CountryTb.Name = "CountryTb";
            CountryTb.Size = new Size(324, 27);
            CountryTb.TabIndex = 9;
            CountryTb.TextChanged += CountryTb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(2, 327);
            label5.Name = "label5";
            label5.Size = new Size(49, 28);
            label5.TabIndex = 10;
            label5.Text = "City";
            // 
            // cityTb
            // 
            cityTb.Location = new Point(94, 328);
            cityTb.Name = "cityTb";
            cityTb.Size = new Size(324, 27);
            cityTb.TabIndex = 11;
            cityTb.TextChanged += cityTb_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(2, 392);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 12;
            label6.Text = "Phone";
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(94, 393);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(324, 27);
            PhoneTb.TabIndex = 13;
            PhoneTb.TextChanged += PhoneTb_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(94, 454);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Date.Location = new Point(2, 452);
            Date.Name = "Date";
            Date.Size = new Size(57, 28);
            Date.TabIndex = 15;
            Date.Text = "Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(2, 518);
            label8.Name = "label8";
            label8.Size = new Size(80, 28);
            label8.TabIndex = 16;
            label8.Text = "Gender";
            // 
            // menRb
            // 
            menRb.AutoSize = true;
            menRb.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            menRb.Location = new Point(94, 522);
            menRb.Name = "menRb";
            menRb.Size = new Size(66, 27);
            menRb.TabIndex = 17;
            menRb.TabStop = true;
            menRb.Text = "Men";
            menRb.UseVisualStyleBackColor = true;
            // 
            // womenRb
            // 
            womenRb.AutoSize = true;
            womenRb.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            womenRb.Location = new Point(186, 522);
            womenRb.Name = "womenRb";
            womenRb.Size = new Size(93, 27);
            womenRb.TabIndex = 18;
            womenRb.TabStop = true;
            womenRb.Text = "Women";
            womenRb.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Cyan;
            SaveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(32, 585);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(386, 55);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(450, 664);
            Controls.Add(SaveButton);
            Controls.Add(womenRb);
            Controls.Add(menRb);
            Controls.Add(label8);
            Controls.Add(Date);
            Controls.Add(dateTimePicker1);
            Controls.Add(PhoneTb);
            Controls.Add(label6);
            Controls.Add(cityTb);
            Controls.Add(label5);
            Controls.Add(CountryTb);
            Controls.Add(label4);
            Controls.Add(FnameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SurnameTb);
            Controls.Add(nameTb);
            Controls.Add(label1);
            Controls.Add(LoadButton);
            Controls.Add(SerchTb);
            Name = "Form1";
            Text = "Anket";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SerchTb;
        private Button LoadButton;
        private Label label1;
        private TextBox nameTb;
        private TextBox SurnameTb;
        private Label label2;
        private Label label3;
        private TextBox FnameTb;
        private Label label4;
        private TextBox CountryTb;
        private Label label5;
        private TextBox cityTb;
        private Label label6;
        private TextBox PhoneTb;
        private DateTimePicker dateTimePicker1;
        private Label Date;
        private Label label8;
        private RadioButton menRb;
        private RadioButton womenRb;
        private Button SaveButton;
    }
}