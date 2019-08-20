﻿// <auto-generated />
using System;
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
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CaducaRest.Models.Caducidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("Fecha");

                    b.Property<int>("ProductoId");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("ClienteId", "ProductoId", "Fecha")
                        .IsUnique()
                        .HasName("UI_ClienteProducto");

                    b.ToTable("Caducidad");
                });

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

            modelBuilder.Entity("CaducaRest.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Activo");

                    b.Property<string>("Celular")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<int>("Clave");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("NombreComercial")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("RFC")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("SitioWeb")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Telefono")
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("Id");

                    b.HasIndex("Clave")
                        .IsUnique()
                        .HasName("UI_ClienteCategoriaClave");

                    b.HasIndex("RazonSocial")
                        .IsUnique()
                        .HasName("UI_ClienteCategoriaNombre");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("CaducaRest.Models.ClienteCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<int>("ClienteId");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ClienteId", "CategoriaId")
                        .IsUnique()
                        .HasName("UI_ClienteCategoria");

                    b.ToTable("ClienteCategoria");
                });

            modelBuilder.Entity("CaducaRest.Models.Historial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Actividad");

                    b.Property<DateTime>("FechaHora");

                    b.Property<string>("Observa")
                        .HasColumnType("VARCHAR(250)")
                        .HasMaxLength(250);

                    b.Property<int>("OrigenId");

                    b.Property<int>("TablaId");

                    b.Property<int?>("UsuarioId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("TablaId")
                        .HasName("IX_HistorialTabla");

                    b.HasIndex("UsuarioId")
                        .HasName("IX_ctrUsuario");

                    b.HasIndex("Actividad", "TablaId", "FechaHora")
                        .HasName("IX_Actividad");

                    b.HasIndex("TablaId", "OrigenId", "Actividad")
                        .HasName("IX_Historial");

                    b.ToTable("Historial");
                });

            modelBuilder.Entity("CaducaRest.Models.Permiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Clave");

                    b.Property<string>("Nombre")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Permiso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Clave = 1,
                            Nombre = "Crear"
                        },
                        new
                        {
                            Id = 2,
                            Clave = 2,
                            Nombre = "Modificar"
                        },
                        new
                        {
                            Id = 3,
                            Clave = 3,
                            Nombre = "Borrar"
                        },
                        new
                        {
                            Id = 4,
                            Clave = 4,
                            Nombre = "Consultar"
                        });
                });

            modelBuilder.Entity("CaducaRest.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CaducidadId");

                    b.Property<int>("CategoriaId");

                    b.Property<int>("Clave");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.HasKey("Id");

                    b.HasIndex("CaducidadId");

                    b.HasIndex("CategoriaId")
                        .HasName("IX_ProductoCategoria");

                    b.HasIndex("Clave")
                        .IsUnique()
                        .HasName("UX_ProductoClave");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasName("UX_ProductoNombre");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("CaducaRest.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Rol");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Administrador"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Vendedor"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Cliente"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Supervisor"
                        });
                });

            modelBuilder.Entity("CaducaRest.Models.RolTablaPermiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RolId");

                    b.Property<int>("TablaPermisoId");

                    b.Property<bool>("TienePermiso");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.HasIndex("TablaPermisoId", "RolId")
                        .IsUnique()
                        .HasName("UI_TablaPermiso");

                    b.ToTable("RolTablaPermiso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RolId = 4,
                            TablaPermisoId = 1,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 2,
                            RolId = 4,
                            TablaPermisoId = 2,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 3,
                            RolId = 4,
                            TablaPermisoId = 3,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 4,
                            RolId = 4,
                            TablaPermisoId = 4,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 5,
                            RolId = 2,
                            TablaPermisoId = 4,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 6,
                            RolId = 3,
                            TablaPermisoId = 4,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 7,
                            RolId = 4,
                            TablaPermisoId = 5,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 8,
                            RolId = 4,
                            TablaPermisoId = 6,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 9,
                            RolId = 4,
                            TablaPermisoId = 7,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 10,
                            RolId = 4,
                            TablaPermisoId = 8,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 11,
                            RolId = 2,
                            TablaPermisoId = 8,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 12,
                            RolId = 4,
                            TablaPermisoId = 9,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 13,
                            RolId = 4,
                            TablaPermisoId = 10,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 14,
                            RolId = 4,
                            TablaPermisoId = 11,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 15,
                            RolId = 4,
                            TablaPermisoId = 12,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 16,
                            RolId = 2,
                            TablaPermisoId = 12,
                            TienePermiso = true
                        },
                        new
                        {
                            Id = 17,
                            RolId = 3,
                            TablaPermisoId = 12,
                            TienePermiso = true
                        });
                });

            modelBuilder.Entity("CaducaRest.Models.Tabla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasMaxLength(40);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Tabla");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripción = "Permite registrar las fechas de caducidad de los productos",
                            Nombre = "Caducidad"
                        },
                        new
                        {
                            Id = 2,
                            Descripción = "Permite registrar las categorias de los productos",
                            Nombre = "Categoria"
                        },
                        new
                        {
                            Id = 3,
                            Descripción = "Permite registrar los clientes",
                            Nombre = "Cliente"
                        },
                        new
                        {
                            Id = 4,
                            Descripción = "Permite registrar las categorías de productos de cada cliente",
                            Nombre = "ClienteCategoria"
                        },
                        new
                        {
                            Id = 5,
                            Descripción = "Permite registrar los productos",
                            Nombre = "Producto"
                        },
                        new
                        {
                            Id = 6,
                            Descripción = "Permite registrar los permisos para el sistema",
                            Nombre = "Permiso"
                        },
                        new
                        {
                            Id = 7,
                            Descripción = "Permite registrar los productos",
                            Nombre = "Producto"
                        },
                        new
                        {
                            Id = 8,
                            Descripción = "Permite registrar los roles de los usuarios",
                            Nombre = "Rol"
                        },
                        new
                        {
                            Id = 9,
                            Descripción = "Permite registrar los usuarios del sistema",
                            Nombre = "Usuario"
                        },
                        new
                        {
                            Id = 10,
                            Descripción = "Permite registrar las categorias de los usuarios del sistema",
                            Nombre = "UsuarioCategoria"
                        },
                        new
                        {
                            Id = 11,
                            Descripción = "Permite registrar los clientes para los usuarios del sistema",
                            Nombre = "UsuarioCliente"
                        },
                        new
                        {
                            Id = 12,
                            Descripción = "Permite registrar los roles para los usuarios del sistema",
                            Nombre = "UsuarioRol"
                        });
                });

            modelBuilder.Entity("CaducaRest.Models.TablaPermiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PermisoId");

                    b.Property<int>("TablaId");

                    b.HasKey("Id");

                    b.HasIndex("PermisoId");

                    b.HasIndex("TablaId", "PermisoId")
                        .IsUnique()
                        .HasName("UI_TablaPermiso");

                    b.ToTable("TablaPermiso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PermisoId = 1,
                            TablaId = 2
                        },
                        new
                        {
                            Id = 2,
                            PermisoId = 2,
                            TablaId = 2
                        },
                        new
                        {
                            Id = 3,
                            PermisoId = 3,
                            TablaId = 2
                        },
                        new
                        {
                            Id = 4,
                            PermisoId = 4,
                            TablaId = 2
                        },
                        new
                        {
                            Id = 5,
                            PermisoId = 1,
                            TablaId = 3
                        },
                        new
                        {
                            Id = 6,
                            PermisoId = 2,
                            TablaId = 3
                        },
                        new
                        {
                            Id = 7,
                            PermisoId = 3,
                            TablaId = 3
                        },
                        new
                        {
                            Id = 8,
                            PermisoId = 4,
                            TablaId = 3
                        },
                        new
                        {
                            Id = 9,
                            PermisoId = 1,
                            TablaId = 5
                        },
                        new
                        {
                            Id = 10,
                            PermisoId = 2,
                            TablaId = 5
                        },
                        new
                        {
                            Id = 11,
                            PermisoId = 3,
                            TablaId = 5
                        },
                        new
                        {
                            Id = 12,
                            PermisoId = 4,
                            TablaId = 5
                        });
                });

            modelBuilder.Entity("CaducaRest.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Activo");

                    b.Property<string>("Adicional1")
                        .IsRequired();

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)")
                        .HasMaxLength(15);

                    b.Property<int>("Codigo");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)")
                        .HasMaxLength(80);

                    b.Property<int>("Intentos");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Clave")
                        .IsUnique()
                        .HasName("UI_UsuarioClave");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activo = true,
                            Adicional1 = "2a3efe03a96840478bde71ae36a20f2e",
                            Clave = "Juan",
                            Codigo = 0,
                            Email = "correo@gmail.com",
                            Intentos = 0,
                            Nombre = "Juan Peréz",
                            Password = "9f9b901a43d795295661443f7f7098ee8e6c6c3694428717c54d5fd058220fed"
                        },
                        new
                        {
                            Id = 2,
                            Activo = true,
                            Adicional1 = "37b93bbd77b2d7a586cc7d5032f83808",
                            Clave = "Maria",
                            Codigo = 0,
                            Email = "correo@gmail.com",
                            Intentos = 0,
                            Nombre = "Maria Lopez",
                            Password = "6ad9ebcfe2bebed6655a4abb3e0409c83ad1e6db35098083476744cfe0d106b9"
                        },
                        new
                        {
                            Id = 3,
                            Activo = true,
                            Adicional1 = "5dd69f799e8ac1fd877460c4d461eb74",
                            Clave = "Carlos",
                            Codigo = 0,
                            Email = "carlos@gmail.com",
                            Intentos = 0,
                            Nombre = "Carlos Hernández",
                            Password = "6c60e72d7ea36a7defc15f0b551cd739180d2254ddaf4c8833ece2ecf8b48c5a"
                        });
                });

            modelBuilder.Entity("CaducaRest.Models.UsuarioAcceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Activo");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("VARCHAR(300)")
                        .HasMaxLength(300);

                    b.Property<DateTime>("Fecha");

                    b.Property<DateTime>("FechaRefresh");

                    b.Property<bool>("MantenerSesion");

                    b.Property<string>("Navegador")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("SistemaOperativo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("VARCHAR(400)");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("RefreshToken")
                        .IsUnique()
                        .HasName("UI_RefreshToken");

                    b.HasIndex("UsuarioId", "Token")
                        .IsUnique()
                        .HasName("UI_Token");

                    b.ToTable("UsuarioAcceso");
                });

            modelBuilder.Entity("CaducaRest.Models.UsuarioCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("UsuarioId", "CategoriaId")
                        .IsUnique()
                        .HasName("UI_UsuarioCategoria");

                    b.ToTable("UsuarioCategoria");
                });

            modelBuilder.Entity("CaducaRest.Models.UsuarioCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId", "ClienteId")
                        .IsUnique()
                        .HasName("UI_UsuarioCliente");

                    b.ToTable("UsuarioCliente");
                });

            modelBuilder.Entity("CaducaRest.Models.UsuarioRol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RolId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.HasIndex("UsuarioId", "RolId")
                        .IsUnique()
                        .HasName("UI_UsuarioRol");

                    b.ToTable("UsuarioRol");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RolId = 3,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            RolId = 2,
                            UsuarioId = 2
                        },
                        new
                        {
                            Id = 3,
                            RolId = 1,
                            UsuarioId = 3
                        });
                });

            modelBuilder.Entity("CaducaRest.Models.Caducidad", b =>
                {
                    b.HasOne("CaducaRest.Models.Cliente", "Cliente")
                        .WithMany("Caducidades")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CaducaRest.Models.Producto", "Producto")
                        .WithMany("Caducidades")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.ClienteCategoria", b =>
                {
                    b.HasOne("CaducaRest.Models.Categoria", "Categoria")
                        .WithMany("ClientesCategorias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CaducaRest.Models.Cliente", "Cliente")
                        .WithMany("ClientesCategorias")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.Historial", b =>
                {
                    b.HasOne("CaducaRest.Models.Tabla")
                        .WithMany()
                        .HasForeignKey("TablaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CaducaRest.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.Producto", b =>
                {
                    b.HasOne("CaducaRest.Models.Caducidad")
                        .WithMany()
                        .HasForeignKey("CaducidadId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.RolTablaPermiso", b =>
                {
                    b.HasOne("CaducaRest.Models.Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CaducaRest.Models.TablaPermiso")
                        .WithMany()
                        .HasForeignKey("TablaPermisoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.TablaPermiso", b =>
                {
                    b.HasOne("CaducaRest.Models.Permiso")
                        .WithMany()
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CaducaRest.Models.Tabla")
                        .WithMany()
                        .HasForeignKey("TablaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.UsuarioAcceso", b =>
                {
                    b.HasOne("CaducaRest.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.UsuarioCategoria", b =>
                {
                    b.HasOne("CaducaRest.Models.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CaducaRest.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.UsuarioCliente", b =>
                {
                    b.HasOne("CaducaRest.Models.Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CaducaRest.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CaducaRest.Models.UsuarioRol", b =>
                {
                    b.HasOne("CaducaRest.Models.Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CaducaRest.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
