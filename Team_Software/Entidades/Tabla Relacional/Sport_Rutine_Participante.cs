using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sport_Rutine_Participante
    {
        Int16 id, sport_id, rutina_id, participante_id;

        public Int16 Rutina_id
        {
            get { return rutina_id; }
            set { rutina_id = value; }
        }

        public Int16 Participante_id
        {
            get { return participante_id; }
            set { participante_id = value; }
        }

        public Int16 Sport_id
        {
            get { return sport_id; }
            set { sport_id = value; }
        }
    
        public Int16 Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
