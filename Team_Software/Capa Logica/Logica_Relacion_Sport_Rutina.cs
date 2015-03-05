using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Capa_Datos;

namespace Capa_Logica
{
   public class Logica_Relacion_Sport_Rutina
    {
        Datos_Rutina_Sport datos = new Datos_Rutina_Sport();

        #region Create
        public void create(Sport_Rutina relacion) 
        {
            datos.Create(relacion);
        }
        #endregion

    }
}
