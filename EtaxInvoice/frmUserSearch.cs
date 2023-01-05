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
    public partial class frmUserSearch : Form
    {
        public List<Person> People { get; set; }
        public frmUserSearch()
        {
            People = GetPeople();
            InitializeComponent();
        }

        private List<Person> GetPeople()
        {
            var list = new List<Person>();
            list.Add(new Person()
            {
                PersonId = 1,
                Name = "Person 1",
                Surname = "Surname 1",
                Profession = "P 1"
            });
            list.Add(new Person()
            {
                PersonId = 1,
                Name = "Person 2",
                Surname = "Surname 2",
                Profession = "P 2"
            });
            list.Add(new Person()
            {
                PersonId = 1,
                Name = "Person 3",
                Surname = "Surname 3",
                Profession = "P 3"
            });
            return list;
        }

        private void frmUserSearch_Load(object sender, EventArgs e)
        {
            var people = this.People;
            dataGridView1.DataSource = people;
            dataGridView1.Columns["PersonId"].Visible = false;
            dataGridView1.Columns["Name"].HeaderText = "ชื่อลูกค้า";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as Person;

                label2.Text = senderGrid.Columns[e.ColumnIndex].HeaderText;

                textBox_search.Text = dataGridView1.SelectedCells[0].Value.ToString();

                this.CurrentSelectedColumn = senderGrid.Columns[e.ColumnIndex].Name;

                this.CurrentPerson = selectedRow;

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
            var people = this.People;
            switch (CurrentSelectedColumn)
            {
                case "Name":
                    people = people.Where(t => t.Name == textBox_search.Text).ToList();
                    break;
                default:break;
            }
            dataGridView1.DataSource = people;
        }
    }
}
