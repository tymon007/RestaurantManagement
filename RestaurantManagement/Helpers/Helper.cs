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
    }
}
