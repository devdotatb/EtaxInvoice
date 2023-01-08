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
    public partial class frmInvoiceTodayABB : Form
    {
        public string POSnumber { get; set; }
        public frmInvoiceTodayABB()
        {
            InitializeComponent();
        }
        private void frmInvoiceTodayABB_Load(object sender, EventArgs e)
        {
            LoadPOSComboBox();
            comboBox1.SelectedIndex = 0;
        }
        public void LoadPOSComboBox()
        {
            string connstr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select FTPosCode from TPSMPos where FTPosRorW=1");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<string>();
            while (reader.Read())
            {
                comboBox1.Items.Add(SQLHelper.SafeGetString(reader, 0));
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            this.POSnumber = comboBox1.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
