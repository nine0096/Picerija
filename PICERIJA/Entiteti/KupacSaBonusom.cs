using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class KupacSaBonusom : Kupac
    {
        public virtual int SakupljeniBodovi { get; set; }
        public virtual DateTime DatumPrvePorudzbine { get; set; }

        public virtual IList<Poklon> Pokloni { get; set; }

        public KupacSaBonusom()
        {
            Pokloni = new List<Poklon>();
        }
    }
}
