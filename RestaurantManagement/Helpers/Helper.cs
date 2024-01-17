using RestaurantManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Helpers
{
    public class Helper
    {
        public void TimerOn(Label label)
        {
            label.Text = DateTime.Now.ToString("F");
        }
        public void OpenOnScreenKeyboard()
        {
            try
            {
                var onScreenKeyboardProcess = new ProcessStartInfo("osk.exe")
                {
                    UseShellExecute = true
                };
                Process.Start(onScreenKeyboardProcess);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas otwierania klawiatury ekranowej: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetTimePickers(DateTimePicker timepicker1, DateTimePicker timepicker2, int timeDifference)
        {
            timepicker1.Value = DateTime.Now;
            timepicker2.Value = DateTime.Now.AddHours(timeDifference);
        }

        public void GenerateImagesWithDescription(int Count, List<ImageWithDescription> list)
        {
            //Image bareImage = Image.FromFile("C:\\Users\\puddi\\Documents\\GitHub\\RestaurantManagement\\RestaurantManagement\\Resources\\pngwing.com.png");
            for (int i = 0; i < Count; i++)
            {
                ImageWithDescription image = new ImageWithDescription();
                image.description = $"Nazwa produktu{i}";
                //image.image = bareImage;
                list.Add(image);
            }
        }
    }
}
