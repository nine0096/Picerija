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
    public partial class DodajSkuter : Form
    {
        public DodajSkuter()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            VoziloSkuterBasic skuter = new VoziloSkuterBasic();

            skuter.Proizvodjac = txbProizvodjac.Text;
            skuter.NazivTipa = txbNaziv.Text;
            skuter.RegBrojS = txbRegistracija.Text;
            skuter.BrojDozvoleS = Int32.Parse(txbDozvola.Text);

            DTOManager.dodajSkuter(skuter);

            MessageBox.Show("Uspesno ste dodali novo vozilo!");
            //this.Close();
            Vozila forma = new Vozila();
            forma.ShowDialog();
        }
    }
}
