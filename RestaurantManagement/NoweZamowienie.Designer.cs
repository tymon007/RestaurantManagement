namespace RestaurantManagement
{
    partial class NoweZamowienie
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewPodsumowanie = new DataGridView();
            panel1 = new Panel();
            label_welcome = new Label();
            button_logout = new Button();
            label_time = new Label();
            buttonSubmit = new Button();
            buttonUsun = new Button();
            panel2 = new Panel();
            labelSuma = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            buttonNaMiejscu = new Button();
            buttonNaWynos = new Button();
            textBoxAdres = new TextBox();
            textBoxNumerTelefonu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodsumowanie).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPodsumowanie
            // 
            dataGridViewPodsumowanie.AllowUserToResizeColumns = false;
            dataGridViewPodsumowanie.AllowUserToResizeRows = false;
            dataGridViewPodsumowanie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPodsumowanie.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPodsumowanie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPodsumowanie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPodsumowanie.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPodsumowanie.Location = new Point(0, 691);
            dataGridViewPodsumowanie.MultiSelect = false;
            dataGridViewPodsumowanie.Name = "dataGridViewPodsumowanie";
            dataGridViewPodsumowanie.ReadOnly = true;
            dataGridViewPodsumowanie.RowHeadersVisible = false;
            dataGridViewPodsumowanie.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPodsumowanie.RowTemplate.Height = 25;
            dataGridViewPodsumowanie.ScrollBars = ScrollBars.Vertical;
            dataGridViewPodsumowanie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPodsumowanie.ShowCellErrors = false;
            dataGridViewPodsumowanie.ShowCellToolTips = false;
            dataGridViewPodsumowanie.ShowEditingIcon = false;
            dataGridViewPodsumowanie.ShowRowErrors = false;
            dataGridViewPodsumowanie.Size = new Size(1020, 215);
            dataGridViewPodsumowanie.TabIndex = 0;
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
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.FromArgb(239, 138, 4);
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(310, 938);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(710, 84);
            buttonSubmit.TabIndex = 7;
            buttonSubmit.Text = "Złóż zamówienie";
            buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // buttonUsun
            // 
            buttonUsun.BackColor = Color.IndianRed;
            buttonUsun.FlatStyle = FlatStyle.Flat;
            buttonUsun.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(0, 938);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(310, 84);
            buttonUsun.TabIndex = 8;
            buttonUsun.Text = "Usuń zaznaczone";
            buttonUsun.UseVisualStyleBackColor = false;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(labelSuma);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 906);
            panel2.Name = "panel2";
            panel2.Size = new Size(1020, 32);
            panel2.TabIndex = 9;
            // 
            // labelSuma
            // 
            labelSuma.AutoSize = true;
            labelSuma.BackColor = Color.Transparent;
            labelSuma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSuma.ForeColor = Color.White;
            labelSuma.Location = new Point(933, 3);
            labelSuma.Name = "labelSuma";
            labelSuma.Size = new Size(0, 21);
            labelSuma.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(873, 3);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 10;
            label2.Text = "Suma:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 652);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 39);
            panel3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 11;
            label4.Text = "Koszyk";
            // 
            // buttonNaMiejscu
            // 
            buttonNaMiejscu.FlatStyle = FlatStyle.Flat;
            buttonNaMiejscu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNaMiejscu.Location = new Point(170, 652);
            buttonNaMiejscu.Name = "buttonNaMiejscu";
            buttonNaMiejscu.Size = new Size(153, 39);
            buttonNaMiejscu.TabIndex = 11;
            buttonNaMiejscu.Text = "Na miejscu";
            buttonNaMiejscu.UseVisualStyleBackColor = true;
            buttonNaMiejscu.Click += buttonNaMiejscu_Click;
            // 
            // buttonNaWynos
            // 
            buttonNaWynos.FlatStyle = FlatStyle.Flat;
            buttonNaWynos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNaWynos.Location = new Point(323, 652);
            buttonNaWynos.Name = "buttonNaWynos";
            buttonNaWynos.Size = new Size(153, 39);
            buttonNaWynos.TabIndex = 12;
            buttonNaWynos.Text = "Na wynos";
            buttonNaWynos.UseVisualStyleBackColor = true;
            buttonNaWynos.Click += buttonNaWynos_Click;
            // 
            // textBoxAdres
            // 
            textBoxAdres.BorderStyle = BorderStyle.FixedSingle;
            textBoxAdres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdres.Location = new Point(476, 652);
            textBoxAdres.MinimumSize = new Size(0, 39);
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.PlaceholderText = "Adres dostawy:";
            textBoxAdres.Size = new Size(315, 39);
            textBoxAdres.TabIndex = 13;
            textBoxAdres.Click += textBoxAdres_Click;
            textBoxAdres.TextChanged += textBoxAdres_TextChanged;
            // 
            // textBoxNumerTelefonu
            // 
            textBoxNumerTelefonu.BorderStyle = BorderStyle.FixedSingle;
            textBoxNumerTelefonu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumerTelefonu.Location = new Point(791, 652);
            textBoxNumerTelefonu.MinimumSize = new Size(0, 39);
            textBoxNumerTelefonu.Name = "textBoxNumerTelefonu";
            textBoxNumerTelefonu.PlaceholderText = "Nr telefonu:";
            textBoxNumerTelefonu.Size = new Size(229, 39);
            textBoxNumerTelefonu.TabIndex = 14;
            textBoxNumerTelefonu.Click += textBoxNumerTelefonu_Click;
            // 
            // Rezerwacje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1020);
            Controls.Add(textBoxNumerTelefonu);
            Controls.Add(textBoxAdres);
            Controls.Add(buttonNaWynos);
            Controls.Add(buttonNaMiejscu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonUsun);
            Controls.Add(buttonSubmit);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPodsumowanie);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rezerwacje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezerwacje";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodsumowanie).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPodsumowanie;
        private Panel panel1;
        private Label label_welcome;
        private Button button_logout;
        private Label label_time;
        private Button buttonSubmit;
        private Button buttonUsun;
        private Panel panel2;
        private Label label2;
        private Label labelSuma;
        private Panel panel3;
        private Label label4;
        private Button buttonNaMiejscu;
        private Button buttonNaWynos;
        private TextBox textBoxAdres;
        private TextBox textBoxNumerTelefonu;
    }
}