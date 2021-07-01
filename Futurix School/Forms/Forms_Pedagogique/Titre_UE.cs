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
    public partial class Titre_UE : Form
    {
        int idUA = 0, idUser=0;
        public Titre_UE(int idU,int idUA, string titreUA)
        {
            InitializeComponent();
            this.idUA = idUA;
            this.idUser = idU;
            lblTitreUA.Text = titreUA;
            gridListeUE.DataSource = DB.getAllCreatedUEBy(idUA);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            ETitreUE eTitreUE = new ETitreUE();

            eTitreUE.idUA = idUA;
            eTitreUE.idUser = idUser;
            eTitreUE.nbreHeure = (txtNbreHeure.Text.Length > 0) ? Convert.ToInt32(txtNbreHeure.Text) : 0;
            eTitreUE.typeLecon = (rdLeconT.Checked) ? 1 : 0; // 1: Théorique && 0: Pratique
            eTitreUE.titre = (txtTitreUE.Text.Length > 0) ? txtTitreUE.Text : " ";

            if (eTitreUE.idUA > 0 || eTitreUE.nbreHeure > 0 || eTitreUE.titre.Length > 0)
            {
                DB.createUE(eTitreUE);
                gridListeUE.DataSource = DB.getAllCreatedUEBy(eTitreUE.idUA);
            }

        }
    }
}
