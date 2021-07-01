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

namespace Futurix_School_Prim_En
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            EEtablissement etablissement = new EEtablissement();

            etablissement.nom = txtNom.TextName.Trim();
            etablissement.noAutorisation = txtAutorisation.TextName.Trim();
            etablissement.statut = Convert.ToInt32(txtStatut.TextName.Trim());
            etablissement.capacite = Convert.ToInt32(txtCapacite.TextName.Trim());
            etablissement.adresse = txtAdresse.TextName.Trim();
            etablissement.codePostal = txtCodePostal.TextName.Trim();
            etablissement.siteWeb = txtSiteWeb.TextName.Trim();
            etablissement.telephone = txtTelephone.TextName.Trim();
            etablissement.pays = txtPays.TextName.Trim();
            etablissement.ville = txtVille.TextName.Trim();
            etablissement.description = txtDescription.Text.Trim();
            etablissement.image = "sdfs";

            DB db = new DB();

            db.createEtablissement(etablissement);
           
        }
    }
}
