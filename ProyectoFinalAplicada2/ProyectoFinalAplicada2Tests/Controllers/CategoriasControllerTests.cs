using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAplicada2.Controllers;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalAplicada2.Controllers.Tests
{
    [TestClass()]
    public class CategoriasControllerTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            CategoriasController controller = new CategoriasController();

            Categorias categoria = new Categorias()
            {
                CategoriaId = 1,
                Nombre = "p"
            };

            Assert.IsTrue(controller.Guardar(categoria));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}