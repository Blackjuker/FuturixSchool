using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futurix_School_Prim_En.Entite
{
    class EAdmin
    {
        public int idAdmin { get; set; }
        public int niveau { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string sexe { get; set; }
        public string telephone { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public int idUser { get; set; }
    }
}
