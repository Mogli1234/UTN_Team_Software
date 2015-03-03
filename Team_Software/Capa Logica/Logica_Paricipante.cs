using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Entidades;
using System.Data;
namespace Capa_Logica
{
   public class Logica_Paricipante
    {
       Datos_Participante datos = new Datos_Participante();

        #region Metodo para insertar
       public void Create(Participante parti) 
       {
           datos.Insertar_Participantes(parti);
       }
        #endregion

        #region MEtodo para cargar Datos
       public DataTable cargar() 
       {
           return datos.Charger_Participante();
       }
        #endregion
    }
}
