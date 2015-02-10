using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sports
    {
        
        Int16 id;
        string deporte, description;

        public string Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Int16 Id
        {
            get { return id; }
            set { id = value; }
        }
        
    }
}
