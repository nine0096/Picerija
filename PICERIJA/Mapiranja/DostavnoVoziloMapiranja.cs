using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    public class DostavnoVoziloMapiranja : ClassMap<PICERIJA.Entiteti.DostavnoVozilo>
    {
        public DostavnoVoziloMapiranja()
        {

            Table("DOSTAVNO_VOZILO");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIP_VOZILA");


            // Map(x => x.TipVozila, "TIP_VOZILA");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.NazivTipa, "NAZIV_TIPA");
           

            HasMany(x => x.Porudzbine).KeyColumn("ID_VOZILA").LazyLoad().Cascade.All().Inverse();

            //MAPIRANJE VEZE N: M
            HasManyToMany(x => x.Dostavljaci)
                .Table("VOZI")
                .ParentKeyColumn("ID_VOZILA")
                .ChildKeyColumn("ID_DOSTAVLJACA")
                .Cascade.All()
                .Inverse();
        }
    }

    class AutomobilMapiranja : SubclassMap<Automobil>
    {
        public AutomobilMapiranja()
        {
            DiscriminatorValue("Automobil");
            Map(x => x.RegBrojA, "REG_BROJ_A");
            Map(x => x.BrojDozvoleA, "BROJ_DOZVOLE_A");

        }
    }

    class SkuterMapiranja : SubclassMap<Skuter>
    {
        public SkuterMapiranja()
        {
            DiscriminatorValue("Skuter");
            Map(x => x.RegBrojS, "REG_BROJ_S");
            Map(x => x.BrojDozvoleS, "BROJ_DOZVOLE_S");
        }

    }

    class BiciklMapiranja : SubclassMap<Bicikl>
    {
        public BiciklMapiranja()
        {
            DiscriminatorValue("Bicikl");
            Map(x => x.VelicinaRama, "VELICINA_RAMA");
        }
    }
}
