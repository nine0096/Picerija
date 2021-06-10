using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class Zaposleni : Osoba
    {

        public virtual long Jmbg { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string TipZaposlenog { get; set; }
        public virtual string Vozacka { get; set; }


        public virtual Raspored PripadaRasporedu { get; set; }

        public virtual IList<DostavnoVozilo> Vozila { get; set; }

        public virtual IList<Porudzbina> Porudzbine { get; set; }

        public Zaposleni()
        {
            Vozila = new List<DostavnoVozilo>();

            Porudzbine = new List<Porudzbina>();

        }
    }
}
