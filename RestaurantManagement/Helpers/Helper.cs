using System;
using System.Collections.Generic;
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
    }
}
