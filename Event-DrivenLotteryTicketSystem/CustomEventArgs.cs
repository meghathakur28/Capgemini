using System;
using System.Collections.Generic;
using System.Text;

namespace Event_DrivenLotteryTicketSystem
{
    public class CustomEventArgs:EventArgs
    {
        public int Quantity { get; set; }

    }
}
