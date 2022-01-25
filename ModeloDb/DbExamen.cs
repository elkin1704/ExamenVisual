using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace ModeloDb
{
    public class DbExamen : DbContext
    {
        public DbSet<Film> Films    { get; set; }
        public DbSet<Film_Category> Film_Categorys { get; set; }
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
            // Films_Actor
            model.Entity<Film_Actor>()
                  .HasOne(film_actor => film_actor.Actors)
                  .WithMany(actor => actor.Film_Actors)
                  .HasForeignKey(fil => fil.ActorId);
            model.Entity<Film_Actor>()
                  .HasOne(film_actor => film_actor.Films)
                  .WithMany(film => film.Film_Actors)
                  .HasForeignKey(fil => fil.FilmId);

            // 

            model.Entity<Film_Actor>()
                .HasKey(film_actor => new
                {
                    film_actor.ActorId,
                    film_actor.FilmId
                });

            model.Entity<Film_Category>()
                  .HasOne(film_category => film_category.Categorys)
                  .WithMany(category => category.Film_Categorys)
                  .HasForeignKey(fil => fil.CategoryId);
            model.Entity<Film_Category>()
                  .HasOne(film_category => film_category.Films)
                  .WithMany(film => film.Film_Categorys)
                  .HasForeignKey(fil => fil.FilmId);

            // 

            model.Entity<Film_Category>()
                .HasKey(film_category => new
                {
                    film_category.CategoryId,
                    film_category.FilmId
                });



        }
    }
}
