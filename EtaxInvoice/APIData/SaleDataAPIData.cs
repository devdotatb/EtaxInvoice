using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.APIData
{
    public class SaleDataAPIData
    {
        public string bu { get; set; }
        public decimal total { get; set; }
        public SalesTicketAPIData salesTicket { get; set; } = new SalesTicketAPIData();
    }
}
