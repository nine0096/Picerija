using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PICERIJA.FolderForme;


namespace PICERIJA.FolderForme
{
    public partial class Automobil : Form
    {
        public Automobil()
        {
            InitializeComponent();
        }

        private void Automobil_Load(object sender, EventArgs e)
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

            List<VoziloAutomobilPregled> listaAuta = DTOManager.vratiSveAutomobile();
            this.listaAutomobila.Items.Clear();

            foreach (VoziloAutomobilPregled p in listaAuta)
            {
                ListViewItem item = new ListViewItem(new string[] { p.VoziloId.ToString(), p.Proizvodjac, p.NazivTipa, p.RegBrojA, p.BrojDozvoleA.ToString() });
                this.listaAutomobila.Items.Add(item);

            }


            this.listaAutomobila.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaAutomobila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite automobil koji zelite da obrisete!");
                return;
            }

            int idAuta = Int32.Parse(listaAutomobila.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati automobil?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAutoIzSistema(idAuta);
                MessageBox.Show("Brisanje vozila je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajAuto forma = new DodajAuto();
            forma.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaAutomobila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo cije podatke zelite da izmenite!");
                return;
            }

            int idAuta = Int32.Parse(listaAutomobila.SelectedItems[0].SubItems[0].Text);
            VoziloAutomobilBasic ob = DTOManager.vratiAutomobil(idAuta);

            IzmeniAuto formaUpdate = new IzmeniAuto(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }
}
