using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    public class RasporedMapiranja : ClassMap<PICERIJA.Entiteti.Raspored>
    {
        public RasporedMapiranja()
        {
            //mapiranje tabele
            Table("RASPORED");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.Assigned();

            //mapiranje svojstava
            //Map(x => x.Id, "ID");
            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");
            Map(x => x.Smena, "SMENA");

            HasMany(x => x.Radnici).KeyColumn("ID_RASPOREDA").LazyLoad().Cascade.All().Inverse();


        }
    }
}
