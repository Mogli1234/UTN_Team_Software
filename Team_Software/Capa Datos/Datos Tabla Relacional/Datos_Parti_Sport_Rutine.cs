using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Capa_Datos
{
    public class Datos_Parti_Sport_Rutine
    {
        string sentencia;
        CL_Metodos_Base_Datos metodos = new CL_Metodos_Base_Datos();

        #region Metodo de insertar
        public void Create(Sport_Rutine_Participante relacion) 
        {
            sentencia = "INSERT INTO participante_deporte_rutina(participante_id,deporte_id,rutina_id)VALUES("
                        +relacion.Participante_id+","+relacion.Sport_id+","+relacion.Rutina_id+")";
            metodos.EjecutarSQL(sentencia);
        }
        #endregion
    }
}
