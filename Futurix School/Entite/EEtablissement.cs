using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futurix_School_Prim_En.Entite
{
    class EEtablissement
    {
        public int idEtablissement { get; set; }
        public string nom { get; set; }
        public string noAutorisation { get; set; }
        public int statut { get; set; }
        public int capacite { get; set; }
        public string adresse { get; set; }
        public string codePostal { get; set; }
        public string siteWeb { get; set; }
        public string telephone { get; set; }
        public string pays { get; set; }
        public string ville { get; set; }
        public string description { get; set; }
        public string image { get; set; }

        public EEtablissement()
        {
        }

        public EEtablissement(int idEtablissement, string nom, string noAutorisation, int statut, int capacite, string adresse,string codePostal, string siteWeb,string telephone, string pays, string ville, string description, string image)
        {
            this.idEtablissement = idEtablissement;
            this.nom = nom;
            this.noAutorisation = noAutorisation;
            this.statut = statut;
            this.capacite = capacite;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.siteWeb = siteWeb;
            this.telephone = telephone;
            this.pays = pays;
            this.ville = ville;
            this.description = description;
            this.image = image;
        }

        
    }
}
