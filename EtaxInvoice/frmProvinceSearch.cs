
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
    public partial class frmProvinceSearch : Form
    {
        public List<Province> Provinces { get; set; }
        public string CurrentSelectedColumn { get; set; }
        public Province CurrentProvince { get; set; }
        public frmProvinceSearch()
        {
            Provinces = GetProvinces();
            InitializeComponent();
        }

        private void frmProvinceSearch_Load(object sender, EventArgs e)
        {
            var provs = this.Provinces;
            UpdateDataGridView(provs);
            SetDefaultData();
        }
        private void SetDefaultData()
        {
            CurrentSelectedColumn = "FTPvnName";
            label2.Text = "ชื่อ";
        }
        private void UpdateDataGridView(List<Province> data)
        {
            this.CurrentProvince = data.FirstOrDefault();
            dataGridView1.DataSource = data;
            dataGridView1.Columns["FTPvnCode"].HeaderText = "รหัส";
            dataGridView1.Columns["FTPvnName"].HeaderText = "ชื่อ";
        }
        private List<Province> GetProvinces()
        {
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT [FTPvnCode]
                  ,[FTPvnName]
                  ,[FDDateUpd]
                  ,[FTTimeUpd]
                  ,[FTWhoUpd]
                  ,[FDDateIns]
                  ,[FTTimeIns]
                  ,[FTWhoIns]
              FROM [SFMPOS].[dbo].[TCNMProvince]");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Province>();
            while (reader.Read())
            {
                var prov = new Province
                {
                    FTPvnCode = SQLHelper.SafeGetString(reader, 0),
                    FTPvnName = SQLHelper.SafeGetString(reader, 1),
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


                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Province;

                this.CurrentProvince = selectedRow;

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
            var prov = this.Provinces;
            switch (CurrentSelectedColumn)
            {
                case "FTPvnCode":
                    prov = prov.Where(t => t.FTPvnCode.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTPvnName":
                    prov = prov.Where(t => t.FTPvnName.Contains(textBox_search.Text)).ToList();
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

        private void button_OK_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
