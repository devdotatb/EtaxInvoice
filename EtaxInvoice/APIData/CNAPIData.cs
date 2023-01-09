using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.APIData
{
    public class CNAPIData
    {
        public string remark { get; set; }
        public bool isShowBranchNo { get; set; }
        public string userid { get; set; }
        public string userBu { get; set; }
        public string userLoc { get; set; }
        public string userRole { get; set; }
        public CustomerAPIData customer { get; set; } = new CustomerAPIData();
        public CustomerAPIData shipTo { get; set; } = new CustomerAPIData();
        public SaleDataAPIData saleData { get; set; } = new SaleDataAPIData();
    }
}
