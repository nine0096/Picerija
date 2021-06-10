using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public abstract class Osoba
    {
        public virtual int Sifra { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Drzava { get; set; }

        public Osoba()
        {

        }
    }
}
