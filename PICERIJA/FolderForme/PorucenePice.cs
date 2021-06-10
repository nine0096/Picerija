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
    public partial class PorucenePice : Form
    {
        public PorucenePice()
        {
            InitializeComponent();
        }

        private void PorucenePice_Load(object sender, EventArgs e)
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

            List<PorucenaPicaPregled> listaPica = DTOManager.vratiSvePorucenePice();
            this.porPice.Items.Clear();

            foreach (PorucenaPicaPregled p in listaPica)
            {
                ListViewItem item = new ListViewItem(new string[] { p.IdPica.ToString(), p.Naziv, p.Cena.ToString(), p.Velicina, p.BonusBodovi.ToString(), p.Sastojci, p.PojedinacnaCena.ToString() });
                this.porPice.Items.Add(item);

            }


            this.porPice.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (porPice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite picu koji zelite da obrisete!");
                return;
            }

            int idPice = Int32.Parse(porPice.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati picu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPorucenuPicuIzSistema(idPice);
                MessageBox.Show("Brisanje pice je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnPorudzbine_Click(object sender, EventArgs e)
        {
            Porudzbine forma = new Porudzbine();
            forma.ShowDialog();
        }
    }
}
