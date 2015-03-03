using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Capa_Datos
{
   public class Datos_Deporte
    {
       CL_Metodos_Base_Datos metodos = new CL_Metodos_Base_Datos();
       String sentencia;

       #region Create Sport
       public void Create_Sport(Sports sport) //Metodo con sentencia para insertar datos
       {
           sentencia = "INSERT INTO deporte(Deporte,Descripcion)VALUES('"+sport.Deporte+"','"+sport.Description+"')";//Sentencia SQL
           metodos.EjecutarSQL(sentencia);
       }
        #endregion

       #region Update Sport
       public void Update_Sport(Sports sport) //Metodo de actualizar con sentencia update
       {
           sentencia = "UPDATE deporte SET Deporte= '"+sport.Deporte+"', Descripcion= '"+sport.Description+"' WHERE deporte.id= "+sport.Id+"";//Sentenci SQL
           metodos.EjecutarSQL(sentencia);
       }
       #endregion

       #region Delete Sport 
       public void Delete_Sport(Sports sport) //Metodo Delete con la sentencia
       {
           sentencia = "DELETE FROM deporte WHERE deporte.id= " + sport.Id + "";//Sentencia SQL
           metodos.EjecutarSQL(sentencia);
       }
        #endregion

       //Metodos para mostrar
        #region Metodo con sentencia select que retorna una lista
       public List<Sports>Charge_Sports()
       {
           sentencia = "SELECT id,Deporte,Descripcion FROM deporte";
           return metodos.Cargar_Deportes(sentencia);
       }
        #endregion

        #region Metodo para cargar un combobox
       public List<Sports> ChargeCombobox() 
       {
           sentencia = "SELECT Deporte FROM deporte";
           return metodos.Cargar_Deportes(sentencia);
       }
        #endregion
    }
}
