using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class PorucenaPicaMapiranja : SubclassMap<PorucenaPica>
    {
        public PorucenaPicaMapiranja()
        {
            Table("PORUCENA_PICA");

            KeyColumn("ID_PICE");
           

            Map(x => x.Sastojci, "SASTOJCI");
            Map(x => x.PojedinacnaCena, "POJEDINACNA_CENA");

            //MAPIRANJE VEZE 1:N PORUDZBINA:PORUCENA_PICA
            References(x => x.PripadaPorudzbini).Column("ID_PORUDZBINE").LazyLoad();
        }
    }
}
