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
    public partial class IzmeniZaposlenog : Form
    {
        public ZaposleniBasic zaposleni;
        public IzmeniZaposlenog()
        {
            InitializeComponent();
        }

        public IzmeniZaposlenog(ZaposleniBasic p)
        {
            InitializeComponent();
            this.zaposleni = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene zaposlenog?";
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
                MessageBox.Show("Azuriranje zaposlenog je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
