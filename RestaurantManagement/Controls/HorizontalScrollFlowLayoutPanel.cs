using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Controls
{
    public class HorizontalScrollFlowLayoutPanel : FlowLayoutPanel
    {
        public HorizontalScrollFlowLayoutPanel()
        {
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.WrapContents = false;
            this.FlowDirection = FlowDirection.LeftToRight;
        }
    }
}
