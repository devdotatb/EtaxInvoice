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
        }
        private void UpdateDataGridView(List<Province> data)
        {
            dataGridView1.DataSource = data;
            dataGridView1.Columns["FTPvnCode"].HeaderText = "รหัส";
            dataGridView1.Columns["FTPvnName"].HeaderText = "ชื่อ";
            dataGridView1.Columns["FDDateUpd"].Visible = false;
            dataGridView1.Columns["FTTimeUpd"].Visible = false;
            dataGridView1.Columns["FTWhoUpd"].Visible = false;
            dataGridView1.Columns["FDDateIns"].Visible = false;
            dataGridView1.Columns["FTTimeIns"].Visible = false;
            dataGridView1.Columns["FTWhoIns"].Visible = false;
        }
        private List<Province> GetProvinces()
        {
            string connstr = @"Data Source=.\sqlexpress;Initial Catalog=SFMPOSS;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT [FTPvnCode]
      ,[FTPvnName]
      ,[FDDateUpd]
      ,[FTTimeUpd]
      ,[FTWhoUpd]
      ,[FDDateIns]
      ,[FTTimeIns]
      ,[FTWhoIns]
  FROM [SFMPOSS].[dbo].[TCNMProvince]");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Province>();
            while (reader.Read())
            {
                var prov = new Province
                {
                    FTPvnCode = SQLHelper.SafeGetString(reader,0),
                    FTPvnName = SQLHelper.SafeGetString(reader,1),
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Province;

                label2.Text = senderGrid.Columns[e.ColumnIndex].HeaderText;

                textBox_search.Text = dataGridView1.SelectedCells[0].Value.ToString();

                this.CurrentSelectedColumn = senderGrid.Columns[e.ColumnIndex].Name;

                this.CurrentProvince = selectedRow;

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
    }
}
