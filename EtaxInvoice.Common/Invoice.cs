using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.Common
{
    public class Invoice
    {
        public string FTBchCode { get; set; }
        public string FDDateIns { get; set; }
        public string FTTimeIns { get; set; }
        public string FTShdDocNo { get; set; }
        public double FCShdTotal { get; set; }
        public double FCShdVat { get; set; }
        public double FCShdVatable { get; set; }
        public double FCShdNonVat { get; set; }
        public double FCShdDis { get; set; }
        public double FCShdB4DisChg { get; set; }
        public double FCShdGndAE { get; set; }
    }
}
