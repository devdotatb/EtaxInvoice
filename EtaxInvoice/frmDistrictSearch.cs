
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
    public partial class frmDistrictSearch : Form
    {
        public List<District> Districts { get; set; }
        public string CurrentSelectedColumn { get; set; }
        public District CurrentDistrict { get; set; }
        public frmDistrictSearch()
        {
            Districts = GetDistricts();
            InitializeComponent();
        }

        private void frmDistrictSearch_Load(object sender, EventArgs e)
        {
            var provs = this.Districts;
            UpdateDataGridView(provs);
            SetDefaultData();
        }
        private void SetDefaultData()
        {
            CurrentSelectedColumn = "FTDstName";
            label2.Text = "ชื่อ";
        }
        private void UpdateDataGridView(List<District> data)
        {
            this.CurrentDistrict = data.FirstOrDefault();
            dataGridView1.DataSource = data;
            dataGridView1.Columns["FTDstCode"].HeaderText = "รหัส";
            dataGridView1.Columns["FTDstName"].HeaderText = "ชื่อ";
            dataGridView1.Columns["FTDstPost"].Visible = false;
            dataGridView1.Columns["FTPvnCode"].Visible = false;
            dataGridView1.Columns["FDDateUpd"].Visible = false;
            dataGridView1.Columns["FTTimeUpd"].Visible = false;
            dataGridView1.Columns["FTWhoUpd"].Visible = false;
            dataGridView1.Columns["FDDateIns"].Visible = false;
            dataGridView1.Columns["FTTimeIns"].Visible = false;
            dataGridView1.Columns["FTWhoIns"].Visible = false;
        }
        private List<District> GetDistricts()
        {
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT  [FTDstCode]
      ,[FTDstName]
      ,[FTDstPost]
      ,[FTPvnCode]
      ,[FDDateUpd]
      ,[FTTimeUpd]
      ,[FTWhoUpd]
      ,[FDDateIns]
      ,[FTTimeIns]
      ,[FTWhoIns]
  FROM [SFMPOS].[dbo].[TCNMDistrict]");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<District>();
            while (reader.Read())
            {
                var prov = new District
                {
                    FTDstCode = SQLHelper.SafeGetString(reader, 0),
                    FTDstName = SQLHelper.SafeGetString(reader, 1),
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


                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as District;

                this.CurrentDistrict = selectedRow;

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

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            var prov = this.Districts;
            switch (CurrentSelectedColumn)
            {
                case "FTDstCode":
                    prov = prov.Where(t => t.FTDstCode.Contains(textBox_search.Text)).ToList();
                    break;
                case "FTDstName":
                    prov = prov.Where(t => t.FTDstName.Contains(textBox_search.Text)).ToList();
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
