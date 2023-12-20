namespace RestaurantManagement
{
    partial class Order
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label_welcome = new Label();
            button_back = new Button();
            label_time = new Label();
            buttonReady = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label4 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            label5 = new Label();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            buttonNaMiejscu = new Button();
            buttonNaWynos = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            Numer = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Od = new DataGridViewTextBoxColumn();
            Do = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(193, 193, 193);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(0, 723);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1020, 202);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 680);
            label1.Name = "label1";
            label1.Size = new Size(369, 40);
            label1.TabIndex = 4;
            label1.Text = "Podsumowanie zamówienia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 100);
            label2.Name = "label2";
            label2.Size = new Size(122, 40);
            label2.TabIndex = 5;
            label2.Text = "Burgery:";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label_welcome);
            panel1.Controls.Add(button_back);
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
            // button_back
            // 
            button_back.BackgroundImage = Properties.Resources.pngaaa_com_3832011;
            button_back.BackgroundImageLayout = ImageLayout.Zoom;
            button_back.FlatStyle = FlatStyle.Flat;
            button_back.ForeColor = SystemColors.ControlText;
            button_back.Location = new Point(933, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 58);
            button_back.TabIndex = 1;
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
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
            // buttonReady
            // 
            buttonReady.BackColor = Color.FromArgb(194, 241, 198);
            buttonReady.FlatStyle = FlatStyle.Popup;
            buttonReady.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReady.Location = new Point(0, 925);
            buttonReady.Name = "buttonReady";
            buttonReady.Size = new Size(1020, 95);
            buttonReady.TabIndex = 8;
            buttonReady.Text = "Przyjmij zamówienie";
            buttonReady.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.pngwing_com;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 107);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.pngwing_com;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(179, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 107);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.pngwing_com;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(346, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 107);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.pngwing_com;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(513, 143);
            panel5.Name = "panel5";
            panel5.Size = new Size(161, 107);
            panel5.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.pngwing_com;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(680, 143);
            panel6.Name = "panel6";
            panel6.Size = new Size(161, 107);
            panel6.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.pngwing_com;
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Location = new Point(847, 143);
            panel7.Name = "panel7";
            panel7.Size = new Size(161, 107);
            panel7.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(193, 256);
            panel8.Name = "panel8";
            panel8.Size = new Size(627, 10);
            panel8.TabIndex = 15;
            panel8.Paint += panel8_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 278);
            label4.Name = "label4";
            label4.Size = new Size(133, 40);
            label4.TabIndex = 16;
            label4.Text = "Przekąski";
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.fryty;
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Location = new Point(12, 321);
            panel9.Name = "panel9";
            panel9.Size = new Size(161, 107);
            panel9.TabIndex = 17;
            // 
            // panel10
            // 
            panel10.BackgroundImage = Properties.Resources.fryty;
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Location = new Point(179, 321);
            panel10.Name = "panel10";
            panel10.Size = new Size(161, 107);
            panel10.TabIndex = 18;
            // 
            // panel11
            // 
            panel11.BackgroundImage = Properties.Resources.fryty;
            panel11.BackgroundImageLayout = ImageLayout.Stretch;
            panel11.Location = new Point(346, 321);
            panel11.Name = "panel11";
            panel11.Size = new Size(161, 107);
            panel11.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 457);
            label5.Name = "label5";
            label5.Size = new Size(110, 40);
            label5.TabIndex = 20;
            label5.Text = "Napoje";
            label5.Click += label5_Click;
            // 
            // panel12
            // 
            panel12.BackgroundImage = Properties.Resources.Coca_Cola_1;
            panel12.BackgroundImageLayout = ImageLayout.Zoom;
            panel12.Location = new Point(12, 500);
            panel12.Name = "panel12";
            panel12.Size = new Size(161, 107);
            panel12.TabIndex = 21;
            // 
            // panel13
            // 
            panel13.BackgroundImage = Properties.Resources.Coca_Cola_1;
            panel13.BackgroundImageLayout = ImageLayout.Zoom;
            panel13.Location = new Point(179, 500);
            panel13.Name = "panel13";
            panel13.Size = new Size(161, 107);
            panel13.TabIndex = 22;
            // 
            // panel14
            // 
            panel14.BackgroundImage = Properties.Resources.Coca_Cola_1;
            panel14.BackgroundImageLayout = ImageLayout.Zoom;
            panel14.Location = new Point(346, 500);
            panel14.Name = "panel14";
            panel14.Size = new Size(161, 107);
            panel14.TabIndex = 23;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Black;
            panel15.Location = new Point(102, 434);
            panel15.Name = "panel15";
            panel15.Size = new Size(312, 10);
            panel15.TabIndex = 24;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Black;
            panel16.Location = new Point(102, 613);
            panel16.Name = "panel16";
            panel16.Size = new Size(312, 10);
            panel16.TabIndex = 25;
            // 
            // buttonNaMiejscu
            // 
            buttonNaMiejscu.BackColor = Color.Silver;
            buttonNaMiejscu.FlatStyle = FlatStyle.Popup;
            buttonNaMiejscu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNaMiejscu.Location = new Point(615, 321);
            buttonNaMiejscu.Name = "buttonNaMiejscu";
            buttonNaMiejscu.Size = new Size(205, 58);
            buttonNaMiejscu.TabIndex = 26;
            buttonNaMiejscu.Text = "Na miejscu";
            buttonNaMiejscu.UseVisualStyleBackColor = false;
            // 
            // buttonNaWynos
            // 
            buttonNaWynos.BackColor = Color.Silver;
            buttonNaWynos.FlatStyle = FlatStyle.Popup;
            buttonNaWynos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNaWynos.Location = new Point(820, 321);
            buttonNaWynos.Name = "buttonNaWynos";
            buttonNaWynos.Size = new Size(200, 58);
            buttonNaWynos.TabIndex = 27;
            buttonNaWynos.Text = "Na wynos";
            buttonNaWynos.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(615, 483);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 29;
            label3.Text = "(Wybór miejsca)";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Numer, Status, Od, Do });
            dataGridView2.Enabled = false;
            dataGridView2.Location = new Point(615, 503);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(405, 220);
            dataGridView2.TabIndex = 30;
            // 
            // Numer
            // 
            Numer.HeaderText = "Numer";
            Numer.Name = "Numer";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Od
            // 
            Od.HeaderText = "Od";
            Od.Name = "Od";
            // 
            // Do
            // 
            Do.HeaderText = "Do";
            Do.Name = "Do";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(719, 381);
            textBox1.MinimumSize = new Size(100, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 50);
            textBox1.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(617, 388);
            label6.Name = "label6";
            label6.Size = new Size(96, 40);
            label6.TabIndex = 32;
            label6.Text = "Adres:";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 1020);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(buttonNaWynos);
            Controls.Add(buttonNaMiejscu);
            Controls.Add(panel16);
            Controls.Add(panel15);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(label5);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(label4);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonReady);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1020, 1020);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += Order_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label_welcome;
        private Button button_back;
        private Label label_time;
        private Button buttonReady;
        private ImageList imageList1;
        private ImageList imageList2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label4;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Label label5;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Button buttonNaMiejscu;
        private Button buttonNaWynos;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Numer;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Od;
        private DataGridViewTextBoxColumn Do;
        private TextBox textBox1;
        private Label label6;
    }
}