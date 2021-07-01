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
    public partial class Classe : Form
    {
        int idU;
        public Classe(int v)
        {
            InitializeComponent();
            this.idU = v;

            comboNiveau.DataSource = DB.fillNiveau();
            comboNiveau.DisplayMember = "DESIGNATION";

            comboSerie.DataSource = DB.fillSerie();
            comboSerie.DisplayMember = "DESIGNATION";
            

            classeGrid.DataSource = DB.getAllClasse();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Classe_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet3.list_de_niveau'. Vous pouvez la déplacer ou la supprimer selon les besoins.
      //      this.list_de_niveauTableAdapter.Fill(this.open_schoolDataSet3.list_de_niveau);
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSetSerieList.serie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
    //        this.serieTableAdapter.Fill(this.open_schoolDataSetSerieList.serie);
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet2.niveau'. Vous pouvez la déplacer ou la supprimer selon les besoins.
         //   this.niveauTableAdapter.Fill(this.open_schoolDataSet2.niveau);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EClasse classe = new EClasse();
            classe.idNiveau = DB.getIdNiveau(comboNiveau.Text.Trim());
            classe.idSerie = DB.getIdSerie(comboSerie.Text.Trim());
            classe.designation = txtClasse.TextName.Trim();
            classe.capaciteAccueil = Convert.ToInt32(txtCapacite.TextName.Trim());
            DB.createClasse(classe,idU);
            classeGrid.DataSource = DB.getAllClasse();
          
        }

        private void comboNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
