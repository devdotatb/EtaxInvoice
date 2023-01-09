using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.APIData
{
    public class PaymentAPIData
    {
        public string paymentType { get; set; }
        public string tenderCode { get; set; }
        public decimal saleAmt { get; set; }
        public string paymentDescription { get; set; }
        public string paymentMediaNumber { get; set; }
    }
}
