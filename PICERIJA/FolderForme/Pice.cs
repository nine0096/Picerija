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
    public partial class Pice : Form
    {
        public Pice()
        {
            InitializeComponent();
        }

        private void Pice_Load(object sender, EventArgs e)
        {
            try { 
                
                popuniPodacima(); 
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public void popuniPodacima()
        {
           

            List<PicaPregled> listaPica = DTOManager.vratiSvePice();
            this.listapica.Items.Clear();

            foreach (PicaPregled p in listaPica)
            {
                ListViewItem item = new ListViewItem(new string[] { p.IdPica.ToString(), p.Naziv, p.Cena.ToString(), p.Velicina, p.BonusBodovi.ToString() });
                this.listapica.Items.Add(item);
               
            }

           
            this.listapica.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listapica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite picu koju zelite da obrisete!");
                return;
            }

            int idPice = Int32.Parse(listapica.SelectedItems[0].SubItems[0].Text);
            string poruka = "Obrisati picu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPicuIzSistema(idPice);
                MessageBox.Show("Brisanje pice je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnPorudzbine_Click(object sender, EventArgs e)
        {
            PorucenePice forma = new PorucenePice();
            forma.ShowDialog();
        }
    }
}
