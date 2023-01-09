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
    public partial class frmEmailConfirm : Form
    {
        public string Email { get; set; }
        public frmEmailConfirm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email = textBox_email.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmEmailConfirm_Load(object sender, EventArgs e)
        {
            textBox_email.Text = Email;
        }
    }
}
