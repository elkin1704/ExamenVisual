using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Film_Actor
    {
        
        public int FilmId { get; set; }
        public Film Films { get; set; }

        public string Last_Update { get; set; }


        //Relacion con Actor
        public Actor Actors { get; set; }
      
        public int ActorId { get; set; }

    
    }
}
