using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.Common
{
    public class CustomerTypeDefault
    {
        public string CCPT { get; set; } = "CCPT";//ต่างชาติ
        public string NIDN { get; set; } = "NIDN";//บุคคลธรรมดา
        public string OTHR { get; set; } = "OTHR";//อื่นๆ
        public string TXID { get; set; } = "TXID";//นิติบุคคล
    }
}
