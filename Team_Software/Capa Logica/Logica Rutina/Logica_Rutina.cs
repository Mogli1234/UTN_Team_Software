using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Capa_Datos;

namespace Capa_Logica
{
    public class Logica_Rutina
    {
        Datos_Rutinas datosRutinas = new Datos_Rutinas();

        #region Crear Rutina
        public void Crear_Rutina(Rutinas rutina)
        {
            datosRutinas.CrearRutina(rutina);
        }
        #endregion

        #region Update Rutina
        public void Actualiza_Rutina(Rutinas rutina)
        {
            datosRutinas.Update_Rutina(rutina);
        }
        #endregion

        #region Eliminar Rutina
        public void Delete_Rutina(Rutinas rutina)
        {
            datosRutinas.Delete_Rutina(rutina);
        }
        #endregion

        //Metodo para select

        #region Metodo de carga datos con lista generica
        public List<Rutinas> CargarRutinas()
        {
           return datosRutinas.Charge_Rutinas();
        }
        #endregion
    }
}
