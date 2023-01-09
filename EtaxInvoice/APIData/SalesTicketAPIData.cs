using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.APIData
{
    public class SalesTicketAPIData
    {
        public List<ProductAPIData> products { get; set; } = new List<ProductAPIData>();
        public List<PaymentAPIData> payments { get; set; } = new List<PaymentAPIData>();
        public RefTicketAPIData refTicket { get; set; } = new RefTicketAPIData();
        public string loc { get; set; }
        public string receiptDate { get; set; }
        public string ticketNo { get; set; }
        public string tpNo { get; set; }
        public string receiptNo { get; set; }
        public decimal totalSaleAmt { get; set; }
        public decimal totalVatSaleAmt { get; set; }
        public decimal totalNetSaleAmt { get; set; }
        public decimal totalVatItemAmt { get; set; }
        public decimal totalNonVatItemAmt { get; set; }
        public string transType { get; set; }
        public string template_type { get; set; }
        public decimal taxValue { get; set; }
        public int totalQty { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal totalAmtExdiscount { get; set; }
        public string receiptNumber { get; set; }
        public string barcodeComplete { get; set; }
        public decimal remainderAmt { get; set; }
        public decimal depositAmt { get; set; }
        public string orderNo { get; set; }
    }
}
