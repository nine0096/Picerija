using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class PicaDodaciMapiranja : ClassMap<PicaDodaci>
    {
        public PicaDodaciMapiranja()
        {
            Table("PICA_DODACI");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Dodaci, "DODACI");

            References(x => x.PripadaPici).Column("ID_PICE").LazyLoad();
        }
    }
}
