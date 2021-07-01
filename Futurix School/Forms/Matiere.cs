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
    public partial class Matiere : Form
    {
        private int idUser=0;
        private string libelle = null;
        public Matiere(int idU)
        {
            InitializeComponent();
            this.idUser = idU;
            matieresGrid.DataSource = DB.getAllMatieres();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EMatiere matiere = new EMatiere();

            matiere.designation = txtMatiere.TextName;
            matiere.idUser = idUser;
            DB.verifIfMatExiste(matiere);
            matieresGrid.DataSource = DB.getAllMatieres();
            txtMatiere.TextName = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string libelle = txtMatiere.TextName;
            DB.deleteMatiere(libelle);
            matieresGrid.DataSource = DB.getAllMatieres();
            txtMatiere.TextName = "";

        }

        private void matieresGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            libelle = matieresGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMatiere.TextName = libelle;
          //  MessageBox.Show(libelle);
        }
    }
}
