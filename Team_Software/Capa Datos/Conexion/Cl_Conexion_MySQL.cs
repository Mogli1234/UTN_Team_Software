using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Capa_Datos
{
   public class Cl_Conexion_MySQL
    {
       MySqlConnection Conexion = new MySqlConnection();

       #region metodo de conexion con my SQL
       public MySqlConnection ConectarConMySQL()
       {
           //se ciera primero la conexion
           Conexion.Close();
           //Se crea el string de conexion con my Sql
           Conexion.ConnectionString = "Server=localhost;Database=utn_deportes;Uid=root;Pwd=12345;";

           return Conexion;

       }
       #endregion
    }
}
