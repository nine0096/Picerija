using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class Poklon
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumDodelePoklona { get; set; }
        public virtual DateTime DatumIskoriscenjaPoklona { get; set; }
        public virtual string Tip { get; set; }
        public virtual int BrojBodova { get; set; }

        public virtual KupacSaBonusom PripadaKupcu { get; set; }

        public Poklon()
        {

        }
    }
}
