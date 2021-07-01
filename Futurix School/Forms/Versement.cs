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
    public partial class Versement : Form
    {
        string Nom, Prenom, Classe, Pension, Montant, Matricule;
        int idUser, idClasse;
        Form f;
        private void btnSave_Click(object sender, EventArgs e)
        {
            EVersement eVersement = new EVersement();
            eVersement.matricule = Matricule;
            eVersement.idClasse = idClasse;
            eVersement.dateV = lblDateVersement.Text;
            eVersement.idUser = idUser;
            //eVersement.montant = Convert.ToInt32(txtMontant.Text) + Convert.ToInt32(soldeEleve.Text);
            eVersement.montant = Convert.ToInt32(txtMontant.Text);
            eVersement.motif = cmbMotif.Text;


            if (DB.versementP(eVersement) == 1)
            {

                EtatImp.factureInscription(Matricule, lblDateVersement.Text, Convert.ToString(DB.getNumeroFacture()), Classe, Nom, Prenom, DB.getNomUser(idUser), txtMontant.Text, lblReste.Text);
                eVersement = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur d'enregistrement de versement");
            }
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            int montant;
            try
            {
                if (txtMontant.Text.Length < 1)
                {

                    montant = 0;
                }
                else
                {
                    montant = Convert.ToInt32(txtMontant.Text);
                }


                lblReste.Text = Convert.ToString(Convert.ToInt32(pensionApayer.Text) - (Convert.ToInt32(soldeEleve.Text) + montant)) + " CFA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erreur de Saisie (Valeur Numérique Uniquement)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                montant = 0;
            }
        }

        private void Versement_Load(object sender, EventArgs e)
        {

        }

        private void checkCravate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCravate.Checked)
            {
                DB.updateCravate(1, Matricule);
            }
            else
            {
                DB.updateCravate(0, Matricule);
            }
        }

        private void checkEcusson_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEcusson.Checked)
            {
                DB.updateEcusson(1, Matricule);
            }
            else
            {
                DB.updateEcusson(0, Matricule);
            }
        }

        private void checkPullOver_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPullOver.Checked)
            {
                DB.updatePullOver(1, Matricule);
            }
            else
            {
                DB.updatePullOver(0, Matricule);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }

        int idU;
        public Versement()
        {
            InitializeComponent();
        }
        public Versement(int v)
        {
            InitializeComponent();
            this.idUser = v;
        }

        public Versement(string matricule, int idU)
        {
            InitializeComponent();
            this.Matricule = matricule;
            this.idUser = idU;
        }
        public Versement(string matricule, string nom, string prenom, string classe, int idu, Form form)
        {
            InitializeComponent();
            f = form;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Classe = classe;
            this.Matricule = matricule;
            this.idUser = idu;
            idClasse = DB.getIdClasseFromEleve(matricule);
            lblMatricule.Text = matricule;
            lblNom.Text = Nom;
            lblPrenom.Text = Prenom;
            pensionApayer.Text = DB.getPensionParClasse(idClasse);



            soldeEleve.Text = Convert.ToString(DB.getSoldeEleve(matricule));


            lblReste.Text = Convert.ToString(Convert.ToInt32(pensionApayer.Text) - (Convert.ToInt32(soldeEleve.Text))) + " CFA";


        }



    }
}
