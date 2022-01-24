using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string First_Name { get; set; }

        public string Last_Name { get; set; }
        public string Last_Update { get; set; }

        //Relacion con Film_Actor

        public ICollection<Film_Actor> Film_Actors { get; set; }

    }
}
