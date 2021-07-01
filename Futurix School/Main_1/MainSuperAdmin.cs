using Futurix_School_Prim_En.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futurix_School_Prim_En.Main_1
{
    public partial class MainSuperAdmin : Form
    {
        int idUser;
        public MainSuperAdmin(int u)
        {
            InitializeComponent();
            this.idUser = u;
        }

        private void btnCompta_Click(object sender, EventArgs e)
        {
            MainNiveau1 mainNiveau1 = new MainNiveau1(idUser);
            this.Hide();
            mainNiveau1.ShowDialog();
            this.Show();
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            MainParametre mainParametre = new MainParametre(idUser);
            this.Hide();
            mainParametre.ShowDialog();
            this.Show();
        }

        private void label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FicheEnseignant ficheEnseignant = new FicheEnseignant(idUser);
            this.Hide();
            ficheEnseignant.ShowDialog();
            this.Show();
        }

        private void attribClasse_Click(object sender, EventArgs e)
        {
            attributionMatiereEnseignant matiereEnseignant = new attributionMatiereEnseignant(idUser);
            this.Hide();
            matiereEnseignant.ShowDialog();
            this.Show();
        }
    }
}
