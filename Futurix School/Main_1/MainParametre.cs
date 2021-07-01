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
    public partial class MainParametre : Form
    {
        int idUser;
        public MainParametre(int u)
        {
            InitializeComponent();
            this.idUser = u;
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            Cycle cycle = new Cycle(idUser);
            this.Hide();
            cycle.ShowDialog();
            this.Show();
        }

        private void btnNiveau_Click(object sender, EventArgs e)
        {
            Niveau niveau = new Niveau(idUser);
            this.Hide();
            niveau.ShowDialog();
            this.Show();
        }

        private void btnSerie_Click(object sender, EventArgs e)
        {
            Serie serie = new Serie(idUser);
            this.Hide();
            serie.ShowDialog();
            this.Show();
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            Classe classe = new Classe(idUser);
            this.Hide();
            classe.ShowDialog();
            this.Show();
        }

        private void btnPension_Click(object sender, EventArgs e)
        {
            Pension pension = new Pension(idUser);
            this.Hide();
            pension.ShowDialog();
            this.Show();
        }

        private void btnTranche_Click(object sender, EventArgs e)
        {
            Tranche tranche = new Tranche(idUser);
            this.Hide();
            tranche.ShowDialog();
            this.Show();
        }

        private void label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMatiere_Click(object sender, EventArgs e)
        {
            Matiere FenMatiere = new Matiere(idUser);
            this.Hide();
            FenMatiere.ShowDialog();
            this.Show();
        }
    }
}
