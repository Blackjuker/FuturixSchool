using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futurix_School_Prim_En.Forms.Forms_Pedagogique
{
    public partial class MainEnseignant : Form
    {
        private int idU = 0;
        public MainEnseignant(int idU)
        {
            InitializeComponent();
            this.idU = idU;
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            Titre_Module titre_Module = new Titre_Module(idU);
            this.Hide();
            titre_Module.ShowDialog();
            this.Show();

        }

        private void btnCahiersDeText_Click(object sender, EventArgs e)
        {
            CahiersDeTexte cahiersDeTexte = new CahiersDeTexte(idU);
            this.Hide();
            cahiersDeTexte.ShowDialog();
            this.Show();
        }
    }
}
