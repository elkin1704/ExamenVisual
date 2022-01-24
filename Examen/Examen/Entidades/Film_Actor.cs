using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Film_Actor
    {
        
        public string FilmId { get; set; }

        public int Last_Update { get; set; }


        //Relacion con Actor
        public Actor Actors { get; set; }
      
        public int ActorId { get; set; }
    
    }
}
