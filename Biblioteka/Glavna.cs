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
using System.Diagnostics;

namespace Biblioteka
{
    public partial class Glavna : Form
    {

        void UlepsajOvo()
        {
            BackColor = Resursi.bojaPozadinaSvetla;
            groupBox1.BackColor = Resursi.bojaPozadinaTamna;
            groupBox1.ForeColor = Resursi.bojaTamna;
            groupBox2.BackColor = Resursi.bojaPozadinaTamna;
            groupBox2.ForeColor = Resursi.bojaTamna;
            groupBox3.BackColor = Resursi.bojaPozadinaTamna;
            groupBox3.ForeColor = Resursi.bojaTamna;
            textBox1.BackColor = Resursi.bojaSvetla;
            textBox2.BackColor = Resursi.bojaSvetla;
            textBox3.BackColor = Resursi.bojaSvetla;
            textBox1.ForeColor = Resursi.bojaTamna;
            textBox2.ForeColor = Resursi.bojaTamna;
            textBox3.ForeColor = Resursi.bojaTamna;
            label1.ForeColor = Resursi.bojaTekst;
            label2.ForeColor = Resursi.bojaTekst;
            label3.ForeColor = Resursi.bojaTekst;
            button1.ForeColor = Resursi.bojaTamna;
            button1.BackColor = Resursi.bojaSvetla;
            button2.ForeColor = Resursi.bojaTamna;
            button2.BackColor = Resursi.bojaSvetla;
            button3.ForeColor = Resursi.bojaTamna;
            button3.BackColor = Resursi.bojaSvetla;
            button4.ForeColor = Resursi.bojaTamna;
            button4.BackColor = Resursi.bojaSvetla;
        }
        public Glavna()
        {
            InitializeComponent();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Knjige' table. You can move, or remove it, as needed.
            this.knjigeTableAdapter.Fill(this.databaseDataSet.Knjige);
            // TODO: This line of code loads data into the 'databaseDataSet.Ucenici' table. You can move, or remove it, as needed.
            this.uceniciTableAdapter.Fill(this.databaseDataSet.Ucenici);
            //this.uceniciTableAdapter.Fill(this.databaseDataSet.Ucenici);
            UlepsajOvo();
            //uceniciTableAdapter.Insert("Bogdan3", "Mitrovic2", "P2", "uzete knjige2", 3, 1, 1);

        }

        

        private void UceniciBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //prikazi ucenike
            this.Hide();
            Ucenici u = new Ucenici();
            u.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1 knjiga 2 korisnik
            //uzmi knjigu
            Debug.WriteLine("uso");
            string idKnjiga = "ID = '" + textBox1.Text + "'";
            databaseDataSet.UceniciRow nadjeni = databaseDataSet.Ucenici.FindByID(int.Parse(textBox2.Text));
            DataRow[] nadjena = databaseDataSet.Knjige.Select(idKnjiga);
            Debug.WriteLine(nadjena.Length);
            if (nadjena.Count<DataRow>() > 0 && nadjeni != null)
            {
                string baseKnjige = nadjeni.uzeteKnjige;
                baseKnjige += "," + textBox1.Text;
                Debug.WriteLine("dodao korisniku " + textBox2.Text + " knjigu " + textBox1.Text);
                
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //prikazi knjige
            this.Hide();
            Knjige k = new Knjige();
            k.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
