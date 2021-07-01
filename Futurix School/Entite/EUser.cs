using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futurix_School_Prim_En.Entite
{
    class EUser
    {
        public int idAdmin { get; set; }

        public int niveau { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public string sexe { get; set; }
        public int telephone { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public EUser(int idAdmin, int niveau, string nom, string prenom, int telephone, string username, string password)
        {
            this.idAdmin = idAdmin;
            this.niveau = niveau;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.telephone = telephone;
            this.username = username;
            this.password = password;
        }

        public EUser()
        {
        }
    }
}
