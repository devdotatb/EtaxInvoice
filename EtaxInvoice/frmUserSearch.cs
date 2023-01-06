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
    public partial class frmUserSearch : Form
    {
        public List<Customer> Customers { get; set; }
        public string CurrentSelectedColumn { get; set; }
        public Customer CurrentCustomer { get; set; }
        public frmUserSearch()
        {
            Customers = GetCustomers();
            InitializeComponent();
        }

        private void frmUserSearch_Load(object sender, EventArgs e)
        {
            var customers = this.Customers;
            UpdateDataGridView(customers);
        }
        private void UpdateDataGridView(List<Customer> data)
        {
            dataGridView1.DataSource = data;
            //dataGridView1.Columns["PersonId"].Visible = false;
            //dataGridView1.Columns["Name"].HeaderText = "ชื่อลูกค้า";
        }

        private List<Customer> GetCustomers()
        {
            string connstr = @"Data Source=.\sqlexpress;Initial Catalog=SFMPOSS;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"Select a.FTCtyCode, a.FTCstName, a.FTCstTaxNo, a.FTCstWeb , a.FTCstAddrInv, a.FTCstStreetInv, a.FTCsttrictInv, a.FTDstCodeInv, a.FTPvnCodeInv , a.FTCstPostCodeInv, a.FTCstSize , a.FTCstTelInv, a.FTCstFaxInv, a.FTCstEmail, e.FTCYDescTh, d.FTPvnName, c.FTDstName 
from TCNMCst a 
left outer join TCNMCstType b on a. FTCtyCode = b. FTCtyCode 
left outer join TCNMDistrict c on a. FTDstCodeInv = c. FTDstCode
left outer join TCNMProvince d on a. FTPvnCodeInv = d. FTPvnCode
left outer join TCNMCountry e on a. FTCstSize = e. FTCYCode");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Customer>();
            while (reader.Read())
            {
                var cus = new Customer
                {
                    FTCtyCode = SQLHelper.SafeGetString(reader,0),
                    FTCstName = SQLHelper.SafeGetString(reader,1),
                    FTCstTaxNo = SQLHelper.SafeGetString(reader,2),
                    FTCstWeb = SQLHelper.SafeGetString(reader,3),
                    FTCstAddrInv = SQLHelper.SafeGetString(reader,4),
                    FTCstStreetInv = SQLHelper.SafeGetString(reader,5),
                    FTCsttrictInv = SQLHelper.SafeGetString(reader,6),
                    FTDstCodeInv = SQLHelper.SafeGetString(reader,7),
                    FTPvnCodeInv = SQLHelper.SafeGetString(reader,8),
                    FTCstPostCodeInv = SQLHelper.SafeGetString(reader,9),
                    FTCstSize = SQLHelper.SafeGetString(reader,10),
                    FTCstTelInv = SQLHelper.SafeGetString(reader,11),
                    FTCstFaxInv = SQLHelper.SafeGetString(reader,12),
                    FTCstEmail = SQLHelper.SafeGetString(reader, 13),
                    FTCYDescTh = SQLHelper.SafeGetString(reader, 14),
                    FTPvnName = SQLHelper.SafeGetString(reader, 15),
                    FTDstName = SQLHelper.SafeGetString(reader, 16),
                };
                result.Add(cus);
            }
            return result;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Customer;

                label2.Text = senderGrid.Columns[e.ColumnIndex].HeaderText;

                textBox_search.Text = dataGridView1.SelectedCells[0].Value.ToString();

                this.CurrentSelectedColumn = senderGrid.Columns[e.ColumnIndex].Name;

                this.CurrentCustomer = selectedRow;

            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            var cus = this.Customers;
            switch (CurrentSelectedColumn)
            {
                case "FTCstName":
                    cus = cus.Where(t => t.FTCstName == textBox_search.Text).ToList();
                    break;
                default:break;
            }
            UpdateDataGridView(cus);
        }
    }
}
