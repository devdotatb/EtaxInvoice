using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice
{
    public class Invoice
    {
        public string FTBchCode { get; set; }
        public string FDDateIns { get; set; }
        public string FTTimeIns { get; set; }
        public string FTShdDocNo { get; set; }
        public decimal FCShdTotal { get; set; }
        public decimal FCShdVat { get; set; }
        public decimal FCShdVatable { get; set; }
        public decimal FCShdNonVat { get; set; }
        public decimal FCShdDis { get; set; }
        public decimal FCShdB4DisChg { get; set; }
        public decimal FCShdGndAE { get; set; }
        public decimal FCShdAftDisChg { get; set; }
        public decimal FCShdVatRate { get; set; }
        public DateTime FDShdDocDate { get; set; }
        public string FTShdPosCN { get; set; }
    }
}
