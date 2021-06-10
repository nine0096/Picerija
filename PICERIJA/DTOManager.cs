using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using PICERIJA.Entiteti;
using System.Windows.Forms;


namespace PICERIJA
{
    class DTOManager
    {
        #region Vozila

        #region Automobili

        public static void obrisiAutomobil(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Automobil automobil = s.Load<Automobil>(id);

                s.Delete(automobil);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }


        public static void dodajAutomobil(VoziloAutomobilBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Automobil o = new PICERIJA.Entiteti.Automobil();

                o.Proizvodjac = p.Proizvodjac;
                o.NazivTipa = p.NazivTipa;
                o.RegBrojA = p.RegBrojA;
                o.BrojDozvoleA = p.BrojDozvoleA;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static VoziloAutomobilBasic vratiAutomobil(int id)
        {
            VoziloAutomobilBasic a = new VoziloAutomobilBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Automobil automobil = s.Load<Automobil>(id);

                a.VoziloId = automobil.Id;
                a.Proizvodjac = automobil.Proizvodjac;
                a.NazivTipa = automobil.NazivTipa;
                a.RegBrojA = automobil.RegBrojA;
                a.BrojDozvoleA = automobil.BrojDozvoleA;


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return a;

        }

        public static void izmeniAutomobil(VoziloAutomobilBasic auto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Automobil a = s.Load<Automobil>(auto.VoziloId);

                a.Proizvodjac = auto.Proizvodjac;
                a.NazivTipa = auto.NazivTipa;
                a.RegBrojA = auto.RegBrojA;
                a.BrojDozvoleA = auto.BrojDozvoleA;



                s.SaveOrUpdate(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void sacuvajAutomobil(VoziloAutomobilBasic auto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Automobil a = new PICERIJA.Entiteti.Automobil();

                a.Proizvodjac = auto.Proizvodjac;
                a.NazivTipa = auto.NazivTipa;
                a.RegBrojA = auto.RegBrojA;
                a.BrojDozvoleA = auto.BrojDozvoleA;

                s.Save(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static List<VoziloAutomobilPregled> vratiSveAutomobile()
        {
            List<VoziloAutomobilPregled> automobili = new List<VoziloAutomobilPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Automobil> sviAutomobili = from o in s.Query<PICERIJA.Entiteti.Automobil>()
                                                                         select o;

                foreach (PICERIJA.Entiteti.Automobil a in sviAutomobili)
                {
                    automobili.Add(new VoziloAutomobilPregled(a.Id, a.Proizvodjac, a.NazivTipa, a.RegBrojA, a.BrojDozvoleA));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return automobili;
        }

        public static void obrisiAutoIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Automobil a = s.Load<PICERIJA.Entiteti.Automobil>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Skuteri
        public static void obrisiSkuter(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Skuter skuter = s.Load<Skuter>(id);

                s.Delete(skuter);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        public static VoziloSkuterBasic vratiSkuter(int id)
        {
            VoziloSkuterBasic a = new VoziloSkuterBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Skuter skuter = s.Load<Skuter>(id);

                a.VoziloId = skuter.Id;
                a.Proizvodjac = skuter.Proizvodjac;
                a.NazivTipa = skuter.NazivTipa;
                a.RegBrojS = skuter.RegBrojS;
                a.BrojDozvoleS = skuter.BrojDozvoleS;


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return a;

        }

        public static void izmeniSkuter(VoziloSkuterBasic skuter)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Skuter a = s.Load<Skuter>(skuter.VoziloId);

                a.Proizvodjac = skuter.Proizvodjac;
                a.NazivTipa = skuter.NazivTipa;
                a.RegBrojS = skuter.RegBrojS;
                a.BrojDozvoleS = skuter.BrojDozvoleS;



                s.SaveOrUpdate(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void sacuvajSkuter(VoziloSkuterBasic skuter)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Skuter a = new PICERIJA.Entiteti.Skuter();

                a.Proizvodjac = skuter.Proizvodjac;
                a.NazivTipa = skuter.NazivTipa;
                a.RegBrojS = skuter.RegBrojS;
                a.BrojDozvoleS = skuter.BrojDozvoleS;

                s.Save(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void dodajSkuter(VoziloSkuterBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Skuter o = new PICERIJA.Entiteti.Skuter();

                o.Proizvodjac = p.Proizvodjac;
                o.NazivTipa = p.NazivTipa;
                o.RegBrojS = p.RegBrojS;
                o.BrojDozvoleS = p.BrojDozvoleS;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static List<VoziloSkuterPregled> vratiSveSkutere()
        {
            List<VoziloSkuterPregled> skuteri = new List<VoziloSkuterPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Skuter> sviSkuteri = from o in s.Query<PICERIJA.Entiteti.Skuter>()
                                                                   select o;

                foreach (PICERIJA.Entiteti.Skuter a in sviSkuteri)
                {
                    skuteri.Add(new VoziloSkuterPregled(a.Id, a.Proizvodjac, a.NazivTipa, a.RegBrojS, a.BrojDozvoleS));
                }


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return skuteri;
        }

        public static void obrisiSkuterIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Skuter a = s.Load<PICERIJA.Entiteti.Skuter>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Bicikli
        public static void obrisiBicikl(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bicikl bicikl = s.Load<Bicikl>(id);

                s.Delete(bicikl);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        public static VoziloBiciklBasic vratiBicikl(int id)
        {
            VoziloBiciklBasic b = new VoziloBiciklBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Bicikl bicikl = s.Load<Bicikl>(id);

                b.VoziloId = bicikl.Id;
                b.Proizvodjac = bicikl.Proizvodjac;
                b.NazivTipa = bicikl.NazivTipa;
                b.Ram = bicikl.VelicinaRama;



                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return b;

        }

        public static void izmeniBicikl(VoziloBiciklBasic bicikl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Bicikl b = s.Load<Bicikl>(bicikl.VoziloId);

                b.Proizvodjac = bicikl.Proizvodjac;
                b.NazivTipa = bicikl.NazivTipa;
                b.VelicinaRama = bicikl.Ram;



                s.SaveOrUpdate(b);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void sacuvajBicikl(VoziloBiciklBasic bicikl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Bicikl b = new PICERIJA.Entiteti.Bicikl();

                b.Proizvodjac = bicikl.Proizvodjac;
                b.NazivTipa = bicikl.NazivTipa;
                b.VelicinaRama = bicikl.Ram;



                s.Save(b);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static List<VoziloBiciklPregled> vratiSveBicikle()
        {
            List<VoziloBiciklPregled> bicikli = new List<VoziloBiciklPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Bicikl> sviBicikli = from o in s.Query<PICERIJA.Entiteti.Bicikl>()
                                                                   select o;

                foreach (PICERIJA.Entiteti.Bicikl a in sviBicikli)
                {
                    bicikli.Add(new VoziloBiciklPregled(a.Id, a.Proizvodjac, a.NazivTipa, a.VelicinaRama));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return bicikli;
        }

        public static void obrisiBiciklIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Bicikl a = s.Load<PICERIJA.Entiteti.Bicikl>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #endregion

        #region Pica

        public static List<PicaPregled> vratiSvePice()
        {
            List<PicaPregled> pice = new List<PicaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Pica> svePice = from o in s.Query<PICERIJA.Entiteti.Pica>()
                                                              select o;

                foreach (PICERIJA.Entiteti.Pica p in svePice)
                {
                    pice.Add(new PicaPregled(p.Id, p.Naziv, p.Cena, p.Velicina, p.BonusBodovi));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pice;
        }

        public static void obrisiPicuIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Pica p = s.Load<PICERIJA.Entiteti.Pica>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region PorucenaPica

        public static List<PorucenaPicaPregled> vratiSvePorucenePice()
        {
            List<PorucenaPicaPregled> pice = new List<PorucenaPicaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.PorucenaPica> svePice = from o in s.Query<PICERIJA.Entiteti.PorucenaPica>()
                                                                      select o;

                foreach (PICERIJA.Entiteti.PorucenaPica p in svePice)
                {
                    pice.Add(new PorucenaPicaPregled(p.Id, p.Naziv, p.Cena, p.Velicina, p.BonusBodovi, p.Sastojci, p.PojedinacnaCena));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pice;
        }

        public static void obrisiPorucenuPicuIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.PorucenaPica p = s.Load<PICERIJA.Entiteti.PorucenaPica>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
            
        #endregion

        #region Zaposleni

            public static void obrisiZaposlenog(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni radnik = s.Load<Zaposleni>(id);

                s.Delete(radnik);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        public static void dodajZaposlenog(ZaposleniBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Zaposleni o = new PICERIJA.Entiteti.Zaposleni();

                o.Ime = p.Ime;
                o.Prezime = p.Prezime;
                o.Ulica = p.Ulica;
                o.Broj = p.Broj;
                o.Grad = p.Grad;
                o.Drzava = p.Drzava;
                o.Jmbg = p.Jmbg;
                o.DatumRodjenja = p.DatumRodjenja;
                o.TipZaposlenog = p.TipZaposlenog;
                o.Vozacka = p.Vozacka;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static ZaposleniBasic vratiZapposlenog(int id)
        {
            ZaposleniBasic a = new ZaposleniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni radnik = s.Load<Zaposleni>(id);

                a.SifraZaposleni = radnik.Sifra;
                a.Ime = radnik.Ime;
                a.Prezime = radnik.Prezime;
                a.Ulica = radnik.Ulica;
                a.Broj = radnik.Broj;
                a.Grad = radnik.Grad;
                a.Drzava = radnik.Drzava;
                a.Jmbg = radnik.Jmbg;
                a.DatumRodjenja = radnik.DatumRodjenja;
                a.TipZaposlenog = radnik.TipZaposlenog;
                a.Vozacka = radnik.Vozacka;


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return a;

        }

        public static void izmeniZaposlenog(ZaposleniBasic radnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Zaposleni a = s.Load<Zaposleni>(radnik.SifraZaposleni);


                a.Ime = radnik.Ime;
                a.Prezime = radnik.Prezime;
                a.Ulica = radnik.Ulica;
                a.Broj = radnik.Broj;
                a.Grad = radnik.Grad;
                a.Drzava = radnik.Drzava;
                a.Jmbg = radnik.Jmbg;
                a.DatumRodjenja = radnik.DatumRodjenja;
                a.TipZaposlenog = radnik.TipZaposlenog;
                a.Vozacka = radnik.Vozacka;


                s.SaveOrUpdate(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void sacuvajZaposlenog(ZaposleniBasic radnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Zaposleni a = new PICERIJA.Entiteti.Zaposleni();

                a.Ime = radnik.Ime;
                a.Prezime = radnik.Prezime;
                a.Ulica = radnik.Ulica;
                a.Broj = radnik.Broj;
                a.Grad = radnik.Grad;
                a.Drzava = radnik.Drzava;
                a.Jmbg = radnik.Jmbg;
                a.DatumRodjenja = radnik.DatumRodjenja;
                a.TipZaposlenog = radnik.TipZaposlenog;
                a.Vozacka = radnik.Vozacka;

                s.Save(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static List<ZaposleniPregled> vratiSveZaposlene()
        {
            List<ZaposleniPregled> radnici = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<PICERIJA.Entiteti.Zaposleni>()
                                                                        select o;

                foreach (PICERIJA.Entiteti.Zaposleni a in sviZaposleni)
                {
                    radnici.Add(new ZaposleniPregled(a.Sifra, a.Ime, a.Prezime, a.Ulica, a.Broj, a.Grad, a.Drzava, a.Jmbg, a.DatumRodjenja, a.TipZaposlenog, a.Vozacka));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return radnici;
        }


        public static List<ZaposleniPregled> vratiSveDostavljace()
        {
            List<ZaposleniPregled> radnici = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<PICERIJA.Entiteti.Zaposleni>()
                                                                        where (o.TipZaposlenog == "Dostavljac")
                                                                        select o;

                foreach (PICERIJA.Entiteti.Zaposleni a in sviZaposleni)
                {
                    radnici.Add(new ZaposleniPregled(a.Sifra, a.Ime, a.Prezime, a.Ulica, a.Broj, a.Grad, a.Drzava, a.Jmbg, a.DatumRodjenja, a.TipZaposlenog, a.Vozacka));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return radnici;
        }


        public static List<ZaposleniPregled> vratiSvePrimaoce()
        {
            List<ZaposleniPregled> radnici = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<PICERIJA.Entiteti.Zaposleni>()
                                                                        where (o.TipZaposlenog == "Primalac porudzbina")
                                                                        select o;

                foreach (PICERIJA.Entiteti.Zaposleni a in sviZaposleni)
                {
                    radnici.Add(new ZaposleniPregled(a.Sifra, a.Ime, a.Prezime, a.Ulica, a.Broj, a.Grad, a.Drzava, a.Jmbg, a.DatumRodjenja, a.TipZaposlenog, a.Vozacka));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return radnici;
        }


        public static void obrisiZaposlenogIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Zaposleni a = s.Load<PICERIJA.Entiteti.Zaposleni>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Kupac

        public static void obrisiKupca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac kupac = s.Load<Kupac>(id);

                s.Delete(kupac);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        public static void dodajKupca(KupacBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Kupac o = new PICERIJA.Entiteti.Kupac();

                o.Ime = p.Ime;
                o.Prezime = p.Prezime;
                o.Ulica = p.Ulica;
                o.Broj = p.Broj;
                o.Grad = p.Grad;
                o.Drzava = p.Drzava;
                o.Email = p.Email;
                o.BrojTelefona = p.BrojTelefona;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static KupacBasic vratiKupca(int id)
        {
            KupacBasic a = new KupacBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac kupac = s.Load<Kupac>(id);

                a.SifraKupac = kupac.Sifra; ;
                a.Ime = kupac.Ime;
                a.Prezime = kupac.Prezime;
                a.Ulica = kupac.Ulica;
                a.Broj = kupac.Broj;
                a.Grad = kupac.Grad;
                a.Drzava = kupac.Drzava;
                a.Email = kupac.Email;
                a.BrojTelefona = kupac.BrojTelefona;


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return a;

        }

        public static void izmeniKupca(KupacBasic kupac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Kupac a = s.Load<Kupac>(kupac.SifraKupac);


                a.Ime = kupac.Ime;
                a.Prezime = kupac.Prezime;
                a.Ulica = kupac.Ulica;
                a.Broj = kupac.Broj;
                a.Grad = kupac.Grad;
                a.Drzava = kupac.Drzava;
                a.Email = kupac.Email;
                a.BrojTelefona = kupac.BrojTelefona;


                s.SaveOrUpdate(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void sacuvajKupca(KupacBasic kupac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Kupac a = new PICERIJA.Entiteti.Kupac();

                a.Ime = kupac.Ime;
                a.Prezime = kupac.Prezime;
                a.Ulica = kupac.Ulica;
                a.Broj = kupac.Broj;
                a.Grad = kupac.Grad;
                a.Drzava = kupac.Drzava;
                a.Email = kupac.Email;
                a.BrojTelefona = kupac.BrojTelefona;


                s.Save(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static List<KupacPregled> vratiSveKupce()
        {
            List<KupacPregled> kupci = new List<KupacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Kupac> sviKupci = from o in s.Query<PICERIJA.Entiteti.Kupac>()
                                                                select o;

                foreach (PICERIJA.Entiteti.Kupac a in sviKupci)
                {
                    kupci.Add(new KupacPregled(a.Sifra, a.Ime, a.Prezime, a.Ulica, a.Broj, a.Grad, a.Drzava, a.Email, a.BrojTelefona));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return kupci;
        }

        public static void obrisiKupcaIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Kupac a = s.Load<PICERIJA.Entiteti.Kupac>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region KupacSaBonusom

        public static void obrisiBonusKupca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KupacSaBonusom kupac = s.Load<KupacSaBonusom>(id);

                s.Delete(kupac);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        public static void dodajBonusKupca(KupacSaBonusomBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.KupacSaBonusom o = new PICERIJA.Entiteti.KupacSaBonusom();

                o.Ime = p.Ime;
                o.Prezime = p.Prezime;
                o.Ulica = p.Ulica;
                o.Broj = p.Broj;
                o.Grad = p.Grad;
                o.Drzava = p.Drzava;
                o.Email = p.Email;
                o.BrojTelefona = p.BrojTelefona;
                o.SakupljeniBodovi = p.SakupljeniBodovi;
                o.DatumPrvePorudzbine = p.DatumPrvePorudzbine;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static KupacSaBonusomBasic vratiBonusKupca(int id)
        {
            KupacSaBonusomBasic a = new KupacSaBonusomBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                KupacSaBonusom kupac = s.Load<KupacSaBonusom>(id);

                a.SifraKupac = kupac.Sifra; ;
                a.Ime = kupac.Ime;
                a.Prezime = kupac.Prezime;
                a.Ulica = kupac.Ulica;
                a.Broj = kupac.Broj;
                a.Grad = kupac.Grad;
                a.Drzava = kupac.Drzava;
                a.Email = kupac.Email;
                a.BrojTelefona = kupac.BrojTelefona;
                a.SakupljeniBodovi = kupac.SakupljeniBodovi;
                a.DatumPrvePorudzbine = kupac.DatumPrvePorudzbine;


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return a;

        }

        public static void izmeniBonusKupca(KupacSaBonusomBasic kupac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.KupacSaBonusom a = s.Load<KupacSaBonusom>(kupac.SifraKupac);


                a.Ime = kupac.Ime;
                a.Prezime = kupac.Prezime;
                a.Ulica = kupac.Ulica;
                a.Broj = kupac.Broj;
                a.Grad = kupac.Grad;
                a.Drzava = kupac.Drzava;
                a.Email = kupac.Email;
                a.BrojTelefona = kupac.BrojTelefona;
                a.SakupljeniBodovi = kupac.SakupljeniBodovi;
                a.DatumPrvePorudzbine = kupac.DatumPrvePorudzbine;

                s.SaveOrUpdate(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void sacuvajBonusKupcaKupca(KupacSaBonusomBasic kupac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.KupacSaBonusom a = new PICERIJA.Entiteti.KupacSaBonusom();

                a.Ime = kupac.Ime;
                a.Prezime = kupac.Prezime;
                a.Ulica = kupac.Ulica;
                a.Broj = kupac.Broj;
                a.Grad = kupac.Grad;
                a.Drzava = kupac.Drzava;
                a.Email = kupac.Email;
                a.BrojTelefona = kupac.BrojTelefona;
                a.SakupljeniBodovi = kupac.SakupljeniBodovi;
                a.DatumPrvePorudzbine = kupac.DatumPrvePorudzbine;

                s.Save(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static List<KupacSaBonusomPregled> vratiSveBonusKupce()
        {
            List<KupacSaBonusomPregled> kupci = new List<KupacSaBonusomPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.KupacSaBonusom> sviKupci = from o in s.Query<PICERIJA.Entiteti.KupacSaBonusom>()
                                                                         select o;

                foreach (PICERIJA.Entiteti.KupacSaBonusom a in sviKupci)
                {
                    kupci.Add(new KupacSaBonusomPregled(a.Sifra, a.Ime, a.Prezime, a.Ulica, a.Broj, a.Grad, a.Drzava, a.Email, a.BrojTelefona, a.SakupljeniBodovi, a.DatumPrvePorudzbine));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return kupci;
        }

        public static void obrisiBonusKupcaIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.KupacSaBonusom a = s.Load<PICERIJA.Entiteti.KupacSaBonusom>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Poklon

        public static List<PoklonPregled> vratiSvePoklone()
        {
            List<PoklonPregled> pokloni = new List<PoklonPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Poklon> sviPokloni = from o in s.Query<PICERIJA.Entiteti.Poklon>()
                                                                      select o;

                foreach (PICERIJA.Entiteti.Poklon p in sviPokloni)
                {
                    pokloni.Add(new PoklonPregled(p.Id, p.DatumDodelePoklona, p.DatumIskoriscenjaPoklona, p.Tip, p.BrojBodova ));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pokloni;
        }

        public static void obrisiPoklonIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Poklon p = s.Load<PICERIJA.Entiteti.Poklon>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        #endregion

        #region Porudzbina
        public static List<PorudzbinaPregled> vratiSvePorudzbine()
        {
            List<PorudzbinaPregled> porudzbine = new List<PorudzbinaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PICERIJA.Entiteti.Porudzbina> svePorudzbine = from o in s.Query<PICERIJA.Entiteti.Porudzbina>()
                                                                      select o;

                foreach (PICERIJA.Entiteti.Porudzbina p in svePorudzbine)
                {
                    porudzbine.Add(new PorudzbinaPregled(p.Id, p.Status, p.DatumKreiranja, p.DatumIsporuke, p.Kartica, p.Kes));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return porudzbine;
        }

        public static void izmeniPorudzbinu(PorudzbinaBasic porudzbina)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Porudzbina a = s.Load<Porudzbina>(porudzbina.IdPorudzbina);

                a.Status = porudzbina.Status;
                a.DatumKreiranja = porudzbina.DatumKreiranja;
                a.DatumIsporuke = porudzbina.DatumIsporuke;
                a.Kartica = porudzbina.Kartica;
                a.Kes = porudzbina.Kes;



                s.SaveOrUpdate(a);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiPorudzbinuIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Porudzbina a = s.Load<PICERIJA.Entiteti.Porudzbina>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static PorudzbinaBasic vratiPorudzbinu(int id)
        {
            PorudzbinaBasic a = new PorudzbinaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Porudzbina porudzbina = s.Load<Porudzbina>(id);

                a.IdPorudzbina = porudzbina.Id;
                a.Status = porudzbina.Status;
                a.DatumKreiranja = porudzbina.DatumKreiranja;
                a.DatumIsporuke = porudzbina.DatumIsporuke;
                a.Kartica = porudzbina.Kartica;
                a.Kes = porudzbina.Kes;
               

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return a;

        }

        #endregion


    }

}
