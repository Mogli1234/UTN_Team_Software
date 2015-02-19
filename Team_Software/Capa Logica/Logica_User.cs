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

       #region CreateUser
       public void Create_User(Users user) 
       {
           datos.Create_User(user);
       }
       #endregion

       #region Login
       public Boolean Login(string user,string pass) 
       {
           return datos.Exist(user, pass);
       }
       #endregion

       #region DeleteUser
       public void Delete_User(Users user) 
       {
           datos.Delete_User(user);
       }
       #endregion


    }
}
