using Futurix_School_Prim_En.DAO;
using Futurix_School_Prim_En.Entite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futurix_School_Prim_En.Forms
{
    public partial class Niveau : Form
    {
        private string titreCombo;
        private int idUser;
        public Niveau(int v)
        {
            InitializeComponent();
            idUser = v;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Niveau_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet2.niveau'. Vous pouvez la déplacer ou la supprimer selon les besoins.
     //       this.niveauTableAdapter.Fill(this.open_schoolDataSet2.niveau);
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet.cycle'. Vous pouvez la déplacer ou la supprimer selon les besoins.
    //        this.cycleTableAdapter.Fill(this.open_schoolDataSet.cycle);
          

        }

        private void comboCycle_SelectedIndexChanged(object sender, EventArgs e)
        {
            titreCombo = comboCycle.Text.Trim();
           // MessageBox.Show(comboCycle.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ENiveau niv = new ENiveau();

            niv.designation = txtNiveau.TextName.Trim();
            niv.idUser = idUser;
            titreCombo = comboCycle.Text.Trim();
            DB.createNiveau(niv, titreCombo);

            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet2.niveau'. Vous pouvez la déplacer ou la supprimer selon les besoins.
         //   this.niveauTableAdapter.Fill(this.open_schoolDataSet2.niveau);
        }

        private void niveauGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
