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
    public partial class FicheEnseignant : Form
    {
        private int idU=0;
        public FicheEnseignant(int idU)
        {
            InitializeComponent();
            this.idU = idU;
            cmbNiveau.DataSource = DB.getAllFonction();
            cmbNiveau.DisplayMember = "FONCTION";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            EAdmin eAdmin = new EAdmin();
            eAdmin.nom = txtNom.TextName;
            eAdmin.prenom = txtPrenom.TextName;
            eAdmin.sexe = (cmbSexe.Text.Length > 0) ? cmbSexe.Text : "H";
            eAdmin.niveau= (cmbNiveau.Text.Length > 0) ? DB.getRoleUser(cmbNiveau.Text) : 0;
            eAdmin.telephone = txtTel.TextName;
            eAdmin.username = txtUsername.TextName;
            eAdmin.password = txtPassword.TextName;
            eAdmin.idUser = idU;

            DB.createAdministrators(eAdmin);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
