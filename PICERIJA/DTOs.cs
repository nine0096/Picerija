using PICERIJA.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICERIJA
{
    #region Vozilo

    public class VoziloBasic
    {
        public int VoziloId { get; set; }
        public string Proizvodjac { get; set; }
        public string NazivTipa { get; set; }
      //  public int BrojDostavljaca { get; set; }
      //  public int BrojPorudzbina { get; set; }

        public VoziloBasic()
        {

        }

        public VoziloBasic(int idV, string proizvodjac, string nazivTipa, int brojPor)
        {
            this.VoziloId = idV;
            this.Proizvodjac = proizvodjac;
            this.NazivTipa = nazivTipa;
            
        }

    }

    public class VoziloAutomobilBasic : VoziloBasic
    {
        public string RegBrojA { get; set; }
        public int BrojDozvoleA { get; set; }

        public VoziloAutomobilBasic()
        {

        }

        public VoziloAutomobilBasic(int idV, string proizvodjac, string nazivTipa, int brojPor, string regbr, int brd) : base(idV, proizvodjac, nazivTipa, brojPor)
        {
            this.RegBrojA = regbr;
            this.BrojDozvoleA = brd;
        }
    }

    public class VoziloSkuterBasic : VoziloBasic
    {
        public string RegBrojS { get; set; }
        public int BrojDozvoleS { get; set; }

        public VoziloSkuterBasic()
        {

        }

        public VoziloSkuterBasic(int idV, string proizvodjac, string nazivTipa, int brojPor, string regbr, int brd) : base(idV, proizvodjac, nazivTipa, brojPor)
        {
            this.RegBrojS = regbr;
            this.BrojDozvoleS = brd;
        }
    }

    public class VoziloBiciklBasic : VoziloBasic
    {
        public string Ram { get; set; }

        public VoziloBiciklBasic()
        {

        }

        public VoziloBiciklBasic(int idV, string proizvodjac, string nazivTipa, int brojPor, string ram) : base(idV, proizvodjac, nazivTipa, brojPor)
        {

            this.Ram = ram;
        }


    }

    public class VoziloPregled
    {
        public int VoziloId { get; set; }
        public string Proizvodjac { get; set; }
        public string NazivTipa { get; set; }

        public VoziloPregled()
        {

        }

        public VoziloPregled(int idV, string proizvodjac, string nazivTipa)
        {
            this.VoziloId = idV;
            this.Proizvodjac = proizvodjac;
            this.NazivTipa = nazivTipa;

        }
    }

    public class VoziloAutomobilPregled : VoziloPregled
    {
        public string RegBrojA { get; set; }
        public int BrojDozvoleA { get; set; }

        public VoziloAutomobilPregled()
        {

        }

        public VoziloAutomobilPregled(int idV, string proizvodjac, string nazivTipa, string regbr, int brd) : base(idV, proizvodjac, nazivTipa)
        {
            this.RegBrojA = regbr;
            this.BrojDozvoleA = brd;
        }
    }

    public class VoziloSkuterPregled : VoziloPregled
    {
        public string RegBrojS { get; set; }
        public int BrojDozvoleS { get; set; }

        public VoziloSkuterPregled()
        {

        }

        public VoziloSkuterPregled(int idV, string proizvodjac, string nazivTipa, string regbr, int brd) : base(idV, proizvodjac, nazivTipa)
        {
            this.RegBrojS = regbr;
            this.BrojDozvoleS = brd;
        }
    }

    public class VoziloBiciklPregled : VoziloPregled
    {
        public string Ram { get; set; }

        public VoziloBiciklPregled()
        {

        }

        public VoziloBiciklPregled(int idV, string proizvodjac, string nazivTipa, string ram) : base(idV, proizvodjac, nazivTipa)
        {

            this.Ram = ram;
        }

    }

    #endregion

    #region Zaposleni

        public class ZaposleniBasic
    {
        public  int SifraZaposleni { get; set; }
        public  string Ime { get; set; }
        public  string Prezime { get; set; }
        public  string Ulica { get; set; }
        public  int Broj { get; set; }
        public  string Grad { get; set; }
        public  string Drzava { get; set; }
        public long Jmbg { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string TipZaposlenog { get; set; }
        public string Vozacka { get; set; }

        //public RasporedBasic Raspored { get; set; }
       // public int BrojVozila { get; set; }
        
        public ZaposleniBasic()
        {

        }

        public ZaposleniBasic(int id, string ime, string prezime, string ulica, int broj, string grad, string drzava, long jmbg, DateTime datum, string tip, string vozacka)
        {
            this.SifraZaposleni = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Ulica = ulica;
            this.Broj = broj;
            this.Grad = grad;
            this.Drzava = drzava;
            this.Jmbg = jmbg;
            this.TipZaposlenog = tip;
            this.Vozacka = vozacka;
            
        }
    }

    public class ZaposleniPregled
    {
        public int SifraZaposleni { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ulica { get; set; }
        public int Broj { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public long Jmbg { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string TipZaposlenog { get; set; }
        public string Vozacka { get; set; }

        public ZaposleniPregled()
        {

        }

        public ZaposleniPregled(int id, string ime, string prezime, string ulica, int broj, string grad, string drzava, long jmbg, DateTime datum, string tip, string vozacka)
        {
            this.SifraZaposleni = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Ulica = ulica;
            this.Broj = broj;
            this.Grad = grad;
            this.Drzava = drzava;
            this.Jmbg = jmbg;
            this.TipZaposlenog = tip;
            this.Vozacka = vozacka;

        }
    }
    #endregion

    #region Pica
    public class PicaPregled
    {
        public int IdPica { get; set; }
        public string Naziv { get; set; }
        public int Cena { get; set; }
        public string Velicina { get; set; }
        public int BonusBodovi { get; set; }

        public PicaPregled()
        {

        }

        public PicaPregled(int id, string naziv, int cena, string velicina, int bodovi)
        {
            this.IdPica = id;
            this.Naziv = naziv;
            this.Cena = cena;
            this.Velicina = velicina;
            this.BonusBodovi = bodovi;
        }
    }


        public class PicaBasic
        {
            public int IdPica { get; set; }
            public string Naziv { get; set; }
            public int Cena { get; set; }
            public string Velicina { get; set; }
            public int BonusBodovi { get; set; }

            public PicaBasic()
            {

            }

            public PicaBasic(int id, string naziv, int cena, string velicina, int bodovi)
            {
                this.IdPica = id;
                this.Naziv = naziv;
                this.Cena = cena;
                this.Velicina = velicina;
                this.BonusBodovi = bodovi;
            }


        }

    #endregion

    #region Raspored

    public class RasporedBasic
    {
        public int IdRaspored { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Smena { get; set; }
       // public int BrojZaposlenih { get; set; }

        public RasporedBasic()
        {

        }

        public RasporedBasic(int id, DateTime datumod, DateTime datumdo, string smena)
        {
            this.IdRaspored = id;
            this.DatumOd = datumod;
            this.DatumDo = datumdo;
            this.Smena = smena;
        }
    }

    public class RasporedPregled
    {
        public int IdRaspored { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Smena { get; set; }

        public RasporedPregled()
        {

        }

        public RasporedPregled(int id, DateTime datumod, DateTime datumdo, string smena)
        {
            this.IdRaspored = id;
            this.DatumOd = datumod;
            this.DatumDo = datumdo;
            this.Smena = smena;
        }
    }

    #endregion

    #region Kupac

    public class KupacBasic
    {
        public int SifraKupac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ulica { get; set; }
        public int Broj { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public  string Email { get; set; }
        public int BrojTelefona { get; set; }
        //public int BrojPorudzbina { get; set; }

        public KupacBasic()
        {

        }

        public KupacBasic(int id, string ime, string prezime, string ulica, int broj, string grad, string drzava, string email, int tel)
        {
            this.SifraKupac = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Ulica = ulica;
            this.Broj = broj;
            this.Grad = grad;
            this.Drzava = drzava;
            this.Email = email;
            this.BrojTelefona = tel;

        }

    }

    public class KupacPregled
    {
        public int SifraKupac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ulica { get; set; }
        public int Broj { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public int BrojTelefona { get; set; }
        

        public KupacPregled()
        {

        }

        public KupacPregled(int id, string ime, string prezime, string ulica, int broj, string grad, string drzava, string email, int tel)
        {
            this.SifraKupac = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Ulica = ulica;
            this.Broj = broj;
            this.Grad = grad;
            this.Drzava = drzava;
            this.Email = email;
            this.BrojTelefona = tel;

        }
    }
    #endregion

    #region Porudzbina
    public class PorudzbinaBasic
    {
        public int IdPorudzbina { get; set; }
        public  string Status { get; set; }
        public  DateTime DatumKreiranja { get; set; }
        public  DateTime DatumIsporuke { get; set; }
        public  string Kartica { get; set; }
        public  string Kes { get; set; }
       //  public VoziloBasic Vozilo { get; set; }
       // public KupacBasic Kupac { get; set; }
       // public int BrojRadnika { get; set; }
       // public int BrojPorucenihPica { get; set; }

        public PorudzbinaBasic()
        {

        }

        public PorudzbinaBasic(int id, string status, DateTime kreirana, DateTime isporucena, string kartica, string kes)
        {
            this.IdPorudzbina = id;
            this.Status = status;
            this.DatumKreiranja = kreirana;
            this.DatumIsporuke = isporucena;
            this.Kartica = kartica;
            this.Kes = kes;
        }

    }

    public class PorudzbinaPregled
    {
        public int IdPorudzbina { get; set; }
        public string Status { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public string Kartica { get; set; }
        public string Kes { get; set; }
       

        public PorudzbinaPregled()
        {

        }

        public PorudzbinaPregled(int id, string status, DateTime kreirana, DateTime isporucena, string kartica, string kes)
        {
            this.IdPorudzbina = id;
            this.Status = status;
            this.DatumKreiranja = kreirana;
            this.DatumIsporuke = isporucena;
            this.Kartica = kartica;
            this.Kes = kes;
        }
    }
    #endregion

    #region KupacSaBonusom

    public class KupacSaBonusomBasic : KupacBasic
    {
        public int SakupljeniBodovi { get; set; }
        public DateTime DatumPrvePorudzbine { get; set; }
       // public int BrojPoklona { get; set; }

        public KupacSaBonusomBasic()
        {

        }

        public KupacSaBonusomBasic(int id, string ime, string prezime, string ulica, int broj, string grad, string drzava, string email, int tel, int bodovi,DateTime prva): base(id, ime, prezime, ulica, broj, grad, drzava, email, tel)
        {
            this.SakupljeniBodovi = bodovi;
            this.DatumPrvePorudzbine = prva;
        }
    }

    public class KupacSaBonusomPregled : KupacPregled
    {
        public int SakupljeniBodovi { get; set; }
        public DateTime DatumPrvePorudzbine { get; set; }
       

        public KupacSaBonusomPregled()
        {

        }

        public KupacSaBonusomPregled(int id, string ime, string prezime, string ulica, int broj, string grad, string drzava, string email, int tel, int bodovi, DateTime prva) : base(id, ime, prezime, ulica, broj, grad, drzava, email, tel)
        {
            this.SakupljeniBodovi = bodovi;
            this.DatumPrvePorudzbine = prva;
        }
    }

    #endregion

    #region PorucenaPica
    public class PorucenaPicaBasic : PicaBasic
    {
        public string Sastojci { get; set; }
        public int PojedinacnaCena { get; set; }
       //public PorudzbinaBasic Porudzbina { get; set; }

        public PorucenaPicaBasic()
        {

        }

        public PorucenaPicaBasic(int id, string naziv, int cena, string velicina, int bodovi, string sastojci, int pojcena) : base(id,naziv,cena,velicina,bodovi)
        {
            this.Sastojci = sastojci;
            this.PojedinacnaCena = pojcena;
        }
    }

    public class PorucenaPicaPregled : PicaPregled
    {
        public string Sastojci { get; set; }
        public int PojedinacnaCena { get; set; }
      

        public PorucenaPicaPregled()
        {

        }

        public PorucenaPicaPregled(int id, string naziv, int cena, string velicina, int bodovi, string sastojci, int pojcena) : base(id, naziv, cena, velicina, bodovi)
        {
            this.Sastojci = sastojci;
            this.PojedinacnaCena = pojcena;
        }
    }
    #endregion

    #region Poklon
    public class PoklonBasic
    {
        public int IdPoklon { get; set; }
        public DateTime DatumDodelePoklona { get; set; }
        public DateTime DatumIskoriscenjaPoklona { get; set; }
        public string Tip { get; set; }
        public int BrojBodova { get; set; }
        //public KupacSaBonusomBasic KupacBonus { get; set; }

        public PoklonBasic()
        {

        }

        public PoklonBasic(int id, DateTime dodela, DateTime iskoristio, string tip, int bodovi)
        {
            this.IdPoklon = id;
            this.DatumDodelePoklona = dodela;
            this.DatumIskoriscenjaPoklona = iskoristio;
            this.Tip = tip;
            this.BrojBodova = bodovi;
        }
    }

    public class PoklonPregled
    {
        public int IdPoklon { get; set; }
        public DateTime DatumDodelePoklona { get; set; }
        public DateTime DatumIskoriscenjaPoklona { get; set; }
        public string Tip { get; set; }
        public int BrojBodova { get; set; }
       

        public PoklonPregled()
        {

        }

        public PoklonPregled(int id, DateTime dodela, DateTime iskoristio, string tip, int bodovi)
        {
            this.IdPoklon = id;
            this.DatumDodelePoklona = dodela;
            this.DatumIskoriscenjaPoklona = iskoristio;
            this.Tip = tip;
            this.BrojBodova = bodovi;
        }
    }


    #endregion

    
}
