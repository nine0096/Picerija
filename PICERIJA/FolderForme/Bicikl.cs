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
    public partial class Bicikl : Form
    {
        public Bicikl()
        {
            InitializeComponent();
        }


        private void Bicikl_Load(object sender, EventArgs e)
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

            this.listaBicikala.Items.Clear();
            List<VoziloBiciklPregled> podaci = DTOManager.vratiSveBicikle();

            foreach (VoziloBiciklPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.VoziloId.ToString(), p.Proizvodjac, p.NazivTipa, p.Ram });
                listaBicikala.Items.Add(item);
            }

            this.listaBicikala.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaBicikala.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo cije podatke zelite da izmenite!");
                return;
            }

            int idB = Int32.Parse(listaBicikala.SelectedItems[0].SubItems[0].Text);
            VoziloBiciklBasic ob = DTOManager.vratiBicikl(idB);

            IzmeniBicikl formaUpdate = new IzmeniBicikl(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajBicikl forma = new DodajBicikl();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaBicikala.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite bicikl koji zelite da obrisete!");
                return;
            }

            int idB = Int32.Parse(listaBicikala.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati bicikl?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiBiciklIzSistema(idB);
                MessageBox.Show("Brisanje bicikla je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
