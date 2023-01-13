
using EtaxInvoice.APIData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace EtaxInvoice
{
    public partial class frmMain : Form
    {
        public static string userLoc;
        public static string ETAX_Invoice_EndPoint;
        public static string ETAX_CN_EndPoint;
        public static string API_Key;
        public static string Client_ID;
        public static string Client_Secret;
        public static string userBu;
        public static string OAuth_URL;
        public static string Web_Service_Timeout;
        public static string b2cauthorize = "test";
        public static string otherCNreasoncode = "CDNG99";
        public static string auth_grant_type = "client_credentials";
        public static string auth_scope = "https://centralgroupb2cdev.onmicrosoft.com/6aa53a06-30c0-438f-88ae-e337707de8f5/.default";

        public static string PrintConfirmText;
        private CustomerTypeDefault customerTypeDefault { get; set; } = new CustomerTypeDefault();
        private Customer CurrentCustomer { get; set; }
        private Country CurrentCountry_0 { get; set; } = new Country();
        private Country CurrentCountry_1 { get; set; } = new Country();
        private Country CurrentCountry_2 { get; set; } = new Country();
        private ReasonCN CurrentReasonCN { get; set; }
        public List<Country> CountryList { get; set; }
        public string APIEmail { get; set; }

        // INV
        public Invoice CurrentInvoice { get; set; }
        public List<InvoiceDetail> CurrentInvoiceDetailList { get; set; }
        public InvoicePayment CurrentInvoicePayment { get; set; }
        // REF INV
        public Invoice REF_CurrentInvoice { get; set; }
        public List<InvoiceDetail> REF_CurrentInvoiceDetailList { get; set; }
        public InvoicePayment REF_CurrentInvoicePayment { get; set; }

        public frmMain()
        {
            InitializeComponent();
            InitializeType();
            CountryList = SQLHelper.LoadCountry();
            comboBox_CNReason.DataSource = SQLHelper.LoadReasonCN();
            LoadConfig();
            DefaultData_Fortest_removing_required();
        }
        private void DefaultData_Fortest_removing_required()
        {
            userBu = "CFR";
            userLoc = "6001";
            Client_ID = "0a59924a-e33e-4faa-a8d5-57101c48879f";
            Client_Secret = "pEZ8Q~8J-rr-MZdGlF_087CYUR1aiHcxu55Bvdoz";
        }
        private void button_testCN_Click(object sender, EventArgs e)
        {
            if (Program.globalProgramMode == 1) Program.globalProgramMode = 2;
            else if (Program.globalProgramMode == 2) Program.globalProgramMode = 1;
            InitializeType();
        }
        public void InitializeType()
        {
            //Invoice || CN
            if (Program.globalProgramMode == 1)
            {
                //Invoice
                this.tabPage4.Text = "ใบกำกับภาษีอย่างย่อ";
                this.Text = "E-TAX Invoice";
                PrintConfirmText = "กรุณายืนยันการออก E-TAX Invoice?";
                label_ReasonCN.Visible = false;
                comboBox_CNReason.Visible = false;
                textBox_CNReason_Other.Visible = false;

            }
            else if (Program.globalProgramMode == 2)
            {
                //CN
                this.tabPage4.Text = "ใบกำกับภาษีอย่างย่อใบใหม่จากการReturn Receipt";
                this.Text = "E-TAX CN";
                PrintConfirmText = "กรุณายืนยันการออก E-TAX CN?";
                label_ReasonCN.Visible = true;
                comboBox_CNReason.Visible = true;
                textBox_CNReason_Other.Visible = true;

            }
        }
        private void LoadConfig()
        {
            userLoc = SQLHelper.LoaduserLoc();
            ETAX_Invoice_EndPoint = SQLHelper.LoadConfig("001");
            ETAX_CN_EndPoint = SQLHelper.LoadConfig("002");
            API_Key = SQLHelper.LoadConfig("003");
            Client_ID = SQLHelper.LoadConfig("004");
            Client_Secret = SQLHelper.LoadConfig("005");
            userBu = SQLHelper.LoadConfig("006");
            OAuth_URL = SQLHelper.LoadConfig("007");
            Web_Service_Timeout = SQLHelper.LoadConfig("008");
        }
        private void frmInvoiceMain_Load(object sender, EventArgs e)
        {
            comboBox_cWeb_1.SelectedIndex = 1;
        }
        private void OpenfrmCustomer()
        {
            try
            {
                frmUserSearch frm = new frmUserSearch();
                frm.StartPosition = FormStartPosition.CenterParent;

                switch (tabCustomerDetail.SelectedIndex)
                {

                    case 0://บุคคลธรรมดา
                        {
                            frm.CustomerTypeCode = customerTypeDefault.NIDN;
                            break;
                        }
                    case 1://นิติบุคคล
                        {
                            frm.CustomerTypeCode = customerTypeDefault.TXID;
                            break;
                        }

                    case 2://ต่างชาติ
                        {
                            frm.CustomerTypeCode = customerTypeDefault.CCPT;
                            break;
                        }
                }
                var result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    Customer cus = frm.CurrentCustomer;
                    //Do something here with these values
                    if (frm.CurrentCustomer == null)
                    {
                        MessageHelper.ShowError("ไม่พบข้อมูลลูกค้า");
                        return;
                    }
                    this.CurrentCustomer = frm.CurrentCustomer;
                    Country cnty = new Country();
                    var findingcnty = CountryList.Where(t => t.FTCYCode == cus.FTCstSize);
                    if (findingcnty.Any())
                    {
                        cnty = findingcnty.FirstOrDefault();
                    }

                    switch (tabCustomerDetail.SelectedIndex)
                    {
                        case 0:
                            {
                                this.CurrentCountry_0 = cnty;
                                this.textBox_customerCode.Text = cus.FTCstCode;
                                this.textBox_customerName.Text = cus.FTCstName;
                                this.textBox_customerTaxId.Text = cus.FTCstTaxNo;
                                this.textBox_customerEmail.Text = cus.FTCstEmail;
                                this.textBox_customerTel.Text = cus.FTCstTelInv;
                                this.textBox_customerFax.Text = cus.FTCstFaxInv;

                                this.textBox_customerAddress.Text = cus.FTCstAddrInv;
                                this.textBox_customerRoad.Text = cus.FTCstStreetInv;
                                this.textBox_customerSubDistrict.Text = cus.FTCsttrictInv;
                                this.textBox_customerDistrictCode.Text = cus.FTDstCodeInv;
                                this.textBox_customerDistrictName.Text = cus.FTDstName;
                                this.textBox_customerProvinceCode.Text = cus.FTPvnCodeInv;
                                this.textBox_customerProvinceName.Text = cus.FTPvnName;
                                this.textBox_customerPostCode.Text = cus.FTCstPostCodeInv;
                                this.textBox_customerCountry.Text = cnty.FTCYDescTh;
                                break;
                            }
                        case 1:
                            {
                                this.CurrentCountry_1 = cnty;
                                this.textBox_customerCode_1.Text = cus.FTCstCode;
                                this.textBox_customerName_1.Text = cus.FTCstName;
                                this.textBox_customerTaxId_1.Text = cus.FTCstTaxNo;
                                this.textBox_customerWeb_1.Text = cus.FTCstWeb;
                                this.textBox_customerEmail_1.Text = cus.FTCstEmail;
                                this.textBox_customerTel_1.Text = cus.FTCstTelInv;
                                this.textBox_customerFax_1.Text = cus.FTCstFaxInv;

                                this.textBox_customerAddress_1.Text = cus.FTCstAddrInv;
                                this.textBox_customerRoad_1.Text = cus.FTCstStreetInv;
                                this.textBox_customerSubDistrict_1.Text = cus.FTCsttrictInv;
                                this.textBox_customerDistrictCode_1.Text = cus.FTDstCodeInv;
                                this.textBox_customerDistrictName_1.Text = cus.FTDstName;
                                this.textBox_customerProvinceCode_1.Text = cus.FTPvnCodeInv;
                                this.textBox_customerProvinceName_1.Text = cus.FTPvnName;
                                this.textBox_customerPostCode_1.Text = cus.FTCstPostCodeInv;
                                this.textBox_customerCountry_1.Text = cnty.FTCYDescTh;
                                break;
                            }

                        case 2:
                            {
                                this.CurrentCountry_2 = cnty;
                                this.textBox_customerCode_2.Text = cus.FTCstCode;
                                this.textBox_customerName_2.Text = cus.FTCstName;
                                this.textBox_customerTaxId_2.Text = cus.FTCstTaxNo;
                                this.textBox_customerEmail_2.Text = cus.FTCstEmail;
                                this.textBox_customerTel_2.Text = cus.FTCstTelInv;

                                this.textBox_customerAddress_2.Text = cus.FTCstAddrInv;
                                this.textBox_customerProvinceName_2.Text = cus.FTPvnName;
                                this.textBox_customerPostCode_2.Text = cus.FTCstPostCodeInv;
                                this.textBox_customerCountry_2.Text = cnty.FTCYDescTh;
                                break;
                            }
                    }
                    EnableText();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void ShowConfirmCheckDate()
        {
            try
            {
                string text = "ออกใบกำกับภาษีเต็มรูป\nจากใบกับกับภาษีอย่างย่อวันนี้หรือไม่";
                string textheader = "";
                var result = MessageHelper.ShowConfirmWithCancel(text, textheader);
                switch (result)
                {
                    case DialogResult.Yes:
                        OpenfrmInvoiceTodayABB();
                        break;
                    case DialogResult.No:
                        OpenfrmInvoice(false, null);
                        break;
                    case DialogResult.Cancel:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void OpenfrmInvoiceTodayABB()
        {
            try
            {
                frmInvoiceTodayABB frm = new frmInvoiceTodayABB();
                frm.StartPosition = FormStartPosition.CenterParent;
                var result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    OpenfrmInvoice(true, frm.POSnumber);
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void OpenfrmInvoice(bool isToday, string POSno)
        {
            try
            {
                frmInvoiceSearch frm = new frmInvoiceSearch();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.isToday = isToday;
                frm.POSnumber = POSno;
                frm.isCN = (Program.globalProgramMode == 2);
                var result = frm.ShowDialog(this);
                if (frm.CurrentInvoice == null)
                {
                    MessageHelper.ShowError("ไม่พบข้อมูลใบกำกับภาษี");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    Invoice inv = frm.CurrentInvoice;
                    this.CurrentInvoice = frm.CurrentInvoice;
                    this.CurrentInvoiceDetailList = frm.CurrentInvoiceDetailList;
                    this.CurrentInvoicePayment = frm.CurrentInvoicePayment;
                    // CN 

                    this.REF_CurrentInvoice = frm.REF_CurrentInvoice;
                    this.REF_CurrentInvoiceDetailList = frm.REF_CurrentInvoiceDetailList;
                    this.REF_CurrentInvoicePayment = frm.REF_CurrentInvoicePayment;


                    textBox_invoiceDocNo.Text = inv.FTShdDocNo;
                    textBox_invoiceBranchCode.Text = inv.FTBchCode;
                    textBox_invoiceDate.Text = inv.FDDateIns;

                    numericUpDown_sumNet.Value = this.CurrentInvoice.FCShdTotal;
                    numericUpDown_sumDiscount.Value = this.CurrentInvoice.FCShdDis;
                    numericUpDown_NetAfter.Value = this.CurrentInvoice.FCShdAftDisChg;
                    numericUpDown_sumVat.Value = this.CurrentInvoice.FCShdVat;
                    numericUpDown_Total.Value = this.CurrentInvoice.FCShdB4DisChg;

                    numericUpDown_VAT.Value = this.CurrentInvoice.FCShdVatRate;

                    UpdateDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void OpenfrmCountry()
        {
            try
            {
                frmCountrySearch frm = new frmCountrySearch();
                frm.StartPosition = FormStartPosition.CenterParent;
                var result = frm.ShowDialog(this);
                if (frm.CurrentCountry == null)
                {
                    MessageHelper.ShowError("ไม่พบข้อมูลประเทศ");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    Country cus = frm.CurrentCountry;

                    switch (tabCustomerDetail.SelectedIndex)
                    {

                        case 0:
                            {
                                this.CurrentCountry_0 = cus;
                                this.textBox_customerCountry.Text = cus.FTCYDescTh;

                                break;
                            }
                        case 1:
                            {
                                this.CurrentCountry_1 = cus;
                                this.textBox_customerCountry_1.Text = cus.FTCYDescTh;

                                break;
                            }

                        case 2:
                            {
                                this.CurrentCountry_2 = cus;
                                this.textBox_customerCountry_2.Text = cus.FTCYDescTh;

                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void OpenfrmProvince()
        {
            try
            {
                frmProvinceSearch frm = new frmProvinceSearch();
                frm.StartPosition = FormStartPosition.CenterParent;
                var result = frm.ShowDialog(this);
                if (frm.CurrentProvince == null)
                {
                    MessageHelper.ShowError("ไม่พบข้อมูลจังหวัด");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    Province cus = frm.CurrentProvince;
                    switch (tabCustomerDetail.SelectedIndex)
                    {

                        case 0:
                            {
                                this.textBox_customerProvinceCode.Text = cus.FTPvnCode;
                                this.textBox_customerProvinceName.Text = cus.FTPvnName;

                                break;
                            }
                        case 1:
                            {
                                this.textBox_customerProvinceCode_1.Text = cus.FTPvnCode;
                                this.textBox_customerProvinceName_1.Text = cus.FTPvnName;

                                break;
                            }

                        case 2:
                            {

                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void OpenfrmDistrict()
        {
            try
            {
                frmDistrictSearch frm = new frmDistrictSearch();
                frm.StartPosition = FormStartPosition.CenterParent;
                var result = frm.ShowDialog(this);
                if (frm.CurrentDistrict == null)
                {
                    MessageHelper.ShowError("ไม่พบข้อมูลอำเภอ");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    District cus = frm.CurrentDistrict;
                    switch (tabCustomerDetail.SelectedIndex)
                    {

                        case 0:
                            {
                                this.textBox_customerDistrictCode.Text = cus.FTDstCode;
                                this.textBox_customerDistrictName.Text = cus.FTDstName;
                                break;
                            }
                        case 1:
                            {
                                this.textBox_customerDistrictCode_1.Text = cus.FTDstCode;
                                this.textBox_customerDistrictName_1.Text = cus.FTDstName;
                                break;
                            }

                        case 2:
                            {

                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = CurrentInvoiceDetailList;

            dataGridView1.Columns["FNSdtSeqNo"].HeaderText = "ลำดับ";
            dataGridView1.Columns["FTSdtBarCode"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["FTPdtName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["FTPdtCode"].HeaderText = "หน่วย";
            dataGridView1.Columns["FCSdtQty"].HeaderText = "จำนวน";
            dataGridView1.Columns["FCSdtDis"].HeaderText = "ส่วนลด";
            dataGridView1.Columns["FCSdtFootAvg"].Visible = false;
            dataGridView1.Columns["FCSdtNet"].HeaderText = "จำนวนเงิน";
            dataGridView1.Columns["FCSdtB4DisChg"].Visible = false;
            dataGridView1.Columns["FCSdtSetPrice"].HeaderText = "ราคาต่อหน่วย";
            dataGridView1.Columns["FCSdtVat"].Visible = false;
            dataGridView1.Columns["FTSdtVatType"].Visible = false;
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            switch (tabCustomerDetail.SelectedIndex)
            {

                case 0:
                    {
                        this.textBox_customerCode.Text = "";
                        this.textBox_customerName.Text = "";
                        this.textBox_customerTaxId.Text = "";
                        this.textBox_customerEmail.Text = "";
                        this.textBox_customerTel.Text = "";
                        this.textBox_customerFax.Text = "";

                        this.textBox_customerAddress.Text = "";
                        this.textBox_customerRoad.Text = "";
                        this.textBox_customerSubDistrict.Text = "";
                        this.textBox_customerDistrictCode.Text = "";
                        this.textBox_customerDistrictName.Text = "";
                        this.textBox_customerProvinceCode.Text = "";
                        this.textBox_customerProvinceName.Text = "";
                        this.textBox_customerPostCode.Text = "";
                        this.textBox_customerCountry.Text = "";

                        break;
                    }
                case 1:
                    {
                        comboBox_cWeb_1.SelectedIndex = 1;
                        this.textBox_customerCode_1.Text = "";
                        this.textBox_customerName_1.Text = "";
                        this.textBox_customerTaxId_1.Text = "";
                        this.textBox_customerWeb_1.Text = "00000";
                        this.textBox_customerEmail_1.Text = "";
                        this.textBox_customerTel_1.Text = "";
                        this.textBox_customerFax_1.Text = "";

                        this.textBox_customerAddress_1.Text = "";
                        this.textBox_customerRoad_1.Text = "";
                        this.textBox_customerSubDistrict_1.Text = "";
                        this.textBox_customerDistrictCode_1.Text = "";
                        this.textBox_customerDistrictName_1.Text = "";
                        this.textBox_customerProvinceCode_1.Text = "";
                        this.textBox_customerProvinceName_1.Text = "";
                        this.textBox_customerPostCode_1.Text = "";
                        this.textBox_customerCountry_1.Text = "";

                        comboBox_cWeb_1.Enabled = true;

                        break;
                    }

                case 2:
                    {
                        this.textBox_customerCode_2.Text = "";
                        this.textBox_customerName_2.Text = "";
                        this.textBox_customerTaxId_2.Text = "";
                        this.textBox_customerEmail_2.Text = "";
                        this.textBox_customerTel_2.Text = "";

                        this.textBox_customerAddress_2.Text = "";
                        this.textBox_customerProvinceName_2.Text = "";
                        this.textBox_customerPostCode_2.Text = "";
                        this.textBox_customerCountry_2.Text = "";

                        break;
                    }
            }
            EnableText();
        }
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            string branch = "00000";
            switch (tabCustomerDetail.SelectedIndex)
            {

                case 0:
                    {
                        branch = "00000";
                        break;
                    }
                case 1:
                    {
                        if (textBox_customerWeb_1.Text.Length == 5)
                        {
                            branch = textBox_customerWeb_1.Text;
                        }
                        else if (textBox_customerWeb_1.Text.Length == 4)
                        {
                            branch = "0" + textBox_customerWeb_1.Text;
                        }
                        else
                        {
                            MessageHelper.ShowError("กรุณากรอกสาขา 4-5 หลัก");
                            return;
                        }
                        break;
                    }

                case 2:
                    {
                        branch = "00000";
                        break;
                    }
            }
            string yyyyMMddHHmmss = DateTime.Now.ToString("yyyyMMddHHmmss");
            string yyMMddHHmmss = yyyyMMddHHmmss.Remove(0, 2);
            string generatedcstcode = "CT" + branch + "-" + yyMMddHHmmss;

            AddCustomer addCustomerdata = new AddCustomer();

            string errorstring = "กรุณากรอก : ";
            string tmperror = errorstring;
            switch (tabCustomerDetail.SelectedIndex)
            {
                case 0: // บุคคลธรรมดา
                    {
                        addCustomerdata.customerCode = textBox_customerCode.Text;
                        addCustomerdata.customerName = textBox_customerName.Text;
                        addCustomerdata.customerTaxId = textBox_customerTaxId.Text;
                        addCustomerdata.customerAddress = textBox_customerAddress.Text;
                        addCustomerdata.customerRoad = textBox_customerRoad.Text;
                        addCustomerdata.customerSubDistrict = textBox_customerSubDistrict.Text;
                        addCustomerdata.customerDistrictCode = textBox_customerDistrictCode.Text;
                        addCustomerdata.customerProvinceCode = textBox_customerProvinceCode.Text;
                        addCustomerdata.customerPostCode = textBox_customerPostCode.Text;
                        addCustomerdata.customerTel = textBox_customerTel.Text;
                        addCustomerdata.customerFax = textBox_customerFax.Text;
                        addCustomerdata.customerEmail = textBox_customerEmail.Text;
                        addCustomerdata.customerWeb = "";
                        addCustomerdata.countrycode = CurrentCountry_0.FTCYCode;
                        addCustomerdata.customerType = customerTypeDefault.NIDN;

                        break;
                    }
                case 1:// นิติบุคคล
                    {
                        addCustomerdata.customerCode = textBox_customerCode_1.Text;
                        addCustomerdata.customerName = textBox_customerName_1.Text;
                        addCustomerdata.customerTaxId = textBox_customerTaxId_1.Text;
                        addCustomerdata.customerAddress = textBox_customerAddress_1.Text;
                        addCustomerdata.customerRoad = textBox_customerRoad_1.Text;
                        addCustomerdata.customerSubDistrict = textBox_customerSubDistrict_1.Text;
                        addCustomerdata.customerDistrictCode = textBox_customerDistrictCode_1.Text;
                        addCustomerdata.customerProvinceCode = textBox_customerProvinceCode_1.Text;
                        addCustomerdata.customerPostCode = textBox_customerPostCode_1.Text;
                        addCustomerdata.customerTel = textBox_customerTel_1.Text;
                        addCustomerdata.customerFax = textBox_customerFax_1.Text;
                        addCustomerdata.customerEmail = textBox_customerEmail_1.Text;
                        addCustomerdata.customerWeb = textBox_customerWeb_1.Text;
                        addCustomerdata.countrycode = CurrentCountry_1.FTCYCode;
                        addCustomerdata.customerType = customerTypeDefault.TXID;

                        break;
                    }

                case 2:// ชาวต่างชาติ
                    {
                        addCustomerdata.customerCode = textBox_customerCode_2.Text;
                        addCustomerdata.customerName = textBox_customerName_2.Text;
                        addCustomerdata.customerTaxId = textBox_customerTaxId_2.Text;
                        addCustomerdata.customerAddress = textBox_customerAddress_2.Text + "|" + textBox_customerProvinceName_2.Text;
                        addCustomerdata.customerPostCode = textBox_customerPostCode_2.Text;
                        addCustomerdata.customerTel = textBox_customerTel_2.Text;
                        addCustomerdata.customerEmail = textBox_customerEmail_2.Text;
                        addCustomerdata.countrycode = CurrentCountry_2.FTCYCode;
                        addCustomerdata.customerType = customerTypeDefault.CCPT;

                        break;
                    }
            }
            if (addCustomerdata.customerCode == "")
            {
                // new cst
                addCustomerdata.customerCode = generatedcstcode;
            }

            if (string.IsNullOrEmpty(addCustomerdata.customerCode))
            {
                MessageHelper.ShowError("กรุณากด \"เพิ่ม\"");
                return;
            }
            if (string.IsNullOrEmpty(addCustomerdata.customerName))
            {
                errorstring += "ชื่อ,";
            }
            if (string.IsNullOrEmpty(addCustomerdata.countrycode))
            {
                errorstring += "ประเทศ,";
            }

            if (errorstring != tmperror)
            {
                MessageHelper.ShowError(errorstring.Remove(errorstring.Length - 1));
                return;
            }

            SQLHelper.AddCustomer(addCustomerdata);

            MessageHelper.ShowInfo("บันทึกสำเร็จ");

            switch (tabCustomerDetail.SelectedIndex)
            {

                case 0:
                    {
                        textBox_customerCode.Text = addCustomerdata.customerCode;
                        break;
                    }
                case 1:
                    {
                        textBox_customerCode_1.Text = addCustomerdata.customerCode;
                        break;
                    }

                case 2:
                    {
                        textBox_customerCode_2.Text = addCustomerdata.customerCode;
                        break;
                    }
            }
        }

        private void EnableText()
        {
            switch (tabCustomerDetail.SelectedIndex)
            {
                case 0: // บุคคลธรรมดา
                    {

                        this.textBox_customerName.ReadOnly = false;
                        this.textBox_customerTaxId.ReadOnly = false;
                        this.textBox_customerTel.ReadOnly = false;
                        this.textBox_customerFax.ReadOnly = false;
                        this.textBox_customerEmail.ReadOnly = false;

                        this.textBox_customerAddress.ReadOnly = false;
                        this.textBox_customerRoad.ReadOnly = false;
                        this.textBox_customerSubDistrict.ReadOnly = false;
                        this.textBox_customerPostCode.ReadOnly = false;

                        break;
                    }
                case 1:// นิติบุคคล
                    {
                        this.textBox_customerName_1.ReadOnly = false;
                        this.textBox_customerTaxId_1.ReadOnly = false;
                        this.textBox_customerWeb_1.ReadOnly = (comboBox_cWeb_1.SelectedIndex == 1);
                        this.textBox_customerTel_1.ReadOnly = false;
                        this.textBox_customerFax_1.ReadOnly = false;
                        this.textBox_customerEmail_1.ReadOnly = false;

                        this.textBox_customerAddress_1.ReadOnly = false;
                        this.textBox_customerRoad_1.ReadOnly = false;
                        this.textBox_customerSubDistrict_1.ReadOnly = false;
                        this.textBox_customerPostCode_1.ReadOnly = false;
                        comboBox_cWeb_1.Enabled = true;
                        break;
                    }

                case 2:// ชาวต่างชาติ
                    {
                        this.textBox_customerName_2.ReadOnly = false;
                        this.textBox_customerTaxId_2.ReadOnly = false;
                        this.textBox_customerTel_2.ReadOnly = false;
                        this.textBox_customerEmail_2.ReadOnly = false;

                        this.textBox_customerAddress_2.ReadOnly = false;
                        this.textBox_customerProvinceName_2.ReadOnly = false;
                        this.textBox_customerPostCode_2.ReadOnly = false;

                        break;
                    }
            }
        }
        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            OpenfrmCustomer();
        }
        private void button_InvoiceSearch_Click(object sender, EventArgs e)
        {
            ShowConfirmCheckDate();
        }
        private void button_countrySearch_Click(object sender, EventArgs e)
        {
            OpenfrmCountry();
        }
        private void button_countrySearch_1_Click(object sender, EventArgs e)
        {
            OpenfrmCountry();
        }
        private void button_countrySearch_2_Click(object sender, EventArgs e)
        {
            OpenfrmCountry();
        }
        private void button_provinceSearch_Click(object sender, EventArgs e)
        {
            OpenfrmProvince();
        }
        private void button_provinceSearch_1_Click(object sender, EventArgs e)
        {
            OpenfrmProvince();
        }
        private void button_DistrictSearch_Click(object sender, EventArgs e)
        {
            OpenfrmDistrict();
        }
        private void button_DistrictSearch_1_Click(object sender, EventArgs e)
        {
            OpenfrmDistrict();
        }
        private void button_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateBeforeAPI())
                {
                    return;
                }
                string text = PrintConfirmText;
                string textheader = "";
                var result = MessageHelper.ShowConfirm(text, textheader);
                switch (result)
                {
                    case DialogResult.Yes:
                        frmEmailConfirm frm = new frmEmailConfirm();
                        switch (tabCustomerDetail.SelectedIndex)
                        {
                            case 0: // บุคคลธรรมดา
                                {
                                    frm.Email = textBox_customerEmail.Text;

                                    break;
                                }
                            case 1:// นิติบุคคล
                                {
                                    frm.Email = textBox_customerEmail_1.Text;

                                    break;
                                }

                            case 2:// ชาวต่างชาติ
                                {
                                    frm.Email = textBox_customerEmail_2.Text;
                                    break;
                                }
                        }
                        frm.StartPosition = FormStartPosition.CenterParent;
                        var email_result = frm.ShowDialog(this);
                        if (email_result == DialogResult.OK)
                        {
                            APIEmail = frm.Email;
                            switch (tabCustomerDetail.SelectedIndex)
                            {
                                case 0: // บุคคลธรรมดา
                                    {
                                        textBox_customerEmail.Text = APIEmail;

                                        SQLHelper.UpdateEmail(APIEmail, textBox_customerCode.Text);

                                        break;
                                    }
                                case 1:// นิติบุคคล
                                    {
                                        textBox_customerEmail_1.Text = APIEmail;

                                        SQLHelper.UpdateEmail(APIEmail, textBox_customerCode_1.Text);

                                        break;
                                    }

                                case 2:// ชาวต่างชาติ
                                    {
                                        textBox_customerEmail_2.Text = APIEmail;

                                        SQLHelper.UpdateEmail(APIEmail, textBox_customerCode_2.Text);

                                        break;
                                    }
                            }
                            if (Program.globalProgramMode == 1)
                            {
                                // invoice
                                InvoiceAPIData built = BuildInvoiceAPIdata(CurrentInvoice, CurrentInvoiceDetailList, CurrentInvoicePayment);
                                Callapi_Invoice(built);
                            }
                            else if (Program.globalProgramMode == 2)
                            {
                                // invoice
                                if (REF_CurrentInvoice == null)
                                {
                                    // CN
                                    CNAPIData CN_built = BuildCNAPIdata();
                                    Callapi_CN(CN_built);
                                }
                                else
                                {
                                    InvoiceAPIData built = BuildInvoiceAPIdata(REF_CurrentInvoice, REF_CurrentInvoiceDetailList, REF_CurrentInvoicePayment);
                                    if (Callapi_Ref_Invoice(built))
                                    {
                                        // CN
                                        CNAPIData CN_built = BuildCNAPIdata();
                                        Callapi_CN(CN_built);
                                    }
                                }
                            }
                        }
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public bool ValidateBeforeAPI()
        {
            if (string.IsNullOrEmpty(Program.globalStartUserName))
            {
                MessageHelper.ShowError("ไม่พบข้อมูลลูกค้า");
                return false;
            }
            if (string.IsNullOrEmpty(userBu))
            {
                MessageHelper.ShowError("ไม่พบข้อมูลลูกค้า");
                return false;
            }
            if (string.IsNullOrEmpty(userLoc))
            {
                MessageHelper.ShowError("ไม่พบข้อมูลลูกค้า");
                return false;
            }
            if (CurrentInvoice == null)
            {
                MessageHelper.ShowError("กรุณาเลือกใบกำกับภาษีอย่างย่อ");
                return false;
            }
            if (Program.globalProgramMode == 2)
            {
                // CN
                if (CurrentReasonCN == null)
                {
                    MessageHelper.ShowError("กรุณาเลือกเหตุผลในการออกใบลดหนี้");
                    return false;
                }
                else if (CurrentReasonCN.FTRsnCNCode == otherCNreasoncode && string.IsNullOrWhiteSpace(textBox_CNReason_Other.Text))
                {
                    MessageHelper.ShowError("กรุณากรอกเหตุผลอื่นในการออกใบลดหนี้");
                    return false;
                }
            }

            string customerCode = "";
            string customerName = "";
            string customerTaxId = "";
            string customerAddress = "";
            string customerSubDistrict = "";
            string customerDistrictName = "";
            string customerProvinceName = "";
            string customerPostCode = "";
            string countrycode = "";
            string customerType = "";

            switch (tabCustomerDetail.SelectedIndex)
            {
                case 0: // บุคคลธรรมดา
                    {
                        customerCode = textBox_customerCode.Text;
                        customerName = textBox_customerName.Text;
                        customerTaxId = textBox_customerTaxId.Text;
                        customerAddress = textBox_customerAddress.Text;
                        customerSubDistrict = textBox_customerSubDistrict.Text;
                        customerDistrictName = textBox_customerDistrictName.Text;
                        customerProvinceName = textBox_customerProvinceName.Text;
                        customerPostCode = textBox_customerPostCode.Text;
                        countrycode = CurrentCountry_0.FTCYCode;
                        customerType = customerTypeDefault.NIDN;

                        break;
                    }
                case 1:// นิติบุคคล
                    {
                        customerCode = textBox_customerCode_1.Text;
                        customerName = textBox_customerName_1.Text;
                        customerTaxId = textBox_customerTaxId_1.Text;
                        customerAddress = textBox_customerAddress_1.Text;
                        customerSubDistrict = textBox_customerSubDistrict_1.Text;
                        customerDistrictName = textBox_customerDistrictName_1.Text;
                        customerProvinceName = textBox_customerProvinceName_1.Text;
                        customerPostCode = textBox_customerPostCode_1.Text;
                        countrycode = CurrentCountry_1.FTCYCode;
                        customerType = customerTypeDefault.TXID;

                        break;
                    }

                case 2:// ชาวต่างชาติ
                    {
                        customerCode = textBox_customerCode_2.Text;
                        customerName = textBox_customerName_2.Text;
                        customerTaxId = textBox_customerTaxId_2.Text;
                        customerAddress = textBox_customerAddress_2.Text;
                        customerProvinceName = textBox_customerProvinceName_2.Text;
                        customerPostCode = textBox_customerPostCode_2.Text;
                        countrycode = CurrentCountry_2.FTCYCode;
                        customerType = customerTypeDefault.CCPT;

                        break;
                    }
            }

            if (string.IsNullOrEmpty(customerCode))
            {
                MessageHelper.ShowError("ไม่พบข้อมูลลูกค้า");
                return false;
            }

            if (string.IsNullOrEmpty(customerCode))
            {
                MessageHelper.ShowError("ไม่พบข้อมูลลูกค้า");
                return false;
            }

            string errorstring = "กรุณากรอก : ";
            string tmperror = errorstring;
            if (string.IsNullOrEmpty(customerName))
            {
                errorstring += "ชื่อ,";
            }
            if (string.IsNullOrEmpty(customerAddress))
            {
                errorstring += "ที่อยู่,";
            }
            if (tabCustomerDetail.SelectedIndex != 2) //!ต่างชาติ
            {
                if (customerTaxId.Length != 13)
                {
                    errorstring += "เลขที่ประจำตัวผู้เสียภาษี(13 หลัก),";
                }
                if (string.IsNullOrEmpty(customerSubDistrict))
                {
                    errorstring += "ตำบล/แขวง,";
                }
                if (string.IsNullOrEmpty(customerDistrictName))
                {
                    errorstring += "อำเภอ/เขต,";
                }
                if (string.IsNullOrEmpty(customerProvinceName))
                {
                    errorstring += "จังหวัด,";
                }
            }
            if (string.IsNullOrEmpty(customerPostCode))
            {
                errorstring += "ไปรษณีย์,";
            }
            if (string.IsNullOrEmpty(countrycode))
            {
                errorstring += "ประเทศ,";
            }


            if (errorstring != tmperror)
            {
                MessageHelper.ShowError(errorstring.Remove(errorstring.Length - 1));
                return false;
            }

            return true;
        }
        public InvoiceAPIData BuildInvoiceAPIdata(Invoice input_invoice, List<InvoiceDetail> input_invoiceDetails, InvoicePayment input_invoicePayment)
        {
            var sendingdata = new InvoiceAPIData();

            sendingdata.remark = "";
            sendingdata.isShowBranchNo = true;
            sendingdata.userid = Program.globalStartUserName;
            sendingdata.userBu = userBu;
            sendingdata.userLoc = userLoc;
            sendingdata.userRole = "admin";

            sendingdata.customer = Build_CustomerData(isCN: false);
            sendingdata.saleData = Build_SaleData(input_invoice, input_invoiceDetails, input_invoicePayment, isCN: false);

            return sendingdata;
        }
        public CNAPIData BuildCNAPIdata()
        {
            var sendingdata = new CNAPIData();

            sendingdata.remark = "";
            sendingdata.isShowBranchNo = true;
            sendingdata.userid = Program.globalStartUserName;
            sendingdata.userBu = userBu;
            sendingdata.userLoc = userLoc;
            sendingdata.userRole = "admin";
            sendingdata.purposeCode = CurrentReasonCN.FTRsnCNCode;
            sendingdata.purposeDesc = CurrentReasonCN.FTRsnCNCode == otherCNreasoncode ? textBox_CNReason_Other.Text : CurrentReasonCN.FTRsnCNDescEn;

            sendingdata.customer = Build_CustomerData(isCN: true);
            sendingdata.saleData = Build_SaleData(CurrentInvoice, CurrentInvoiceDetailList, CurrentInvoicePayment, isCN: true);

            return sendingdata;
        }
        public CustomerAPIData Build_CustomerData(bool isCN = false)
        {
            CustomerAPIData building_customer = new CustomerAPIData();
            building_customer.consentInfo = true;

            switch (tabCustomerDetail.SelectedIndex)
            {
                case 0: // บุคคลธรรมดา
                    {
                        building_customer.customerType = customerTypeDefault.NIDN;
                        building_customer.customerName = textBox_customerName.Text;
                        building_customer.customerTaxId = textBox_customerTaxId.Text;
                        building_customer.customerBranch = "";
                        building_customer.templateLang = "TH";
                        building_customer.addressType = "LOCAL";
                        building_customer.buildingNo = textBox_customerAddress.Text;
                        building_customer.buildingName = "";
                        building_customer.roomNo = "";
                        building_customer.moo = "";
                        building_customer.floor = "";
                        building_customer.soi = "";
                        building_customer.road = textBox_customerRoad.Text;
                        building_customer.subDistrict = textBox_customerSubDistrict.Text;
                        building_customer.district = textBox_customerDistrictName.Text;
                        building_customer.province = textBox_customerProvinceName.Text;
                        building_customer.postcode = textBox_customerPostCode.Text;
                        building_customer.country = CurrentCountry_0.FTCYDescTh;
                        building_customer.countryCode = CurrentCountry_0.FTCYCode;
                        building_customer.tel = textBox_customerTel.Text;
                        building_customer.fax = textBox_customerFax.Text;
                        building_customer.email = APIEmail;
                        building_customer.addressLine = "";

                        break;
                    }
                case 1:// นิติบุคคล
                    {
                        building_customer.customerType = customerTypeDefault.TXID;
                        building_customer.customerName = textBox_customerName_1.Text;
                        building_customer.customerTaxId = textBox_customerTaxId_1.Text;
                        building_customer.customerBranch = textBox_customerWeb_1.Text;
                        building_customer.templateLang = "TH";
                        building_customer.addressType = "LOCAL";
                        building_customer.buildingNo = textBox_customerAddress_1.Text;
                        building_customer.buildingName = "";
                        building_customer.roomNo = "";
                        building_customer.moo = "";
                        building_customer.floor = "";
                        building_customer.soi = "";
                        building_customer.road = textBox_customerRoad_1.Text;
                        building_customer.subDistrict = textBox_customerSubDistrict_1.Text;
                        building_customer.district = textBox_customerDistrictName_1.Text;
                        building_customer.province = textBox_customerProvinceName_1.Text;
                        building_customer.postcode = textBox_customerPostCode_1.Text;
                        building_customer.country = CurrentCountry_1.FTCYDescTh;
                        building_customer.countryCode = CurrentCountry_1.FTCYCode;
                        building_customer.tel = textBox_customerTel_1.Text;
                        building_customer.fax = textBox_customerFax_1.Text;
                        building_customer.email = APIEmail;
                        building_customer.addressLine = "";

                        break;
                    }

                case 2:// ชาวต่างชาติ
                    {
                        building_customer.customerType = customerTypeDefault.CCPT;
                        building_customer.customerName = textBox_customerName_2.Text;
                        building_customer.customerTaxId = textBox_customerTaxId_2.Text;
                        building_customer.customerBranch = "";
                        building_customer.templateLang = "EN";
                        building_customer.addressType = "INTER";
                        building_customer.buildingNo = "-";
                        building_customer.buildingName = "";
                        building_customer.roomNo = "";
                        building_customer.moo = "";
                        building_customer.floor = "";
                        building_customer.soi = "";
                        building_customer.road = "";
                        building_customer.subDistrict = "";
                        building_customer.district = "";
                        building_customer.province = textBox_customerProvinceName_2.Text;
                        building_customer.postcode = textBox_customerPostCode_2.Text;
                        building_customer.country = CurrentCountry_2.FTCYDescTh;
                        building_customer.countryCode = CurrentCountry_2.FTCYCode;
                        building_customer.tel = textBox_customerTel_2.Text;
                        building_customer.fax = "";
                        building_customer.email = APIEmail;
                        building_customer.addressLine = textBox_customerAddress_2.Text;

                        break;
                    }
            }

            return building_customer;

        }
        public SaleDataAPIData Build_SaleData(Invoice input_invoice, List<InvoiceDetail> input_invoiceDetails, InvoicePayment input_invoicePayment, bool isCN = false)
        {
            SaleDataAPIData building_saledata = new SaleDataAPIData();
            building_saledata.bu = userBu;
            building_saledata.total = input_invoiceDetails.Sum(t => t.FCSdtQty);

            SalesTicketAPIData building_salesTicket = new SalesTicketAPIData();

            List<ProductAPIData> building_products = new List<ProductAPIData>();
            foreach (var invdt in input_invoiceDetails)
            {
                var each_product = new ProductAPIData();
                each_product.seq = invdt.FNSdtSeqNo;
                each_product.barcode = invdt.FTSdtBarCode;
                each_product.serialNo = "";
                each_product.productNameTH = invdt.FTPdtName;
                each_product.productNameEN = invdt.FTPdtName;
                each_product.sku = Convert.ToInt32(invdt.FTPdtCode);
                each_product.cat1 = "";
                each_product.cat2 = "";
                each_product.cat3 = "";
                each_product.cat4 = "";
                each_product.cat5 = "";
                each_product.qty = invdt.FCSdtQty;
                each_product.discountAmt = invdt.FCSdtDis + invdt.FCSdtFootAvg;
                each_product.amt = invdt.FCSdtDis - invdt.FCSdtFootAvg;
                each_product.amtExdiscount = invdt.FCSdtB4DisChg;
                each_product.amtPerQty = invdt.FCSdtSetPrice;
                each_product.vatAmt = invdt.FCSdtVat;
                each_product.isVat = invdt.FTSdtVatType == "1" ? "V" : "N";
                each_product.discountInfo = new List<DiscountInfoAPIData>();
                building_products.Add(each_product);
            }
            building_salesTicket.products = building_products;

            List<PaymentAPIData> building_payments = new List<PaymentAPIData>();

            var each_payment = new PaymentAPIData();
            each_payment.paymentType = "";
            each_payment.tenderCode = "";
            each_payment.saleAmt = input_invoicePayment.FCSrcNet;
            each_payment.paymentDescription = input_invoicePayment.FTRcvName;
            each_payment.paymentMediaNumber = input_invoicePayment.FTSrcRef;
            building_payments.Add(each_payment);
            building_salesTicket.payments = building_payments;

            building_salesTicket.loc = userLoc;
            building_salesTicket.receiptDate = input_invoice.FDDateIns;
            building_salesTicket.ticketNo = input_invoice.FTShdDocNo;
            building_salesTicket.tpNo = input_invoice.FTShdDocNo;
            building_salesTicket.receiptNo = input_invoice.FTShdDocNo;
            building_salesTicket.totalSaleAmt = input_invoice.FCShdTotal;
            building_salesTicket.totalVatSaleAmt = input_invoice.FCShdVat + input_invoice.FCShdVatable;
            building_salesTicket.totalNetSaleAmt = input_invoice.FCShdNonVat + input_invoice.FCShdVatable;
            building_salesTicket.totalVatItemAmt = input_invoice.FCShdVatable;
            building_salesTicket.totalNonVatItemAmt = input_invoice.FCShdNonVat;
            building_salesTicket.transType = "";
            building_salesTicket.template_type = isCN ? "CN" : "Sales";
            building_salesTicket.taxValue = input_invoice.FCShdVat;
            building_salesTicket.totalQty = input_invoiceDetails.Sum(t => t.FCSdtQty);
            building_salesTicket.totalDiscount = input_invoice.FCShdDis;
            building_salesTicket.totalAmtExdiscount = input_invoice.FCShdB4DisChg;
            building_salesTicket.receiptNumber = input_invoice.FTShdDocNo;
            building_salesTicket.barcodeComplete = input_invoice.FTShdDocNo;
            building_salesTicket.remainderAmt = 0;
            building_salesTicket.depositAmt = input_invoice.FCShdGndAE;
            building_salesTicket.orderNo = "";

            if (isCN)
            {
                building_salesTicket.refTicket = new RefTicketAPIData()
                {
                    tpNo = input_invoice.FTShdPosCN,
                    receiptNo = input_invoice.FTShdPosCN,
                    totalSaleAmt = input_invoice.FCShdTotal,
                    correctAmt = input_invoice.FCShdTotal,
                    variance = input_invoice.FCShdTotal - input_invoice.FCShdTotal,
                };
            }

            building_saledata.salesTicket = building_salesTicket;

            return building_saledata;
        }
        public void Callapi_Invoice(InvoiceAPIData data)
        {
            string apiUrl = ETAX_Invoice_EndPoint;
            string serviceName = "std-genft-document";

            string jsonString = JsonConvert.SerializeObject(data);

            string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonString));

            CallApi_share(apiUrl, serviceName, base64String);
        }
        public void Callapi_CN(CNAPIData data)
        {
            string apiUrl = ETAX_CN_EndPoint;
            string serviceName = "std-gencn-document";

            string jsonString = JsonConvert.SerializeObject(data);

            string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonString));

            CallApi_share(apiUrl, serviceName, base64String);
        }
        public bool Callapi_Ref_Invoice(InvoiceAPIData data)
        {
            string apiUrl = ETAX_Invoice_EndPoint;
            string serviceName = "std-genft-document";

            string jsonString = JsonConvert.SerializeObject(data);

            string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonString));

            return CallApi_CreateRef(apiUrl, serviceName, base64String);
        }
        public void CallApi_share(string apiUrl, string serviceName, string base64String)
        {
            string Bearer_api_key = CallApi_Auth();
            if (Bearer_api_key == null)
            {
                return;
            }
            try
            {
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(Web_Service_Timeout))
                    {
                        int output;
                        if (int.TryParse(Web_Service_Timeout, out output))
                        {
                            client.Timeout = TimeSpan.FromSeconds(int.Parse(Web_Service_Timeout));
                        }
                    }

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Bearer_api_key);
                    client.DefaultRequestHeaders.Add("b2cauthorize", b2cauthorize);
                    client.DefaultRequestHeaders.Add("api-key", API_Key);

                    //var payload = new StringContent(base64String);

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
                    request.Content = new StringContent(base64String, Encoding.UTF8, "text/plain");

                    HttpResponseMessage response = client.SendAsync(request).Result;
                    string responseContent = response.Content.ReadAsStringAsync().Result;
                    var obj_result = JsonConvert.DeserializeObject<resultAPIData>(responseContent);

                    SaveLog(serviceName, base64String, responseContent, response.StatusCode.ToString(), obj_result.statusMessage);

                    if (response.IsSuccessStatusCode)
                    {

                        string pdflink = "";
                        if (obj_result.statusCode == "SUC023")
                        {
                            //duplicate
                            var obj_result_full = JsonConvert.DeserializeObject<resultSuccessDuplicateAPIData>(responseContent);
                            pdflink = obj_result_full.data.pdfURL.FirstOrDefault();

                            string text = obj_result.statusMessage;
                            string textheader = "";
                            var result = MessageHelper.ShowInfo(text, textheader);
                            if (result == DialogResult.OK)
                            {
                                string text_p = "คลิก OK เพื่อแสดงเอกสาร";
                                string textheader_p = "";
                                var result_p = MessageHelper.ShowInfo(text_p, textheader_p);
                                if (result_p == DialogResult.OK)
                                {
                                    System.Diagnostics.Process.Start(pdflink);
                                }
                            }
                        }
                        else if (obj_result.statusCode == "SUC004")
                        {
                            //new
                            var obj_result_full = JsonConvert.DeserializeObject<resultSuccessNewAPIData>(responseContent);
                            pdflink = obj_result_full.data.pdfURL;

                            string text = "ระบบได้ดำเนินการส่งรายละเอียด\nเพื่อสร้างเอกสารอิเล็กทรอนิกส์เรียบร้อยแล้ว\nโดยนำส่งตาม E-mail ที่มีการระบุไว้";
                            string textheader = "";
                            var result = MessageHelper.ShowInfo(text, textheader);
                            if (result == DialogResult.OK)
                            {
                                string text_p = "คลิก OK เพื่อแสดงเอกสาร";
                                string textheader_p = "";
                                var result_p = MessageHelper.ShowInfo(text_p, textheader_p);
                                if (result_p == DialogResult.OK)
                                {
                                    System.Diagnostics.Process.Start(pdflink);
                                }
                            }
                        }

                        else if (obj_result.statusCode == "SUC006")
                        {
                            //CN
                            var obj_result_full = JsonConvert.DeserializeObject<resultSuccessNewAPIData>(responseContent);
                            pdflink = obj_result_full.data.pdfURL;

                            string text = "ระบบได้ดำเนินการส่งรายละเอียด\nเพื่อสร้างเอกสารอิเล็กทรอนิกส์เรียบร้อยแล้ว\nโดยนำส่งตาม E-mail ที่มีการระบุไว้";
                            string textheader = "";
                            var result = MessageHelper.ShowInfo(text, textheader);
                            if (result == DialogResult.OK)
                            {
                                string text_p = "คลิก OK เพื่อแสดงเอกสาร";
                                string textheader_p = "";
                                var result_p = MessageHelper.ShowInfo(text_p, textheader_p);
                                if (result_p == DialogResult.OK)
                                {
                                    System.Diagnostics.Process.Start(pdflink);
                                }
                            }
                        }
                        else
                        {
                            string text = obj_result.statusMessage;
                            var result = MessageHelper.ShowError(text);
                        }
                    }
                    else
                    {
                        string text = responseContent;// + "\n" + base64String;
                        var result = MessageHelper.ShowError(text);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageHelper.ShowError("CallApi_share:" + ex.Message);
            }
        }

        public bool CallApi_CreateRef(string apiUrl, string serviceName, string base64String)
        {
            string Bearer_api_key = CallApi_Auth();
            if (Bearer_api_key == null)
            {
                return false;
            }
            try
            {
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(Web_Service_Timeout))
                    {
                        int output;
                        if (int.TryParse(Web_Service_Timeout, out output))
                        {
                            client.Timeout = TimeSpan.FromSeconds(int.Parse(Web_Service_Timeout));
                        }
                    }

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Bearer_api_key);
                    client.DefaultRequestHeaders.Add("b2cauthorize", b2cauthorize);
                    client.DefaultRequestHeaders.Add("api-key", API_Key);

                    //var payload = new StringContent(base64String);

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
                    request.Content = new StringContent(base64String, Encoding.UTF8, "text/plain");

                    HttpResponseMessage response = client.SendAsync(request).Result;
                    string responseContent = response.Content.ReadAsStringAsync().Result;
                    var obj_result = JsonConvert.DeserializeObject<resultAPIData>(responseContent);

                    SaveLog(serviceName, base64String, responseContent, response.StatusCode.ToString(), obj_result.statusMessage, isRef_Create: true);

                    if (response.IsSuccessStatusCode)
                    {
                        if (obj_result.statusCode == "SUC023")
                        {
                            //duplicate
                            return true;
                        }
                        else if (obj_result.statusCode == "SUC004")
                        {
                            //new
                            return true;
                        }
                        else
                        {
                            string text = obj_result.statusMessage;
                            var result = MessageHelper.ShowError(text);
                        }
                    }
                    else
                    {
                        string text = responseContent;// + "\n" + base64String;
                        var result = MessageHelper.ShowError(text);
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError("CallApi_CreateRef :" + ex.Message);
                return false;
            }
        }

        public string CallApi_Auth()
        {
            try
            {
                string oauthUrl = OAuth_URL;
                string clientId = Client_ID;
                string clientSecret = Client_Secret;
                string grantType = auth_grant_type;
                string scope = auth_scope;

                string postData = "grant_type=" + grantType + "&client_id=" + clientId + "&client_secret=" + clientSecret + "&scope=" + scope;
                byte[] postDataBytes = Encoding.UTF8.GetBytes(postData);

                var request = (HttpWebRequest)WebRequest.Create(oauthUrl);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = postDataBytes.Length;

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(postDataBytes, 0, postDataBytes.Length);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        using (var streamReader = new StreamReader(responseStream))
                        {
                            var responseString = streamReader.ReadToEnd();
                            // handle response

                            var obj_result = JsonConvert.DeserializeObject<resultAuthAPIData>(responseString);

                            return obj_result.access_token;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                var result = MessageHelper.ShowError("CallApi_Auth :" + ex.Message);
                return null;
            }
        }

        public void SaveLog(string serviceName, string base64String, string responseContent, string responseStatusCodeToString, string obj_resultstatusMessage, bool isRef_Create = false)
        {
            LogETAX logdata = new LogETAX();
            logdata.FDDateIns = DateTime.Now;
            logdata.FTTimeIns = DateTime.Now.ToString("HHmmss");
            logdata.FTWhoIns = Program.globalStartUserName;
            logdata.FTRemark = "";
            logdata.FTBchCode = Program.globalBranchNumber;
            logdata.FTDeviceID = "Storeback";
            logdata.FTShdDocNo = CurrentInvoice.FTShdDocNo;
            logdata.FDShdDocDate = CurrentInvoice.FDShdDocDate;
            logdata.FTShdDocType = Program.globalProgramMode == 1 ? "1" : "9";
            logdata.FTReqType = Program.globalProgramMode == 1 ? "สร้างใบกำกับภาษี" : "สร้างใบลดหนี้";
            if (isRef_Create)
            {
                logdata.FTReqType = "สร้างใบกำกับภาษี";
            }
            logdata.FNStep = 0;
            logdata.FTServiceName = serviceName;
            logdata.FTReqPara = base64String;
            logdata.FTResPara = responseContent;
            logdata.FTResCode = responseStatusCodeToString;
            logdata.FTResMsg = obj_resultstatusMessage;
            logdata.FTResShwMsg = "";
            LogInserter.InterfaceInsertLog(logdata);
        }

        private void only_number_TextChanged(object sender, EventArgs e, TextBox textBox)
        {
            long number;
            if (!Int64.TryParse(textBox.Text, out number))
            {
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }
        private void only_number_KeyDown(object sender, KeyEventArgs e, TextBox textBox)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText();
                long number;
                if (!Int64.TryParse(textBox.Text, out number))
                {
                    textBox.Paste(clipboardText);
                }
                e.SuppressKeyPress = true;
            }
        }
        private void only_number_contextMenustripChanged(object sender, EventArgs e, TextBox textBox)
        {
            ContextMenuStrip menu = textBox.ContextMenuStrip;
            if (menu != null)
            {
                foreach (ToolStripItem item in menu.Items)
                {
                    if (item.Text == "Paste")
                    {
                        item.Enabled = false;
                    }
                }
            }
        }

        // 0
        private void textBox_customerTaxId_TextChanged(object sender, EventArgs e)
        {
            only_number_TextChanged(sender, e, textBox_customerTaxId);
        }
        private void textBox_customerTaxId_KeyDown(object sender, KeyEventArgs e)
        {
            only_number_KeyDown(sender, e, textBox_customerTaxId);
        }
        private void textBox_customerTaxId_ContextMenuStripChanged(object sender, EventArgs e)
        {
            only_number_contextMenustripChanged(sender, e, textBox_customerTaxId);
        }
        private void textBox_customerTel_TextChanged(object sender, EventArgs e)
        {
            only_number_TextChanged(sender, e, textBox_customerTel);
        }
        private void textBox_customerTel_KeyDown(object sender, KeyEventArgs e)
        {
            only_number_KeyDown(sender, e, textBox_customerTel);
        }
        private void textBox_customerTel_ContextMenuStripChanged(object sender, EventArgs e)
        {
            only_number_contextMenustripChanged(sender, e, textBox_customerTel);
        }
        private void textBox_customerPostCode_TextChanged(object sender, EventArgs e)
        {
            only_number_TextChanged(sender, e, textBox_customerPostCode);
        }
        private void textBox_customerPostCode_KeyDown(object sender, KeyEventArgs e)
        {
            only_number_KeyDown(sender, e, textBox_customerPostCode);
        }
        private void textBox_customerPostCode_ContextMenuStripChanged(object sender, EventArgs e)
        {
            only_number_contextMenustripChanged(sender, e, textBox_customerPostCode);
        }


        // 1
        private void comboBox_cWeb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_cWeb_1.SelectedIndex == 0)
            {
                // สาขาที่
                textBox_customerWeb_1.Text = "";
                textBox_customerWeb_1.ReadOnly = false;
            }
            else
            {
                // สำนักงานใหญ่
                textBox_customerWeb_1.Text = "00000";
                textBox_customerWeb_1.ReadOnly = true;
            }
        }
        private void textBox_customerTaxId_1_TextChanged(object sender, EventArgs e)
        {
            only_number_TextChanged(sender, e, textBox_customerTaxId_1);
        }
        private void textBox_customerTaxId_1_KeyDown(object sender, KeyEventArgs e)
        {
            only_number_KeyDown(sender, e, textBox_customerTaxId_1);
        }
        private void textBox_customerTaxId_1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            only_number_contextMenustripChanged(sender, e, textBox_customerTaxId_1);
        }
        private void textBox_customerTel_1_TextChanged(object sender, EventArgs e)
        {
            only_number_TextChanged(sender, e, textBox_customerTel_1);
        }
        private void textBox_customerTel_1_KeyDown(object sender, KeyEventArgs e)
        {
            only_number_KeyDown(sender, e, textBox_customerTel_1);
        }
        private void textBox_customerTel_1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            only_number_contextMenustripChanged(sender, e, textBox_customerTel_1);
        }
        private void textBox_customerPostCode_1_TextChanged(object sender, EventArgs e)
        {
            only_number_TextChanged(sender, e, textBox_customerPostCode_1);
        }
        private void textBox_customerPostCode_1_KeyDown(object sender, KeyEventArgs e)
        {
            only_number_KeyDown(sender, e, textBox_customerPostCode_1);
        }
        private void textBox_customerPostCode_1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            only_number_contextMenustripChanged(sender, e, textBox_customerPostCode_1);
        }

        // 2
        private void textBox_customerTel_2_TextChanged(object sender, EventArgs e)
        {
            only_number_TextChanged(sender, e, textBox_customerTel_2);
        }
        private void textBox_customerTel_2_KeyDown(object sender, KeyEventArgs e)
        {
            only_number_KeyDown(sender, e, textBox_customerTel_2);
        }
        private void textBox_customerTel_2_ContextMenuStripChanged(object sender, EventArgs e)
        {
            only_number_contextMenustripChanged(sender, e, textBox_customerTel_2);
        }
        private void textBox_customerPostCode_2_TextChanged(object sender, EventArgs e)
        {
            only_number_TextChanged(sender, e, textBox_customerPostCode_2);
        }
        private void textBox_customerPostCode_2_KeyDown(object sender, KeyEventArgs e)
        {
            only_number_KeyDown(sender, e, textBox_customerPostCode_2);
        }
        private void textBox_customerPostCode_2_ContextMenuStripChanged(object sender, EventArgs e)
        {
            only_number_contextMenustripChanged(sender, e, textBox_customerPostCode_2);
        }

        private void email_text_TextChanged(object sender, EventArgs e, TextBox textBox)
        {
            if (!IsValidEmailFormat(textBox.Text))
            {
                int index = textBox.SelectionStart - 1;
                textBox.Text = textBox.Text.Remove(index, 1);
                textBox.SelectionStart = index;
            }
        }
        private bool IsValidEmailFormat(string text)
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";
            foreach (char c in text)
            {
                if (!allowedChars.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void textBox_customerEmail_TextChanged(object sender, EventArgs e)
        {
            email_text_TextChanged(sender, e, textBox_customerEmail);
        }
        private void textBox_customerEmail_1_TextChanged(object sender, EventArgs e)
        {
            email_text_TextChanged(sender, e, textBox_customerEmail_1);
        }
        private void textBox_customerEmail_2_TextChanged(object sender, EventArgs e)
        {
            email_text_TextChanged(sender, e, textBox_customerEmail_2);
        }

        private void comboBox_CNReason_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_CNReason.SelectedValue != null)
            {
                ReasonCN current = (ReasonCN)comboBox_CNReason.SelectedValue;
                CurrentReasonCN = current;
                textBox_CNReason_Other.ReadOnly = (current.FTRsnCNCode != otherCNreasoncode);
            }
        }

        private void tabCustomerDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
