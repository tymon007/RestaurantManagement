namespace RestaurantManagement
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(176, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.White;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(176, 289);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(215, 190);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(215, 271);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Hasło:";
            // 
            // button_login
            // 
            button_login.BackColor = Color.Black;
            button_login.FlatStyle = FlatStyle.Popup;
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(196, 340);
            button_login.Name = "button_login";
            button_login.Size = new Size(81, 34);
            button_login.TabIndex = 4;
            button_login.Text = "Zaloguj";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.burger;
            pictureBox1.Location = new Point(145, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(488, 481);
            Controls.Add(pictureBox1);
            Controls.Add(button_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button_login;
        private PictureBox pictureBox1;
    }
}