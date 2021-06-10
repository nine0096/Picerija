using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;


namespace PICERIJA.Mapiranja
{
    class PorudzbinaMapiranja : ClassMap<Porudzbina>
    {
        public PorudzbinaMapiranja()
        {
            Table("PORUDZBINA");

            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("PORUDZBINA_ID_SEQ");

            Map(x => x.Status, "STATUS");
            Map(x => x.DatumKreiranja, "DATUM_KREIRANJA");
            Map(x => x.DatumIsporuke, "DATUM_ISPORUKE");
            Map(x => x.Kartica, "KARTICA");
            Map(x => x.Kes, "KES");

            //Mapiranje veze 1:N DOSTAVNO_VOZILO:PORUDZBINA
            References(x => x.PripadaVozilu).Column("ID_VOZILA").LazyLoad();

            //Mapiranje veze 1:N KUPAC:PORUDZBINA
            References(x => x.PripadaKupcu).Column("ID_KUPCA").LazyLoad();

            //Mapiranje veze 1:N PORUDZBINA:PORUCENA_PICA
            HasMany(x => x.PorucenePice).KeyColumn("ID_PORUDZBIINE").LazyLoad().Cascade.All().Inverse();

            //MAPIRANJE VEZE N: M
            HasManyToMany(x => x.Radnici)
                .Table("PRIMA_I_ISPORUCUJE")
                .ParentKeyColumn("ID_PORUDZBINE")
                .ChildKeyColumn("ID_ZAPOSLENOG")
                .Cascade.All()
                .Inverse();
        }
    }
}
