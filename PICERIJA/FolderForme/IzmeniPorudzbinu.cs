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
    public partial class IzmeniPorudzbinu : Form
    {
        public PorudzbinaBasic porudzbina;
        public IzmeniPorudzbinu()
        {
            InitializeComponent();
        }

        public IzmeniPorudzbinu(PorudzbinaBasic p)
        {
            InitializeComponent();
            this.porudzbina = p;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene porudzbine?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.porudzbina.Status = txbStatus.Text;
                this.porudzbina.DatumKreiranja = dtKreirana.Value;
                this.porudzbina.DatumIsporuke = dtIsporucena.Value;
                this.porudzbina.Kartica = txbKartica.Text;
                this.porudzbina.Kes = txbKes.Text;



                DTOManager.izmeniPorudzbinu(this.porudzbina);
                MessageBox.Show("Azuriranje porudzbine je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
