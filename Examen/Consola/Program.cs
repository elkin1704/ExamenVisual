using System;
usin ModeloDb;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             Category act = new Category()
            {
                Name = "El conjuro",
                Last_Update = "24/01/2022"
                
            };
            // Grabar los datos
            using (DbExamen repos = new DbExamen())
            {
                repos.ResumenAmortizacions.AddRange(act);
                repos.SaveChanges();
            }
        }
    
    }
}
