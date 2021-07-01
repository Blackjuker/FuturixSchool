using Futurix_School_Prim_En.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futurix_School_Prim_En.Main_1
{
    public partial class MainDiscipline : Form
    {
        private int idUser=0;
        public MainDiscipline(int idU)
        {
            InitializeComponent();
            this.idUser = idU;
        }

        private void btnDiscipline_Click(object sender, EventArgs e)
        {
            Discipline discipline = new Discipline(idUser);
            this.Hide();
            discipline.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJustification_Click(object sender, EventArgs e)
        {
            Justification justification = new Justification(idUser);
            this.Hide();
            justification.ShowDialog();
            this.Show();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes(idUser);
            this.Hide();
            notes.ShowDialog();
            this.Show();
        }
    }
}
