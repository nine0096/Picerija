using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class KupacSaBonusomMapiranja : SubclassMap<KupacSaBonusom>
    {
        public KupacSaBonusomMapiranja()
        {
            Table("KUPAC_SA_BONUSOM");

            KeyColumn("ID_KUPCA");

            Map(x => x.SakupljeniBodovi, "SAKUPLJENI_BODOVI");
            Map(x => x.DatumPrvePorudzbine, "DATUM_PRVE_PORUDZBINE");

            HasMany(x => x.Pokloni).KeyColumn("ID_KUPCA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
