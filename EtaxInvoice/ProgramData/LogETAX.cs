using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice
{
    public class LogETAX
    {
        public DateTime FDDateIns { get; set; }
        public string FTTimeIns { get; set; }
        public string FTWhoIns { get; set; }
        public string FTRemark { get; set; }
        public string FTBchCode { get; set; }
        public string FTDeviceID { get; set; }
        public string FTShdDocNo { get; set; }
        public DateTime FDShdDocDate { get; set; }
        public string FTShdDocType { get; set; }
        public string FTReqType { get; set; }
        public decimal FNStep { get; set; }
        public string FTServiceName { get; set; }
        public string FTReqPara { get; set; }
        public string FTResPara { get; set; }
        public string FTResCode { get; set; }
        public string FTResMsg { get; set; }
        public string FTResShwMsg { get; set; }

    }
}
