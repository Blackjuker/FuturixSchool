using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futurix_School_Prim_En.Entite
{
    class EDiscipline
    {
        public int idDiscipline { get; set; }
        public string matricule { get; set; }
        public string dateDebut { get; set; }
        public string dateFin { get; set; }
        public int nbreHr { get; set; }
        public int nbreHrJ { get; set; }
        public int nbrJr { get; set; }
        public int nbrConv { get; set; }
        public string motif { get; set; }
        public string justifier { get; set; }
        public int idUser { get; set; }
    }
}
