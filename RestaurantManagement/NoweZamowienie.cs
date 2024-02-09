using RestaurantManagement.Controls;
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
using static RestaurantManagement.Models.Zamowienia;
using System.Security.Policy;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
using RestaurantManagement.Service;

namespace RestaurantManagement
{
    public partial class NoweZamowienie : Form
    {
        private Button selectedButton;
        ImageWithDescription imageWithDescription = new ImageWithDescription();
        Helper helper = new Helper();
        List<ZamowienieElement> listaZamowien = new List<ZamowienieElement>();

        public NoweZamowienie()
        {
            InitializeComponent();
            InitializePanels(3, 50, 100);

            selectedButton = buttonNaMiejscu;
            selectedButton.BackColor = Color.Silver;

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
            //List<ImageWithDescription> images = new List<ImageWithDescription>();
            //helper.GenerateImagesWithDescription(10, images);
            DatabaseHandler dbHandler = new DatabaseHandler();

            List<MenuItem> allMenuItems = dbHandler.GetMenuItems();


            //foreach (ImageWithDescription item in images)
            //{
            //    // Kontener dla obrazka i etykiety
            //    Panel panel = new Panel();
            //    panel.Size = new Size(140, 140);

            //    // Obrazek
            //    Button button = new Button();
            //    button.BackgroundImage = item.image;
            //    button.BackgroundImageLayout = ImageLayout.Stretch;
            //    button.Size = new Size(140, 100);

            //    // Label
            //    Label descLabel = new Label();
            //    descLabel.Text = item.description;
            //    descLabel.Dock = DockStyle.Bottom;
            //    descLabel.Font = new Font(descLabel.Font.FontFamily, 10);
            //    descLabel.TextAlign = ContentAlignment.MiddleCenter;

            //    button.Click += (sender, e) => ShowAdditionalControlsInPopup(panel, descLabel.Text);

            //    panel.Controls.Add(button);
            //    panel.Controls.Add(descLabel);

            //    hpanel.Controls.Add(panel);
            //}
            foreach (MenuItem item in allMenuItems)
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
                descLabel.Text = item.name;
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
            confirmButton.BackColor = Color.Silver;

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
            DatabaseHandler dbHandler = new DatabaseHandler();
            int temp_id = 0;
            double temp_cena = 0;
            List<MenuItem> allMenuItems = dbHandler.GetMenuItems();
            foreach (MenuItem item in allMenuItems)
            {
                if (item.name == nazwaProduktu)
                {
                    temp_id = item.id;
                    temp_cena = item.price;
                }
            }
            ZamowienieElement zamowienie = new ZamowienieElement
            {
                produkt_ilosc = ilosc,

                produkt_id = temp_id, // tymczasowo
                produkt_nazwa = nazwaProduktu,
                produkt_cena = temp_cena // tymczasowo
            };

            listaZamowien.Add(zamowienie);

            RefreshDataGridView();
            RefreshLabel();
        }

        private void RefreshDataGridView()
        {
            dataGridViewPodsumowanie.DataSource = null;
            dataGridViewPodsumowanie.DataSource = listaZamowien.Select(z => z.DataGridViewModel).ToList();
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
                return;
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
            buttonNaMiejscu.BackColor = Color.Silver;

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
            buttonNaWynos.BackColor = Color.Silver;

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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (listaZamowien.Count == 0)
            {
                MessageBox.Show("Brak pozycji zamowienia");
                return;
            }

            //wyslanie query do bazy zeby otrzymac id zamowienia. Baza ma zwrocic id zamowienia i czy sie udalo zlozyc 
            DatabaseHandler dbHandler = new DatabaseHandler();
            
            bool successful = true;

            bool naMiejscu = true;
            string adres = string.Empty;
            if (selectedButton == buttonNaWynos)
            {
                naMiejscu = false;
                adres = textBoxAdres.Text;
            }

            if (successful)
            {
                ZarzadzanieZamowieniami zamowienie = new ZarzadzanieZamowieniami();
                int idZamowienia = dbHandler.DodajZamowienie(zamowienie);

                zamowienie.IDZamowienia = idZamowienia;
                zamowienie.Status = ZarzadzanieZamowieniami.StatusZamowienia.Przyjete;
                zamowienie.DataZlozenia = DateTime.Now;
                zamowienie.PozycjeZamowienia = listaZamowien;
                zamowienie.NaMiejscu = naMiejscu;
                zamowienie.Adres = adres;

                MessageBox.Show("Podsumowanie zamówienia: \n\n" + zamowienie.ToString());
            }
        }

        private void NoweZamowienie_Load(object sender, EventArgs e)
        {

        }
    }
}
