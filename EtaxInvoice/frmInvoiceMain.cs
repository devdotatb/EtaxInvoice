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
    public partial class frmInvoiceMain : Form
    {
        public frmInvoiceMain()
        {
            InitializeComponent();
        }

        private void frmInvoiceMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenfrmUser();
        }

        private void button_InvoiceSearch_Click(object sender, EventArgs e)
        {
            OpenfrmInvoice();
        }
        private void button_provinceSearch_Click(object sender, EventArgs e)
        {
            OpenfrmProvince();
        }
        private void button_DistrictSearch_Click(object sender, EventArgs e)
        {
            OpenfrmDistrict();
        }

        private void tabCustomerDetail_Click(object sender, EventArgs e)
        {
            //this.textBox4.Text = tabCustomerDetail.SelectedIndex.ToString();
            switch (tabCustomerDetail.SelectedIndex)
            {

                case 0:
                    {
                        //Your Changes
                        break;
                    }
                case 1:
                    {
                        //Your Changes 
                        break;
                    }

                case 2:
                    {
                        //Your Changes 
                        break;
                    }
            }
        }
        private void OpenfrmUser()
        {
            try
            {
                frmUserSearch frm = new frmUserSearch();
                var result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    Customer cus = frm.CurrentCustomer;
                    //Do something here with these values

                    //for example
                    //this.textBox_userid.Text = val;
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
                    //this.textBox_customerCountry.Text = cus.FTCstName;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
        private void OpenfrmInvoice()
        {
            try
            {
                frmInvoiceSearch frm = new frmInvoiceSearch();
                var result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
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
                    this.textBox_customerProvinceCode.Text = cus.FTPvnCode;
                    this.textBox_customerProvinceName.Text = cus.FTPvnName;
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
                    this.textBox_customerDistrictCode.Text = cus.FTDstCode;
                    this.textBox_customerDistrictName.Text = cus.FTDstName;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            this.textBox_customerCode.Text = "test";
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
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            string customerCode = textBox_customerCode.Text;
            string customerName = textBox_customerName.Text;
            string customerTaxId = textBox_customerTaxId.Text;
            string customerAddress = textBox_customerAddress.Text;
            string customerRoad = textBox_customerRoad.Text;
            string customerSubDistrict = textBox_customerSubDistrict.Text;
            string customerDistrictCode = textBox_customerDistrictCode.Text;
            string customerProvinceCode = textBox_customerProvinceCode.Text;
            string customerPostCode = textBox_customerPostCode.Text;
            string customerTel = textBox_customerTel.Text;
            string customerFax = textBox_customerFax.Text;
            string customerEmail = textBox_customerEmail.Text;
            switch (tabCustomerDetail.SelectedIndex)
            {
                case 0:
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

                        break;
                    }
                case 1:
                    {
                        //Your Changes 
                        break;
                    }

                case 2:
                    {
                        //Your Changes 
                        break;
                    }
            }

            string connstr = @"Data Source=.\sqlexpress;Initial Catalog=SFMPOSS;Integrated Security=True;";
            string insertformat = @"
                            IF NOT EXISTS (SELECT * FROM TCNMCst WHERE FTCstCode = @customerCode)
                            BEGIN
                                INSERT INTO TCNMCst (FTCstCode, FTCstName, FTCstTaxNo, FTCstAddrInv, FTCstStreetInv, FTCsttrictInv, FTDstCodeInv, FTPvnCodeInv, FTCstPostCodeInv, FTCstTelInv, FTCstFaxInv, FTCstEmail)
                                VALUES (@customerCode, @customerName, @customerTaxId, @customerAddress, @customerRoad, @customerSubDistrict, @customerDistrictCode, @customerProvinceCode, @customerPostCode, @customerTel, @customerFax, @customerEmail)
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
                                    FTCstEmail = @customerEmail
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

            cmd.ExecuteNonQuery();
            connection.Close();
            MessageHelper.ShowInfo("บันทึกสำเร็จ");
        }
    }
}
