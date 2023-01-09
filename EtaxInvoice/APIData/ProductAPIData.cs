using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.APIData
{
    public class ProductAPIData
    {
        public int seq { get; set; }
        public string barcode { get; set; }
        public string serialNo { get; set; }
        public string productNameTH { get; set; }
        public string productNameEN { get; set; }
        public string sku { get; set; }
        public string cat1 { get; set; }
        public string cat2 { get; set; }
        public string cat3 { get; set; }
        public string cat4 { get; set; }
        public string cat5 { get; set; }
        public int qty { get; set; }
        public decimal discountAmt { get; set; }
        public decimal amt { get; set; }
        public decimal amtExdiscount { get; set; }
        public decimal amtPerQty { get; set; }
        public decimal vatAmt { get; set; }
        public string isVat { get; set; }
        public List<DiscountInfoAPIData> discountInfo { get; set; } = new List<DiscountInfoAPIData>();
    }
}
