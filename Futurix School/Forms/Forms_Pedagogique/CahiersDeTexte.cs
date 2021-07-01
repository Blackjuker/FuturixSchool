using Futurix_School_Prim_En.DAO;
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
    public partial class CahiersDeTexte : Form
    {
        int idU= 0  , idClasse=0, idMatiere=0;
        int idModule = 0;
        public CahiersDeTexte(int idU)
        {
            InitializeComponent();
            this.idU = idU;
            cmbClasse.DataSource = DB.getAllClasseEnseignant(idU);
            cmbClasse.DisplayMember = "Classe";

            idClasse = (cmbClasse.Text.ToString().Length > 0) ? DB.getIdClasse(cmbClasse.Text) : 0;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

        }

        private void chkIsFinish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbModuleTitre_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            idModule = DB.getIdModuleTitre(idClasse, idMatiere, cmbModuleTitre.Text.ToString());

            cmbUA.DataSource = DB.getAllCreatedUABy(idModule);
            cmbUA.DisplayMember = "TITRE";
        }

        private void cmbUA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUE.DataSource = DB.getAllCreatedUEBy(DB.getIdUA(idModule,cmbUA.Text));
            cmbUE.DisplayMember = "TITRE";
        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMatieres.DataSource = DB.getAllMatiereEnseignant(idU, DB.getIdClasse(cmbClasse.Text));
            cmbMatieres.DisplayMember = "Matiere";

             idClasse = (cmbClasse.Text.ToString().Length > 0) ? DB.getIdClasse(cmbClasse.Text) : 0;
             idMatiere = (cmbMatieres.Text.ToString().Length > 0) ? DB.getIdMatiere(cmbMatieres.Text) : 0;

           
        }

        private void cmbMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMatiere = (cmbMatieres.Text.ToString().Length > 0) ? DB.getIdMatiere(cmbMatieres.Text) : 0;
            cmbModuleTitre.DataSource = DB.getAllCreatedModuleByClasseAndMatiere(idMatiere, idClasse);
            cmbModuleTitre.DisplayMember = "TITRE";
        }
    }
}
