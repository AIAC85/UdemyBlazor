// <auto-generated />
using System;
using EjerciciosBlazor.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EjerciciosBlazor.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.GeneroPelicula", b =>
                {
                    b.Property<int>("Generoid")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("Generoid", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("GenerosPeliculas");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EnCartelera")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Lanzamiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resumen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.PeliculaActor", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PeliculaId", "PersonaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("PeliculasActors");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.GeneroPelicula", b =>
                {
                    b.HasOne("EjerciciosBlazor.Shared.Entidades.Genero", "Genero")
                        .WithMany("GeneroPeliculas")
                        .HasForeignKey("Generoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EjerciciosBlazor.Shared.Entidades.Pelicula", "Pelicula")
                        .WithMany("GenerosPelicula")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.PeliculaActor", b =>
                {
                    b.HasOne("EjerciciosBlazor.Shared.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasActor")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EjerciciosBlazor.Shared.Entidades.Persona", "Persona")
                        .WithMany("PeliculasActor")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.Genero", b =>
                {
                    b.Navigation("GeneroPeliculas");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.Pelicula", b =>
                {
                    b.Navigation("GenerosPelicula");

                    b.Navigation("PeliculasActor");
                });

            modelBuilder.Entity("EjerciciosBlazor.Shared.Entidades.Persona", b =>
                {
                    b.Navigation("PeliculasActor");
                });
#pragma warning restore 612, 618
        }
    }
}
