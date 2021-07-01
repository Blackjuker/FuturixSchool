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
    public partial class Matieres : Form
    {
        int idUser = 0;
        public Matieres(int idU)
        {
            InitializeComponent();
            this.idUser = idU;
        }

        private void Matieres_Load(object sender, EventArgs e)
        {


            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet6.matiere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
     //       this.matiereTableAdapter.Fill(this.open_schoolDataSet6.matiere);

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string libelleMatiere = "";
            libelleMatiere = txtMatiere.TextName.ToUpper();

            EMatiere eMatiere = new EMatiere();

            eMatiere.designation = libelleMatiere;
            eMatiere.idUser = idUser;

            DB.verifIfMatExiste(eMatiere);

            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet6.matiere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
       //     this.matiereTableAdapter.Fill(this.open_schoolDataSet6.matiere);
        }
    }
}
