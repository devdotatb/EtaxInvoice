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
    public partial class frmInvoiceCheckDate : Form
    {
        public bool isToday { get; set; }
        public frmInvoiceCheckDate()
        {
            InitializeComponent();
        }

        private void button_today_Click(object sender, EventArgs e)
        {
            this.isToday = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_otherday_Click(object sender, EventArgs e)
        {
            this.isToday = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
