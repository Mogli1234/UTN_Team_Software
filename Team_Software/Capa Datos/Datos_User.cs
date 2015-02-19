using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Capa_Datos
{
   public class Datos_User
    {
       CL_Metodos_Base_Datos metodos = new CL_Metodos_Base_Datos();
       string sentencia;

        #region Metodo Insert Users
       public void Create_User(Users user) 
       {
           sentencia = "INSERT INTO Users(Username,Password,Email,Role)VALUES('" + user.Username + "','" + user.Password + "','"
                                                                              +user.Email+"','"+user.Role+"')";
           metodos.EjecutarSQL(sentencia);
       }
        #endregion


        #region Metodo para validar el usuario
       public Boolean Exist(string user,string pass) 
       {
           sentencia = "SELECT Username,Password FROM users";
           return metodos.Login(sentencia, user, pass);
       }
        #endregion

        #region Metodo de Delete
       public void Delete_User(Users user) 
       {
           sentencia = "DELETE * FROM users WHERE users.id= "+ user.Id;
           metodos.EjecutarSQL(sentencia);
       }
        #endregion


    }
}
