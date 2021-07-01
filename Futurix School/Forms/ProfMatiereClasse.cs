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
    public partial class ProfMatiereClasse : Form
    {
        int idU = 0,idClasse=0,idMatiere = 0,idEnseignant= 0;

        private void cmbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMatiere  = (cmbMatiere.Text.Length > 0) ? DB.getIdMatiere(cmbMatiere.Text) : 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idMatiere>=0 || idEnseignant >=0|| idClasse >= 0)
            {
                
                
                if (DB.ifExistEnseignantMatiere(idEnseignant, idMatiere, idClasse) == 0) { 
                    DB.createEnseignantMatiere(idEnseignant, idMatiere, idClasse);
                    metroGridClasseEnseigner.DataSource = DB.getAllClasseEnseigner(idEnseignant);
                }else { 
                    MessageBox.Show("Ce cours à déjà été ajouter !!!");
                }
            }
        }

        private void cycleGridListeEnseignant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < cycleGridListeEnseignant.Rows.Count  && e.RowIndex > -1)
            {
                idEnseignant =Convert.ToInt32(cycleGridListeEnseignant.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblProf.Text = (cycleGridListeEnseignant.Rows[e.RowIndex].Cells[1].Value.ToString().Length > 0) ? cycleGridListeEnseignant.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper() : "";
                metroGridClasseEnseigner.DataSource = DB.getAllClasseEnseigner(idEnseignant);
            }
        }

        public ProfMatiereClasse(int idU)
        {
            InitializeComponent();
            this.idU = idU;

            cmbClasse.DataSource = DB.getAllClasse();
            cmbClasse.DisplayMember = "CLASSE";

            cycleGridListeEnseignant.DataSource = DB.getAllEnseignant();

        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            idClasse = DB.getIdClasse(cmbClasse.Text);
            cmbMatiere.DataSource = DB.getMatieresParClasse(idClasse);
            cmbMatiere.DisplayMember = "matieres";
            idMatiere = DB.getIdMatiere(cmbMatiere.Text);

        }
    }
}
