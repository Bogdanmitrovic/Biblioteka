using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Glavna : Form
    {


        public Glavna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.uceniciTableAdapter.Fill(this.databaseDataSet.Ucenici);

            //uceniciTableAdapter.Insert("Bogdan3", "Mitrovic2", "P2", "uzete knjige2", 3, 1, 1);

        }

        private void UceniciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uceniciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void UceniciBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
