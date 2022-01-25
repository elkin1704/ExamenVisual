﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDb;

namespace ModeloDb.Migrations
{
    [DbContext(typeof(DbExamen))]
    partial class DbExamenModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Update")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Modelo.Entidades.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Last_Update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("Modelo.Entidades.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fulltext")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LenguageID")
                        .HasColumnType("int");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Release_Year")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rental_Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rental_Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Replacement_Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Special_Features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Modelo.Entidades.Film_Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Last_Update")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("Film_Actors");
                });

            modelBuilder.Entity("Modelo.Entidades.Film_Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Last_Update")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("Film_Categorys");
                });

            modelBuilder.Entity("Modelo.Entidades.Film_Actor", b =>
                {
                    b.HasOne("Modelo.Entidades.Actor", "Actors")
                        .WithMany("Film_Actors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Film", "Films")
                        .WithMany("Film_Actors")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actors");

                    b.Navigation("Films");
                });

            modelBuilder.Entity("Modelo.Entidades.Film_Category", b =>
                {
                    b.HasOne("Modelo.Entidades.Category", "Categorys")
                        .WithMany("Film_Categorys")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Film", "Films")
                        .WithMany("Film_Categorys")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorys");

                    b.Navigation("Films");
                });

            modelBuilder.Entity("Modelo.Entidades.Actor", b =>
                {
                    b.Navigation("Film_Actors");
                });

            modelBuilder.Entity("Modelo.Entidades.Category", b =>
                {
                    b.Navigation("Film_Categorys");
                });

            modelBuilder.Entity("Modelo.Entidades.Film", b =>
                {
                    b.Navigation("Film_Actors");

                    b.Navigation("Film_Categorys");
                });
#pragma warning restore 612, 618
        }
    }
}
