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
    public partial class Eleve : Form
    {
        private int idU;
        private int idClasseEleve = 0;
        public Eleve(int v)
        {
            InitializeComponent();
            txtMatricule.Text = "CF0"+v+DB.getAllCountEleve();
            this.idU = v;

            //remplir les cycles
            metroComboBox1.DataSource = DB.fillCycle();
            metroComboBox1.DisplayMember = "DESIGNATION";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eleve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet1.cycle'. Vous pouvez la déplacer ou la supprimer selon les besoins.
         //   this.cycleTableAdapter1.Fill(this.open_schoolDataSet1.cycle);
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet.cycle'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        //    this.cycleTableAdapter.Fill(this.open_schoolDataSet.cycle);

        }

        //cycle
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboNiveau.DataSource = DB.fillNiveauByCycle(DB.getIdCycle(metroComboBox1.Text));
            comboNiveau.DisplayMember = "DESIGNATION";
        }

        private void comboNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboClasse.DataSource = DB.fillClasseByNiveau(DB.getIdNiveau(comboNiveau.Text));
            comboClasse.DisplayMember = "DESIGNATION";
        }

        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            idClasseEleve = DB.getIdClasseInscription(comboClasse.Text, maxClasse, actuClasse);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string matricule = txtMatricule.Text.Trim();

           // MessageBox.Show(matricule);

            /**
             * Enregistrement Eleve
             * */
            EEleve eleve = new EEleve();

            eleve.matricule = matricule;
            eleve.nom = txtNom.TextName.Trim();
            eleve.prenom = txtPrenom.TextName.Trim();
            eleve.nationalite = txtNationalite.TextName.Trim();
            eleve.lieuNaissance = txtLieuNais.TextName.Trim();
            eleve.apte = mtrcomboApte.Text.Trim();
            eleve.nomAncienEcole = txtNomAncienneEcole.TextName.Trim();
            eleve.nomMaladif = txtNomMaladie.TextName.Trim();
            eleve.idClasse = DB.getIdClasse(comboClasse.Text.Trim());
            eleve.nomAncienEcole = txtNomAncienneEcole.TextName.Trim();
            eleve.noteAncienne = Convert.ToInt32(txtNotePred.TextName.Trim());
            eleve.genre = metroGenre.Text.Trim();
            eleve.redoublant = comboRedoublant.Text.Trim();
            eleve.iduser = idU;


            



            /**
             * Enregistrement pere
             * 
             **/
            EParent pere = new EParent();
            pere.nomPere = txtNomPere.TextName.Trim();
            pere.prenomPere = txtNomPere.TextName.Trim();
            pere.profession = txtNomPere.TextName.Trim();
            pere.telephone_p = txtNomPere.TextName.Trim();
            pere.telephone_f = txtNomPere.TextName.Trim();
            pere.enCharge = 0;
            pere.role = "père";
            pere.matriculeEnfant = matricule;
         

            /**
             * Enregistrement mere
             * 
             **/
            EParent mere=new EParent();
            mere.nomPere = txtNomPere.TextName.Trim();
            mere.prenomPere = txtNomPere.TextName.Trim();
            mere.profession = txtNomPere.TextName.Trim();
            mere.telephone_p = txtNomPere.TextName.Trim();
            mere.telephone_f = txtNomPere.TextName.Trim();
            mere.role = "mere";
            mere.enCharge = 0;
            mere.matriculeEnfant = matricule;


            EParent tuteur = new EParent();

            if (cmbParentCharge.SelectedText == "Tuteur") {
            /**
             * Enregistrement tuteur
             * 
             **/
           
            tuteur.nomPere = txtNomPere.TextName.Trim();
            tuteur.prenomPere = txtNomPere.TextName.Trim();
            tuteur.profession = txtNomPere.TextName.Trim();
            tuteur.telephone_p =txtNomPere.TextName.Trim();
            tuteur.telephone_f = txtNomPere.TextName.Trim();
                tuteur.role = "tuteur";
                tuteur.enCharge = 0;
            tuteur.matriculeEnfant = matricule;
                DB.createParent(tuteur, "Tuteur");

            }


            /**
             * parent en charge
             * */
            switch (cmbParentCharge.Text.Trim())
            {
                case "Pere":
                    pere.enCharge = 1;
                    break;
                case "Mere":
                    mere.enCharge = 1;
                    break;
                case "Tuteur":
                    tuteur.enCharge = 1;
                    break;
                default:
                    pere.enCharge = 1;
                    break;
            }



            /**
             * Validation des parametres
             * */
          DB.createParent(pere,"pere");
            
          DB.createParent(mere,"mere");


            /*
             * Creation eleve
             * */
            DB.createEleve(eleve);

            Versement versement = new Versement(eleve.matricule, eleve.nom, eleve.prenom, comboClasse.Text.Trim(), idU,this) ;
            versement.ShowDialog();

            /**

             * reinitialiser la fenetre
             * */
            this.Close();


        }
    }
}
