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

namespace Futurix_School_Prim_En.Forms.Forms_Pedagogique
{
    public partial class Titre_UA : Form
    {
        int idU = 0, idModule = 0;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            ETITREUA eTITREUA = new ETITREUA();

            eTITREUA.idUser = idU;
            eTITREUA.idModule = idModule;
            eTITREUA.nbreHeure = (txtNbreHeure.Text.Length>0) ? Convert.ToInt32(txtNbreHeure.Text) : 0;
            eTITREUA.nbreUE = (txtUE.Text.Length>0) ?Convert.ToInt32(txtUE.Text) : 0;
            eTITREUA.titreUA = (txtTitreUA.Text.Length > 0) ? txtTitreUA.Text : " ";

            if (eTITREUA.nbreHeure>0||eTITREUA.nbreUE>0 || eTITREUA.titreUA.Length > 0)
            {
                DB.createUAMatieres(eTITREUA);
                gridListeUA.DataSource = DB.getAllCreatedUABy(eTITREUA.idModule);
            }
        }

        private void gridListeUA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUA = 0;
            idUA = Convert.ToInt32(gridListeUA.Rows[e.RowIndex].Cells[0].Value.ToString());
            string titre = "";
            titre = gridListeUA.Rows[e.RowIndex].Cells[1].Value.ToString();
            Titre_UE titre_UE = new Titre_UE(idU, idUA, titre);
            this.Hide();
            titre_UE.ShowDialog();
            this.Show();
        }

        public Titre_UA(int idU,int idM,string titreModule)
        {
            InitializeComponent();
            this.idU = idU;
            this.idModule = idM;
            lblTitreUA.Text = titreModule;
            gridListeUA.DataSource = DB.getAllCreatedUABy(idModule);

        }
    }
}
