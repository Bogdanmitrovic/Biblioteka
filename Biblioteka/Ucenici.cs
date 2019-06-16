using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Biblioteka
{
    public partial class Ucenici : Form
    {
        public Ucenici()
        {
            InitializeComponent();
        }
        string search;
        private void Ucenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Ucenici' table. You can move, or remove it, as needed.
            this.uceniciTableAdapter.Fill(this.databaseDataSet.Ucenici);
            listView1.Items.Add("ID");
            listView1.Items.Add("ime");
            listView1.Items.Add("prezime");
            listView1.Items.Add("srednjeSlovo");
            listView1.Items.Add("uzeteKnjige");
            listView1.Items.Add("razred");
            listView1.Items.Add("odeljenje");
            listView1.Items.Add("brojUzetihKnjiga");
            search = "Ime";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(uceniciTableAdapter.GetData());
            dv.RowFilter = string.Format(search + " LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
            Debug.WriteLine(1);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            search = listView1.SelectedItems[0].Text;
            Debug.WriteLine(search);
        }
    }
}
