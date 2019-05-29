using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Knjiga
    {
        public int ID { get { return this.ID; } protected set { this.ID = value; } }
        public string Naziv { get { return this.Naziv; } protected set { this.Naziv = value; } }
        public string Pisac { get { return this.Pisac; } protected set { this.Pisac = value; } }
        public string Izdavac { get { return this.Izdavac; } protected set { this.Izdavac = value; } }
        public bool Dostupna { get { return this.Dostupna; } protected set { this.Dostupna = value; } }
        public List<DateTime> Izdata { get { return this.Izdata; } protected set { this.Izdata = value; } }
        public List<DateTime> Vracena { get { return this.Vracena; } protected set { this.Vracena = value; } }
        public List<Ucenik> KodKogaJe { get { return this.KodKogaJe; } protected set { this.KodKogaJe = value; } }
        /*diskutabilno za get set i liste*/
        /*trenutno pravim tri liste, verovatno postoji lepsi nacin*/

        /*mozda ako napravim podklasu za knjigu od istih izdavaca, naslova i pisaca, 
         * da se ne pojavljuju vise puta u spisku ali da vrse normalno fje
         videcemo*/

        public Knjiga(int ID, string Naziv, string Pisac, string Izdavac)
        {
            this.ID = ID;
            this.Naziv = Naziv;
            this.Pisac = Pisac;
            this.Izdavac = Izdavac;
            this.Dostupna = true;
            this.Izdata = new List<DateTime>();
            this.Vracena = new List<DateTime>();
            this.KodKogaJe = new List<Ucenik>();
        }

        public void IzdajKnjigu(DateTime Datum, Ucenik Osoba)
        {
            if (this.Dostupna)
            {
                this.Dostupna = false;
                this.KodKogaJe.Add(Osoba);
                this.Izdata.Add(Datum);
            }
            /*
             * else treba da se obavesti korisnik
             */
        }

        public void VratiKnjigu(DateTime Datum)
        {
            if (this.Dostupna)
            {
                Dostupna = false;
                this.Vracena.Add(Datum);
            }
            /*
             * else treba da se obavesti korisnik
             */
        }
    }
}
