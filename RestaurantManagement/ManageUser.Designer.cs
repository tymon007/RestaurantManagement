namespace RestaurantManagement
{
    partial class ManageUser
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
            panel1 = new Panel();
            label7 = new Label();
            label_welcome = new Label();
            button_logout = new Button();
            label_time = new Label();
            dataGridViewPracownicy = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            buttonUsunDane = new Button();
            buttonZmienStatus = new Button();
            panel2 = new Panel();
            comboBoxRole = new ComboBox();
            buttonZmienRole = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label_welcome);
            panel1.Controls.Add(button_logout);
            panel1.Controls.Add(label_time);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 80);
            panel1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(358, 20);
            label7.Name = "label7";
            label7.Size = new Size(294, 32);
            label7.TabIndex = 4;
            label7.Text = "PANEL ADMINISTRATORA";
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
            // dataGridViewPracownicy
            // 
            dataGridViewPracownicy.AllowUserToResizeColumns = false;
            dataGridViewPracownicy.AllowUserToResizeRows = false;
            dataGridViewPracownicy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPracownicy.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPracownicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPracownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPracownicy.Columns.AddRange(new DataGridViewColumn[] { Column8, Column4, Column1, Column2, Column3, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPracownicy.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPracownicy.Location = new Point(0, 160);
            dataGridViewPracownicy.MultiSelect = false;
            dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            dataGridViewPracownicy.ReadOnly = true;
            dataGridViewPracownicy.RowHeadersVisible = false;
            dataGridViewPracownicy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPracownicy.RowTemplate.Height = 25;
            dataGridViewPracownicy.ScrollBars = ScrollBars.Vertical;
            dataGridViewPracownicy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPracownicy.ShowCellErrors = false;
            dataGridViewPracownicy.ShowCellToolTips = false;
            dataGridViewPracownicy.ShowEditingIcon = false;
            dataGridViewPracownicy.ShowRowErrors = false;
            dataGridViewPracownicy.Size = new Size(1020, 860);
            dataGridViewPracownicy.TabIndex = 11;
            // 
            // Column8
            // 
            Column8.HeaderText = "Status";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "ID Pracownika";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Imię";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nazwisko";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Rola";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Płeć";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Wiek";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Pracuje od";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // buttonUsunDane
            // 
            buttonUsunDane.BackColor = Color.LightCoral;
            buttonUsunDane.FlatStyle = FlatStyle.Flat;
            buttonUsunDane.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsunDane.ForeColor = Color.Black;
            buttonUsunDane.Location = new Point(680, 80);
            buttonUsunDane.Name = "buttonUsunDane";
            buttonUsunDane.Size = new Size(340, 80);
            buttonUsunDane.TabIndex = 14;
            buttonUsunDane.Text = "Usuń dane osobowe";
            buttonUsunDane.UseVisualStyleBackColor = false;
            buttonUsunDane.Click += buttonUsunDane_Click;
            // 
            // buttonZmienStatus
            // 
            buttonZmienStatus.BackColor = Color.LightSkyBlue;
            buttonZmienStatus.FlatStyle = FlatStyle.Flat;
            buttonZmienStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZmienStatus.ForeColor = Color.Black;
            buttonZmienStatus.Location = new Point(340, 80);
            buttonZmienStatus.Name = "buttonZmienStatus";
            buttonZmienStatus.Size = new Size(340, 80);
            buttonZmienStatus.TabIndex = 15;
            buttonZmienStatus.Text = "Zmień status";
            buttonZmienStatus.UseVisualStyleBackColor = false;
            buttonZmienStatus.Click += buttonZmienStatus_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(comboBoxRole);
            panel2.Controls.Add(buttonZmienRole);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 80);
            panel2.TabIndex = 16;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(73, 3);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(186, 33);
            comboBoxRole.TabIndex = 18;
            // 
            // buttonZmienRole
            // 
            buttonZmienRole.BackColor = Color.Bisque;
            buttonZmienRole.FlatStyle = FlatStyle.Flat;
            buttonZmienRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZmienRole.ForeColor = Color.Black;
            buttonZmienRole.Location = new Point(73, 36);
            buttonZmienRole.Name = "buttonZmienRole";
            buttonZmienRole.Size = new Size(186, 40);
            buttonZmienRole.TabIndex = 17;
            buttonZmienRole.Text = "Zmień rolę";
            buttonZmienRole.UseVisualStyleBackColor = false;
            buttonZmienRole.Click += buttonZmienRole_Click;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1020);
            Controls.Add(panel2);
            Controls.Add(buttonZmienStatus);
            Controls.Add(buttonUsunDane);
            Controls.Add(dataGridViewPracownicy);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1020, 1020);
            Name = "ManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUser";
            Load += ManageUser_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label_welcome;
        private Button button_logout;
        private Label label_time;
        private DataGridView dataGridViewPracownicy;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button buttonUsunDane;
        private Button buttonZmienStatus;
        private Panel panel2;
        private Button buttonZmienRole;
        private ComboBox comboBoxRole;
    }
}