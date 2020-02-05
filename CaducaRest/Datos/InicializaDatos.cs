﻿using CaducaRest.Models;

namespace CaducaRest.Datos
{
    /// <summary>
    /// Permite inicializar datos de prueba
    /// </summary>
    public class InicializaDatos
    {
        /// <summary>
        /// Constructro de la clase
        /// </summary>
        /// <param name="contexto"></param>
        public static void Inicializar(CaducaContext contexto)
        {
            //Si no es base de datos en memoria no se agrega nada
            if (contexto.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                return;
            //Te aseguras que la base de datos haya sido creada
            contexto.Database.EnsureCreated();

            var categorias = new Categoria[]
            {
                /*01*/ new Categoria { Clave = 1, Nombre = "Análgesicos"},
            };
            foreach (Categoria registro in categorias)
            {
                contexto.Categoria.Add(registro);
            }
            contexto.SaveChanges();
        }
    }
}
