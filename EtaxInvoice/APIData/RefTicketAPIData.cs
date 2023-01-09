using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.APIData
{
    public class RefTicketAPIData
    {
        public string tpNo { get; set; }
        public string receiptNo { get; set; }
        public decimal totalSaleAmt { get; set; }
        public decimal correctAmt { get; set; }
        public decimal variance { get; set; }
    }
}
