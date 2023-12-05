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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(291, 352);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Na miejscu";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(405, 352);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Na wynos";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(695, 375);
            button1.Name = "button1";
            button1.Size = new Size(75, 47);
            button1.TabIndex = 2;
            button1.Text = "Strona główna";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(164, 300);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 53);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 4;
            label1.Text = "Podsumowanie zamówienia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(279, 145);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 5;
            label2.Text = "ikona otwierająca burgery do wyboru";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(279, 210);
            label3.Name = "label3";
            label3.Size = new Size(198, 15);
            label3.TabIndex = 6;
            label3.Text = "ikona otwierająca napoje do wyboru";
            label3.Click += label3_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}