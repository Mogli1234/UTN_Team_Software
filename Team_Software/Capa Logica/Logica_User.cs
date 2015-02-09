using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Entidades;

namespace Capa_Logica
{
   public class Logica_User
    {
       Datos_User datos = new Datos_User();

       public void Create_User(Users user) 
       {
           datos.Create_User(user);
       }

    }
}
