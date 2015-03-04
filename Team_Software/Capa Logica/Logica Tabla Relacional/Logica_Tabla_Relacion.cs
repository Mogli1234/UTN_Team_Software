using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Entidades;

namespace Capa_Logica
{
    public class Logica_Tabla_Relacion
    {
        Datos_Parti_Sport_Rutine datos = new Datos_Parti_Sport_Rutine();

        #region Metodo de creacion
        public void Create(Sport_Rutine_Participante relacion) 
        {
            datos.Create(relacion);
        }
        #endregion


    }
}
