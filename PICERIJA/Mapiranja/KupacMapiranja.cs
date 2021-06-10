using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class KupacMapiranja : SubclassMap<Kupac>
    {
        public KupacMapiranja()
        {
            Table("KUPAC");

            Abstract();

            Map(x => x.Email, "EMAIL");
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");

            HasMany(x => x.Porudzbine).KeyColumn("ID_KUPCA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
