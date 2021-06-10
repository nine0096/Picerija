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
    public partial class PrvaStranica : Form
    {
        public PrvaStranica()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vozila forma = new Vozila();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pice forma = new Pice();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zaposleni forma = new Zaposleni();
            forma.ShowDialog();
        }

        private void btnKupci_Click(object sender, EventArgs e)
        {
            Kupci forma = new Kupci();
            forma.ShowDialog();
        }
    }
}
