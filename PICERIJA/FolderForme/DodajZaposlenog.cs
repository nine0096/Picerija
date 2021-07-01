using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICERIJA.FolderForme
{
    public partial class DodajZaposlenog : Form
    {
        public ZaposleniBasic zaposleni;
        public DodajZaposlenog()
        {
            InitializeComponent();
        }

        public DodajZaposlenog(ZaposleniBasic p)
        {
            InitializeComponent();
            this.zaposleni = p;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZaposleniBasic radnik = new ZaposleniBasic();

            radnik.Ime = txbIme.Text;
            radnik.Prezime = txbPrezime.Text;
            radnik.Ulica = txbUlica.Text;
            radnik.Broj = Int32.Parse(txbBroj.Text);
            radnik.Grad = txbGrad.Text;
            radnik.Drzava = txbDrzava.Text;
            radnik.Jmbg = Int32.Parse(txbJMBG.Text);
            radnik.DatumRodjenja = dDatum.Value;
            radnik.TipZaposlenog = txbTip.Text;
            radnik.Vozacka = txbVozacka.Text;

            DTOManager.dodajZaposlenog(radnik);

            MessageBox.Show("Uspesno ste dodali novog radnika!");
            //this.Close();
            PrvaStranica forma = new PrvaStranica();
            forma.ShowDialog();
        }
    }
}
