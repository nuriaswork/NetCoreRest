﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CaducaRest.DAO;
using CaducaRest.Models;
using CaducaRest.Resources;
using CaducaRest.Rules.Categoria;
using Xunit;

namespace xUnit.CaducaRest
{
    public class Categorias
    {
        CaducaContext contexto;
        LocService locService;

        public Categorias()
        {
            contexto = new CaducaContextMemoria().ObtenerContexto();
            locService = new MockLocService().ObtenerLocService();
        }
        /// <summary>
        /// Validamos que no se pueda agregar una categoria con un nombre repetido
        /// El resultado deberia ser falso
        /// </summary>
        [Fact]
        public async Task ReglaNombreUnico_ConNombreRepetido_RegresaFalsoAsync()
        {
            //Inicialización de datos (Arrange)
            var categoriaDAO = new CategoriaDAO(contexto, locService);
            //Obtenemos la lista de categorías si esta vacía agregamos una
            List<Categoria> categorias = await categoriaDAO.ObtenerTodoAsync();
            if (categorias.Count==0)
            {
                categorias.Add(new Categoria { Clave = 1, Nombre = "Análgesicos" });
            }
            //Método a probar (Act)
            ReglaNombreUnico agregarNombreRegla = new ReglaNombreUnico(categorias[0].Id, categorias[0].Nombre, contexto, locService);
            //Comprobación de resultados (Assert)
            Assert.False(agregarNombreRegla.EsCorrecto());
        }
        /// <summary>
        /// Validamos que no se pueda agregar una categoria con un nombre repetido
        /// El resultado deberia ser true
        /// </summary>
        [Fact]
        public async Task ReglaNombreUnico_ConNombreNoRepetido_RegresaVerdaderoAsync()
        {
            //Inicialización de datos (Arrange)
            var categoriaDAO = new CategoriaDAO(contexto, locService);
            //Obtenemos la lista de categorías si esta vacía agregamos una
            List<Categoria> categorias = await categoriaDAO.ObtenerTodoAsync();
            if (categorias.Count == 0)
            {
                categorias.Add(new Categoria { Clave = 1, Nombre = "Análgesicos" });
            }
            //Método a probar (Act)
            ReglaNombreUnico agregarNombreRegla = new ReglaNombreUnico(2,"Antibióticos", contexto, locService);
            //Comprobación de resultados (Assert)
            Assert.True(agregarNombreRegla.EsCorrecto());
        }

        /// <summary>
        /// Revisar que se pueda agregar una nueva categoría
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task AgregaNuevaCategoria_DatosCorrectos_RegresaVerdaderoAsync()
        {
            //Inicialización de datos (Arrange)
            var categoriaDAO = new CategoriaDAO(contexto, locService);
            var categoria = new Categoria();
            categoria.Clave = 2;
            categoria.Nombre = "Antibióticos";
            //Método a probar (Act)
            var esCorrecto = await categoriaDAO.AgregarAsync(categoria);
            //Comprobación de resultados (Assert)
            Assert.True(esCorrecto);
        }
    }
}
