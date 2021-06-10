using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class ZaposleniNivoiJezikaMapiranja : ClassMap<ZaposleniNivoiJezika>
    {
        public ZaposleniNivoiJezikaMapiranja()
        {
            Table("NIVOI_JEZIKA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.NivoiJezika, "NIVOI_JEZIKA");

            References(x => x.PripadaZaposlenom).Column("ID_ZAPOSLENOG").LazyLoad();
        }
    }
}
