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

namespace PICERIJA
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PrvaStranica forma = new PrvaStranica();
            forma.ShowDialog();
        }
    }
}
