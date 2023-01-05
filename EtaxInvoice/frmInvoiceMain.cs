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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenfrmUser();
        }

        private void button_InvoiceSearch_Click(object sender, EventArgs e)
        {
            OpenfrmInvoice();
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
    }
}
