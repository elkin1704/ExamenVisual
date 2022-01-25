using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Film
    {
        public int FilmId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Release_Year { get; set; }
        public int LenguageID { get; set; }
        public string Rental_Duration { get; set; }
        public decimal Rental_Rate { get; set; }

        public string Length { get; set; }

        public decimal Replacement_Cost { get; set; }
        public string Rating { get; set; }

        public string Last_Update { get; set; }

        public string Special_Features { get; set; }

        public string Fulltext { get; set; }

        //Relacion con Film_Actor

        public ICollection<Film_Actor> Film_Actors { get; set; }


        // Relacion con Film_Category
        public ICollection<Film_Category> Film_Categorys { get; set; }
    }
}
