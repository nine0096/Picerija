using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class PoklonMapiranja : ClassMap<Poklon>
    {
        public PoklonMapiranja()
        {
            Table("POKLON");


            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

           //ZA STRANI KLJUC SAMO:
           // References(x => x.IdKupca)
           //.Column("ID_KUPCA")
           //.Cascade.All();



            Map(x => x.DatumDodelePoklona, "DATUM_DODELE_POKLONA");
            Map(x => x.DatumIskoriscenjaPoklona, "DATUM_ISKORISCENJA_POKLONA");
            Map(x => x.Tip, "TIP");
            Map(x => x.BrojBodova, "BROJ_BODOVA");

            References(x => x.PripadaKupcu).Column("ID_KUPCA").LazyLoad();

        }
    }
}
