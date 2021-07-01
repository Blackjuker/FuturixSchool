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
    public partial class Justification : Form
    {

        int idUser = 0;
        string matricule = null;
        public Justification(int idU)
        {
            InitializeComponent();

            this.idUser = idU;

            comboClasse.DataSource = DB.fillClasse();
            comboClasse.DisplayMember = "DESIGNATION";
            getAllEleveByClasse(DB.getIdClasse(comboClasse.Text));
        }

        public void getAllEleveByClasse(int idClasse)
        {
            metroGridListeEleve.DataSource = null;
            metroGridListeEleve.DataSource = DB.getAllEleveByClasse(idClasse);

        }

        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAllEleveByClasse(DB.getIdClasse(comboClasse.Text));
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            miseAJourHeure();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string n = null;
            n = comboNbreHeure.Text;
            int heureAJustifier = 0;

            if (n.Length>0)
            {
                heureAJustifier = Convert.ToInt32(n);
                DB.justificationHeure(heureAJustifier, matricule);
                miseAJourHeure();
            }



            
        }

        private void metroGridListeEleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < metroGridListeEleve.Rows.Count - 1 && e.RowIndex > -1)
            {
                nomEleve.Text = metroGridListeEleve.Rows[e.RowIndex].Cells[1].Value.ToString();
                matricule = metroGridListeEleve.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void miseAJourHeure()
        {

            lblAbsence.Text = Convert.ToString(DB.getAllHeureAbsence(matricule, monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy")));
            lblConvocation.Text = Convert.ToString(DB.getAllConvocation(matricule, monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy")));
            lblExclusion.Text = Convert.ToString(DB.getAllExclusion(matricule, monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy")));
            lblHrTotalNonJ.Text = Convert.ToString(DB.getAllTotalHeureAbsence(matricule));
        }
    }

       
   
}
