using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Capa_Datos
{
  public  class CL_Metodos_Base_Datos
  {
      #region Instancias de las clases para hacer los metodos e base de datos
      Cl_Conexion_MySQL ConexionMySQL = new Cl_Conexion_MySQL();
      MySqlCommand Comando = new MySqlCommand();
      MySqlDataAdapter Adaptador = new MySqlDataAdapter();
      MySqlConnection Conexion = new MySqlConnection();
      DataTable Tabla_Datos = new DataTable();
    #endregion

      #region Metodo de insertar en base de datos
      public void EjecutarSQL(String SentenciaSql) 
      {
          try
          {
              Conexion = ConexionMySQL.ConectarConMySQL();
              Comando.CommandText = SentenciaSql;
              Comando.Connection = Conexion;
              Conexion.Open();
              Adaptador.InsertCommand = Comando;
              Adaptador.InsertCommand.ExecuteNonQuery();
          }
          catch (MySqlException e)
          {

              e.Message.ToString();
          }
          finally 
          {
              Conexion.Close();
          }
      }
      #endregion

      #region Metodo de Seleccionar con dataset
      public DataTable SeleccionarBasedeDatos(String SentenciaMySQL)
        {
            try
            {
                LimpiarTabla();
                Conexion = ConexionMySQL.ConectarConMySQL();

                Comando.CommandText = SentenciaMySQL;
                Comando.Connection = Conexion;
                Conexion.Open();
                Adaptador.SelectCommand = Comando;
                Adaptador.SelectCommand.ExecuteNonQuery();
                Adaptador.Fill(Tabla_Datos);
            }
            catch (MySqlException e)
            {
                e.Message.ToString();
            }
            finally 
            {
                Conexion.Close();
            }
            

            return Tabla_Datos;
        }
        #endregion

      #region Metodo para limpiar las tablas de datos generico
      //Limpia las tablas de la base de datos
      private void LimpiarTabla()
      {
          Tabla_Datos.Clear();
          Tabla_Datos.Rows.Clear();
          Tabla_Datos.Columns.Clear();
      }
      #endregion

  }
}
