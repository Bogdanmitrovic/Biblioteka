using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Ucenici : Form
    {
        public Ucenici()
        {
            InitializeComponent();
        }

        private void Ucenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Ucenici' table. You can move, or remove it, as needed.
            this.uceniciTableAdapter.Fill(this.databaseDataSet.Ucenici);

        }
    }
}
