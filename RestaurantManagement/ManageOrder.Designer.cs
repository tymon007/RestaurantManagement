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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label_welcome = new Label();
            button_logout = new Button();
            label_time = new Label();
            dataGridView1 = new DataGridView();
            zamowieniaBindingSource1 = new BindingSource(components);
            zamowieniaBindingSource = new BindingSource(components);
            buttonNaMiejscu = new Button();
            buttonNaWynos = new Button();
            buttonGotowe = new Button();
            buttonUsun = new Button();
            buttonZrealizowano = new Button();
            buttonNieZrealizowano = new Button();
            buttonFiltruj = new Button();
            buttonWyslano = new Button();
            labelSkunks = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zamowieniaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zamowieniaBindingSource).BeginInit();
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(0, 305);
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
            dataGridView1.Size = new Size(1020, 715);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // zamowieniaBindingSource1
            // 
            zamowieniaBindingSource1.DataSource = typeof(Models.Zamowienia);
            // 
            // zamowieniaBindingSource
            // 
            zamowieniaBindingSource.DataSource = typeof(Models.Zamowienia);
            // 
            // buttonNaMiejscu
            // 
            buttonNaMiejscu.BackColor = Color.White;
            buttonNaMiejscu.FlatStyle = FlatStyle.Flat;
            buttonNaMiejscu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNaMiejscu.ForeColor = Color.Black;
            buttonNaMiejscu.Location = new Point(246, 105);
            buttonNaMiejscu.Name = "buttonNaMiejscu";
            buttonNaMiejscu.Size = new Size(125, 40);
            buttonNaMiejscu.TabIndex = 10;
            buttonNaMiejscu.Text = "Na miejscu";
            buttonNaMiejscu.UseVisualStyleBackColor = true;
            buttonNaMiejscu.Click += buttonNaMiejscu_Click;
            // 
            // buttonNaWynos
            // 
            buttonNaWynos.BackColor = Color.White;
            buttonNaWynos.FlatStyle = FlatStyle.Flat;
            buttonNaWynos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNaWynos.Location = new Point(371, 105);
            buttonNaWynos.Name = "buttonNaWynos";
            buttonNaWynos.Size = new Size(125, 40);
            buttonNaWynos.TabIndex = 11;
            buttonNaWynos.Text = "Na wynos";
            buttonNaWynos.UseVisualStyleBackColor = true;
            buttonNaWynos.Click += buttonNaWynos_Click;
            // 
            // buttonGotowe
            // 
            buttonGotowe.BackColor = Color.LightGreen;
            buttonGotowe.FlatStyle = FlatStyle.Flat;
            buttonGotowe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGotowe.ForeColor = Color.Black;
            buttonGotowe.Location = new Point(770, 265);
            buttonGotowe.Name = "buttonGotowe";
            buttonGotowe.Size = new Size(125, 40);
            buttonGotowe.TabIndex = 12;
            buttonGotowe.Text = "Zrealizowano";
            buttonGotowe.UseVisualStyleBackColor = false;
            buttonGotowe.Click += buttonGotowe_Click;
            // 
            // buttonUsun
            // 
            buttonUsun.BackColor = Color.LightCoral;
            buttonUsun.FlatStyle = FlatStyle.Flat;
            buttonUsun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.ForeColor = Color.Black;
            buttonUsun.Location = new Point(895, 265);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(125, 40);
            buttonUsun.TabIndex = 13;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = false;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // buttonZrealizowano
            // 
            buttonZrealizowano.BackColor = Color.White;
            buttonZrealizowano.FlatStyle = FlatStyle.Flat;
            buttonZrealizowano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZrealizowano.Location = new Point(496, 105);
            buttonZrealizowano.Name = "buttonZrealizowano";
            buttonZrealizowano.Size = new Size(125, 40);
            buttonZrealizowano.TabIndex = 14;
            buttonZrealizowano.Text = "Zrealizowano";
            buttonZrealizowano.UseVisualStyleBackColor = true;
            buttonZrealizowano.Click += buttonZrealizowano_Click;
            // 
            // buttonNieZrealizowano
            // 
            buttonNieZrealizowano.BackColor = Color.White;
            buttonNieZrealizowano.FlatStyle = FlatStyle.Flat;
            buttonNieZrealizowano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNieZrealizowano.Location = new Point(621, 105);
            buttonNieZrealizowano.Name = "buttonNieZrealizowano";
            buttonNieZrealizowano.Size = new Size(155, 40);
            buttonNieZrealizowano.TabIndex = 35;
            buttonNieZrealizowano.Text = "Nie zrealizowano";
            buttonNieZrealizowano.UseVisualStyleBackColor = true;
            buttonNieZrealizowano.Click += buttonNieZrealizowano_Click;
            // 
            // buttonFiltruj
            // 
            buttonFiltruj.BackColor = Color.Bisque;
            buttonFiltruj.FlatStyle = FlatStyle.Flat;
            buttonFiltruj.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFiltruj.Location = new Point(621, 145);
            buttonFiltruj.Name = "buttonFiltruj";
            buttonFiltruj.Size = new Size(155, 40);
            buttonFiltruj.TabIndex = 36;
            buttonFiltruj.Text = "Filtruj";
            buttonFiltruj.UseVisualStyleBackColor = false;
            buttonFiltruj.Click += buttonFiltruj_Click;
            // 
            // buttonWyslano
            // 
            buttonWyslano.BackColor = Color.LightSkyBlue;
            buttonWyslano.FlatStyle = FlatStyle.Flat;
            buttonWyslano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWyslano.ForeColor = Color.Black;
            buttonWyslano.Location = new Point(645, 265);
            buttonWyslano.Name = "buttonWyslano";
            buttonWyslano.Size = new Size(125, 40);
            buttonWyslano.TabIndex = 37;
            buttonWyslano.Text = "Wysłano";
            buttonWyslano.UseVisualStyleBackColor = false;
            // 
            // labelSkunks
            // 
            labelSkunks.AutoSize = true;
            labelSkunks.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelSkunks.Location = new Point(402, 270);
            labelSkunks.Name = "labelSkunks";
            labelSkunks.Size = new Size(219, 32);
            labelSkunks.TabIndex = 38;
            labelSkunks.Text = "Podgląd zamówień";
            // 
            // ManageOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1020, 1020);
            Controls.Add(labelSkunks);
            Controls.Add(buttonWyslano);
            Controls.Add(buttonFiltruj);
            Controls.Add(buttonNieZrealizowano);
            Controls.Add(buttonZrealizowano);
            Controls.Add(buttonUsun);
            Controls.Add(buttonGotowe);
            Controls.Add(buttonNaWynos);
            Controls.Add(buttonNaMiejscu);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1020, 1020);
            Name = "ManageOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrder";
            Load += ManageOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)zamowieniaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)zamowieniaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_welcome;
        private Button button_logout;
        private Label label_time;
        private DataGridView dataGridView1;
        private Button buttonNaMiejscu;
        private Button buttonNaWynos;
        private Button buttonGotowe;
        private Button buttonUsun;
        private Button buttonZrealizowano;
        private Button buttonNieZrealizowano;
        private Button buttonFiltruj;
        private Button buttonWyslano;
        private BindingSource zamowieniaBindingSource;
        private BindingSource zamowieniaBindingSource1;
        private Label labelSkunks;
    }
}