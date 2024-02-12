namespace RestaurantManagement
{
    partial class Rezerwacje
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label_welcome = new Label();
            button_logout = new Button();
            label_time = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            comboBoxDzien = new ComboBox();
            comboBoxMiesiac = new ComboBox();
            comboBoxRok = new ComboBox();
            buttonDzis = new Button();
            buttonWyborDate = new Button();
            dataGridView1 = new DataGridView();
            ColumnData = new DataGridViewTextBoxColumn();
            ColumnOd = new DataGridViewTextBoxColumn();
            ColumnDo = new DataGridViewTextBoxColumn();
            ColumnStolik = new DataGridViewTextBoxColumn();
            ColumnOsoba = new DataGridViewTextBoxColumn();
            ColumnTelefon = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            panelWyborDaty = new Panel();
            groupBox2 = new GroupBox();
            panelCzas = new Panel();
            textBox_klient = new TextBox();
            label6 = new Label();
            comboBoxStolik = new ComboBox();
            buttonDodaj = new Button();
            label5 = new Label();
            dateTimePickerOd = new DateTimePicker();
            label4 = new Label();
            dateTimePickerDo = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            comboBoxNRDzien = new ComboBox();
            label3 = new Label();
            comboBoxNRRok = new ComboBox();
            comboBoxNRMiesiac = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panelWyborDaty.SuspendLayout();
            groupBox2.SuspendLayout();
            panelCzas.SuspendLayout();
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
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(395, 2);
            label14.Name = "label14";
            label14.Size = new Size(52, 21);
            label14.TabIndex = 34;
            label14.Text = "Dzień:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(172, 2);
            label13.Name = "label13";
            label13.Size = new Size(65, 21);
            label13.TabIndex = 33;
            label13.Text = "Miesiąc:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(11, 2);
            label12.Name = "label12";
            label12.Size = new Size(40, 21);
            label12.TabIndex = 32;
            label12.Text = "Rok:";
            // 
            // comboBoxDzien
            // 
            comboBoxDzien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDzien.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDzien.FormattingEnabled = true;
            comboBoxDzien.Location = new Point(395, 26);
            comboBoxDzien.Name = "comboBoxDzien";
            comboBoxDzien.Size = new Size(95, 40);
            comboBoxDzien.TabIndex = 31;
            comboBoxDzien.SelectedIndexChanged += comboBoxDzien_SelectedIndexChanged;
            // 
            // comboBoxMiesiac
            // 
            comboBoxMiesiac.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiesiac.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMiesiac.FormattingEnabled = true;
            comboBoxMiesiac.Location = new Point(170, 26);
            comboBoxMiesiac.Name = "comboBoxMiesiac";
            comboBoxMiesiac.Size = new Size(225, 40);
            comboBoxMiesiac.TabIndex = 30;
            comboBoxMiesiac.SelectedIndexChanged += comboBoxMiesiac_SelectedIndexChanged;
            // 
            // comboBoxRok
            // 
            comboBoxRok.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRok.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRok.FormattingEnabled = true;
            comboBoxRok.Location = new Point(9, 26);
            comboBoxRok.Name = "comboBoxRok";
            comboBoxRok.Size = new Size(161, 40);
            comboBoxRok.TabIndex = 29;
            comboBoxRok.SelectedIndexChanged += comboBoxRok_SelectedIndexChanged;
            // 
            // buttonDzis
            // 
            buttonDzis.BackColor = Color.White;
            buttonDzis.FlatStyle = FlatStyle.Flat;
            buttonDzis.Location = new Point(271, 42);
            buttonDzis.Name = "buttonDzis";
            buttonDzis.Size = new Size(240, 59);
            buttonDzis.TabIndex = 35;
            buttonDzis.Text = "Dziś";
            buttonDzis.UseVisualStyleBackColor = false;
            buttonDzis.Click += buttonDzis_Click;
            // 
            // buttonWyborDate
            // 
            buttonWyborDate.BackColor = Color.White;
            buttonWyborDate.FlatStyle = FlatStyle.Flat;
            buttonWyborDate.Location = new Point(511, 42);
            buttonWyborDate.Name = "buttonWyborDate";
            buttonWyborDate.Size = new Size(240, 59);
            buttonWyborDate.TabIndex = 36;
            buttonWyborDate.Text = "Wybór daty";
            buttonWyborDate.UseVisualStyleBackColor = false;
            buttonWyborDate.Click += buttonWyborDate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnData, ColumnOd, ColumnDo, ColumnStolik, ColumnOsoba, ColumnTelefon });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(0, 185);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1020, 483);
            dataGridView1.TabIndex = 38;
            // 
            // ColumnData
            // 
            ColumnData.HeaderText = "Data";
            ColumnData.Name = "ColumnData";
            ColumnData.ReadOnly = true;
            // 
            // ColumnOd
            // 
            ColumnOd.HeaderText = "Od";
            ColumnOd.Name = "ColumnOd";
            ColumnOd.ReadOnly = true;
            // 
            // ColumnDo
            // 
            ColumnDo.HeaderText = "Do";
            ColumnDo.Name = "ColumnDo";
            ColumnDo.ReadOnly = true;
            // 
            // ColumnStolik
            // 
            ColumnStolik.HeaderText = "Stolik";
            ColumnStolik.Name = "ColumnStolik";
            ColumnStolik.ReadOnly = true;
            // 
            // ColumnOsoba
            // 
            ColumnOsoba.HeaderText = "Osoba rezerwująca";
            ColumnOsoba.Name = "ColumnOsoba";
            ColumnOsoba.ReadOnly = true;
            // 
            // ColumnTelefon
            // 
            ColumnTelefon.HeaderText = "Telefon";
            ColumnTelefon.Name = "ColumnTelefon";
            ColumnTelefon.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelWyborDaty);
            groupBox1.Controls.Add(buttonDzis);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(buttonWyborDate);
            groupBox1.Location = new Point(0, 352);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1020, 670);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bieżące rezerwacje";
            // 
            // panelWyborDaty
            // 
            panelWyborDaty.Controls.Add(comboBoxMiesiac);
            panelWyborDaty.Controls.Add(comboBoxRok);
            panelWyborDaty.Controls.Add(label13);
            panelWyborDaty.Controls.Add(label14);
            panelWyborDaty.Controls.Add(comboBoxDzien);
            panelWyborDaty.Controls.Add(label12);
            panelWyborDaty.Location = new Point(259, 102);
            panelWyborDaty.Name = "panelWyborDaty";
            panelWyborDaty.Size = new Size(505, 77);
            panelWyborDaty.TabIndex = 39;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelCzas);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBoxNRDzien);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBoxNRRok);
            groupBox2.Controls.Add(comboBoxNRMiesiac);
            groupBox2.Location = new Point(0, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1020, 260);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nowa rezerwacja";
            // 
            // panelCzas
            // 
            panelCzas.Controls.Add(textBox_klient);
            panelCzas.Controls.Add(label6);
            panelCzas.Controls.Add(comboBoxStolik);
            panelCzas.Controls.Add(buttonDodaj);
            panelCzas.Controls.Add(label5);
            panelCzas.Controls.Add(dateTimePickerOd);
            panelCzas.Controls.Add(label4);
            panelCzas.Controls.Add(dateTimePickerDo);
            panelCzas.Location = new Point(270, 113);
            panelCzas.Name = "panelCzas";
            panelCzas.Size = new Size(481, 114);
            panelCzas.TabIndex = 49;
            // 
            // textBox_klient
            // 
            textBox_klient.Location = new Point(141, 73);
            textBox_klient.Name = "textBox_klient";
            textBox_klient.Size = new Size(204, 33);
            textBox_klient.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 50;
            label6.Text = "Stolik:";
            // 
            // comboBoxStolik
            // 
            comboBoxStolik.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStolik.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStolik.FormattingEnabled = true;
            comboBoxStolik.Location = new Point(2, 28);
            comboBoxStolik.Name = "comboBoxStolik";
            comboBoxStolik.Size = new Size(117, 40);
            comboBoxStolik.TabIndex = 49;
            // 
            // buttonDodaj
            // 
            buttonDodaj.BackColor = Color.PowderBlue;
            buttonDodaj.FlatStyle = FlatStyle.Flat;
            buttonDodaj.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(345, 28);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(136, 39);
            buttonDodaj.TabIndex = 48;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = false;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(231, 4);
            label5.Name = "label5";
            label5.Size = new Size(33, 21);
            label5.TabIndex = 47;
            label5.Text = "Do:";
            // 
            // dateTimePickerOd
            // 
            dateTimePickerOd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerOd.Format = DateTimePickerFormat.Time;
            dateTimePickerOd.Location = new Point(119, 28);
            dateTimePickerOd.Name = "dateTimePickerOd";
            dateTimePickerOd.Size = new Size(112, 39);
            dateTimePickerOd.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(119, 4);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 46;
            label4.Text = "Od:";
            // 
            // dateTimePickerDo
            // 
            dateTimePickerDo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDo.Format = DateTimePickerFormat.Time;
            dateTimePickerDo.Location = new Point(231, 28);
            dateTimePickerDo.Name = "dateTimePickerDo";
            dateTimePickerDo.Size = new Size(114, 39);
            dateTimePickerDo.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(431, 48);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 42;
            label1.Text = "Miesiąc:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(270, 48);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 41;
            label2.Text = "Rok:";
            // 
            // comboBoxNRDzien
            // 
            comboBoxNRDzien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNRDzien.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNRDzien.FormattingEnabled = true;
            comboBoxNRDzien.Location = new Point(655, 72);
            comboBoxNRDzien.Name = "comboBoxNRDzien";
            comboBoxNRDzien.Size = new Size(96, 40);
            comboBoxNRDzien.TabIndex = 40;
            comboBoxNRDzien.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(656, 48);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 43;
            label3.Text = "Dzień:";
            // 
            // comboBoxNRRok
            // 
            comboBoxNRRok.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNRRok.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNRRok.FormattingEnabled = true;
            comboBoxNRRok.Location = new Point(270, 72);
            comboBoxNRRok.Name = "comboBoxNRRok";
            comboBoxNRRok.Size = new Size(161, 40);
            comboBoxNRRok.TabIndex = 38;
            comboBoxNRRok.SelectedIndexChanged += comboBoxNRRok_SelectedIndexChanged;
            // 
            // comboBoxNRMiesiac
            // 
            comboBoxNRMiesiac.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNRMiesiac.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNRMiesiac.FormattingEnabled = true;
            comboBoxNRMiesiac.Location = new Point(431, 72);
            comboBoxNRMiesiac.Name = "comboBoxNRMiesiac";
            comboBoxNRMiesiac.Size = new Size(225, 40);
            comboBoxNRMiesiac.TabIndex = 39;
            comboBoxNRMiesiac.SelectedIndexChanged += comboBoxNRMiesiac_SelectedIndexChanged;
            // 
            // Rezerwacje
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1020);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximumSize = new Size(1020, 1020);
            MinimumSize = new Size(1020, 1020);
            Name = "Rezerwacje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezerwacje";
            Load += Rezerwacje_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            panelWyborDaty.ResumeLayout(false);
            panelWyborDaty.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelCzas.ResumeLayout(false);
            panelCzas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_welcome;
        private Button button_logout;
        private Label label_time;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox comboBoxDzien;
        private ComboBox comboBoxMiesiac;
        private ComboBox comboBoxRok;
        private Button buttonDzis;
        private Button buttonWyborDate;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxNRDzien;
        private Label label3;
        private ComboBox comboBoxNRRok;
        private ComboBox comboBoxNRMiesiac;
        private DateTimePicker dateTimePickerOd;
        private Panel panelCzas;
        private Button buttonDodaj;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePickerDo;
        private Panel panelWyborDaty;
        private Label label6;
        private ComboBox comboBoxStolik;
        private DataGridViewTextBoxColumn ColumnData;
        private DataGridViewTextBoxColumn ColumnOd;
        private DataGridViewTextBoxColumn ColumnDo;
        private DataGridViewTextBoxColumn ColumnStolik;
        private DataGridViewTextBoxColumn ColumnOsoba;
        private DataGridViewTextBoxColumn ColumnTelefon;
        private TextBox textBox_klient;
    }
}