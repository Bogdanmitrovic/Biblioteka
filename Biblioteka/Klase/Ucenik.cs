using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ucenik
    {
        public string Ime { get { return this.Ime; } protected set { this.Ime = value; } }
        public char SrednjeSlovo { get { return this.SrednjeSlovo; } protected set { this.SrednjeSlovo = value; } }
        public string Prezime { get { return this.Prezime; } protected set { this.Prezime = value; } }
        public int Godina { get { return this.Godina; } protected set { this.Godina = value; } }
        public int Odeljenje { get { return this.Odeljenje; } protected set { this.Odeljenje = value; } }
        public int BrojUDnevniku { get { return this.BrojUDnevniku; } protected set { this.BrojUDnevniku = value; } }
        public int BrojZaduzenihKnjiga { get { return this.BrojZaduzenihKnjiga; } protected set { this.BrojZaduzenihKnjiga = value; } }

        public List<Knjiga> SpisakZaduzenihKnjiga { get { return this.SpisakZaduzenihKnjiga; } protected set { this.SpisakZaduzenihKnjiga = value; } }

        public Ucenik(string Ime, char SrednjeSlovo, string Prezime, int Godina, int Odeljenje, int BrojUDnevniku, int BrojZaduzenihKnjiga)
        {
            this.Ime = Ime;
            this.SrednjeSlovo = SrednjeSlovo;
            this.Prezime = Prezime;
            this.Godina = Godina;
            this.Odeljenje = Odeljenje;
            this.BrojUDnevniku = BrojUDnevniku;
            this.BrojZaduzenihKnjiga = 0;
            this.SpisakZaduzenihKnjiga = new List<Knjiga>();

        }
    }
}
