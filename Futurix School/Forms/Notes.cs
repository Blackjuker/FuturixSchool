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
    public partial class Notes : Form
    {
        int laNote=1;
        int idUser = 0;
        private int idClasse = 0;
        private int idTrimestre = 0;
        private int idMatiere = 0;

        public Notes(int idU)
        {
            InitializeComponent();
            this.idUser = idU;

            comboClasse.DataSource = DB.getAllClasse();
            comboClasse.DisplayMember = "CLASSE";

           


            comboTrimestre.DataSource = DB.getAllTrimestre();
            comboTrimestre.DisplayMember = "DESIGNATION";

            getAllId();
            comboMatieres.DataSource = DB.getMatieresParClasse(idClasse);
            comboMatieres.DisplayMember = "matieres";
        }


        private void getAllId()
        {
            if (comboClasse.Text.Length < 0)
            {
                idClasse = DB.getIdClasse("0");
            }
            else
            {
                idClasse = DB.getIdClasse(comboClasse.Text);
            }
            if (comboTrimestre.Text.Length < 0)
            {
                idTrimestre = DB.getIdTrimestre("0");
            }
            else
            {
                idTrimestre = DB.getIdTrimestre(comboTrimestre.Text);
            }
            if (comboMatieres.Text.Length < 0)
            {
                idMatiere = DB.getIdMatiere("0");
            }
            else
            {
                idMatiere = DB.getIdMatiere(comboMatieres.Text);
            }
            
        }


        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            getAllId();
            metroGridListeEleve.DataSource = null;
            metroGridListeEleve.DataSource = DB.getEleveNoteByClasseByMatiere(idClasse, idTrimestre, idMatiere);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAllId();
            metroGridListeEleve.DataSource = null;
            metroGridListeEleve.DataSource = DB.getEleveNoteByClasseByMatiere(idClasse, idTrimestre, idMatiere);

        }

        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            idClasse = DB.getIdClasse(comboClasse.Text);
            comboMatieres.DataSource = DB.getMatieresParClasse(idClasse);
            comboMatieres.DisplayMember = "matieres";
           
                        lblNombreEleve.Text = Convert.ToString(DB.getAllNombreEleve(idClasse))+ " Elèves";

            

                       metroGridListeEleve.DataSource = null;
                       metroGridListeEleve.DataSource = DB.getEleveNoteByClasseByMatiere(idClasse, idTrimestre, idMatiere);
                     
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
          //  DB.addNotes(laNote, idTrimestre, idMatiere, "matricule", 0);
            //  DB.updateNotes(laNote, idTrimestre, idMatiere, "matricule", 0);
            List<ENote> allNotes = new List<ENote>();
            allNotes.Clear();

            ENote note = null;

            for(int i = 0; i < metroGridListeEleve.Rows.Count-1; i++)
            {
                note = new ENote();

                note.matricule = metroGridListeEleve.Rows[i].Cells[0].Value.ToString();
                note.note = Convert.ToInt32(metroGridListeEleve.Rows[i].Cells[2].Value.ToString());
                note.idPeriode = idTrimestre;
                note.idMatiere = idMatiere;
                note.idUser = idUser;


                allNotes.Add(note);   
            }

            foreach(ENote n in allNotes)
            {
                
                if (DB.addIfNotesExiste(n))
                {
                    DB.updateNotes(n);
                }
                else
                {
                    DB.addNotes(n);
                }
            }
        }
    }
}
