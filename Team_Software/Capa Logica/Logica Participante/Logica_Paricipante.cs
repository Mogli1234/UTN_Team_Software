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

       #region Actualizar datos de Participante
       public void Actualiza_Participante(Participante participante)
       {
           datos.Update_Participante(participante);
       }
       #endregion

       #region Eliminar Participante
       public void Delete_Rutina(Participante participante)
       {
           datos.Delete_Participante(participante);
       }
       #endregion

        #region Metodo para cargar Datos
       public DataTable cargar() 
       {
           return datos.Charger_Participante();
       }
        #endregion

        #region Metodo de autocomplete
       public DataTable fill(Participante parti)
       {
           return datos.Fill_Participante(parti);
       }
        #endregion
    }
}
