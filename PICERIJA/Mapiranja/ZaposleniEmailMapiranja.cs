using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class ZaposleniEmailMapiranja : ClassMap<ZaposleniEmail>
    {
        public ZaposleniEmailMapiranja()
        {
            Table("ZAPOSLENI_EMAIL");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Email, "EMAIL");

            References(x => x.PripadaZaposlenom).Column("ID_ZAPOSLENOG").LazyLoad();
        }
    }
}
