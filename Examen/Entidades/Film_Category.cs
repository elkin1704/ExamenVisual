using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Film_Category
    {
        public Film Films { get; set; }
        public int FilmId { get; set; }

        public Category Categorys { get; set; }
        public int CategoryId { get; set; }

        public string Last_Update { get; set; }
    }
}
