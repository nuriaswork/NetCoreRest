﻿using CaducaRest.Core;
using CaducaRest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaducaRest.DAO
{
    /// <summary>
    /// Funciones para acceso a los datos para las categorías
    /// </summary>
    public class CategoriaDAO
    {
        private readonly CaducaContext contexto;
        public CustomError customError;

        /// <summary>
        /// Clase para acceso a la base de datos
        /// </summary>
        /// <param name="context"></param>
        public CategoriaDAO(CaducaContext context)
        {
            this.contexto = context;
        }

        /// <summary>
        /// Obtiene todas las categorias
        /// </summary>
        /// <returns></returns>
        public List<Categoria> ObtenerTodo()
        {
            return contexto.Categoria.ToList();
        }

        /// <summary>
        /// Obtienen una categoría por us Id
        /// </summary>
        /// <param name="id">Id de la categoría</param>
        /// <returns></returns>
        public async Task<Categoria> ObtenerPorIdAsync(int id)
        {
            return await contexto.Categoria.FindAsync(id);
        }

        /// <summary>
        /// Permite agregar una nueva categoria
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public async Task<bool> AgregarAsync(Categoria categoria)
        {
            Categoria registroRepetido;
            try
            {
                registroRepetido = contexto.Categoria.FirstOrDefault(c => c.Nombre == categoria.Nombre);
                if (registroRepetido != null)
                {
                    customError = new CustomError(400, 
                                            "Ya existe una categoría con este nombre, " +
                                            "por favor teclea un nombre diferente", "Nombre");
                    return false;
                }
                registroRepetido = contexto.Categoria.FirstOrDefault(c => c.Clave == categoria.Clave);
                if (registroRepetido != null)
                {
                    customError = new CustomError(400, 
                                            "Ya existe una categoría con esta clave, " +
                                            "por favor teclea una clave diferente", "Nombre");
                    return false;
                }

                contexto.Categoria.Add(categoria);
                await contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
    }
}
