using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
   public class Raspored
    {

        public virtual int Id { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual string Smena { get; set; }

        public virtual IList<Zaposleni> Radnici { get; set; }
        public Raspored()
        {
            Radnici = new List<Zaposleni>();
        }


    }
}
