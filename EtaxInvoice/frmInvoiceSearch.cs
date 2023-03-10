
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
    public partial class frmInvoiceSearch : Form
    {
        public bool isToday { get; set; }
        public bool isCN { get; set; }
        public string POSnumber { get; set; }
        public List<Invoice> Invoices { get; set; }
        public string CurrentSelectedColumn { get; set; }
        // INV
        public Invoice CurrentInvoice { get; set; }
        public List<InvoiceDetail> CurrentInvoiceDetailList { get; set; }
        public InvoicePayment CurrentInvoicePayment { get; set; }
        // REF INV
        public Invoice REF_CurrentInvoice { get; set; }
        public List<InvoiceDetail> REF_CurrentInvoiceDetailList { get; set; }
        public InvoicePayment REF_CurrentInvoicePayment { get; set; }
        public frmInvoiceSearch()
        {
            InitializeComponent();
        }
        private void frmInvoiceSearch_Load(object sender, EventArgs e)
        {
            Invoices = GetInvoices();
            var invs = this.Invoices;
            UpdateDataGridView(invs);
            SetDefaultData();
        }
        private void SetDefaultData()
        {
            CurrentSelectedColumn = "FTShdDocNo";
            label2.Text = "รหัส";
        }
        private void UpdateDataGridView(List<Invoice> data)
        {
            this.CurrentInvoice = data.FirstOrDefault();
            dataGridView1.DataSource = data;
            dataGridView1.Columns["FTBchCode"].Visible = false;
            dataGridView1.Columns["FDDateIns"].HeaderText = "วันที่เอกสาร";
            dataGridView1.Columns["FTTimeIns"].Visible = false;
            dataGridView1.Columns["FTShdDocNo"].HeaderText = "รหัส";
            dataGridView1.Columns["FCShdTotal"].Visible = false;
            dataGridView1.Columns["FCShdVat"].Visible = false;
            dataGridView1.Columns["FCShdVatable"].Visible = false;
            dataGridView1.Columns["FCShdNonVat"].Visible = false;
            dataGridView1.Columns["FCShdDis"].Visible = false;
            dataGridView1.Columns["FCShdB4DisChg"].Visible = false;
            dataGridView1.Columns["FCShdGndAE"].Visible = false;
            dataGridView1.Columns["FCShdAftDisChg"].Visible = false;
            dataGridView1.Columns["FCShdVatRate"].Visible = false;
            dataGridView1.Columns["FDShdDocDate"].Visible = false;
            dataGridView1.Columns["FTShdPosCN"].Visible = false;
        }
        private List<Invoice> GetInvoices()
        {
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = "";
            if (isToday)
            {
                // 001 002 003
                sql = string.Format(@"select FTBchCode, FDDateIns, FTTimeIns, FTShdDocNo
, FCShdTotal, FCShdVat, FCShdVatable, FCShdNonVat
, FCShdDis, FCShdB4DisChg, FCShdGndAE , FCShdAftDisChg , FCShdVatRate , FDShdDocDate , FTShdPosCN
from TSHD{0} HD with(nolock)
where isnull(FTShdDocVatFull,'') = '' and FTShdStaDoc = '1' and FTShdDocNo like '{1}%'", this.POSnumber, isCN ? "R" : "S");
            }
            else
            {
                // TPSTSalHD
                sql = string.Format(@"select FTBchCode, FDDateIns, FTTimeIns, FTShdDocNo, 
FCShdTotal, FCShdVat, FCShdVatable, FCShdNonVat, 
FCShdDis, FCShdB4DisChg, FCShdGndAE , FCShdAftDisChg , FCShdVatRate , FDShdDocDate , FTShdPosCN
from TPSTSalHD HD with(nolock)
where isnull(FTShdDocVatFull,'') = ''  and FTShdDocNo like '{0}%'", isCN ? "R" : "S");
            }
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Invoice>();
            while (reader.Read())
            {
                var each_data = new Invoice
                {
                    FTBchCode = SQLHelper.SafeGetString(reader, 0),
                    FDDateIns = SQLHelper.SafeGetDateToString(reader, 1),
                    FTTimeIns = SQLHelper.SafeGetString(reader, 2),
                    FTShdDocNo = SQLHelper.SafeGetString(reader, 3),
                    FCShdTotal = SQLHelper.SafeGetDecimal(reader, 4),
                    FCShdVat = SQLHelper.SafeGetDecimal(reader, 5),
                    FCShdVatable = SQLHelper.SafeGetDecimal(reader, 6),
                    FCShdNonVat = SQLHelper.SafeGetDecimal(reader, 7),
                    FCShdDis = SQLHelper.SafeGetDecimal(reader, 8),
                    FCShdB4DisChg = SQLHelper.SafeGetDecimal(reader, 9),
                    FCShdGndAE = SQLHelper.SafeGetDecimal(reader, 10),
                    FCShdAftDisChg = SQLHelper.SafeGetDecimal(reader, 11),
                    FCShdVatRate = SQLHelper.SafeGetDecimal(reader, 12),
                    FDShdDocDate = SQLHelper.SafeGetDate(reader, 13),
                    FTShdPosCN = SQLHelper.SafeGetString(reader, 14),
                };
                result.Add(each_data);
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
                if (e.RowIndex == -1)
                {
                    return false;
                }
                var senderGrid = (DataGridView)sender;
                label2.Text = senderGrid.Columns[e.ColumnIndex].HeaderText;
                this.CurrentSelectedColumn = senderGrid.Columns[e.ColumnIndex].Name;

                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Invoice;

                this.CurrentInvoice = selectedRow;

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
                seachDetailthenClose();
            }
        }
        private void seachDetailthenClose()
        {
            if (string.IsNullOrEmpty(this.CurrentInvoice.FTShdDocNo))
            {
                MessageHelper.ShowError("No CurrentInvoice.FTShdDocNo");
            }
            saveDetail();
            savePayment();
            if (isCN)
            {
                CN_saveRef_INV();
                CN_saveRef_INVDetail();
                CN_saveRef_INVPayment();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void saveDetail()
        {
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = "";
            if (isToday)
            {
                // 001 002 003
                sql = string.Format(@"select DT.FNSdtSeqNo, DT.FTSdtBarCode, DT.FTPdtName, DT.FTPdtCode, DT.FCSdtQty, DT.FCSdtDis, DT.FCSdtFootAvg, DT.FCSdtNet, DT.FCSdtB4DisChg, DT.FCSdtSetPrice, DT.FCSdtVat, DT.FTSdtVatType 
from TSHD{0} HD with(nolock)
left join TSDT{0} DT with(nolock) on HD.FTShdDocNo = DT.FTShdDocNo
where isnull(HD.FTShdDocVatFull,'') = '' and HD.FTShdStaDoc = '1' and DT.FTShdDocNo = '{1}'", this.POSnumber, this.CurrentInvoice.FTShdDocNo);
            }
            else
            {
                // TPSTSalHD
                sql = string.Format(@"select DT.FNSdtSeqNo, DT.FTSdtBarCode, DT.FTPdtName, DT.FTPdtCode, DT.FCSdtQty, DT.FCSdtDis, DT.FCSdtFootAvg, DT.FCSdtNet, DT.FCSdtB4DisChg, DT.FCSdtSetPrice, DT.FCSdtVat, DT.FTSdtVatType 
from TPSTSalHD HD with(nolock)
left join TPSTSalDT DT with(nolock) on HD.FTShdDocNo = DT.FTShdDocNo
where isnull(HD.FTShdDocVatFull,'') = '' and DT.FTShdDocNo = '{0}'", this.CurrentInvoice.FTShdDocNo);
            }
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<InvoiceDetail>();
            while (reader.Read())
            {
                var each_data = new InvoiceDetail
                {
                    FNSdtSeqNo = SQLHelper.SafeGetDecimal(reader, 0),
                    FTSdtBarCode = SQLHelper.SafeGetString(reader, 1),
                    FTPdtName = SQLHelper.SafeGetString(reader, 2),
                    FTPdtCode = SQLHelper.SafeGetString(reader, 3),
                    FCSdtQty = SQLHelper.SafeGetDecimal(reader, 4),
                    FCSdtDis = SQLHelper.SafeGetDecimal(reader, 5),
                    FCSdtFootAvg = SQLHelper.SafeGetDecimal(reader, 6),
                    FCSdtNet = SQLHelper.SafeGetDecimal(reader, 7),
                    FCSdtB4DisChg = SQLHelper.SafeGetDecimal(reader, 8),
                    FCSdtSetPrice = SQLHelper.SafeGetDecimal(reader, 9),
                    FCSdtVat = SQLHelper.SafeGetDecimal(reader, 10),
                    FTSdtVatType = SQLHelper.SafeGetString(reader, 11),
                };
                result.Add(each_data);
            }
            this.CurrentInvoiceDetailList = result;
        }
        private void savePayment()
        {
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = "";
            if (isToday)
            {
                // 001 002 003
                sql = string.Format(@"select RC.FCSrcNet, RC.FTRcvName, RC.FTSrcRef
from TSHD{0} HD with(nolock)
left join TSRC{0} RC with(nolock) on HD.FTShdDocNo = RC.FTShdDocNo
where isnull(HD.FTShdDocVatFull,'') = '' and HD.FTShdStaDoc = '1' and RC.FTShdDocNo = '{1}'", this.POSnumber, this.CurrentInvoice.FTShdDocNo);
            }
            else
            {
                // TPSTSalHD
                sql = string.Format(@"select RC.FCSrcNet, RC.FTRcvName, RC.FTSrcRef
from TPSTSalHD HD with(nolock)
left join TPSTSalRC RC with(nolock) on HD.FTShdDocNo = RC.FTShdDocNo
where isnull(FTShdDocVatFull,'') = '' and RC.FTShdDocNo = '{0}'", this.CurrentInvoice.FTShdDocNo);
            }
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<InvoicePayment>();
            while (reader.Read())
            {
                var each_data = new InvoicePayment
                {
                    FCSrcNet = SQLHelper.SafeGetDecimal(reader, 0),
                    FTRcvName = SQLHelper.SafeGetString(reader, 1),
                    FTSrcRef = SQLHelper.SafeGetString(reader, 2),
                };
                result.Add(each_data);
            }
            if (result.Any())
            {
                this.CurrentInvoicePayment = result.FirstOrDefault();
            }
        }
        private void CN_saveRef_INV()
        {
            var ref_invoice = CurrentInvoice.FTShdPosCN;
            var ref_POSNumber = CurrentInvoice.FTShdPosCN.Substring(8,3);

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select FTBchCode, FDDateIns, FTTimeIns, FTShdDocNo
, FCShdTotal, FCShdVat, FCShdVatable, FCShdNonVat
, FCShdDis, FCShdB4DisChg, FCShdGndAE , FCShdAftDisChg , FCShdVatRate , FDShdDocDate , FTShdPosCN
from TSHD{0} HD with(nolock)
where isnull(FTShdDocVatFull,'') = '' and FTShdStaDoc = '1' and FTShdDocNo like '{1}'
union all
select FTBchCode, FDDateIns, FTTimeIns, FTShdDocNo, 
FCShdTotal, FCShdVat, FCShdVatable, FCShdNonVat, 
FCShdDis, FCShdB4DisChg, FCShdGndAE , FCShdAftDisChg , FCShdVatRate , FDShdDocDate , FTShdPosCN
from TPSTSalHD HD with(nolock)
where isnull(FTShdDocVatFull,'') = ''  and FTShdDocNo like '{1}'", ref_POSNumber, ref_invoice);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Invoice>();
            while (reader.Read())
            {
                var each_data = new Invoice
                {
                    FTBchCode = SQLHelper.SafeGetString(reader, 0),
                    FDDateIns = SQLHelper.SafeGetDateToString(reader, 1),
                    FTTimeIns = SQLHelper.SafeGetString(reader, 2),
                    FTShdDocNo = SQLHelper.SafeGetString(reader, 3),
                    FCShdTotal = SQLHelper.SafeGetDecimal(reader, 4),
                    FCShdVat = SQLHelper.SafeGetDecimal(reader, 5),
                    FCShdVatable = SQLHelper.SafeGetDecimal(reader, 6),
                    FCShdNonVat = SQLHelper.SafeGetDecimal(reader, 7),
                    FCShdDis = SQLHelper.SafeGetDecimal(reader, 8),
                    FCShdB4DisChg = SQLHelper.SafeGetDecimal(reader, 9),
                    FCShdGndAE = SQLHelper.SafeGetDecimal(reader, 10),
                    FCShdAftDisChg = SQLHelper.SafeGetDecimal(reader, 11),
                    FCShdVatRate = SQLHelper.SafeGetDecimal(reader, 12),
                    FDShdDocDate = SQLHelper.SafeGetDate(reader, 13),
                    FTShdPosCN = SQLHelper.SafeGetString(reader, 14),
                };
                result.Add(each_data);
            }
            if (result.Any())
            {
                this.REF_CurrentInvoice = result.First();
            }
        }
        private void CN_saveRef_INVDetail()
        {
            var ref_invoice = CurrentInvoice.FTShdPosCN;
            var ref_POSNumber = CurrentInvoice.FTShdPosCN.Substring(8, 3);

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select DT.FNSdtSeqNo, DT.FTSdtBarCode, DT.FTPdtName, DT.FTPdtCode, DT.FCSdtQty, DT.FCSdtDis, DT.FCSdtFootAvg, DT.FCSdtNet, DT.FCSdtB4DisChg, DT.FCSdtSetPrice, DT.FCSdtVat, DT.FTSdtVatType 
from TPSTSalHD HD with(nolock)
left join TPSTSalDT DT with(nolock) on HD.FTShdDocNo = DT.FTShdDocNo
where isnull(HD.FTShdDocVatFull,'') = '' and DT.FTShdDocNo = '{1}'

union all 

select DT.FNSdtSeqNo, DT.FTSdtBarCode, DT.FTPdtName, DT.FTPdtCode, DT.FCSdtQty, DT.FCSdtDis, DT.FCSdtFootAvg, DT.FCSdtNet, DT.FCSdtB4DisChg, DT.FCSdtSetPrice, DT.FCSdtVat, DT.FTSdtVatType 
from TSHD{0} HD with(nolock)
left join TSDT{0} DT with(nolock) on HD.FTShdDocNo = DT.FTShdDocNo
where isnull(HD.FTShdDocVatFull,'') = '' and HD.FTShdStaDoc = '1' and DT.FTShdDocNo = '{1}'", ref_POSNumber, ref_invoice);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<InvoiceDetail>();
            while (reader.Read())
            {
                var each_data = new InvoiceDetail
                {
                    FNSdtSeqNo = SQLHelper.SafeGetDecimal(reader, 0),
                    FTSdtBarCode = SQLHelper.SafeGetString(reader, 1),
                    FTPdtName = SQLHelper.SafeGetString(reader, 2),
                    FTPdtCode = SQLHelper.SafeGetString(reader, 3),
                    FCSdtQty = SQLHelper.SafeGetDecimal(reader, 4),
                    FCSdtDis = SQLHelper.SafeGetDecimal(reader, 5),
                    FCSdtFootAvg = SQLHelper.SafeGetDecimal(reader, 6),
                    FCSdtNet = SQLHelper.SafeGetDecimal(reader, 7),
                    FCSdtB4DisChg = SQLHelper.SafeGetDecimal(reader, 8),
                    FCSdtSetPrice = SQLHelper.SafeGetDecimal(reader, 9),
                    FCSdtVat = SQLHelper.SafeGetDecimal(reader, 10),
                    FTSdtVatType = SQLHelper.SafeGetString(reader, 11),
                };
                result.Add(each_data);
            }
            if (result.Any())
            {
                this.REF_CurrentInvoiceDetailList = result;
            }
        }
        private void CN_saveRef_INVPayment()
        {
            var ref_invoice = CurrentInvoice.FTShdPosCN;
            var ref_POSNumber = CurrentInvoice.FTShdPosCN.Substring(8, 3);

            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select RC.FCSrcNet, RC.FTRcvName, RC.FTSrcRef, HD.FTShdPosCN

from TPSTSalHD HD with(nolock)

left join TPSTSalRC RC with(nolock) on HD.FTShdDocNo = RC.FTShdDocNo

where isnull(FTShdDocVatFull,'') = '' and RC.FTShdDocNo = '{1}'

union all

select RC.FCSrcNet, RC.FTRcvName, RC.FTSrcRef, HD.FTShdPosCN

from TSHD{0} HD with(nolock)

left join TSRC{0} RC with(nolock) on HD.FTShdDocNo = RC.FTShdDocNo

where isnull(HD.FTShdDocVatFull,'') = '' and HD.FTShdStaDoc = '1' and RC.FTShdDocNo = '{1}'", ref_POSNumber, ref_invoice);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<InvoicePayment>();
            while (reader.Read())
            {
                var each_data = new InvoicePayment
                {
                    FCSrcNet = SQLHelper.SafeGetDecimal(reader, 0),
                    FTRcvName = SQLHelper.SafeGetString(reader, 1),
                    FTSrcRef = SQLHelper.SafeGetString(reader, 2),
                };
                result.Add(each_data);
            }
            if (result.Any())
            {
                this.REF_CurrentInvoicePayment = result.FirstOrDefault();
            }
        }
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            var prov = this.Invoices;
            switch (CurrentSelectedColumn)
            {
                /*case "FTBchCode":
                    prov = prov.Where(t => t.FTBchCode.Contains(textBox_search.Text)).ToList();
                    break;*/
                case "FDDateIns":
                    prov = prov.Where(t => t.FDDateIns.Contains(textBox_search.Text)).ToList();
                    break;
                /*case "FTTimeIns":
                    prov = prov.Where(t => t.FTTimeIns.Contains(textBox_search.Text)).ToList();
                    break;*/
                case "FTShdDocNo":
                    prov = prov.Where(t => t.FTShdDocNo.ToUpper().Contains(textBox_search.Text.ToUpper())).ToList();
                    break;
                /*case "FCShdTotal":
                    prov = prov.Where(t => t.FCShdTotal.Contains(textBox_search.Text)).ToList();
                    break;
                case "FCShdVat":
                    prov = prov.Where(t => t.FCShdVat.Contains(textBox_search.Text)).ToList();
                    break;
                case "FCShdVatable":
                    prov = prov.Where(t => t.FCShdVatable.Contains(textBox_search.Text)).ToList();
                    break;
                case "FCShdNonVat":
                    prov = prov.Where(t => t.FCShdNonVat.Contains(textBox_search.Text)).ToList();
                    break;
                case "FCShdDis":
                    prov = prov.Where(t => t.FCShdDis.Contains(textBox_search.Text)).ToList();
                    break;
                case "FCShdB4DisChg":
                    prov = prov.Where(t => t.FCShdB4DisChg.Contains(textBox_search.Text)).ToList();
                    break;
                case "FCShdGndAE":
                    prov = prov.Where(t => t.FCShdGndAE.Contains(textBox_search.Text)).ToList();
                    break;*/
                default: break;
            }
            UpdateDataGridView(prov);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (CurrentInvoice != null)
            {
                seachDetailthenClose();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
