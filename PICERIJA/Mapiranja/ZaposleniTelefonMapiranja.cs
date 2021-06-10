using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class ZaposleniTelefonMapiranja : ClassMap<ZaposleniTelefon>
    {
        public ZaposleniTelefonMapiranja()
        {
            Table("ZAPOSLENI_TELEFON");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojTelefona, "BROJ_TELEFONA");

            References(x => x.PripadaZaposlenom).Column("ID_ZAPOSLENOG").LazyLoad();
        }
    }
}
