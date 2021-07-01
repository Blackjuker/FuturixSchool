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
    public partial class MatiereCoefficient : Form
    {
        private int idUser = 0;
        private int idMatiere = 0;
        private int idClasse = 0;
        private int coefficient = 0;
        public MatiereCoefficient(int idU)
        {
            InitializeComponent();

            this.idUser = idU;
        }

        private void MatiereCoefficient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet8Classe.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        //    this.classeTableAdapter1.Fill(this.open_schoolDataSet8Classe.classe);
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet7.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            ///::this.classeTableAdapter.Fill(this.open_schoolDataSet7.classe);
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet7Mat.matiere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
      //      this.matiereTableAdapter.Fill(this.open_schoolDataSet7Mat.matiere);
            //remplissage list des matieres coefficient
       //     matieresGrid.DataSource = DB.listMatiereCoef(Convert.ToInt32(open_schoolDataSet8Classe.classe[classeBindingSource1.Position].IDCLASSE.ToString()));
        }

        private void matiereBindingSource_CurrentChanged(object sender, EventArgs e)
        {

       //     idMatiere = Convert.ToInt32(open_schoolDataSet7Mat.matiere[matiereBindingSource.Position].IDMATIERE.ToString());
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void classeBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
       //     idClasse = Convert.ToInt32(open_schoolDataSet8Classe.classe[classeBindingSource1.Position].IDCLASSE.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCoef.TextName == "0")
            {
                MessageBox.Show("Veuillez donner un coefficient");
            }
            else
            {
                coefficient = Convert.ToInt32(txtCoef.TextName.ToString());
                string groupe = comboGroupe.Text.Trim();
               if (DB.createCoefMatiere(coefficient, idClasse, idMatiere, idUser, groupe) == 1)
                {
                    MessageBox.Show("Inscription Reussie");
                    //remplissage list des matieres coefficient
            //        matieresGrid.DataSource = DB.listMatiereCoef(Convert.ToInt32(open_schoolDataSet8Classe.classe[classeBindingSource1.Position].IDCLASSE.ToString()));

                }
            }
        }

        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //remplissage list des matieres coefficient
            matieresGrid.DataSource = DB.listMatiereCoef(DB.getIdClasse(comboClasse.Text.Trim()));

        }
    }
}
