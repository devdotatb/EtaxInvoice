using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.Common
{
    public class InvoiceDetail
    {
        public int FTSdtSeqNo { get; set; }
        public string FTSdtBarCode { get; set; }
        public string FTPdtName { get; set; }
        public string FTPdtCode { get; set; }
        public double FCSdtQty { get; set; }
        public double FCSdtDis { get; set; }
        public double FCSdtFootAvg { get; set; }
        public double FCSdtNet { get; set; }
        public double FCSdtB4DisChg { get; set; }
        public double FCSdtSetPrice { get; set; }
        public double FCSdtVat { get; set; }
        public string FTSdtVatType { get; set; }
    }
}
