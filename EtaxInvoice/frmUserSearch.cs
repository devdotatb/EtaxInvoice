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
            SetDefaultData();
        }
        private void SetDefaultData()
        {
            CurrentSelectedColumn = "FTCstName";
            label2.Text = "ชื่อลูกค้า";
        }
        private void UpdateDataGridView(List<Customer> data)
        {
            dataGridView1.DataSource = data;
            dataGridView1.Columns["FTCstCode"].HeaderText = "รหัสลูกค้า";
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
            dataGridView1.Columns["FTDstName"].HeaderText = "อำเภอ";
        }

        private List<Customer> GetCustomers()
        {
            string connstr = @"Data Source=.\sqlexpress;Initial Catalog=SFMPOSS;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"Select a.FTCstCode, a.FTCstName, a.FTCstTaxNo, a.FTCstWeb , a.FTCstAddrInv, a.FTCstStreetInv, a.FTCsttrictInv, a.FTDstCodeInv, a.FTPvnCodeInv , a.FTCstPostCodeInv, a.FTCstSize , a.FTCstTelInv, a.FTCstFaxInv, a.FTCstEmail, e.FTCYDescTh, d.FTPvnName, c.FTDstName 
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
                    FTCstCode = SQLHelper.SafeGetString(reader,0),
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

        private bool dataGrid_clicked_operation(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1)
                {
                    return false;
                }
                var senderGrid = (DataGridView)sender;
                label2.Text = senderGrid.Columns[e.ColumnIndex].HeaderText;
                this.CurrentSelectedColumn = senderGrid.Columns[e.ColumnIndex].Name;

                if (dataGridView1.SelectedCells[0].RowIndex == 0)
                {
                    return false;
                }


                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Customer;

                this.CurrentCustomer = selectedRow;

                return true;

            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
                return false;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid_clicked_operation(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var result = dataGrid_clicked_operation(sender, e);
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            var cus = this.Customers;
            switch (CurrentSelectedColumn)
            {
                case "FTCstCode":
                    cus = cus.Where(t => t.FTCstCode.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstName":
                    cus = cus.Where(t => t.FTCstName.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstTaxNo":
                    cus = cus.Where(t => t.FTCstTaxNo.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstWeb":
                    cus = cus.Where(t => t.FTCstWeb.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstAddrInv":
                    cus = cus.Where(t => t.FTCstAddrInv.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstStreetInv":
                    cus = cus.Where(t => t.FTCstStreetInv.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCsttrictInv":
                    cus = cus.Where(t => t.FTCsttrictInv.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTDstCodeInv":
                    cus = cus.Where(t => t.FTDstCodeInv.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTPvnCodeInv":
                    cus = cus.Where(t => t.FTPvnCodeInv.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstPostCodeInv":
                    cus = cus.Where(t => t.FTCstPostCodeInv.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstSize":
                    cus = cus.Where(t => t.FTCstSize.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstTelInv":
                    cus = cus.Where(t => t.FTCstTelInv.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstFaxInv":
                    cus = cus.Where(t => t.FTCstFaxInv.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCstEmail":
                    cus = cus.Where(t => t.FTCstEmail.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCYDescTh":
                    cus = cus.Where(t => t.FTCYDescTh.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTPvnName":
                    cus = cus.Where(t => t.FTPvnName.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTDstName":
                    cus = cus.Where(t => t.FTDstName.Contains(textBox_search.Text)).ToList();
                    break;
                default: break;
            }
            UpdateDataGridView(cus);
        }
    }
}
