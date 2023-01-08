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
    public partial class frmCountrySearch : Form
    {
        public List<Country> Countries { get; set; }
        public string CurrentSelectedColumn { get; set; }
        public Country CurrentCountry { get; set; }
        public frmCountrySearch()
        {
            Countries = GetCountries();
            InitializeComponent();
        }

        private void frmCountrySearch_Load(object sender, EventArgs e)
        {
            var provs = this.Countries;
            UpdateDataGridView(provs);
            SetDefaultData();
        }
        private void SetDefaultData()
        {
            CurrentSelectedColumn = "FTCYDescTh";
            label2.Text = "ชื่อไทย";
        }
        private void UpdateDataGridView(List<Country> data)
        {
            this.CurrentCountry = data.FirstOrDefault();
            dataGridView1.DataSource = data;
            dataGridView1.Columns["FTCYCode"].HeaderText = "รหัส";
            dataGridView1.Columns["FTCYDescTh"].HeaderText = "ชื่อไทย";
            dataGridView1.Columns["FTCYDescEn"].HeaderText = "ชื่ออังกฤษ";
        }
        private List<Country> GetCountries()
        {
            string connstr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select FTCYCode,FTCYDescTh,FTCYDescEn from TCNMCountry");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Country>();
            while (reader.Read())
            {
                var prov = new Country
                {
                    FTCYCode = SQLHelper.SafeGetString(reader, 0),
                    FTCYDescTh = SQLHelper.SafeGetString(reader, 1),
                    FTCYDescEn = SQLHelper.SafeGetString(reader, 1),
                    /*FDDateUpd = SQLHelper.SafeGetString(reader,2),
                    FTTimeUpd = SQLHelper.SafeGetString(reader,3),
                    FTWhoUpd = SQLHelper.SafeGetString(reader,4),
                    FDDateIns = SQLHelper.SafeGetString(reader,5),
                    FTTimeIns = SQLHelper.SafeGetString(reader,6),
                    FTWhoIns = SQLHelper.SafeGetString(reader,7),*/
                };
                result.Add(prov);
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


                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Country;

                this.CurrentCountry = selectedRow;

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
            dataGrid_clicked_operation(sender,e);
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

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            var prov = this.Countries;
            switch (CurrentSelectedColumn)
            {
                case "FTCYCode":
                    prov = prov.Where(t => t.FTCYCode.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCYDescTh":
                    prov = prov.Where(t => t.FTCYDescTh.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTCYDescEn":
                    prov = prov.Where(t => t.FTCYDescEn.Contains(textBox_search.Text)).ToList();
                    break;
                default: break;
            }
            UpdateDataGridView(prov);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
