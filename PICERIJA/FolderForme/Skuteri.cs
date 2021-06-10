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
    public partial class Skuteri : Form
    {
        public Skuteri()
        {
            InitializeComponent();
        }

        private void Skuteri_Load(object sender, EventArgs e)
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
            this.listaskutera.Items.Clear();
            List<VoziloSkuterPregled> listaSkutera = DTOManager.vratiSveSkutere();
           

            foreach (VoziloSkuterPregled p in listaSkutera)
            {
                ListViewItem item = new ListViewItem(new string[] { p.VoziloId.ToString(), p.Proizvodjac, p.NazivTipa, p.RegBrojS, p.BrojDozvoleS.ToString() });
                listaskutera.Items.Add(item);

            }


            this.listaskutera.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaskutera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite skuter koji zelite da obrisete!");
                return;
            }

            int idSkutera = Int32.Parse(listaskutera.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati skuter?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSkuterIzSistema(idSkutera);
                MessageBox.Show("Brisanje vozila je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaskutera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo cije podatke zelite da izmenite!");
                return;
            }

            int idSkutera = Int32.Parse(listaskutera.SelectedItems[0].SubItems[0].Text);
            VoziloSkuterBasic ob = DTOManager.vratiSkuter(idSkutera);

            IzmeniSkuter formaUpdate = new IzmeniSkuter(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajSkuter forma = new DodajSkuter();
            forma.ShowDialog();
        }
    }
}
