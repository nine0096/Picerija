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
    public partial class IzmeniBicikl : Form
    {
        public VoziloBiciklBasic vozilo;
        public IzmeniBicikl()
        {
            InitializeComponent();
        }

        public IzmeniBicikl(VoziloBiciklBasic p)
        {
            InitializeComponent();
            this.vozilo = p;
        }

        private void btnIzmeniBicikl_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene vozila?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.vozilo.Proizvodjac = txbProizvodjac.Text;
                this.vozilo.NazivTipa = txbNaziv.Text;
                this.vozilo.Ram = txbRam.Text;
               


                DTOManager.izmeniBicikl(this.vozilo);
                MessageBox.Show("Azuriranje vozila je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
