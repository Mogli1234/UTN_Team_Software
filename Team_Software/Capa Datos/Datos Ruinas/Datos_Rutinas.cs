using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Capa_Datos
{
    public class Datos_Rutinas
    {
        CL_Metodos_Base_Datos metodos = new CL_Metodos_Base_Datos();
        String sentencia;

        //Metodos Edicion
        #region Creacion Rutina
        public void CrearRutina(Rutinas rutina) //Metodo con sentencia para insertar datos
        {
            sentencia = "INSERT INTO rutina(id,Rutina)VALUES('" + rutina.Id + "','" + rutina.Rutina + "')";//Sentencia SQL
            metodos.EjecutarSQL(sentencia);
        }

        #endregion

        #region Actualizar Rutina
        public void Update_Rutina(Rutinas rutina) //Metodo de actualizar con sentencia update
        {
            sentencia = "UPDATE rutina SET Id= '" + rutina.Id + "', Rutina= '" + rutina.Rutina + "' WHERE rutina.id= " + rutina.Id + "";//Sentenci SQL
            metodos.EjecutarSQL(sentencia);
        }
        #endregion

        #region Delete Rutina
        public void Delete_Rutina(Rutinas rutina) //Metodo Delete con la sentencia
        {
            sentencia = "DELETE FROM rutina WHERE rutina.id= " + @rutina.Id + "";//Sentencia SQL
            metodos.EjecutarSQL(sentencia);
        }
        #endregion

        //Metodo para mostrar
        #region Metodo con sentencia select que retorna una lista de Rutinas
        public List<Rutinas> Charge_Rutinas()
        {
            sentencia = "SELECT id,Rutina FROM rutina";
            return metodos.Cargar_Rutinas(sentencia);
        }
        #endregion
    }
}
