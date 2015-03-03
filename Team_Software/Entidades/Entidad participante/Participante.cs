using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Participante
    {
        string nombre, primer_apellido, segundo_apellido, fecha_ingreso;
        Int16 id, edad;

        public Int16 Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Int16 Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }

        public string Segundo_apellido
        {
            get { return segundo_apellido; }
            set { segundo_apellido = value; }
        }

        public string Primer_apellido
        {
            get { return primer_apellido; }
            set { primer_apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       
    }
}
