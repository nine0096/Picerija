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
    public partial class Zaposleni : Form
    {
        public Zaposleni()
        {
            InitializeComponent();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

            if (listaZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog cije podatke zelite da izmenite!");
                return;
            }

            int idB = Int32.Parse(listaZaposleni.SelectedItems[0].SubItems[0].Text);
            ZaposleniBasic ob = DTOManager.vratiZaposlenog(idB);

            IzmeniZaposlenog formaUpdate = new IzmeniZaposlenog(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenog forma = new DodajZaposlenog();
            forma.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite radnika kog zelite da obrisete!");
                return;
            }

            int idZ = Int32.Parse(listaZaposleni.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati radnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiZaposlenogIzSistema(idZ);
                MessageBox.Show("Brisanje radnika je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void Zaposleni_Load(object sender, EventArgs e)
        {
            try
            {
                popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public void popuniPodacima()
        {

            List<ZaposleniPregled> listaRadnika = DTOManager.vratiSveZaposlene();
            this.listaZaposleni.Items.Clear();

            foreach (ZaposleniPregled p in listaRadnika)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Sifra.ToString(), p.Ime, p.Prezime, p.Ulica, p.Broj.ToString(), p.Grad, p.Drzava, p.Jmbg.ToString(), p.DatumRodjenja.ToString(), p.TipZaposlenog, p.Vozacka });
                this.listaZaposleni.Items.Add(item);

            }


            this.listaZaposleni.Refresh();
        }


    }
}
