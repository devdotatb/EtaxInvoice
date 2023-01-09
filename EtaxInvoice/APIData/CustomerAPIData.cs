using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice.APIData
{
    public class CustomerAPIData
    {
        public bool consentInfo { get; set; }
        public string customerType { get; set; }
        public string customerName { get; set; }
        public string customerTaxId { get; set; }
        public string customerBranch { get; set; }
        public string templateLang { get; set; }
        public string addressType { get; set; }
        public string buildingNo { get; set; }
        public string buildingName { get; set; }
        public string roomNo { get; set; }
        public string moo { get; set; }
        public string floor { get; set; }
        public string soi { get; set; }
        public string road { get; set; }
        public string subDistrict { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string addressLine { get; set; }
    }
}
