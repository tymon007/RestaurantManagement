namespace RestaurantManagement
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            panel1 = new Panel();
            label_welcome = new Label();
            button_logout = new Button();
            label_time = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label_welcome);
            panel1.Controls.Add(button_logout);
            panel1.Controls.Add(label_time);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 80);
            panel1.TabIndex = 6;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_welcome.ForeColor = Color.White;
            label_welcome.Location = new Point(771, 20);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(156, 32);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "Witaj Maciej!";
            // 
            // button_logout
            // 
            button_logout.BackgroundImage = (Image)resources.GetObject("button_logout.BackgroundImage");
            button_logout.BackgroundImageLayout = ImageLayout.Zoom;
            button_logout.FlatStyle = FlatStyle.Flat;
            button_logout.ForeColor = SystemColors.ControlText;
            button_logout.Location = new Point(933, 12);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(75, 58);
            button_logout.TabIndex = 1;
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_time.ForeColor = Color.White;
            label_time.Location = new Point(12, 20);
            label_time.Name = "label_time";
            label_time.Size = new Size(99, 32);
            label_time.TabIndex = 3;
            label_time.Text = "godzina";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Giga_Chad_A_Hyperrealistic_Digital_Graphic_42247951_1;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(85, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 255);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 361);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 8;
            label1.Text = "Zmień zdjęcie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 16);
            label2.Name = "label2";
            label2.Size = new Size(209, 32);
            label2.TabIndex = 9;
            label2.Text = "Dane Pracownika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 64);
            label3.Name = "label3";
            label3.Size = new Size(307, 25);
            label3.TabIndex = 10;
            label3.Text = "Imie i nazwisko: Zygmunt Kaszanka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 102);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 11;
            label4.Text = "Płeć: Inna";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 139);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 12;
            label5.Text = "Wiek: 14";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 175);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 13;
            label6.Text = "Rola: Kierownik";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 212);
            label7.Name = "label7";
            label7.Size = new Size(305, 25);
            label7.TabIndex = 14;
            label7.Text = "Data rozpoczęcia pracy: 21.06.2008";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(361, 333);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(308, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(592, 255);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.edit;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(402, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(58, 51);
            panel4.TabIndex = 16;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(385, 1);
            button1.Name = "button1";
            button1.Size = new Size(207, 70);
            button1.TabIndex = 15;
            button1.Text = "Edytuj dane";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(3, 3);
            monthCalendar1.Location = new Point(85, 480);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(85, 439);
            label9.Name = "label9";
            label9.Size = new Size(87, 32);
            label9.TabIndex = 19;
            label9.Text = "Grafik:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(270, 453);
            label10.Name = "label10";
            label10.Size = new Size(314, 15);
            label10.TabIndex = 20;
            label10.Text = "(tutaj bedzie kalendarz dostosowany do obslugi dotykiem)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(201, 945);
            label11.Name = "label11";
            label11.Size = new Size(699, 15);
            label11.TabIndex = 21;
            label11.Text = "(po kliknieciu w komorke otworzy sie formularz gdzie mozna uzupelnic, edytowac, usunac lub podejrzec godziny na wybrany dzien)";
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1020);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(monthCalendar1);
            Controls.Add(panel3);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profil";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_welcome;
        private Button button_logout;
        private Label label_time;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}