using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice
{
    public class InvoiceDetail
    {
        public decimal FNSdtSeqNo { get; set; }
        public string FTSdtBarCode { get; set; }
        public string FTPdtName { get; set; }
        public string FTPdtCode { get; set; }
        public decimal FCSdtQty { get; set; }
        public decimal FCSdtSetPrice { get; set; }
        public decimal FCSdtDis { get; set; }
        public decimal FCSdtFootAvg { get; set; }
        public decimal FCSdtNet { get; set; }
        public decimal FCSdtB4DisChg { get; set; }
        public decimal FCSdtVat { get; set; }
        public string FTSdtVatType { get; set; }
    }
}
