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
    public partial class InsolvableListe : Form
    {
        int idClasse,idNiveau,pensionClasse,countEleveParClasse,idPension;

        public InsolvableListe()
        {
            InitializeComponent();

            idClasse = DB.getIdClasse(comboClasse.Text);

            countEleveParClasse = DB.getAllNumberEleveParClasse(idClasse);
            lblNombreEleve.Text = countEleveParClasse.ToString();
            // cmbTranche.DataSource = DB.getAllTranche();

            //Tranche déjà verser 
           // lblTotalCompte.Text = compteurSomme(mGridInsolvable, 3);
        }

        private void cmbTranche_SelectedIndexChanged(object sender, EventArgs e)
        {
            mGridInsolvable.DataSource = DB.getAllInsolvableByTranche(idClasse, cmbTranche.Text,idPension);
            //Tranche déjà verser 
            lblTotalCompte.Text = compteurSomme(mGridInsolvable, 3);
            montantManquant.Text = compteurSomme(mGridInsolvable, 4);

            lblTotalVerserT.Text = "Total Versement " + cmbTranche.Text + " :";

            lblTotalTrancheAVerser.Text = "Total " + cmbTranche.Text + " à Verser :";
        }

        private void btnPrintInsolvable_Click(object sender, EventArgs e)
        {
            List<EInsolvable> eInsolvables = new List<EInsolvable>();

            eInsolvables = getAllEleveInsolvable(mGridInsolvable);

            // MessageBox.Show(eInsolvables.Count.ToString());

            EtatImp.Solvabilite(eInsolvables, comboClasse.Text, cmbTranche.Text, lblNombreEleve.Text, TotalVerser.Text, montantManquant.Text) ;
        }

        private void InsolvableListe_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSetClasse.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //   this.classeTableAdapter.Fill(this.open_schoolDataSetClasse.classe);
            comboClasse.DataSource = DB.fillClasse();
            comboClasse.DisplayMember = "DESIGNATION";
            label3.Text = "Total Pension " + comboClasse.Text + " :";

            lblTotalVerserT.Text = "Total Versement " + cmbTranche.Text + " :";
            lblTotalTrancheAVerser.Text = "Total " + cmbTranche.Text + " à Verser :";
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            idClasse = DB.getIdClasse(comboClasse.Text);

            label3.Text = "Total Pension " + comboClasse.Text+" :";
            countEleveParClasse = DB.getAllNumberEleveParClasse(idClasse);

            idNiveau = DB.getIdNiveauFromClasse(idClasse);

            pensionClasse = Convert.ToInt32(DB.getPensionParClasse(idClasse));

            idPension = DB.getIdPensionParNiveau(idNiveau);

            lblNombreEleve.Text = countEleveParClasse.ToString();

            cmbTranche.DataSource = DB.getLibelleTrancheFromPension(idPension);
            cmbTranche.DisplayMember = "DESIGNATION";

            TotalVerser.Text = Convert.ToString((pensionClasse * countEleveParClasse )+ " FCFA");

            lblTotalCompte.Text = Convert.ToString(DB.getTotalCompteParClasse(idClasse));

            //Tranche déjà verser 
            lblTotalCompte.Text = compteurSomme(mGridInsolvable, 3);

            //Tranche à verser
            montantManquant.Text = compteurSomme(mGridInsolvable, 4);

            //  MessageBox.Show(Convert.ToString(DB.getTotalCompteParClasse(idClasse)));
        }

        private string compteurSomme(DataGridView dataGrid,int index)
        {
            string compteur = null;
            int count = 0;
            
            if (dataGrid.Rows.Count > 0)
            {
                for (int counter = 0; counter < dataGrid.Rows.Count - 1; counter++)
                {
                    count += Convert.ToInt32(dataGrid.Rows[counter].Cells[index].Value.ToString());
                }
            }

         return   count.ToString() + " FCFA";
            //en anglais conversion en lettre
            //   montantEnLettre.Text =NumberToWord.Convert("56");

      //      montantEnLettre.Text = count.ToWord(NumberExtension.LiteralNumberFormat.Normal) + " francs CFA";
        }

        private List<EInsolvable> getAllEleveInsolvable(DataGridView dataGrid)
        {
            List<EInsolvable> eInsolvables = new List<EInsolvable>();

            EInsolvable eInsolvable = null;

            if(dataGrid.Rows.Count > 0)
            {
                for(int counterRow = 0; counterRow < dataGrid.Rows.Count - 1; counterRow++)
                {
                    eInsolvable = new EInsolvable();
                  
                        eInsolvable.matricule = dataGrid.Rows[counterRow].Cells[0].Value.ToString();
                        eInsolvable.nom = dataGrid.Rows[counterRow].Cells[1].Value.ToString();
                        eInsolvable.prenom = dataGrid.Rows[counterRow].Cells[2].Value.ToString();
                        eInsolvable.montantPayer = dataGrid.Rows[counterRow].Cells[3].Value.ToString();
                        eInsolvable.montantRestant = dataGrid.Rows[counterRow].Cells[4].Value.ToString();
                    eInsolvables.Add(eInsolvable);
                }
            }


            return eInsolvables;
        }
    }
}
