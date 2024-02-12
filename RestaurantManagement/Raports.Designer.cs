namespace RestaurantManagement
{
    partial class Raports
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label_welcome = new Label();
            button_logout = new Button();
            label_time = new Label();
            dataGridViewPopularnoscDan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridViewGodzinyPracownikow = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            dataGridViewPodzialPrzychodu = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            dataGridViewRocznyPrzychod = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            buttonOdswiezDane = new Button();
            label6 = new Label();
            comboBoxMiesiac = new ComboBox();
            label5 = new Label();
            comboBoxRok = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPopularnoscDan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGodzinyPracownikow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodzialPrzychodu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRocznyPrzychod).BeginInit();
            panel4.SuspendLayout();
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
            // dataGridViewPopularnoscDan
            // 
            dataGridViewPopularnoscDan.AllowUserToResizeColumns = false;
            dataGridViewPopularnoscDan.AllowUserToResizeRows = false;
            dataGridViewPopularnoscDan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPopularnoscDan.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPopularnoscDan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPopularnoscDan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPopularnoscDan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPopularnoscDan.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPopularnoscDan.Location = new Point(651, 194);
            dataGridViewPopularnoscDan.MultiSelect = false;
            dataGridViewPopularnoscDan.Name = "dataGridViewPopularnoscDan";
            dataGridViewPopularnoscDan.ReadOnly = true;
            dataGridViewPopularnoscDan.RowHeadersVisible = false;
            dataGridViewPopularnoscDan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPopularnoscDan.RowTemplate.Height = 25;
            dataGridViewPopularnoscDan.ScrollBars = ScrollBars.Vertical;
            dataGridViewPopularnoscDan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPopularnoscDan.ShowCellErrors = false;
            dataGridViewPopularnoscDan.ShowCellToolTips = false;
            dataGridViewPopularnoscDan.ShowEditingIcon = false;
            dataGridViewPopularnoscDan.ShowRowErrors = false;
            dataGridViewPopularnoscDan.Size = new Size(369, 400);
            dataGridViewPopularnoscDan.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nazwa Dania";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ilość szt.";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Udział %";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // dataGridViewGodzinyPracownikow
            // 
            dataGridViewGodzinyPracownikow.AllowUserToResizeColumns = false;
            dataGridViewGodzinyPracownikow.AllowUserToResizeRows = false;
            dataGridViewGodzinyPracownikow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGodzinyPracownikow.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewGodzinyPracownikow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewGodzinyPracownikow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGodzinyPracownikow.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewGodzinyPracownikow.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGodzinyPracownikow.Location = new Point(0, 634);
            dataGridViewGodzinyPracownikow.MultiSelect = false;
            dataGridViewGodzinyPracownikow.Name = "dataGridViewGodzinyPracownikow";
            dataGridViewGodzinyPracownikow.ReadOnly = true;
            dataGridViewGodzinyPracownikow.RowHeadersVisible = false;
            dataGridViewGodzinyPracownikow.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewGodzinyPracownikow.RowTemplate.Height = 25;
            dataGridViewGodzinyPracownikow.ScrollBars = ScrollBars.Vertical;
            dataGridViewGodzinyPracownikow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGodzinyPracownikow.ShowCellErrors = false;
            dataGridViewGodzinyPracownikow.ShowCellToolTips = false;
            dataGridViewGodzinyPracownikow.ShowEditingIcon = false;
            dataGridViewGodzinyPracownikow.ShowRowErrors = false;
            dataGridViewGodzinyPracownikow.Size = new Size(645, 386);
            dataGridViewGodzinyPracownikow.TabIndex = 9;
            // 
            // Column4
            // 
            Column4.HeaderText = "Imie";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Nazwisko";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Zaplanowane";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Urlop";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Niedostepny";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // dataGridViewPodzialPrzychodu
            // 
            dataGridViewPodzialPrzychodu.AllowUserToResizeColumns = false;
            dataGridViewPodzialPrzychodu.AllowUserToResizeRows = false;
            dataGridViewPodzialPrzychodu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPodzialPrzychodu.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewPodzialPrzychodu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewPodzialPrzychodu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPodzialPrzychodu.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10, Column11, Column12, Column13, Column14 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewPodzialPrzychodu.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewPodzialPrzychodu.Location = new Point(0, 194);
            dataGridViewPodzialPrzychodu.MultiSelect = false;
            dataGridViewPodzialPrzychodu.Name = "dataGridViewPodzialPrzychodu";
            dataGridViewPodzialPrzychodu.ReadOnly = true;
            dataGridViewPodzialPrzychodu.RowHeadersVisible = false;
            dataGridViewPodzialPrzychodu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPodzialPrzychodu.RowTemplate.Height = 25;
            dataGridViewPodzialPrzychodu.ScrollBars = ScrollBars.Vertical;
            dataGridViewPodzialPrzychodu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPodzialPrzychodu.ShowCellErrors = false;
            dataGridViewPodzialPrzychodu.ShowCellToolTips = false;
            dataGridViewPodzialPrzychodu.ShowEditingIcon = false;
            dataGridViewPodzialPrzychodu.ShowRowErrors = false;
            dataGridViewPodzialPrzychodu.Size = new Size(645, 400);
            dataGridViewPodzialPrzychodu.TabIndex = 10;
            // 
            // Column9
            // 
            Column9.HeaderText = "Przychód na miejscu";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Udział %";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Ilość";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "Przychód na wynos";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Udział %";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.HeaderText = "Ilość";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // dataGridViewRocznyPrzychod
            // 
            dataGridViewRocznyPrzychod.AllowUserToResizeColumns = false;
            dataGridViewRocznyPrzychod.AllowUserToResizeRows = false;
            dataGridViewRocznyPrzychod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRocznyPrzychod.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewRocznyPrzychod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewRocznyPrzychod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRocznyPrzychod.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewRocznyPrzychod.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewRocznyPrzychod.Location = new Point(651, 634);
            dataGridViewRocznyPrzychod.MultiSelect = false;
            dataGridViewRocznyPrzychod.Name = "dataGridViewRocznyPrzychod";
            dataGridViewRocznyPrzychod.ReadOnly = true;
            dataGridViewRocznyPrzychod.RowHeadersVisible = false;
            dataGridViewRocznyPrzychod.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewRocznyPrzychod.RowTemplate.Height = 25;
            dataGridViewRocznyPrzychod.ScrollBars = ScrollBars.Vertical;
            dataGridViewRocznyPrzychod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRocznyPrzychod.ShowCellErrors = false;
            dataGridViewRocznyPrzychod.ShowCellToolTips = false;
            dataGridViewRocznyPrzychod.ShowEditingIcon = false;
            dataGridViewRocznyPrzychod.ShowRowErrors = false;
            dataGridViewRocznyPrzychod.Size = new Size(369, 386);
            dataGridViewRocznyPrzychod.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Miesiąc";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Łączny przychód";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(644, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 858);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(758, 166);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 13;
            label1.Text = "Popularność dań";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(238, 166);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 14;
            label2.Text = "Podział przychodu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(223, 606);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 15;
            label3.Text = "Godziny pracowników";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 594);
            panel3.Name = "panel3";
            panel3.Size = new Size(1020, 8);
            panel3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(758, 606);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 17;
            label4.Text = "Roczny przychód";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(buttonOdswiezDane);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(comboBoxMiesiac);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(comboBoxRok);
            panel4.Location = new Point(0, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(1020, 83);
            panel4.TabIndex = 18;
            // 
            // buttonOdswiezDane
            // 
            buttonOdswiezDane.BackColor = Color.White;
            buttonOdswiezDane.FlatStyle = FlatStyle.Popup;
            buttonOdswiezDane.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdswiezDane.Location = new Point(697, 27);
            buttonOdswiezDane.Name = "buttonOdswiezDane";
            buttonOdswiezDane.Size = new Size(140, 33);
            buttonOdswiezDane.TabIndex = 18;
            buttonOdswiezDane.Text = "Odśwież dane";
            buttonOdswiezDane.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(403, 30);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 17;
            label6.Text = "Miesiąc:";
            // 
            // comboBoxMiesiac
            // 
            comboBoxMiesiac.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiesiac.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMiesiac.FormattingEnabled = true;
            comboBoxMiesiac.Location = new Point(491, 27);
            comboBoxMiesiac.MinimumSize = new Size(120, 0);
            comboBoxMiesiac.Name = "comboBoxMiesiac";
            comboBoxMiesiac.Size = new Size(160, 33);
            comboBoxMiesiac.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(149, 30);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 15;
            label5.Text = "Rok:";
            // 
            // comboBoxRok
            // 
            comboBoxRok.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRok.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRok.FormattingEnabled = true;
            comboBoxRok.Location = new Point(208, 27);
            comboBoxRok.MinimumSize = new Size(120, 0);
            comboBoxRok.Name = "comboBoxRok";
            comboBoxRok.Size = new Size(160, 33);
            comboBoxRok.TabIndex = 0;
            comboBoxRok.SelectedIndexChanged += comboBoxRok_SelectedIndexChanged;
            // 
            // Raports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1020);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(dataGridViewRocznyPrzychod);
            Controls.Add(dataGridViewPodzialPrzychodu);
            Controls.Add(dataGridViewGodzinyPracownikow);
            Controls.Add(dataGridViewPopularnoscDan);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1020, 1020);
            MinimumSize = new Size(1020, 1020);
            Name = "Raports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raports";
            Load += Raports_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPopularnoscDan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGodzinyPracownikow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodzialPrzychodu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRocznyPrzychod).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_welcome;
        private Button button_logout;
        private Label label_time;
        private DataGridView dataGridViewPopularnoscDan;
        private DataGridView dataGridViewGodzinyPracownikow;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridView dataGridViewPodzialPrzychodu;
        private DataGridView dataGridViewRocznyPrzychod;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label6;
        private ComboBox comboBoxMiesiac;
        private Label label5;
        private ComboBox comboBoxRok;
        private Button buttonOdswiezDane;
    }
}