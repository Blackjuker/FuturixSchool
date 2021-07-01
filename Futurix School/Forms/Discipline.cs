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
    public partial class Discipline : Form
    {
        int idUser = 0;
        int idClasse = 0;
        string matricule = null;
        string dateDebut=null;
        string dateFin=null;
        int absHeure = 0;
        int exclusion = 0;
        int convocation = 0;
        public Discipline(int idU)
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

          /*  List<string> listMatricule = new List<string>();

            for (int i = 0; i < metroGridListeEleve.RowCount-1; i++)
                listMatricule.Add(metroGridListeEleve.Rows[i].Cells[0].Value.ToString());
          */
           /* foreach (string s in listMatricule)
            {

               // MessageBox.Show(s);
                DB.deleteVersement(s);
            }*/

        }

        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

            getAllEleveByClasse(DB.getIdClasse(comboClasse.Text));
            
           // getAllEleveByClasse(15);
        }

        private void metroGridListeEleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<metroGridListeEleve.Rows.Count-1 && e.RowIndex > -1) { 
                nomEleve.Text = metroGridListeEleve.Rows[e.RowIndex].Cells[1].Value.ToString();
                matricule = metroGridListeEleve.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void metroGridListeEleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < metroGridListeEleve.Rows.Count - 1 && e.RowIndex > 0)
                nomEleve.Text = metroGridListeEleve.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dateDiscipline_DateChanged(object sender, DateRangeEventArgs e)
        {
          //  MessageBox.Show(d)
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerDebut_ValueChanged(object sender, EventArgs e)
        {
            
            dateDebut = dateTimePickerDebut.Value.ToString("dd/MM/yyyy");

           
        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            dateFin = dateTimePickerFin.Value.ToString("dd/MM/yyyy");
           
        }

        private void comboNbreHeure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioAbsHeure.Checked == true)
            {
                absHeure = Int32.Parse(comboNbreHeure.Text);
            }else if (radioExclusion.Checked ==true)
            {
                exclusion = Int32.Parse(comboNbreHeure.Text);
            }
            else if (radioConvocation.Checked == true)
            {
                convocation = Int32.Parse(comboNbreHeure.Text);
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EDiscipline eDiscipline = new EDiscipline();
            if (dateFin==null)
            {
                dateFin = dateTimePickerFin.Value.ToString("dd/MM/yyyy");
            }
            if (dateDebut == null)
            {
                dateDebut = dateTimePickerDebut.Value.ToString("dd/MM/yyyy");
            }
            eDiscipline.idUser = idUser;
            eDiscipline.matricule = matricule;
            eDiscipline.motif = richMotif.Text;
            eDiscipline.nbreHr = absHeure;
            eDiscipline.nbrJr = exclusion;
            eDiscipline.nbrConv = convocation;
            eDiscipline.dateFin = dateFin;
            eDiscipline.dateDebut = dateDebut;
            dateDebut = dateTimePickerDebut.Value.ToString("dd/MM/yyyy");
            dateFin = dateTimePickerFin.Value.ToString("dd/MM/yyyy");
            if (matricule != null)
            {
                DB.insertDiscipline(eDiscipline);
                richMotif.Text = "";
            }
            else
            {
                MessageBox.Show("Veuillez selectionner le matricule");
            }

        }
    }
}
