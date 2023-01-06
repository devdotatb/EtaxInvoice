using EtaxInvoice.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    this.textBox_customerName.Text = cus.FTCstName;
                    this.textBox_customerTaxId.Text = cus.FTCstTaxNo;
                    this.textBox_customerName.Text = cus.FTCstName;
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
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
    }
}
