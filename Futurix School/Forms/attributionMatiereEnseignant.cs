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
    public partial class attributionMatiereEnseignant : Form
    {
        int idU=0, idAgent=0,idClasse;
        
        public attributionMatiereEnseignant(int idU)
        {
            InitializeComponent();
            this.idU = idU;

            cmbRolesAdmin.DataSource = DB.getAllFonction();
            cmbRolesAdmin.DisplayMember = "FONCTION";

            cmbClasse.DataSource = DB.getAllClasse();
            cmbClasse.DisplayMember = "CLASSE";

            
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMatiere.Enabled = true;

            idClasse = DB.getIdClasse(cmbClasse.Text);
            cmbMatiere.DataSource = DB.getMatieresParClasse(idClasse);
            cmbMatiere.DisplayMember = "matieres";

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmbEnseignant_SelectedIndexChanged(object sender, EventArgs e)
        {
          // MessageBox.Show(cmbEnseignant.)
        }

        private void cmbRolesAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

            idAgent = DB.getRoleUser(cmbRolesAdmin.Text.ToString());
            cmbEnseignant.Enabled = true;

            cmbEnseignant.DataSource = DB.getAllEnseignantByRole(idAgent);
            cmbEnseignant.DisplayMember = "nomPrenom";
        }
    }
}
