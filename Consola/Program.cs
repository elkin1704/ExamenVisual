using Modelo.Entidades;
using System;
using ModeloDb;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Actor act = new Actor { First_Name = "Elkin", Last_Name = "Romero", Last_Update = "24/01/22" };
            Actor act2 = new Actor { First_Name = "Eduardo", Last_Name = "Taco", Last_Update = "24/01/22" };
            Actor act3 = new Actor { First_Name = "Diego", Last_Name = "Romero", Last_Update = "24/01/22" };
            Actor act4 = new Actor { First_Name = "Elizabeth", Last_Name = "Torres", Last_Update = "24/01/22" };
            Actor act5 = new Actor { First_Name = "Emely", Last_Name = "Calapaqui", Last_Update = "24/01/22" };
            Actor act6 = new Actor { First_Name = "Adrian", Last_Name = "Siguencia", Last_Update = "24/01/22" };
            Actor act7 = new Actor { First_Name = "Luis", Last_Name = "Lopez", Last_Update = "24/01/22" };
            Actor act8 = new Actor { First_Name = "Sebastian", Last_Name = "Asimbaya", Last_Update = "24/01/22" };
            Actor act9 = new Actor { First_Name = "Saul", Last_Name = "Rosero", Last_Update = "24/01/22" };

            List<Actor> actoresP = new List<Actor>() {
              act,act2,act3,act4,act5,act6, act7,act8,act9
            };
            Film fil = new Film { Title = "El conjuro 3", Description = "Pelicula que te dara mucho miedo", Release_Year = "2020", LenguageID = 1, Rental_Duration = "2 meses", Rental_Rate = 6.0M, Length = "10", Replacement_Cost = 8.0M, Rating = "10", Last_Update = "24/01/2022", Special_Features = "Premium", Fulltext = "Trama que te atrapa desde el inicio" };
            Film fil2 = new Film { Title = "El conjuro 2", Description = "Pelicula que te dara mucho miedo", Release_Year = "2016", LenguageID = 1, Rental_Duration = "2 meses", Rental_Rate = 6.0M, Length = "10", Replacement_Cost = 8.0M, Rating = "10", Last_Update = "24/01/2022", Special_Features = "Premium", Fulltext = "Trama que te atrapa desde el inicio" };
            Film fil3 = new Film { Title = "El conjuro 1", Description = "Pelicula que te dara mucho miedo", Release_Year = "2018", LenguageID = 1, Rental_Duration = "2 meses", Rental_Rate = 6.0M, Length = "10", Replacement_Cost = 8.0M, Rating = "10", Last_Update = "24/01/2022", Special_Features = "Premium", Fulltext = "Trama que te atrapa desde el inicio" };
            Film fil4 = new Film { Title = "Insidius 1", Description = "Pelicula que te dara mucho miedo", Release_Year = "2014", LenguageID = 1, Rental_Duration = "2 meses", Rental_Rate = 6.0M, Length = "10", Replacement_Cost = 8.0M, Rating = "10", Last_Update = "24/01/2022", Special_Features = "Premium", Fulltext = "Trama que te atrapa desde el inicio" };
            Film fil5 = new Film { Title = "Insidius 2", Description = "Pelicula que te dara mucho miedo", Release_Year = "2017", LenguageID = 1, Rental_Duration = "2 meses", Rental_Rate = 6.0M, Length = "10", Replacement_Cost = 8.0M, Rating = "10", Last_Update = "24/01/2022", Special_Features = "Premium", Fulltext = "Trama que te atrapa desde el inicio" };
            Film fil6 = new Film { Title = "Insidius 3", Description = "Pelicula que te dara mucho miedo", Release_Year = "2019", LenguageID = 1, Rental_Duration = "2 meses", Rental_Rate = 6.0M, Length = "10", Replacement_Cost = 8.0M, Rating = "10", Last_Update = "24/01/2022", Special_Features = "Premium", Fulltext = "Trama que te atrapa desde el inicio" };
            List<Film> filmP = new List<Film>() {
              fil,fil2,fil3,fil4,fil5,fil6
              };

            Category cat = new Category { Name = "Miedo", Last_Update = "24/01/22" };
            Category cat2 = new Category { Name = "Miedo", Last_Update = "24/01/22" };
            Category cat3 = new Category { Name = "Miedo", Last_Update = "24/01/22" };
            Category cat4 = new Category { Name = "Miedo", Last_Update = "24/01/22" };
            Category cat5 = new Category { Name = "Miedo", Last_Update = "24/01/22" };
            Category cat6 = new Category { Name = "Miedo", Last_Update = "24/01/22" };

            List<Category> catP = new List<Category>() {
              cat,cat2,cat3,cat4,cat5,cat6
              };
            Film_Actor filAp = new Film_Actor { FilmId = 1, ActorId = 1, Last_Update = "24/01/2022" };
            Film_Actor filAp2 = new Film_Actor { FilmId = 2, ActorId = 2, Last_Update = "24/01/2022" };
            Film_Actor filAp3 = new Film_Actor { FilmId = 3, ActorId = 3, Last_Update = "24/01/2022" };
            Film_Actor filAp4 = new Film_Actor { FilmId = 4, ActorId = 4, Last_Update = "24/01/2022" };
            Film_Actor filAp5 = new Film_Actor { FilmId = 5, ActorId = 5, Last_Update = "24/01/2022" };
            Film_Actor filAp6 = new Film_Actor { FilmId = 6, ActorId = 6, Last_Update = "24/01/2022" };
            Film_Actor filAp7 = new Film_Actor { FilmId = 2, ActorId = 7, Last_Update = "24/01/2022" };
            Film_Actor filAp8 = new Film_Actor { FilmId = 3, ActorId = 8, Last_Update = "24/01/2022" };
            Film_Actor filAp9 = new Film_Actor { FilmId = 5, ActorId = 9, Last_Update = "24/01/2022" };

            List<Film_Actor> filmAP = new List<Film_Actor>() {
              filAp,filAp2,filAp3,filAp4,filAp5,filAp6,filAp7,filAp8,filAp9
              };

            Film_Category filmCat = new Film_Category { FilmId = 1, CategoryId = 1, Last_Update = "24/01/2022" };
            Film_Category filmCat2 = new Film_Category { FilmId = 2, CategoryId = 2, Last_Update = "24/01/2022" };
            Film_Category filmCat3 = new Film_Category { FilmId = 3, CategoryId = 3, Last_Update = "24/01/2022" };
            Film_Category filmCat4 = new Film_Category { FilmId = 4, CategoryId = 4, Last_Update = "24/01/2022" };
            Film_Category filmCat5 = new Film_Category { FilmId = 5, CategoryId = 5, Last_Update = "24/01/2022" };
            Film_Category filmCat6 = new Film_Category { FilmId = 6, CategoryId = 6, Last_Update = "24/01/2022" };

            List<Film_Category> filmCatP = new List<Film_Category>() {
              filmCat,filmCat2,filmCat3,filmCat4,filmCat5,filmCat6
              };
            // Grabar los datos
            using (DbExamen repos = new DbExamen())
            {
                repos.Actors.AddRange(actoresP);
                repos.Films.AddRange(filmP);
                repos.Categorys.AddRange(catP);
                repos.Film_Actors.AddRange(filmAP);
                repos.Film_Categorys.AddRange(filmCatP);
                repos.SaveChanges();


            }

            

        }
    }
}
