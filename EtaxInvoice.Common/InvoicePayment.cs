using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.Common
{
    public class InvoicePayment
    {
        public double FCSrcNet { get; set; }
        public string FTRcvName { get; set; }
        public string FTSrcRef { get; set; }
        public string FTShdPosCN { get; set; }
    }
}
