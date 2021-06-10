using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PICERIJA.Entiteti;

namespace PICERIJA.Mapiranja
{
    class OsobaMapiranja : ClassMap<Osoba>
    {
        public OsobaMapiranja()
        {
            UseUnionSubclassForInheritanceMapping();

            Id(x => x.Sifra).Column("SIFRA").GeneratedBy.SequenceIdentity("OSOBA_ID_SEQ");

            
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Drzava, "DRZAVA");

        }
    }
}
