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
        public int Generacija { get { return this.Generacija; } protected set { this.Generacija = value; } }
        public List<Knjiga> SpisakZaduzenihKnjiga { get { return this.SpisakZaduzenihKnjiga; } protected set { this.SpisakZaduzenihKnjiga = value; } }
        public Ucenik(string Ime, char SrednjeSlovo, string Prezime, int Godina, int Odeljenje, int BrojUDnevniku, int BrojZaduzenihKnjiga, int Generacija)
        {
            this.Ime = Ime;
            this.SrednjeSlovo = SrednjeSlovo;
            this.Prezime = Prezime;
            this.Godina = Godina;
            this.Odeljenje = Odeljenje;
            this.BrojUDnevniku = BrojUDnevniku;
            this.BrojZaduzenihKnjiga = 0;
            this.SpisakZaduzenihKnjiga = new List<Knjiga>();
            this.Generacija = Generacija;
        }
        public string ReturnString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < SpisakZaduzenihKnjiga.Count; i++)
            {
                if (stringBuilder.Length == 0) stringBuilder.Append(SpisakZaduzenihKnjiga[i].ID);
                else stringBuilder.Append(SpisakZaduzenihKnjiga[i].ID + ",");
            }
            return stringBuilder.ToString();
        }
        //public Ucenik(string Ime, char SrednjeSlovo, string Prezime, int Godina, int Odeljenje, int BrojUDnevniku, int BrojZaduzenihKnjiga, string IdKnjiga)
        //    : this(Ime, SrednjeSlovo, Prezime, Godina, Odeljenje, BrojUDnevniku, BrojZaduzenihKnjiga)
        //{
        //    string[] ZaduzeneKnjige = IdKnjiga.Split(',');
        //    this.BrojZaduzenihKnjiga = ZaduzeneKnjige.Length;

        //    for(int i=0;i<this.BrojZaduzenihKnjiga; i++)
        //    {
        //        this.SpisakZaduzenihKnjiga.Add(new Knjiga(int.Parse(ZaduzeneKnjige[i])));
        //    }
        //}

    }
}
