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
    public partial class ListeEleve : Form
    {
        int idUser = 0;
        EEleve eleve;


        string montantPension = "0";
        public ListeEleve()
        {
            InitializeComponent();
        }
        public ListeEleve(int v)
        {
            InitializeComponent();
            idUser = v;
        }

        private void ListeEleve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_school_liste_classe.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
          //  this.classeTableAdapter.Fill(this.open_school_liste_classe.classe);
            metroGrid1.DataSource = DB.listAllEleve();

        }

        private void metroComboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int 
        }

        private void radioParClasse_CheckedChanged(object sender, EventArgs e)
        {
            metroComboClasse.Visible = true;
            labelClasse.Visible = true;
        }

        private void radioTouteClasse_CheckedChanged(object sender, EventArgs e)
        {
            metroComboClasse.Visible = false;
            labelClasse.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void radioParClasse_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioParClasse.Checked)
            {
                metroComboClasse.Visible = true;
                labelClasse.Visible = true;
                metroComboClasse.DataSource = DB.getAllClasse();
                metroComboClasse.DisplayMember="CLASSE";


                metroGrid1.DataSource = DB.listParClasse(DB.getIdClasse(metroComboClasse.Text));
            }
            else
            {
                metroComboClasse.Visible = false;
                labelClasse.Visible = false;
            }
        }

        private void radioTouteClasse_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioTouteClasse.Checked)
            {
                metroComboClasse.Visible = false;
                labelClasse.Visible = false;
                metroGrid1.DataSource = DB.listAllEleve();

            }
            else
            {
                metroComboClasse.Visible = true;
                labelClasse.Visible = true;
               

            }
        }

        private void metroComboClasse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            int idClasse = DB.getIdClasse(metroComboClasse.Text);
            metroGrid1.DataSource = DB.listParClasse(idClasse);
             montantPension = DB.getPensionParClasse(idClasse);
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string matricule = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            eleve = new EEleve();
            eleve = DB.getEleveInscription(matricule);

            Versement versement = new Versement(matricule, eleve.nom, eleve.prenom,metroComboClasse.Text,idUser,this);
            this.Hide();
            versement.ShowDialog();
            this.Show();
        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {
            string query;
            if (radioMatricule.Checked)
            {
                query = "Select MATRICULE, CONCAT(PRENOM,NOM) as NOM, DATENAISSANCE from eleve where MATRICULE like '%"+txtMatricule.Text+"%'";
                metroGrid1.DataSource = DB.listAllEleve(query);
            }
            else if (radioNom.Checked)
            {
                query = "Select MATRICULE, CONCAT(PRENOM,NOM) as NOM, DATENAISSANCE from eleve where CONCAT(MATRICULE,PRENOM,NOM) like '%" + txtMatricule.Text + "%'";
                metroGrid1.DataSource = DB.listAllEleve(query);
            }
        }
    }
}
