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
            label7 = new Label();
            label_welcome = new Label();
            button_logout = new Button();
            label_time = new Label();
            dataGridViewPopularnoscDan = new DataGridView();
            dataGridViewGodzinyPracownikow = new DataGridView();
            dataGridViewPodzialPrzychodu = new DataGridView();
            dataGridViewRocznyPrzychod = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            buttonOdswiezDane = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPopularnoscDan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGodzinyPracownikow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodzialPrzychodu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRocznyPrzychod).BeginInit();
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
            panel1.TabIndex = 7;
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
            label2.Location = new Point(167, 166);
            label2.Name = "label2";
            label2.Size = new Size(358, 25);
            label2.TabIndex = 14;
            label2.Text = "Podział przychodu na miejscu / na wynos";
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
            // buttonOdswiezDane
            // 
            buttonOdswiezDane.BackColor = Color.LightBlue;
            buttonOdswiezDane.FlatStyle = FlatStyle.Popup;
            buttonOdswiezDane.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOdswiezDane.Location = new Point(0, 80);
            buttonOdswiezDane.Name = "buttonOdswiezDane";
            buttonOdswiezDane.Size = new Size(1020, 83);
            buttonOdswiezDane.TabIndex = 18;
            buttonOdswiezDane.Text = "Odśwież dane";
            buttonOdswiezDane.UseVisualStyleBackColor = false;
            buttonOdswiezDane.Click += buttonOdswiezDane_Click;
            // 
            // Raports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1020);
            Controls.Add(buttonOdswiezDane);
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
        private DataGridView dataGridViewPodzialPrzychodu;
        private DataGridView dataGridViewRocznyPrzychod;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Label label7;
        private Button buttonOdswiezDane;
    }
}