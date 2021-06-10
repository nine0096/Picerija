using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class ZaposleniJeziciMapiranja : ClassMap<ZaposleniJezici>
    {
        public ZaposleniJeziciMapiranja()
        {
            Table("STRANI_JEZICI");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.StraniJezici, "STRANI_JEZICI");

            References(x => x.PripadaZaposlenom).Column("ID_ZAPOSLENOG").LazyLoad();
        }
    }
}
