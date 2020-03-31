using ProyectoFinalAplicada2.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ProyectoFinalAplicada2.Models;

namespace ProyectoFinalAplicada2.Controllers.Tests
{
    [TestClass()]
    public class CategoriasControllerTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //bool paso = false;
            //Categorias Categoria = new Categorias();
            //Categoria.Nombre = "ProbandoTest";

            //paso = CategoriasController.Insertar(Categoria);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //bool paso = false;
            //Categorias Categoria = new Categorias();
            //Categoria.CategoriaId = 2;
            //Categoria.Nombre = "ProbandoTestModificar";

            //paso = CategoriasController.Modificar(Categoria);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Categorias Categoria = CategoriasController.Buscar(1);

            //Assert.IsNotNull(Categoria);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            //bool paso = false;

            //paso = CategoriasController.Eliminar(1);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            //List<Categorias> Categorias = new List<Categorias>();
            //Categorias = CategoriasController.GetList(e => true);

            //Assert.IsNotNull(Categorias);
        }
    }
}