using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class ZaposleniEmail
    {
        public virtual int Id { get; set; }
        public virtual int Email { get; set; }

        public virtual Zaposleni PripadaZaposlenom { get; set; }

        public ZaposleniEmail()
        {

        }
    }
}
