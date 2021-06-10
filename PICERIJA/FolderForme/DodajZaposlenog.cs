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
            string poruka = "Da li zelite da izvrsite izmene vozila?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.zaposleni.Ime = txbIme.Text;
                this.zaposleni.Prezime = txbPrezime.Text;
                this.zaposleni.Ulica = txbUlica.Text;
                this.zaposleni.Broj = Int32.Parse(txbBroj.Text);
                this.zaposleni.Grad = txbGrad.Text;
                this.zaposleni.DatumRodjenja = dtDatum.Value;


                DTOManager.izmeniZaposlenog(this.zaposleni);
                MessageBox.Show("Azuriranje vozila je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
