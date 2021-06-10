using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA.Entiteti
{
    public abstract class DostavnoVozilo
    {
        public virtual int Id { get; set; }
        public virtual string TipVozila { get; set; }
        public virtual string Proizvodjac { get; set; }
        public virtual string NazivTipa { get; set; }
       


        public virtual IList<Porudzbina> Porudzbine { get; set; }
        public virtual IList<Zaposleni> Dostavljaci { get; set; }

        public DostavnoVozilo()
        {
            Porudzbine = new List<Porudzbina>();

            Dostavljaci = new List<Zaposleni>();
        }
    }

    public class Automobil : DostavnoVozilo
    {
        public virtual string RegBrojA { get; set; }
        public virtual int BrojDozvoleA { get; set; }
    }

    public class Skuter : DostavnoVozilo
    {
        public virtual string RegBrojS { get; set; }
        public virtual int BrojDozvoleS { get; set; }
    }

    public class Bicikl : DostavnoVozilo
    {
        public virtual string VelicinaRama { get; set; }


    }
}
