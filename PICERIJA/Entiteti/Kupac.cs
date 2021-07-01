using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class Kupac : Osoba
    {
        public virtual string Email { get; set; }
        public virtual int BrojTelefona { get; set; }
        public virtual string TipKupca { get; set; }
        public virtual int SakupljeniBodovi { get; set; }
        public virtual DateTime DatumPrvePorudzbine { get; set; }

        public virtual IList<Porudzbina> Porudzbine { get; set; }
        public virtual IList<Poklon> Pokloni { get; set; }

        public Kupac()
        {
            Porudzbine = new List<Porudzbina>();

            Pokloni = new List<Poklon>();
        }
    }
}
