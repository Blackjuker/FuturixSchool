using Futurix_School_Prim_En.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futurix_School_Prim_En.Main_1
{
    public partial class MainNiveau1 : Form
    {
        int idUser = 0;
       
        public MainNiveau1(int v)
        {
            InitializeComponent();
            this.idUser = v;
        }

        private void btnVersement_Click(object sender, EventArgs e)
        {
            ListeEleve listeEleve = new ListeEleve(idUser);
            this.Hide();
            listeEleve.ShowDialog();
            this.Show();
            
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Eleve inscriptionEleve = new Eleve(idUser);
            this.Hide();
            inscriptionEleve.ShowDialog();
            inscriptionEleve.Dispose();
            this.Show();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            InsolvableListe insolvableListe = new InsolvableListe();
            this.Hide();
            insolvableListe.ShowDialog();
            this.Show();
        }

        private void label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEtatJour_Click(object sender, EventArgs e)
        {
            EtatJournalier etatJournalier = new EtatJournalier(idUser);
            this.Hide();
            etatJournalier.ShowDialog();
            this.Show();
        }
    }
}
