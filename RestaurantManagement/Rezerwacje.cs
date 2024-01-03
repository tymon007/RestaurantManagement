﻿using RestaurantManagement.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagement.Helpers;
using RestaurantManagement.Models;
using static RestaurantManagement.Models.DataGridViewModels;

namespace RestaurantManagement
{
    public partial class Rezerwacje : Form
    {
        private Button selectedButton;
        ImageWithDescription imageWithDescription = new ImageWithDescription();
        Helper helper = new Helper();
        List<ZamowienieElement> listaZamowien = new List<ZamowienieElement>();

        public Rezerwacje()
        {
            InitializeComponent();
            InitializePanels(3, 50, 100);

            selectedButton = buttonNaMiejscu;
            selectedButton.BackColor = Color.LightGreen;

            textBoxAdres.Enabled = false;
            textBoxNumerTelefonu.Enabled = false;
        }

        private void InitializePanels(int numberOfPanels, int startX, int startY)
        {
            for (int i = 0; i < numberOfPanels; i++)
            {
                HorizontalScrollFlowLayoutPanel hpanel = new HorizontalScrollFlowLayoutPanel();
                hpanel.Size = new Size(900, 170);
                hpanel.Location = new Point(startX, startY + i * (hpanel.Height + 10));
                Controls.Add(hpanel);
                AddButtonsWithImagesToHPanel(hpanel);
            }
        }

        private void AddButtonsWithImagesToHPanel(HorizontalScrollFlowLayoutPanel hpanel)
        {
            List<ImageWithDescription> images = new List<ImageWithDescription>();
            helper.GenerateImagesWithDescription(10, images);

            foreach (ImageWithDescription item in images)
            {
                // Kontener dla obrazka i etykiety
                Panel panel = new Panel();
                panel.Size = new Size(140, 140);

                // Obrazek
                Button button = new Button();
                button.BackgroundImage = item.image;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Size = new Size(140, 100);

                // Label
                Label descLabel = new Label();
                descLabel.Text = item.description;
                descLabel.Dock = DockStyle.Bottom;
                descLabel.Font = new Font(descLabel.Font.FontFamily, 10);
                descLabel.TextAlign = ContentAlignment.MiddleCenter;

                button.Click += (sender, e) => ShowAdditionalControlsInPopup(panel, descLabel.Text);

                panel.Controls.Add(button);
                panel.Controls.Add(descLabel);

                hpanel.Controls.Add(panel);
            }
        }

        private void ShowAdditionalControlsInPopup(Panel panel, string productName)
        {
            // Kontener popup
            Form popupForm = new Form();
            popupForm.Size = new Size(220, 200);
            popupForm.StartPosition = FormStartPosition.CenterParent;
            popupForm.FormBorderStyle = FormBorderStyle.None;
            popupForm.MaximizeBox = false;
            popupForm.BackColor = Color.Silver;

            // Numeric Up Down
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Size = new Size(200, 30);
            numericUpDown.Location = new Point(10, 10);
            numericUpDown.Minimum = 1;
            numericUpDown.Maximum = 20;
            numericUpDown.ReadOnly = true;
            numericUpDown.Font = new Font(numericUpDown.Font.FontFamily, 18);

            // Button Zatwierdź
            Button confirmButton = new Button();
            confirmButton.Text = "Zatwierdź";
            confirmButton.Size = new Size(200, 60);
            confirmButton.Location = new Point(10, numericUpDown.Bottom + 10);
            confirmButton.Click += (sender, e) =>
            {
                int selectedValue = (int)numericUpDown.Value;
                DodajZamowienieDoListy(productName, selectedValue);
                popupForm.Close();
            };
            confirmButton.Font = new Font(confirmButton.Font.FontFamily, 14);
            confirmButton.BackColor = Color.LightGreen;

            // Button Anuluj
            Button cancelButton = new Button();
            cancelButton.Text = "Anuluj";
            cancelButton.Size = new Size(200, 60);
            cancelButton.Location = new Point(10, confirmButton.Bottom + 10);
            cancelButton.Click += (sender, e) => popupForm.Close();
            cancelButton.Font = new Font(cancelButton.Font.FontFamily, 14);
            cancelButton.BackColor = Color.LightCoral;

            popupForm.Controls.Add(numericUpDown);
            popupForm.Controls.Add(confirmButton);
            popupForm.Controls.Add(cancelButton);

            popupForm.ShowDialog();
        }

        private void DodajZamowienieDoListy(string nazwaProduktu, int ilosc)
        {
            ZamowienieElement zamowienie = new ZamowienieElement
            {
                produkt_ilosc = ilosc,
                produkt_id = 0, // tymczasowo
                produkt_nazwa = nazwaProduktu,
                produkt_cena = 15.99 // tymczasowo
            };

            listaZamowien.Add(zamowienie);

            RefreshDataGridView();
            RefreshLabel();
        }

        private void RefreshDataGridView()
        {
            dataGridViewPodsumowanie.DataSource = null;
            dataGridViewPodsumowanie.DataSource = listaZamowien.Select(z => z.ZamowienieElementDGV).ToList();
        }

        private void RefreshLabel()
        {
            double newsum = 0;
            foreach (ZamowienieElement item in listaZamowien)
            {
                newsum += item.produkt_cena * item.produkt_ilosc;
            }
            labelSuma.Text = newsum.ToString("0.00") + " zł";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (listaZamowien.Count == 0)
            {
                MessageBox.Show("Brak pozycji do usuniecia");
                return;
            }
            if (dataGridViewPodsumowanie.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Prosze wybrac pozycje do usuniecia");
            }
            listaZamowien.RemoveAt(dataGridViewPodsumowanie.CurrentCell.RowIndex);
            RefreshDataGridView();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            Hide();
            main.Show();
        }

        private void buttonNaMiejscu_Click(object sender, EventArgs e)
        {
            buttonNaMiejscu.BackColor = Color.LightGreen;

            if (selectedButton != null && selectedButton != buttonNaMiejscu)
            {
                selectedButton.BackColor = SystemColors.Control;
            }

            selectedButton = buttonNaMiejscu;
            textBoxAdres.Enabled = false;
            textBoxNumerTelefonu.Enabled = false;
        }

        private void buttonNaWynos_Click(object sender, EventArgs e)
        {
            buttonNaWynos.BackColor = Color.LightGreen;

            if (selectedButton != null && selectedButton != buttonNaWynos)
            {
                selectedButton.BackColor = SystemColors.Control;
            }

            selectedButton = buttonNaWynos;
            textBoxAdres.Enabled = true;
            textBoxNumerTelefonu.Enabled = true;
        }

        private void textBoxAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdres_Click(object sender, EventArgs e)
        {
            helper.OpenOnScreenKeyboard();
        }

        private void textBoxNumerTelefonu_Click(object sender, EventArgs e)
        {
            helper.OpenOnScreenKeyboard();
        }
    }
}
