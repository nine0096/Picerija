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
    public partial class DodajAuto : Form
    {

        
        public DodajAuto()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            VoziloAutomobilBasic auto = new VoziloAutomobilBasic();
            
                auto.Proizvodjac = txbProizvodjac.Text;
                auto.NazivTipa = txbNaziv.Text;
                auto.RegBrojA = txbRegistracija.Text;
                auto.BrojDozvoleA = Int32.Parse(txbDozvola.Text);
               
                DTOManager.dodajAutomobil(auto);

                MessageBox.Show("Uspesno ste dodali novo vozilo!");
            //this.Close();
            Vozila forma = new Vozila();
            forma.ShowDialog();
            

        }
    }
}
