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
    public partial class frmInvoiceSearch : Form
    {
        public List<Invoice> Invoices { get; set; }
        public frmInvoiceSearch()
        {
            Invoices = GetInvoices();
            InitializeComponent();
        }
        private void frmInvoiceSearch_Load(object sender, EventArgs e)
        {
            var invs = this.Invoices;
            UpdateDataGridView(invs);
        }
        private void UpdateDataGridView(List<Invoice> data)
        {
            dataGridView1.DataSource = data;
            dataGridView1.Columns["Code"].HeaderText = "รหัส";
            dataGridView1.Columns["Date"].HeaderText = "วันที่เอกสาร";
            //dataGridView1.Columns["PersonId"].Visible = false;
            //dataGridView1.Columns["Name"].HeaderText = "ชื่อลูกค้า";
        }
        private List<Invoice> GetInvoices()
        {
            var list = new List<Invoice>();
            list.Add(new Invoice()
            {
                Code = "0000000000000000",
                Date = new DateTimeOffset().ToString(),
            });
            list.Add(new Invoice()
            {
                Code = "0001111111111000",
                Date = new DateTimeOffset().ToString(),
            });
            return list;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Invoice;

                label2.Text = senderGrid.Columns[e.ColumnIndex].HeaderText;

                textBox_search.Text = dataGridView1.SelectedCells[0].Value.ToString();

                this.CurrentSelectedColumn = senderGrid.Columns[e.ColumnIndex].Name;

                this.CurrentInvoice = selectedRow;

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


        private void button_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
