using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public  class Porudzbina
    {
        public virtual int Id { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime DatumKreiranja { get; set; }
        public virtual DateTime DatumIsporuke { get; set; }
        public virtual string Kartica { get; set; }
        public virtual string Kes { get; set; }

        public virtual DostavnoVozilo PripadaVozilu { get; set; }

        public virtual Kupac PripadaKupcu { get; set; }

        public virtual IList<PorucenaPica>PorucenePice { get; set; }

        public virtual IList<Zaposleni> Radnici { get; set; }  // dostavljaci i primaoci porudzbina

        public Porudzbina()
        {
            PorucenePice = new List<PorucenaPica>();

            Radnici = new List<Zaposleni>();
        }
    }
}
