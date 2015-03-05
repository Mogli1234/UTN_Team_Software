using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Sport_Rutina
    {
        Int16 id, rutina_id, sport_id;

        public Int16 Id
        {
            get { return id; }
            set { id = value; }
        }

        public Int16 Rutina_id
        {
            get { return rutina_id; }
            set { rutina_id = value; }
        }

        public Int16 Sport_id
        {
            get { return sport_id; }
            set { sport_id = value; }
        }
    }
}
