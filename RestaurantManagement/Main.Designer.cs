namespace RestaurantManagement
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            label_welcome = new Label();
            notifyIcon1 = new NotifyIcon(components);
            button_logout = new Button();
            label_time = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
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
            label_welcome.Click += label_welcome_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // button_logout
            // 
            button_logout.BackgroundImage = Properties.Resources.logout;
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
            label_time.Click += label_time_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 163, 70);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(137, 155);
            button1.Name = "button1";
            button1.Size = new Size(744, 150);
            button1.TabIndex = 4;
            button1.Text = "Nowe zamówienie";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panel1.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(204, 78, 17);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(137, 467);
            button2.Name = "button2";
            button2.Size = new Size(744, 150);
            button2.TabIndex = 6;
            button2.Text = "Rezerwacje";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(40, 40, 40);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(137, 623);
            button3.Name = "button3";
            button3.Size = new Size(476, 150);
            button3.TabIndex = 7;
            button3.Text = "Moj profil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(619, 623);
            button4.Name = "button4";
            button4.Size = new Size(262, 150);
            button4.TabIndex = 8;
            button4.Text = "Raporty";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(137, 779);
            button5.Name = "button5";
            button5.Size = new Size(744, 109);
            button5.TabIndex = 9;
            button5.Text = "Zarządzanie użytkownikami";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(227, 114, 0);
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(137, 311);
            button6.Name = "button6";
            button6.Size = new Size(744, 150);
            button6.TabIndex = 10;
            button6.Text = "Zarządzanie zamówieniami";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            BackgroundImage = Properties.Resources.nick_karvounis_Ciqxn7FE4vE_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 1020);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_welcome;
        private NotifyIcon notifyIcon1;
        private Button button_logout;
        private Label label_time;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}