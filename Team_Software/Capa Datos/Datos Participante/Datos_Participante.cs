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

        #region filtrado de los participantes
        public DataTable Fill_Participante(Participante parti) 
        {
            sentencia = "SELECT * FROM participante WHERE Nombre LIKE '"+parti.Nombre+"%'";
            return metodos.SeleccionarBasedeDatos(sentencia);
        }
        #endregion
    }
}
