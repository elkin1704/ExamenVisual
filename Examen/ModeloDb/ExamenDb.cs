using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace ModeloDb
{
    internal class ExamenDb : DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film_Actor> Film_Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connSQL = "server = DESKTOP-8BBLG0F\\SQLEXPRESS ; database=Examen; user id=sa; password=1234";
            optionsBuilder.UseSqlServer(connSQL);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            // Films_Actor no tiene clave primaria
            model.Entity<Film_Actor>()
                .HasNoKey();
            // Actor


            model.Entity<Film_Actor>()
                .HasOne(film_Actor => film_Actor.Actors)
                .WithMany()
                .HasForeignKey(fil => fil.ActorId);


        }
    }
}
