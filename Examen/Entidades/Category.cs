using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public string Last_Update { get; set; }

        //Relacion con Film_Category

        public ICollection<Film_Category> Film_Categorys { get; set; }
    }
}
