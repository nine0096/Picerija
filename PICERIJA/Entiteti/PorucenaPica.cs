using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class PorucenaPica : Pica
    {
        public virtual string Sastojci { get; set; }
        public virtual int PojedinacnaCena { get; set; }

        public virtual Porudzbina PripadaPorudzbini { get; set; }

        

    }
}
