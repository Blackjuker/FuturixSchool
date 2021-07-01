using Futurix_School_Prim_En.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futurix_School_Prim_En.IDAO
{
    interface IUser
    {
        EUser Login(String username, String password);
    }
}
