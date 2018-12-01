﻿// <auto-generated />
using CaducaRest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaducaRest.Migrations
{
    [DbContext(typeof(CaducaContext))]
    partial class CaducaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CaducaRest.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Clave");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.HasKey("Id");

                    b.HasIndex("Clave")
                        .IsUnique()
                        .HasName("UI_CategoriaClave");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasName("UI_CategoriaNombre");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("CaducaRest.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<int>("Clave");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.HasKey("Id");

                    b.ToTable("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
