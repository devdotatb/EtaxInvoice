using EtaxInvoice.Common;
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

namespace EtaxInvoice
{
    public partial class frmMain : Form
    {
        private CustomerTypeDefault customerTypeDefault { get; set; } = new CustomerTypeDefault();
        private Customer CurrentCustomer { get; set; }
        private Invoice CurrentInvoice { get; set; }
        private Country CurrentCountry { get; set; }
        public List<InvoiceDetail> CurrentInvoiceDetailList { get; set; }
        public List<Country> CountryList { get; set; }
        private InvoicePayment CurrentInvoicePayment { get; set; }
        public frmMain()
        {
            InitializeComponent();
            LoadCountry();
        }

        private void LoadCountry()
        {
            string connstr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
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
            comboBox_cWeb_1.SelectedIndex = 0;
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
                                this.textBox_customerCode.Text = cus.FTCstCode;
                                this.textBox_customerName.Text = cus.FTCstName;
                                this.textBox_customerTaxId.Text = cus.FTCstTaxNo;
                                this.textBox_customerWeb.Text = cus.FTCstWeb;
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
                                //this.textBox_customerWeb_2.Text = cus.FTCstWeb;
                                this.textBox_customerEmail_2.Text = cus.FTCstEmail;
                                this.textBox_customerTel_2.Text = cus.FTCstTelInv;
                                //this.textBox_customerFax_2.Text = cus.FTCstFaxInv;

                                this.textBox_customerAddress_2.Text = cus.FTCstAddrInv;
                                //this.textBox_customerRoad_2.Text = cus.FTCstStreetInv;
                                //this.textBox_customerSubDistrict_2.Text = cus.FTCsttrictInv;
                                //this.textBox_customerDistrictCode_2.Text = cus.FTDstCodeInv;
                                //this.textBox_customerDistrictName_2.Text = cus.FTDstName;
                                //this.textBox_customerProvinceCode_2.Text = cus.FTPvnCodeInv;
                                this.textBox_customerProvinceName_2.Text = cus.FTPvnName;
                                this.textBox_customerPostCode_2.Text = cus.FTCstPostCodeInv;
                                this.textBox_customerCountry_2.Text = cnty.FTCYDescTh;
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
        private void OpenfrmInvoiceCheckDate()
        {
            try
            {
                frmInvoiceCheckDate frm = new frmInvoiceCheckDate();
                var result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    if (frm.isToday)
                    {
                        OpenfrmInvoiceTodayABB();
                    }
                    else
                    {
                        OpenfrmInvoice(false, null);
                    }
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
                frm.isToday = isToday;
                frm.POSnumber = POSno;
                var result = frm.ShowDialog(this);
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
                var result = frm.ShowDialog(this);
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
                var result = frm.ShowDialog(this);
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
                var result = frm.ShowDialog(this);
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
            /*dataGridView1.Columns["FTCstCode"].HeaderText = "รหัสลูกค้า";
            dataGridView1.Columns["FTCstName"].HeaderText = "ชื่อลูกค้า";
            dataGridView1.Columns["FTCstTaxNo"].HeaderText = "หมายเลขประจำตัวผู้เสียภาษี";
            dataGridView1.Columns["FTCstWeb"].Visible = false;
            dataGridView1.Columns["FTCstAddrInv"].HeaderText = "ที่อยู่";
            dataGridView1.Columns["FTCstStreetInv"].HeaderText = "ถนน";
            dataGridView1.Columns["FTCsttrictInv"].HeaderText = "ตำบล/แขวง";
            dataGridView1.Columns["FTDstCodeInv"].HeaderText = "รหัสอำเภอ";
            dataGridView1.Columns["FTPvnCodeInv"].HeaderText = "รหัสจังหวัด";
            dataGridView1.Columns["FTCstPostCodeInv"].HeaderText = "รหัสไปรษณีย์";
            dataGridView1.Columns["FTCstSize"].Visible = false;
            dataGridView1.Columns["FTCstTelInv"].HeaderText = "เบอร์โทรศัพท์";
            dataGridView1.Columns["FTCstFaxInv"].HeaderText = "เบอร์โทรสาร";
            dataGridView1.Columns["FTCstEmail"].HeaderText = "Email";
            dataGridView1.Columns["FTCYDescTh"].Visible = false;
            dataGridView1.Columns["FTPvnName"].HeaderText = "จังหวัด";
            dataGridView1.Columns["FTDstName"].HeaderText = "อำเภอ";*/
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            string branch = "00000";
            string generatedcstcode = "CST" + branch + "-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            switch (tabCustomerDetail.SelectedIndex)
            {

                case 0:
                    {
                        this.textBox_customerCode.Text = generatedcstcode;
                        this.textBox_customerName.Text = "";
                        this.textBox_customerTaxId.Text = "";
                        this.textBox_customerWeb.Text = "";
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
                        this.textBox_customerCode_1.Text = generatedcstcode;
                        this.textBox_customerName_1.Text = "";
                        this.textBox_customerTaxId_1.Text = "";
                        this.textBox_customerWeb_1.Text = "";
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

                        break;
                    }

                case 2:
                    {
                        this.textBox_customerCode_2.Text = generatedcstcode;
                        this.textBox_customerName_2.Text = "";
                        this.textBox_customerTaxId_2.Text = "";
                        //this.textBox_customerWeb_2.Text = "";
                        this.textBox_customerEmail_2.Text = "";
                        this.textBox_customerTel_2.Text = "";
                        //this.textBox_customerFax_2.Text = "";

                        this.textBox_customerAddress_2.Text = "";
                        //this.textBox_customerRoad_2.Text = "";
                        //this.textBox_customerSubDistrict_2.Text = "";
                        //this.textBox_customerDistrictCode_2.Text = "";
                        //this.textBox_customerDistrictName_2.Text = "";
                        //this.textBox_customerProvinceCode_2.Text = "";
                        this.textBox_customerProvinceName_2.Text = "";
                        this.textBox_customerPostCode_2.Text = "";
                        this.textBox_customerCountry_2.Text = "";

                        break;
                    }
            }
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
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
                        customerWeb = textBox_customerWeb.Text;
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
            if (string.IsNullOrEmpty(customerName))
            {
                errorstring += "ชื่อ,";
            }

            if (errorstring != tmperror)
            {
                MessageHelper.ShowError(errorstring.Remove(errorstring.Length - 1));
                return;
            }

            string connstr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
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

        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            OpenfrmUser();
        }

        private void button_InvoiceSearch_Click(object sender, EventArgs e)
        {
            OpenfrmInvoiceCheckDate();
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
        private void button_DistrictSearch_Click(object sender, EventArgs e)
        {
            OpenfrmDistrict();
        }

        private void button_DistrictSearch_1_Click(object sender, EventArgs e)
        {
            OpenfrmDistrict();
        }

        private void button_provinceSearch_1_Click(object sender, EventArgs e)
        {
            OpenfrmProvince();
        }

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

        private void button_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
