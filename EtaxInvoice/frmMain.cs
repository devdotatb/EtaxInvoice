
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
using Newtonsoft.Json;
using System.Net.Http.Headers;

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
        private CustomerTypeDefault customerTypeDefault { get; set; } = new CustomerTypeDefault();
        private Customer CurrentCustomer { get; set; }
        private Invoice CurrentInvoice { get; set; }
        private Country CurrentCountry { get; set; } = new Country();
        public List<InvoiceDetail> CurrentInvoiceDetailList { get; set; }
        public List<Country> CountryList { get; set; }
        private InvoicePayment CurrentInvoicePayment { get; set; }
        public string APIEmail { get; set; }
        public frmMain()
        {
            InitializeComponent();
            LoadCountry();
            LoadConfig();
        }
        private void LoadConfig()
        {
            LoaduserLoc();
            LoadETAX_Invoice_EndPoint();
            LoadETAX_CN_EndPoint();
            LoadAPI_Key();
            LoadClient_ID();
            LoadClient_Secret();
            LoaduserBu();
            LoadOAuth_URL();
            LoadWeb_Service_Timeout();
        }
        private void LoaduserLoc()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select top 1 FTBchCode from TCNMComp");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userLoc = SQLHelper.SafeGetString(reader, 0);
            }
        }
        private void LoadETAX_Invoice_EndPoint()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT FTSysUsrValue FROM TSysConfig WHERE FTSysCode = 'ETAX' AND FTSysSeq = '001'");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ETAX_Invoice_EndPoint = SQLHelper.SafeGetString(reader, 0);
            }
        }
        private void LoadETAX_CN_EndPoint()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT FTSysUsrValue FROM TSysConfig WHERE FTSysCode = 'ETAX' AND FTSysSeq = '002'");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ETAX_CN_EndPoint = SQLHelper.SafeGetString(reader, 0);
            }
        }
        private void LoadAPI_Key()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT FTSysUsrValue FROM TSysConfig WHERE FTSysCode = 'ETAX' AND FTSysSeq = '003'");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                API_Key = SQLHelper.SafeGetString(reader, 0);
            }
        }
        private void LoadClient_ID()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT FTSysUsrValue FROM TSysConfig WHERE FTSysCode = 'ETAX' AND FTSysSeq = '004'");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Client_ID = SQLHelper.SafeGetString(reader, 0);
            }
        }
        private void LoadClient_Secret()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT FTSysUsrValue FROM TSysConfig WHERE FTSysCode = 'ETAX' AND FTSysSeq = '005'");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Client_Secret = SQLHelper.SafeGetString(reader, 0);
            }
        }
        private void LoaduserBu()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select FTSysUsrValue from TSysConfig where FTSysCode = 'ETAX' and FTSysSeq = '006'");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userBu = SQLHelper.SafeGetString(reader, 0);
            }
        }
        private void LoadOAuth_URL()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT FTSysUsrValue FROM TSysConfig WHERE FTSysCode = 'ETAX' AND FTSysSeq = '007'");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OAuth_URL = SQLHelper.SafeGetString(reader, 0);
            }
        }
        private void LoadWeb_Service_Timeout()
        {

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT FTSysUsrValue FROM TSysConfig WHERE FTSysCode = 'ETAX' AND FTSysSeq = '008'");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Web_Service_Timeout = SQLHelper.SafeGetString(reader, 0);
            }
        }

        private void LoadCountry()
        {
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select FTCYCode,FTCYDescTh,FTCYDescEn from TCNMCountry");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Country>();
            while (reader.Read())
            {
                var prov = new Country
                {
                    FTCYCode = SQLHelper.SafeGetString(reader, 0),
                    FTCYDescTh = SQLHelper.SafeGetString(reader, 1),
                    FTCYDescEn = SQLHelper.SafeGetString(reader, 1),
                };
                result.Add(prov);
            }
            CountryList = result;
        }
        private void frmInvoiceMain_Load(object sender, EventArgs e)
        {
            comboBox_cWeb_1.SelectedIndex = 1;
        }
        private void tabCustomerDetail_Click(object sender, EventArgs e)
        {
            switch (tabCustomerDetail.SelectedIndex)
            {

                case 0:
                    {

                        break;
                    }
                case 1:
                    {

                        break;
                    }

                case 2:
                    {

                        break;
                    }
            }
        }
        private void OpenfrmUser()
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
                    this.CurrentCountry = cnty;

                    switch (tabCustomerDetail.SelectedIndex)
                    {
                        case 0:
                            {
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


                    textBox_invoiceDocNo.Text = inv.FTShdDocNo;
                    textBox_invoiceBranchCode.Text = inv.FTBchCode;
                    textBox_invoiceDate.Text = inv.FDDateIns;

                    numericUpDown_sumNet.Value = (decimal)this.CurrentInvoice.FCShdTotal;
                    numericUpDown_sumDiscount.Value = (decimal)this.CurrentInvoice.FCShdDis;
                    numericUpDown_NetAfter.Value = (decimal)this.CurrentInvoice.FCShdAftDisChg;
                    numericUpDown_sumVat.Value = (decimal)this.CurrentInvoice.FCShdVat;
                    numericUpDown_Total.Value = (decimal)this.CurrentInvoice.FCShdB4DisChg;

                    numericUpDown_VAT.Value = (decimal)this.CurrentInvoice.FCShdVatRate;

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
                    this.CurrentCountry = cus;

                    switch (tabCustomerDetail.SelectedIndex)
                    {

                        case 0:
                            {
                                this.textBox_customerCountry.Text = cus.FTCYDescTh;

                                break;
                            }
                        case 1:
                            {
                                this.textBox_customerCountry_1.Text = cus.FTCYDescTh;

                                break;
                            }

                        case 2:
                            {
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


            string customerCode = "";
            string customerName = "";
            string customerTaxId = "";
            string customerAddress = "";
            string customerRoad = "";
            string customerSubDistrict = "";
            string customerDistrictCode = "";
            string customerProvinceCode = "";
            string customerPostCode = "";
            string customerTel = "";
            string customerFax = "";
            string customerEmail = "";
            string customerWeb = "";
            string countrycode = "";
            string customerType = "";

            string errorstring = "กรุณากรอก : ";
            string tmperror = errorstring;
            switch (tabCustomerDetail.SelectedIndex)
            {
                case 0: // บุคคลธรรมดา
                    {
                        customerCode = textBox_customerCode.Text;
                        customerName = textBox_customerName.Text;
                        customerTaxId = textBox_customerTaxId.Text;
                        customerAddress = textBox_customerAddress.Text;
                        customerRoad = textBox_customerRoad.Text;
                        customerSubDistrict = textBox_customerSubDistrict.Text;
                        customerDistrictCode = textBox_customerDistrictCode.Text;
                        customerProvinceCode = textBox_customerProvinceCode.Text;
                        customerPostCode = textBox_customerPostCode.Text;
                        customerTel = textBox_customerTel.Text;
                        customerFax = textBox_customerFax.Text;
                        customerEmail = textBox_customerEmail.Text;
                        customerWeb = "";
                        countrycode = CurrentCountry.FTCYCode;
                        customerType = customerTypeDefault.NIDN;

                        break;
                    }
                case 1:// นิติบุคคล
                    {
                        customerCode = textBox_customerCode_1.Text;
                        customerName = textBox_customerName_1.Text;
                        customerTaxId = textBox_customerTaxId_1.Text;
                        customerAddress = textBox_customerAddress_1.Text;
                        customerRoad = textBox_customerRoad_1.Text;
                        customerSubDistrict = textBox_customerSubDistrict_1.Text;
                        customerDistrictCode = textBox_customerDistrictCode_1.Text;
                        customerProvinceCode = textBox_customerProvinceCode_1.Text;
                        customerPostCode = textBox_customerPostCode_1.Text;
                        customerTel = textBox_customerTel_1.Text;
                        customerFax = textBox_customerFax_1.Text;
                        customerEmail = textBox_customerEmail_1.Text;
                        customerWeb = textBox_customerWeb_1.Text;
                        countrycode = CurrentCountry.FTCYCode;
                        customerType = customerTypeDefault.TXID;

                        break;
                    }

                case 2:// ชาวต่างชาติ
                    {
                        customerCode = textBox_customerCode_2.Text;
                        customerName = textBox_customerName_2.Text;
                        customerTaxId = textBox_customerTaxId_2.Text;
                        customerAddress = textBox_customerAddress_2.Text + "|" + textBox_customerProvinceName_2.Text;
                        customerPostCode = textBox_customerPostCode_2.Text;
                        customerTel = textBox_customerTel_2.Text;
                        customerEmail = textBox_customerEmail_2.Text;
                        countrycode = CurrentCountry.FTCYCode;
                        customerType = customerTypeDefault.CCPT;

                        break;
                    }
            }
            if (customerCode == "")
            {
                // new cst
                customerCode = generatedcstcode;
            }

            if (string.IsNullOrEmpty(customerCode))
            {
                MessageHelper.ShowError("กรุณากด \"เพิ่ม\"");
                return;
            }
            if (string.IsNullOrEmpty(customerName))
            {
                errorstring += "ชื่อ,";
            }
            if (string.IsNullOrEmpty(countrycode))
            {
                errorstring += "ประเทศ,";
            }

            if (errorstring != tmperror)
            {
                MessageHelper.ShowError(errorstring.Remove(errorstring.Length - 1));
                return;
            }

            string connstr = ConfigHelper.ConnectionString;
            string insertformat = @"
                            IF NOT EXISTS (SELECT * FROM TCNMCst WHERE FTCstCode = @customerCode)
                            BEGIN
                                INSERT INTO TCNMCst (FTCstCode, FTCstName, FTCstTaxNo, FTCstAddrInv, FTCstStreetInv, FTCsttrictInv, FTDstCodeInv, FTPvnCodeInv, FTCstPostCodeInv, FTCstTelInv, FTCstFaxInv, FTCstEmail,FTCstWeb,FTCstSize,FTCtyCode)
                                VALUES (@customerCode, @customerName, @customerTaxId, @customerAddress, @customerRoad, @customerSubDistrict, @customerDistrictCode, @customerProvinceCode, @customerPostCode, @customerTel, @customerFax, @customerEmail,@customerWeb,@countrycode,@customerType)
                            END
                            ELSE
                            BEGIN
                                UPDATE TCNMCst
                                SET FTCstName = @customerName,
                                    FTCstTaxNo = @customerTaxId,
                                    FTCstAddrInv = @customerAddress,
                                    FTCstStreetInv = @customerRoad,
                                    FTCsttrictInv = @customerSubDistrict,
                                    FTDstCodeInv = @customerDistrictCode,
                                    FTPvnCodeInv = @customerProvinceCode,
                                    FTCstPostCodeInv = @customerPostCode,
                                    FTCstTelInv = @customerTel,
                                    FTCstFaxInv = @customerFax,
                                    FTCstEmail = @customerEmail,
                                    FTCstWeb = @customerWeb,
                                    FTCstSize = @countrycode,
                                    FTCtyCode = @customerType
                                WHERE FTCstCode = @customerCode
                            END
                        ";

            SqlConnection connection = new SqlConnection(connstr);
            connection.Open();

            SqlCommand cmd = new SqlCommand(insertformat, connection);
            cmd.Parameters.AddWithValue("@customerCode", customerCode);
            cmd.Parameters.AddWithValue("@customerName", customerName);
            cmd.Parameters.AddWithValue("@customerTaxId", customerTaxId);
            cmd.Parameters.AddWithValue("@customerAddress", customerAddress);
            cmd.Parameters.AddWithValue("@customerRoad", customerRoad);
            cmd.Parameters.AddWithValue("@customerSubDistrict", customerSubDistrict);
            cmd.Parameters.AddWithValue("@customerDistrictCode", customerDistrictCode);
            cmd.Parameters.AddWithValue("@customerProvinceCode", customerProvinceCode);
            cmd.Parameters.AddWithValue("@customerPostCode", customerPostCode);
            cmd.Parameters.AddWithValue("@customerTel", customerTel);
            cmd.Parameters.AddWithValue("@customerFax", customerFax);
            cmd.Parameters.AddWithValue("@customerEmail", customerEmail);
            cmd.Parameters.AddWithValue("@customerWeb", customerWeb);
            cmd.Parameters.AddWithValue("@countrycode", countrycode);
            cmd.Parameters.AddWithValue("@customerType", customerType);

            cmd.ExecuteNonQuery();
            connection.Close();
            MessageHelper.ShowInfo("บันทึกสำเร็จ");
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
                        break;
                    }

                case 2:// ชาวต่างชาติ
                    {
                        this.textBox_customerName_2.ReadOnly = false;
                        this.textBox_customerTaxId_2.ReadOnly = false;
                        this.textBox_customerTel_2.ReadOnly = false;
                        this.textBox_customerEmail_2.ReadOnly = false;

                        this.textBox_customerAddress_2.ReadOnly = false;
                        this.textBox_customerPostCode_2.ReadOnly = false;

                        break;
                    }
            }
        }
        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            OpenfrmUser();
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
                string text = "กรุณายืนยันการออก E-TAX Invoice";
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
                            InvoiceAPIData built = BuildAPIdata();
                            Callapi_Invoice(built);
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

        public void ValidateBeforeAPI()
        {
            string customerCode = "";
            string customerName = "";
            string customerTaxId = "";
            string customerAddress = "";
            string customerRoad = "";
            string customerSubDistrict = "";
            string customerDistrictCode = "";
            string customerProvinceCode = "";
            string customerPostCode = "";
            string customerTel = "";
            string customerFax = "";
            string customerEmail = "";
            string customerWeb = "";
            string countrycode = "";
            string customerType = "";

            string errorstring = "กรุณากรอก : ";
            string tmperror = errorstring;
            switch (tabCustomerDetail.SelectedIndex)
            {
                case 0: // บุคคลธรรมดา
                    {
                        customerCode = textBox_customerCode.Text;
                        customerName = textBox_customerName.Text;
                        customerTaxId = textBox_customerTaxId.Text;
                        customerAddress = textBox_customerAddress.Text;
                        customerRoad = textBox_customerRoad.Text;
                        customerSubDistrict = textBox_customerSubDistrict.Text;
                        customerDistrictCode = textBox_customerDistrictCode.Text;
                        customerProvinceCode = textBox_customerProvinceCode.Text;
                        customerPostCode = textBox_customerPostCode.Text;
                        customerTel = textBox_customerTel.Text;
                        customerFax = textBox_customerFax.Text;
                        customerEmail = textBox_customerEmail.Text;
                        customerWeb = "";
                        countrycode = CurrentCountry.FTCYCode;
                        customerType = customerTypeDefault.NIDN;

                        break;
                    }
                case 1:// นิติบุคคล
                    {
                        customerCode = textBox_customerCode_1.Text;
                        customerName = textBox_customerName_1.Text;
                        customerTaxId = textBox_customerTaxId_1.Text;
                        customerAddress = textBox_customerAddress_1.Text;
                        customerRoad = textBox_customerRoad_1.Text;
                        customerSubDistrict = textBox_customerSubDistrict_1.Text;
                        customerDistrictCode = textBox_customerDistrictCode_1.Text;
                        customerProvinceCode = textBox_customerProvinceCode_1.Text;
                        customerPostCode = textBox_customerPostCode_1.Text;
                        customerTel = textBox_customerTel_1.Text;
                        customerFax = textBox_customerFax_1.Text;
                        customerEmail = textBox_customerEmail_1.Text;
                        customerWeb = textBox_customerWeb_1.Text;
                        countrycode = CurrentCountry.FTCYCode;
                        customerType = customerTypeDefault.TXID;

                        break;
                    }

                case 2:// ชาวต่างชาติ
                    {
                        customerCode = textBox_customerCode_2.Text;
                        customerName = textBox_customerName_2.Text;
                        customerTaxId = textBox_customerTaxId_2.Text;
                        customerAddress = textBox_customerAddress_2.Text + "|" + textBox_customerProvinceName_2.Text;
                        customerPostCode = textBox_customerPostCode_2.Text;
                        customerTel = textBox_customerTel_2.Text;
                        customerEmail = textBox_customerEmail_2.Text;
                        countrycode = CurrentCountry.FTCYCode;
                        customerType = customerTypeDefault.CCPT;

                        break;
                    }
            }

            if (string.IsNullOrEmpty(customerCode))
            {
                MessageHelper.ShowError("กรุณากด \"เพิ่ม\"");
                return;
            }
            if (string.IsNullOrEmpty(customerName))
            {
                errorstring += "ชื่อ,";
            }
            if (string.IsNullOrEmpty(countrycode))
            {
                errorstring += "ประเทศ,";
            }

            if (errorstring != tmperror)
            {
                MessageHelper.ShowError(errorstring.Remove(errorstring.Length - 1));
                return;
            }
        }
        public InvoiceAPIData BuildAPIdata()
        {
            var sendingdata = new InvoiceAPIData();

            sendingdata.remark = "";
            sendingdata.isShowBranchNo = true;
            sendingdata.userid = Program.globalStartUserName;
            sendingdata.userBu = "CFR";//userBu;//
            sendingdata.userLoc = "6001";//userLoc;//
            sendingdata.userRole = "Test by ADMIN";

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
                        building_customer.district = textBox_customerDistrictCode.Text;
                        building_customer.province = textBox_customerProvinceCode.Text;
                        building_customer.postcode = textBox_customerPostCode.Text;
                        building_customer.country = CurrentCountry.FTCYDescTh;
                        building_customer.countryCode = CurrentCountry.FTCYCode;
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
                        building_customer.buildingNo = textBox_customerAddress.Text;
                        building_customer.buildingName = "";
                        building_customer.roomNo = "";
                        building_customer.moo = "";
                        building_customer.floor = "";
                        building_customer.soi = "";
                        building_customer.road = textBox_customerRoad_1.Text;
                        building_customer.subDistrict = textBox_customerSubDistrict_1.Text;
                        building_customer.district = textBox_customerDistrictCode_1.Text;
                        building_customer.province = textBox_customerProvinceCode_1.Text;
                        building_customer.postcode = textBox_customerPostCode_1.Text;
                        building_customer.country = CurrentCountry.FTCYDescTh;
                        building_customer.countryCode = CurrentCountry.FTCYCode;
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
                        building_customer.templateLang = "EN";
                        building_customer.addressType = "INTER";
                        building_customer.buildingNo = textBox_customerAddress.Text;
                        building_customer.buildingName = "";
                        building_customer.roomNo = "";
                        building_customer.moo = "";
                        building_customer.floor = "";
                        building_customer.soi = "";
                        building_customer.postcode = textBox_customerPostCode_2.Text;
                        building_customer.country = CurrentCountry.FTCYDescTh;
                        building_customer.countryCode = CurrentCountry.FTCYCode;
                        building_customer.tel = textBox_customerTel_2.Text;
                        building_customer.email = APIEmail;
                        building_customer.addressLine = "";

                        break;
                    }
            }
            sendingdata.customer = building_customer;

            SaleDataAPIData building_saledata = new SaleDataAPIData();
            building_saledata.bu = "CFR";//userBu;//
            building_saledata.total = CurrentInvoiceDetailList.Sum(t => t.FCSdtQty);

            SalesTicketAPIData building_salesTicket = new SalesTicketAPIData();

            List<ProductAPIData> building_products = new List<ProductAPIData>();
            foreach (var invdt in CurrentInvoiceDetailList)
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
            each_payment.saleAmt = CurrentInvoicePayment.FCSrcNet;
            each_payment.paymentDescription = CurrentInvoicePayment.FTRcvName;
            each_payment.paymentMediaNumber = CurrentInvoicePayment.FTSrcRef;
            building_payments.Add(each_payment);
            building_salesTicket.payments = building_payments;

            building_salesTicket.loc = "6001";//userLoc;//
            building_salesTicket.receiptDate = CurrentInvoice.FDDateIns;
            building_salesTicket.ticketNo = CurrentInvoice.FTShdDocNo;
            building_salesTicket.tpNo = CurrentInvoice.FTShdDocNo;
            building_salesTicket.receiptNo = CurrentInvoice.FTShdDocNo;
            building_salesTicket.totalSaleAmt = CurrentInvoice.FCShdTotal;
            building_salesTicket.totalVatSaleAmt = CurrentInvoice.FCShdVat + CurrentInvoice.FCShdVatable;
            building_salesTicket.totalNetSaleAmt = CurrentInvoice.FCShdNonVat + CurrentInvoice.FCShdVatable;
            building_salesTicket.totalVatItemAmt = CurrentInvoice.FCShdVatable;
            building_salesTicket.totalNonVatItemAmt = CurrentInvoice.FCShdNonVat;
            building_salesTicket.transType = "";
            building_salesTicket.template_type = "Sales";
            building_salesTicket.taxValue = CurrentInvoice.FCShdVat;
            building_salesTicket.totalQty = CurrentInvoiceDetailList.Sum(t => t.FCSdtQty);
            building_salesTicket.totalDiscount = CurrentInvoice.FCShdDis;
            building_salesTicket.totalAmtExdiscount = CurrentInvoice.FCShdB4DisChg;
            building_salesTicket.receiptNumber = CurrentInvoice.FTShdDocNo;
            building_salesTicket.barcodeComplete = CurrentInvoice.FTShdDocNo;
            building_salesTicket.remainderAmt = 0;
            building_salesTicket.depositAmt = CurrentInvoice.FCShdGndAE;
            building_salesTicket.orderNo = "";

            building_saledata.salesTicket = building_salesTicket;
            sendingdata.saleData = building_saledata;

            return sendingdata;
        }
        public async void Callapi_Invoice(InvoiceAPIData data)
        {
            string apiUrl = ETAX_Invoice_EndPoint;
            string serviceName = "std-genft-document";

            string jsonString = JsonConvert.SerializeObject(data);

            string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonString));

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer your-api-key");
                client.DefaultRequestHeaders.Add("b2cauthorize", "test");
                client.DefaultRequestHeaders.Add("api-key", API_Key);

                var payload = new StringContent(base64String);

                HttpResponseMessage response = await client.PostAsync(apiUrl, payload);

                string responseContent = await response.Content.ReadAsStringAsync();
                var obj_result = JsonConvert.DeserializeObject<resultAPIData>(responseContent);
                //log response ?
                LogETAX logdata = new LogETAX();
                logdata.FDDateIns = DateTime.Now;
                logdata.FTTimeIns = DateTime.Now.ToString("HHmmss");
                logdata.FTWhoIns = Program.globalStartUserName;
                logdata.FTRemark = "";
                logdata.FTBchCode = Program.globalBranchNumber;
                logdata.FTDeviceID = "Storeback";
                logdata.FTShdDocNo = CurrentInvoice.FTShdDocNo;
                logdata.FDShdDocDate = CurrentInvoice.FDShdDocDate;
                logdata.FTShdDocType = "1";
                logdata.FTReqType = "สร้างใบกำกับภาษี";
                logdata.FNStep = 0;
                logdata.FTServiceName = serviceName;
                logdata.FTReqPara = base64String;
                logdata.FTResPara = responseContent;
                logdata.FTResCode = response.StatusCode.ToString();
                logdata.FTResMsg = obj_result.statusMessage;
                logdata.FTResShwMsg = "";
                SaveLog(logdata);

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
        public void SaveLog(LogETAX logdata)
        {
            LogInserter.InsertLog(logdata);
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
                int number;
                if (int.TryParse(clipboardText, out number))
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
    }
}
