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
    public partial class Cycle : Form
    {
        int idEtat;
        int idUser;
        public Cycle(int idU)
        {
            InitializeComponent();
            idEtat = DB.getIdEtablissement();
            idUser = idU;
            cycleGrid.DataSource = DB.listCycles();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ECycle eCycle = new ECycle();
            eCycle.designation = txtCycle.TextName.Trim();
            eCycle.idEtablissement = idEtat;
            eCycle.idUser = idUser;
            DB.createCycle(eCycle);

            cycleGrid.DataSource = DB.listCycles();
        }

        private void Cycle_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSet.cycle'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           

        }
    }
}
