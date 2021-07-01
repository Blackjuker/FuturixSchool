using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futurix_School_Prim_En.Entite
{
    class EEleve
    {
        internal string genre;
        internal object iduser;
        private string v1;
        private string v2;

        public int idEleve { get; set; } 
        public string matricule { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public string dateNaissance { get; set; }
        public string lieuNaissance { get; set; }
        public string nationalite { get; set; }
        public string apte { get; set; }
        public string maladif { get; set; }
        public string nomMaladif { get; set; }
        public string status { get; set; }
        public string nomAncienEcole { get; set; }
        public int ancienAnnee { get; set; }
        public int noteAncienne { get; set; }
        public string boursier { get; set; }
        public int abandon { get; set; }
        public string redoublant { get; set; }
        public string numeroInternat { get; set; }
        public int idClasse { get; set; }
        public string imagePath { get; set; }

        public EEleve()
        {

        }

        public EEleve(int idEleve, string matricule, string prenom, string nom, string dateNaissance, string lieuNaissance, string nationalite, string apte, string maladif, string status, string nomAncienEcole, int ancienAnnee, int noteAncienne, string boursier, int abandon, string redoublant, string numeroInternat, int idClasse, string imagePath)
        {
            this.idEleve = idEleve;
            this.matricule = matricule;
            this.prenom = prenom;
            this.nom = nom;
            this.dateNaissance = dateNaissance;
            this.lieuNaissance = lieuNaissance;
            this.nationalite = nationalite;
            this.apte = apte;
            this.maladif = maladif;
            this.status = status;
            this.nomAncienEcole = nomAncienEcole;
            this.ancienAnnee = ancienAnnee;
            this.noteAncienne = noteAncienne;
            this.boursier = boursier;
            this.abandon = abandon;
            this.redoublant = redoublant;
            this.numeroInternat = numeroInternat;
            this.idClasse = idClasse;
            
            this.imagePath = imagePath;
        }

        public EEleve(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}

/*SqlCommand command = new SqlCommand("SELECT nom,prenom FROM T_PERSONNEL where cin = '" + val + "'  ", SQLConn);

SqlDataReader reader = command.ExecuteReader();
reader.Read();
lbnom.Text = reader.GetString(0);
lbprenom.Text = reader.GetString(1);*/