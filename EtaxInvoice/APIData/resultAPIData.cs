using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.APIData
{
    public class resultAPIData
    {
        public string result { get; set; }
        public string statusCode { get; set; }
        public string statusMessage { get; set; }
        //public resultInnerAPIData data { get; set; } = new resultInnerAPIData();
    }

    public class resultSuccessNewAPIData
    {
        //SUC004
        public string result { get; set; }
        public string statusCode { get; set; }
        public string statusMessage { get; set; }
        public resultInnerNewAPIData data { get; set; } = new resultInnerNewAPIData();
    }
    public class resultSuccessDuplicateAPIData
    {
        //SUC023
        public string result { get; set; }
        public string statusCode { get; set; }
        public string statusMessage { get; set; }
        public resultInnerDuplicateAPIData data { get; set; } = new resultInnerDuplicateAPIData();
    }

    public class resultInnerDuplicateAPIData
    {
        public string transactionCode { get; set; }
        public string status { get; set; }
        public int totalRecord { get; set; }
        public int totalPage { get; set; }
        public int currentPageNumber { get; set; }
        public List<string> pdfURL { get; set; }
    }

    public class resultInnerNewAPIData
    {
        public string transactionCode { get; set; }
        public string status { get; set; }
        public int totalRecord { get; set; }
        public int totalPage { get; set; }
        public int currentPageNumber { get; set; }
        public string pdfURL { get; set; }
        public string xmlURL { get; set; }
        public string taxinvoiceNo { get; set; }
        public string createdTime { get; set; }
        public string receiptNo { get; set; }
        public string tpNo { get; set; }
    }
}
