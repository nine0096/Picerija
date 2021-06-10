using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using PICERIJA.Entiteti;

namespace PICERIJA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitajRaspored_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //ucitavaju se podaci o rasporedu sa id-ijem 3
                PICERIJA.Entiteti.Raspored p = s.Load<PICERIJA.Entiteti.Raspored>(3);

                MessageBox.Show(p.Smena);


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajBicikl_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bicikl b = new Bicikl()
                {
                    //Id = 28,
                    Proizvodjac = "AA Bikes",
                    NazivTipa = "City bike",
                    VelicinaRama = "75cm"
                };

                s.Save(b);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajAutomobil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Automobil a = new Automobil()
                {
                    //Id = 28,
                    Proizvodjac = "Fiat",
                    NazivTipa = "Corsa D",
                    RegBrojA = "PI-08734",
                    BrojDozvoleA = 123221
                    
                };

                s.Save(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPoruciPicu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PorucenaPica p = new PorucenaPica();

                p.Naziv = "Fungi";
                p.Cena = 800;
                p.Velicina = "Porodicna";
                p.BonusBodovi = 50;

                p.Sastojci = "pelat, kackavalj, pecurke, feferoni";
                p.PojedinacnaCena = 850;


                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajKupca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Kupac k = new Entiteti.Kupac();

                //Entiteti.Raspored p;

                //p = s.Load<Entiteti.Raspored>(9);
               
                //k.Sifra = 170;
                k.Ime = "Teodora";
                k.Prezime = "Petkovic";
                k.Ulica = "Radin Do";
                k.Broj = 17;
                k.Grad = "Pirot";
                k.Drzava = "Srbija";
                k.Email = "tea@gmail.com";
                k.BrojTelefona = 0693160313;

                s.Save(k);
                //s.SaveOrUpdate(k);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                Entiteti.Zaposleni d = new Entiteti.Zaposleni()
                {
                    Sifra = 120,
                    Ime = "Marija",
                    Prezime = "Maric",
                    Ulica = "Kralja Petra",
                    Broj = 5,
                    Grad = "Pirot",
                    Drzava = "Srbija",
                    Jmbg = 1212975737538,
                    DatumRodjenja = new DateTime(1975, 12, 12),
                    TipZaposlenog = "Dostavljac",
                    Vozacka = "Da"
                    
                };

                s.Save(d);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void cmdDodajSkuter_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Skuter sk = new Skuter()
                {
                    //Id = 28,
                    Proizvodjac = "Fiat",
                    NazivTipa = "skuter",
                    RegBrojS = "S-08734",
                    BrojDozvoleS = 12322

                };

                s.Save(sk);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManyToOne_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Porudzbina p = s.Load<Porudzbina>(3);
                MessageBox.Show(p.Status);

                MessageBox.Show(p.PripadaKupcu.Ime);

                MessageBox.Show(p.Status);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdmany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PICERIJA.Entiteti.Kupac k = s.Load<PICERIJA.Entiteti.Kupac>(2);

                foreach (Porudzbina p in k.Porudzbine)
                {
                    MessageBox.Show(p.Status + " " + "porudzbina");
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
