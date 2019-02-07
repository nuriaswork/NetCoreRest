﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaducaRest.Models.Entity_Configurations
{
    /// <summary>
    /// Llaves foráneas e índices
    /// </summary>
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        /// <summary>
        /// Llaves foráneas e índices
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasIndex(e => e.CategoriaId)
             .HasName("IX_ProductoCategoria");

            builder.HasOne(typeof(Categoria))
                   .WithMany()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(e => e.Nombre)
                .IsUnique()
                .HasName("UX_ProductoNombre");

            builder.HasIndex(e => e.Clave)
                .IsUnique()
                .HasName("UX_ProductoClave");

        }
    }
}