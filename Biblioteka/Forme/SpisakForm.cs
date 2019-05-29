using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.Forme
{
    public partial class SpisakForm : Form
    {
        public SpisakForm()
        {
            InitializeComponent();
        }

        private void NazadButton_Click(object sender, EventArgs e)
        {
            PocetniEkranForm.ActiveForm.Show();
            this.Close();
        }
    }
}
