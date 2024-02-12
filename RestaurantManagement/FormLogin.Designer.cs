namespace RestaurantManagement
{
    partial class FormLogin
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button_login = new Button();
            panel1 = new Panel();
            label3 = new Label();
            buttonZamknij = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(0, 421);
            textBox1.MinimumSize = new Size(1020, 200);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Login";
            textBox1.Size = new Size(1020, 200);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Click += textBox1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(0, 620);
            textBox2.MinimumSize = new Size(1020, 200);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Hasło";
            textBox2.Size = new Size(1020, 200);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Click += textBox2_Click;
            // 
            // button_login
            // 
            button_login.BackColor = Color.Black;
            button_login.FlatStyle = FlatStyle.Popup;
            button_login.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(0, 820);
            button_login.MinimumSize = new Size(800, 200);
            button_login.Name = "button_login";
            button_login.Size = new Size(1020, 200);
            button_login.TabIndex = 4;
            button_login.Text = "Zaloguj";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.birgur;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(250, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 241);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(247, 204, 60);
            label3.Location = new Point(267, 19);
            label3.Name = "label3";
            label3.Size = new Size(387, 55);
            label3.TabIndex = 6;
            label3.Text = "Trzej Burgerowie";
            // 
            // buttonZamknij
            // 
            buttonZamknij.BackColor = Color.Black;
            buttonZamknij.FlatStyle = FlatStyle.Popup;
            buttonZamknij.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZamknij.ForeColor = Color.IndianRed;
            buttonZamknij.Location = new Point(880, 0);
            buttonZamknij.Name = "buttonZamknij";
            buttonZamknij.Size = new Size(140, 74);
            buttonZamknij.TabIndex = 19;
            buttonZamknij.Text = "Zakończ";
            buttonZamknij.UseVisualStyleBackColor = false;
            buttonZamknij.Click += buttonZamknij_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(1020, 1020);
            Controls.Add(buttonZamknij);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button_login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1020, 1020);
            MinimumSize = new Size(1020, 1020);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_login;
        private Panel panel1;
        private Label label3;
        private Button buttonZamknij;
    }
}