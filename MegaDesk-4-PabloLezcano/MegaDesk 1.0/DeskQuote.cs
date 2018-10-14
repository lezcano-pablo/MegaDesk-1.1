using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1._0
{
    class DeskQuote
    {

        private string CustomerName;
        private DateTime QuoteDate;
        private Desk Desk = new Desk();
        public int RushDays= 0;


        private const int PRICE_BASE = 200;

        public static int Rushdays { get; internal set; }
    }
}
