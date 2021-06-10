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
    public partial class Kupci : Form
    {
        public Kupci()
        {
            InitializeComponent();
        }

        private void btnPokloni_Click(object sender, EventArgs e)
        {
            Pokloni forma = new Pokloni();
            forma.ShowDialog();
        }

        private void Kupci_Load(object sender, EventArgs e)
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

            List<KupacPregled> listaKupaca = DTOManager.vratiSveKupce();
            this.listaKupci.Items.Clear();

            foreach (KupacPregled p in listaKupaca)
            {
                ListViewItem item = new ListViewItem(new string[] { p.SifraKupac.ToString(), p.Ime, p.Prezime, p.Ulica, p.Broj.ToString(), p.Grad, p.Drzava, p.Email, p.BrojTelefona.ToString() });
                this.listaKupci.Items.Add(item);

            }


            this.listaKupci.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaKupci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kupca kog zelite da obrisete!");
                return;
            }

            int idKupac = Int32.Parse(listaKupci.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati kupca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAutoIzSistema(idKupac);
                MessageBox.Show("Brisanje kupca je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
