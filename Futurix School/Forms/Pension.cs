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
    public partial class Pension : Form
    {
        int idUser;
        public Pension(int v)
        {
            InitializeComponent();
            this.idUser = v;
        }

        private void Pension_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet5.allpension'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        //    this.allpensionTableAdapter.Fill(this.open_schoolDataSet5.allpension);
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet2.niveau'. Vous pouvez la déplacer ou la supprimer selon les besoins.
      //      this.niveauTableAdapter.Fill(this.open_schoolDataSet2.niveau);



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EPension pension = new EPension();
            pension.idNiveau = DB.getIdNiveau(comboNiveau.Text.Trim());
            pension.montant = Convert.ToInt32(txtMontant.TextName.Trim());
            DB.createPension(pension, idUser);

            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet5.allpension'. Vous pouvez la déplacer ou la supprimer selon les besoins.
    //        this.allpensionTableAdapter.Fill(this.open_schoolDataSet5.allpension);
        }
    }
}
