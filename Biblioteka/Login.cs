using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Biblioteka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        void UlepsajOvo()
        {
            BackColor = Resursi.bojaPozadinaSvetla;
            groupBox1.BackColor = Resursi.bojaPozadinaTamna;
            groupBox1.ForeColor = Resursi.bojaTamna;
            textBox1.BackColor = Resursi.bojaSvetla;
            textBox2.BackColor = Resursi.bojaSvetla;
            textBox1.ForeColor = Resursi.bojaTamna;
            textBox2.ForeColor = Resursi.bojaTamna;
            label1.ForeColor = Resursi.bojaTekst;
            label2.ForeColor = Resursi.bojaTekst;
            button1.ForeColor = Resursi.bojaTamna;
            button1.BackColor = Resursi.bojaSvetla;
            textBox2.PasswordChar = '*';
        }
        private void Login_Load(object sender, EventArgs e)
        {
            UlepsajOvo();
            if (!File.Exists("info.txt"))
            {
                button1.Text = "Креирај налог";
                Debug.WriteLine("ne postoji fajl");
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("info.txt"))
            {
                StreamReader citac = new StreamReader("info.txt");
                string ime = citac.ReadLine();
                string lozinka = citac.ReadLine();
                string key = "3f2AC0nMCYyqfIgaH62r";
                citac.Close();
                Debug.WriteLine(ime + "yay");
                Debug.WriteLine(textBox1.Text);
                if (ime.Equals(textBox1.Text))
                {
                    StringBuilder provera = new StringBuilder();
                    for (int i = 0; i < textBox2.TextLength; i++)
                    {
                        provera.Append(textBox2.Text[i] ^ key[i]);
                    }
                    if (provera.ToString() == lozinka)
                    {
                        Glavna g = new Glavna();
                        g.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                StreamWriter pisac = new StreamWriter("info.txt");
                string key = "3f2AC0nMCYyqfIgaH62r";
                StringBuilder provera = new StringBuilder();
                for (int i = 0; i < textBox2.TextLength; i++)
                {
                    provera.Append(textBox2.Text[i] ^ key[i]);
                }
                if (provera.Length > 0)
                {
                    pisac.WriteLine(textBox1.Text);
                    pisac.WriteLine(provera);
                    pisac.Close();
                    Glavna g = new Glavna();
                    g.Show();
                    this.Close();
                }
            }
        }
    }
    public static class Resursi
    {
        public static readonly Color bojaTekst = Color.FromArgb(240, 240, 242);
        public static readonly Color bojaPozadinaTamna = Color.FromArgb(71, 79, 89);
        public static readonly Color bojaTamna = Color.FromArgb(31, 34, 38);
        public static readonly Color bojaSvetla = Color.FromArgb(174, 181, 191);
        public static readonly Color bojaPozadinaSvetla = Color.FromArgb(112, 127, 140);
    }
}
