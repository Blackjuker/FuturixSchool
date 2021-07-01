using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futurix_School_Prim_En.Entite
{
    class EVersement
    {
        public int idVersement { get; set; }
        public string matricule { get; set; }
        public int idClasse { get; set; }
        public int montant { get; set; }
        public string motif { get; set; }
        public int idUser { get; set; }
        public string dateV { get; set; }
    }
}
