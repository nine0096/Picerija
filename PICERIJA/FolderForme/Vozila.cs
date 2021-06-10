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
    public partial class Vozila : Form
    {
        public Vozila()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Automobil forma = new Automobil();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Skuteri forma = new Skuteri();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bicikl forma = new Bicikl();
            forma.ShowDialog();
        }
    }
}
