using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futurix_School_Prim_En.Globals
{
    static class GlobalVars
    {
        public static MySqlConnection connection=null;
        public static string adresseServeur="localhost";
      // public static string adresseServeur="192.168.8.3";
         public static string serveurUsername="root";//
       // public static string serveurUsername= "FuturixSchool";
         public static string serveurPassword="";
       // public static string serveurPassword= "Blackjuker2021";

        public static string BD = null;

        public static void clear()
        {
            connection = null;
        }
    }
}
