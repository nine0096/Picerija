using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class PicaMapiranja : ClassMap<PICERIJA.Entiteti.Pica>
    {

        public PicaMapiranja()
        {
            Table("PICA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Cena, "CENA");
            Map(x => x.Velicina, "VELICINA");
            Map(x => x.BonusBodovi, "BONUS_BODOVI");


        }
    }
}
