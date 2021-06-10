using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public class ZaposleniNivoiJezika
    {
        public virtual int Id { get; set; }
        public virtual string NivoiJezika { get; set; }
        public virtual Zaposleni PripadaZaposlenom { get; set; }

        public ZaposleniNivoiJezika()
        {

        }
    }
}
