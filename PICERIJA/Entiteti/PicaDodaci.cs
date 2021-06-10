using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class PicaDodaci
    {
        public virtual int Id { get; set; }
        public virtual string Dodaci { get; set; }

        public virtual Pica PripadaPici { get; set; }

        public PicaDodaci()
        {

        }
    }
}
