using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class ZaposleniTelefon
    {
        public virtual int Id { get; set; }
        public virtual int BrojTelefona { get; set; }

        public virtual Zaposleni PripadaZaposlenom { get; set; }

        public ZaposleniTelefon()
        {

        }
    }
}
