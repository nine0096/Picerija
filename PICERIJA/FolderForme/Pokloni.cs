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
    public partial class Pokloni : Form
    {
        public Pokloni()
        {
            InitializeComponent();
        }

        private void Pokloni_Load(object sender, EventArgs e)
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

            List<PoklonPregled> listaPoklona = DTOManager.vratiSvePoklone();
            this.listaPokloni.Items.Clear();

            foreach (PoklonPregled p in listaPoklona)
            {
                ListViewItem item = new ListViewItem(new string[] { p.IdPoklon.ToString(), p.DatumDodelePoklona.ToString(), p.DatumIskoriscenjaPoklona.ToString(), p.Tip, p.BrojBodova.ToString() });
                this.listaPokloni.Items.Add(item);

            }


            this.listaPokloni.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaPokloni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite poklon koji zelite da obrisete!");
                return;
            }

            int idPoklona = Int32.Parse(listaPokloni.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati poklon?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPoklonIzSistema(idPoklona);
                MessageBox.Show("Brisanje poklona je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
