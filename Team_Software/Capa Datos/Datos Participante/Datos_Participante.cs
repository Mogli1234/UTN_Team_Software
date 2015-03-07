using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Capa_Datos
{
    public class Datos_Participante
    {
        string sentencia;
        CL_Metodos_Base_Datos metodos = new CL_Metodos_Base_Datos();

        #region Insertar Participantes
        public void Insertar_Participantes(Participante parti) 
        {
            sentencia = "INSERT INTO participante(Nombre,Primer_Apellido,Segundo_Apellido,Edad,Fecha_Ingreso)VALUES('"+parti.Nombre+"','"
                        +parti.Primer_apellido+"','"+parti.Segundo_apellido+"',"+parti.Edad+",'"+parti.Fecha_ingreso+"');";
            metodos.EjecutarSQL(sentencia);
        }
        #endregion

        #region cargar participantes
        public DataTable Charger_Participante() 
        {
            sentencia = "SELECT * FROM participante";
            return metodos.SeleccionarBasedeDatos(sentencia);
        }
        #endregion

        #region Actualizar Participante
        public void Update_Participante(Participante participante) //Metodo de actualizar con sentencia update
        {
            sentencia = "UPDATE participante SET Id= '" + participante.Id + "', Nombre= '" + participante.Nombre + "', Primer_Apellido= '" +
                participante.Primer_apellido + "', Segundo_Apellido= '" + participante.Segundo_apellido + "',   Edad= '" +
                participante.Edad + "', Fecha_Ingreso= '" + participante.Fecha_ingreso + "' WHERE participante.id= " + participante.Id + "";//Sentencia SQL
            metodos.EjecutarSQL(sentencia);
        }
        #endregion

        #region Delete Rutina
        public void Delete_Participante(Participante participante) //Metodo Delete con la sentencia
        {
            sentencia = "DELETE FROM participante WHERE participante.id= " + participante.Id + "";//Sentencia SQL
            metodos.EjecutarSQL(sentencia);
        }
        #endregion


        #region filtrado de los participantes
        public DataTable Fill_Participante(Participante parti) 
        {
            sentencia = "SELECT * FROM participante WHERE Nombre LIKE '"+parti.Nombre+"%'";
            return metodos.SeleccionarBasedeDatos(sentencia);
        }
        #endregion
    }
}
