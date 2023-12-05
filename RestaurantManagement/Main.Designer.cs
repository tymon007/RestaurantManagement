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
            monthCalendar1 = new MonthCalendar();
            label_time = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Location = new Point(360, 24);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(75, 15);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "Witaj Maciej!";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // button_logout
            // 
            button_logout.Location = new Point(684, 376);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(75, 23);
            button_logout.TabIndex = 1;
            button_logout.Text = "Wyloguj";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 48);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Location = new Point(112, 24);
            label_time.Name = "label_time";
            label_time.Size = new Size(49, 15);
            label_time.TabIndex = 3;
            label_time.Text = "godzina";
            // 
            // button1
            // 
            button1.Location = new Point(338, 186);
            button1.Name = "button1";
            button1.Size = new Size(144, 78);
            button1.TabIndex = 4;
            button1.Text = "Zamówienie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label_time);
            Controls.Add(monthCalendar1);
            Controls.Add(button_logout);
            Controls.Add(label_welcome);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_welcome;
        private NotifyIcon notifyIcon1;
        private Button button_logout;
        private MonthCalendar monthCalendar1;
        private Label label_time;
        private Button button1;
    }
}