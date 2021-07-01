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
    public partial class Tranche : Form
    {
        List<int> listSomme = null;
        int idPension = 0;
        int idUser;
        public Tranche(int v)
        {
            InitializeComponent();
            
           
           
           // txtMontant.Text = DB.getPrixPension(Convert.ToInt32(DB.getIdNiveau(comboNiveau.Text.Trim())));
           
            idUser = v;
        }

        private void Tranche_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet2.niveau'. Vous pouvez la déplacer ou la supprimer selon les besoins.
       //     this.niveauTableAdapter.Fill(this.open_schoolDataSet2.niveau);

        }

        private void comboNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMontant.Text = DB.getPrixPension(Convert.ToInt32(DB.getIdNiveau(comboNiveau.Text.Trim())));
            idPension = DB.getIdPension(DB.getIdNiveau(comboNiveau.Text.Trim()));
            this.dataGridTranche.DataSource = DB.getAllTrancheNiveau(idPension);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
            listSomme = new List<int>();
            listSomme.Add(Convert.ToInt32(txtMontantTranche.Text.Trim()));
            ETranche tranche = new ETranche();
            tranche.montant = Convert.ToInt32(txtMontantTranche.Text.Trim());
            tranche.libelle = txtLibelle.TextName.Trim();
            tranche.dateFin = dateTimePicker.Value.ToShortDateString();
            tranche.idPension = idPension;
            DB.createTranche(tranche, idUser);
            this.dataGridTranche.DataSource = DB.getAllTrancheNiveau(idPension);
        }


      

        private void txtMontantTranche_TextChanged(object sender, EventArgs e)
        {
            int cumul = 0;

            idPension = DB.getIdPension(DB.getIdNiveau(comboNiveau.Text.Trim()));
            this.dataGridTranche.DataSource = DB.getAllTrancheNiveau(idPension);

            if (listSomme!=null)
            foreach (int som in listSomme)
                cumul += som;

            if (txtMontantTranche.Text.Length <= 0)
            {
                txtMontantTranche.Text = Convert.ToString(0);
            }

            txtMontantReste.Text = Convert.ToString(Convert.ToInt32(txtMontant.Text.Trim())-(Convert.ToInt32(txtMontantTranche.Text.Trim())+cumul));
            if (Convert.ToInt32(txtMontantReste.Text) < 0)
            {
                alert.Visible = true;
                btnValider.Enabled = false;
            }
            else
            {
                alert.Visible = false;
                btnValider.Enabled = true;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
