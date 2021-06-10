using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    public class ZaposleniMapiranja : SubclassMap<PICERIJA.Entiteti.Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Abstract();

           
            Map(x => x.Jmbg, "JMBG");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.TipZaposlenog, "TIP_ZAPOSLENOG");
            Map(x => x.Vozacka, "VOZACKA");

            //MAPIRANJE VEZE 1:N RASPORED:ZAPOSLENI
            References(x => x.PripadaRasporedu).Column("ID_RASPOREDA").LazyLoad();

            //MAPIRANJE VEZE N: M
            HasManyToMany(x => x.Vozila)
                .Table("VOZI")
                .ParentKeyColumn("ID_DOSTAVLJACA")
                .ChildKeyColumn("ID_VOZILA")
                .Cascade.All();

            //MAPIRANJE VEZE N: M
            HasManyToMany(x => x.Porudzbine)
                .Table("PRIMA_I_ISPORUCUJE")
                .ParentKeyColumn("ID_ZAPOSLENOG")
                .ChildKeyColumn("ID_PORUDZBINE")
                .Cascade.All();
        }


    }
}
