using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class Pica
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int Cena { get; set; }
        public virtual string Velicina { get; set; }
        public virtual int BonusBodovi { get; set; }

        public Pica()
        {

        }
    }
}
