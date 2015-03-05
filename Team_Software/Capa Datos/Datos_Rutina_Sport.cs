using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Capa_Datos
{
    public class Datos_Rutina_Sport
    {
        CL_Metodos_Base_Datos metodos = new CL_Metodos_Base_Datos();
        string sentencia;

        #region Metodo con SQL para crear
        public void Create(Sport_Rutina rela) 
        {
            sentencia = "INSERT INTO Rutinas_Deportes(rutina_id,sport_id)VALUES("+rela.Rutina_id+","+rela.Sport_id+")";
            metodos.EjecutarSQL(sentencia);
        }
        #endregion

    }
}
