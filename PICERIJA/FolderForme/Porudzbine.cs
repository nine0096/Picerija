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
    public partial class Porudzbine : Form
    {
        public Porudzbine()
        {
            InitializeComponent();
        }

        private void Porudzbine_Load(object sender, EventArgs e)
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

            List<PorudzbinaPregled> listaPOR = DTOManager.vratiSvePorudzbine();
            this.listaPorudzbina.Items.Clear();

            foreach (PorudzbinaPregled p in listaPOR)
            {
                ListViewItem item = new ListViewItem(new string[] { p.IdPorudzbina.ToString(), p.Status, p.DatumKreiranja.ToString(), p.DatumIsporuke.ToString(), p.Kartica, p.Kes });
                this.listaPorudzbina.Items.Add(item);

            }

            this.listaPorudzbina.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaPorudzbina.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite porudzbinu koji zelite da obrisete!");
                return;
            }

            int idAuta = Int32.Parse(listaPorudzbina.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati porudzbinu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPorudzbinuIzSistema(idAuta);
                MessageBox.Show("Brisanje porudzbine je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaPorudzbina.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite porudzbinu cije podatke zelite da izmenite!");
                return;
            }

            int idPor = Int32.Parse(listaPorudzbina.SelectedItems[0].SubItems[0].Text);
            PorudzbinaBasic ob = DTOManager.vratiPorudzbinu(idPor);

            IzmeniPorudzbinu formaUpdate = new IzmeniPorudzbinu(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    
    }
}
