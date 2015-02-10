using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Capa_Datos;
namespace Capa_Logica
{
   public class Logica_Deporte
    {
       Datos_Deporte datos = new Datos_Deporte();

       #region Create Sport
       public void Create_Sport(Sports sport) 
       {
           datos.Create_Sport(sport);
       }
       #endregion

       #region Update Sport
       public void Update_Sport(Sports sport) 
       {
           datos.Update_Sport(sport);
       }
       #endregion

       #region Delete Sport
       public void Delete_Sport(Sports sport) 
       {
           datos.Delete_Sport(sport);
       }
       #endregion
    }
}
