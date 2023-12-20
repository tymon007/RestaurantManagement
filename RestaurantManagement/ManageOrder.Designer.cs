namespace RestaurantManagement
{
    partial class ManageOrder
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label_welcome = new Label();
            button_logout = new Button();
            label_time = new Label();
            dataGridView1 = new DataGridView();
            DataZ = new DataGridViewTextBoxColumn();
            GodzinaZ = new DataGridViewTextBoxColumn();
            GodzinaR = new DataGridViewTextBoxColumn();
            Zrealizowano = new DataGridViewCheckBoxColumn();
            Pozycje = new DataGridViewTextBoxColumn();
            Wartość = new DataGridViewTextBoxColumn();
            namiejscu = new DataGridViewCheckBoxColumn();
            Stolik = new DataGridViewTextBoxColumn();
            Adres = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button_logout.BackgroundImage = Properties.Resources.pngaaa1;
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
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataZ, GodzinaZ, GodzinaR, Zrealizowano, Pozycje, Wartość, namiejscu, Stolik, Adres });
            dataGridView1.Location = new Point(52, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(904, 755);
            dataGridView1.TabIndex = 7;
            // 
            // DataZ
            // 
            DataZ.HeaderText = "Data złożenia";
            DataZ.Name = "DataZ";
            // 
            // GodzinaZ
            // 
            GodzinaZ.HeaderText = "Godzina złożenia";
            GodzinaZ.Name = "GodzinaZ";
            // 
            // GodzinaR
            // 
            GodzinaR.HeaderText = "Godzina realizacji";
            GodzinaR.Name = "GodzinaR";
            // 
            // Zrealizowano
            // 
            Zrealizowano.HeaderText = "Zrealizowano";
            Zrealizowano.Name = "Zrealizowano";
            // 
            // Pozycje
            // 
            Pozycje.HeaderText = "Pozycje zamówienia";
            Pozycje.Name = "Pozycje";
            Pozycje.Resizable = DataGridViewTriState.True;
            Pozycje.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Wartość
            // 
            Wartość.HeaderText = "Wartość";
            Wartość.Name = "Wartość";
            Wartość.Resizable = DataGridViewTriState.True;
            Wartość.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // namiejscu
            // 
            namiejscu.HeaderText = "Na miejscu";
            namiejscu.Name = "namiejscu";
            // 
            // Stolik
            // 
            Stolik.HeaderText = "Stolik";
            Stolik.Name = "Stolik";
            Stolik.Resizable = DataGridViewTriState.True;
            Stolik.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Adres
            // 
            Adres.HeaderText = "Adres";
            Adres.Name = "Adres";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(52, 124);
            dateTimePicker1.MinimumSize = new Size(300, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(342, 50);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(400, 124);
            button1.Name = "button1";
            button1.Size = new Size(117, 51);
            button1.TabIndex = 10;
            button1.Text = "Na miejscu";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(523, 124);
            button2.Name = "button2";
            button2.Size = new Size(130, 51);
            button2.TabIndex = 11;
            button2.Text = "Na wynos";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(659, 123);
            button3.Name = "button3";
            button3.Size = new Size(150, 51);
            button3.TabIndex = 12;
            button3.Text = "Gotowe";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(806, 123);
            button4.Name = "button4";
            button4.Size = new Size(150, 51);
            button4.TabIndex = 13;
            button4.Text = "Usuń";
            button4.UseVisualStyleBackColor = false;
            // 
            // ManageOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1020);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1020, 1020);
            Name = "ManageOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_welcome;
        private Button button_logout;
        private Label label_time;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DataZ;
        private DataGridViewTextBoxColumn GodzinaZ;
        private DataGridViewTextBoxColumn GodzinaR;
        private DataGridViewCheckBoxColumn Zrealizowano;
        private DataGridViewTextBoxColumn Pozycje;
        private DataGridViewTextBoxColumn Wartość;
        private DataGridViewCheckBoxColumn namiejscu;
        private DataGridViewTextBoxColumn Stolik;
        private DataGridViewTextBoxColumn Adres;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}