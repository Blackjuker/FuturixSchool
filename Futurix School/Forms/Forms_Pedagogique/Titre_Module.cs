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

namespace Futurix_School_Prim_En.Forms.Forms_Pedagogique
{
    public partial class Titre_Module : Form
    {
        int idU = 0;
        public Titre_Module(int idU)
        {
            InitializeComponent();
            this.idU = idU;
            

            cmbClasse.DataSource = DB.getAllClasseEnseignant(idU);
            cmbClasse.DisplayMember = "Classe";

            




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            ETitreModule eTitreModule = new ETitreModule();


            eTitreModule.idClasse = (cmbClasse.Text.ToString().Length > 0) ? DB.getIdClasse(cmbClasse.Text) : 0;
            eTitreModule.idMatiere = (cmbMatieres.Text.ToString().Length > 0) ? DB.getIdMatiere(cmbMatieres.Text) : 0;
            eTitreModule.idUser = idU;
            eTitreModule.nbreHeure = (txtNbreHeure.Text.ToString().Length > 0) ? Convert.ToInt32(txtNbreHeure.Text) : 0;
            eTitreModule.nbreUA = (txtUA.Text.ToString().Length > 0) ? Convert.ToInt32(txtUA.Text) : 0;
            eTitreModule.titreModule = (txtTitreModule.Text.ToString().Length > 0) ? txtTitreModule.Text :  " "  ;

            if (eTitreModule.idClasse>0||eTitreModule.idMatiere>0||eTitreModule.nbreHeure>0 || eTitreModule.titreModule.Length > 0)
            {
                DB.createModuleMatieres(eTitreModule);
                gridListeModules.DataSource = DB.getAllCreatedModuleByClasseAndMatiere(eTitreModule.idMatiere, eTitreModule.idClasse);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs!!!");
            }

        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMatieres.DataSource = DB.getAllMatiereEnseignant(idU, DB.getIdClasse(cmbClasse.Text));
            cmbMatieres.DisplayMember = "Matiere";

            int idClasse = (cmbClasse.Text.ToString().Length > 0) ? DB.getIdClasse(cmbClasse.Text) : 0;
            int idMatiere = (cmbMatieres.Text.ToString().Length > 0) ? DB.getIdMatiere(cmbMatieres.Text) : 0;

            gridListeModules.DataSource = DB.getAllCreatedModuleByClasseAndMatiere(idMatiere, idClasse);

        }

        private void cmbMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idClasse = (cmbClasse.Text.ToString().Length > 0) ? DB.getIdClasse(cmbClasse.Text) : 0;
            int idMatiere = (cmbMatieres.Text.ToString().Length > 0) ? DB.getIdMatiere(cmbMatieres.Text) : 0;

            gridListeModules.DataSource = DB.getAllCreatedModuleByClasseAndMatiere(idMatiere, idClasse);
        }

        private void gridListeModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < gridListeModules.Rows.Count && e.RowIndex > -1)
            {
                int idModule = 0;
                idModule = Convert.ToInt32(gridListeModules.Rows[e.RowIndex].Cells[0].Value.ToString());
                string titre = "";
                titre = gridListeModules.Rows[e.RowIndex].Cells[1].Value.ToString();
                Titre_UA titre_UA = new Titre_UA(idU, idModule, titre);
                this.Hide();
                titre_UA.ShowDialog();
                this.Show();
            }
        }
    }
}
