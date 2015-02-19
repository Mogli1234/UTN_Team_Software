using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

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

      //Metodo de tipo select cargados con lsita generica

      #region Metodo de cargar con lista generica de deportes
      public List<Sports>Cargar_Deportes(String SentenciaSQL)
      {
          List<Sports> Objeto_Deporte = new List<Sports>();
          try
          {
              Comando.CommandText = SentenciaSQL;
              Conexion = ConexionMySQL.ConectarConMySQL();
              Comando.Connection = Conexion;
              Conexion.Open();
              MySqlDataReader lector = Comando.ExecuteReader();
              
              while (lector.Read())
              {
                  Sports entidad_confi = new Sports();
                  
                  entidad_confi.Description = lector.GetString(2);
                  entidad_confi.Deporte = lector.GetString(1);
                  entidad_confi.Id = lector.GetInt16(0);
                  Objeto_Deporte.Add(entidad_confi);
              }
              lector.Close();
          }
          catch (MySqlException e)
          {

              e.Message.ToString();
          }
          finally
          {
              Conexion.Close();
          }
          
          return Objeto_Deporte;
      }
      #endregion

      //Metodo de tipo select cargados con lista generica (Rutinas)

      #region Metodo de cargar con lista generica de Rutinas
      public List<Rutinas> Cargar_Rutinas(String SentenciaSQL)
      {
          List<Rutinas> Objeto_Rutina = new List<Rutinas>();
          try
          {
              Comando.CommandText = SentenciaSQL;
              Conexion = ConexionMySQL.ConectarConMySQL();
              Comando.Connection = Conexion;
              Conexion.Open();
              MySqlDataReader lector = Comando.ExecuteReader();

              while (lector.Read())
              {
                  Rutinas entidad_confi = new Rutinas();

                  entidad_confi.Rutina = lector.GetString(1);
                  entidad_confi.Id = lector.GetInt32(0);
                  Objeto_Rutina.Add(entidad_confi);
              }
              lector.Close();
          }
          catch (MySqlException e)
          {

              e.Message.ToString();
          }
          finally
          {
              Conexion.Close();
          }

          return Objeto_Rutina;
      }
      #endregion

      public Boolean Login(String SentenciaMySQL,string username, string password) 
      {
          bool estado = false;
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
              for (int i = 0; i < Tabla_Datos.Rows.Count-1; i++)
              {
                  string use = Tabla_Datos.Rows[i].ToString();
                  if (username.Equals(use))
                  {
                      for (int j = 0; j < Tabla_Datos.Columns.Count; j++)
                      {
                          string pass = Tabla_Datos.Columns[j].ToString();
                          if (password.Equals(pass))
                          {
                              estado = true;
                          }
                      }
                  }
              }
          }
          catch (MySqlException e)
          {
              e.Message.ToString();
          }
          finally
          {
              Conexion.Close();
          }
          return estado;

      }

  }
}
